using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Data.Models;

namespace Impendulo.Courses.InputForms.Deployment
{
    public partial class frmAddTrainingDepartmentCourseSeta : Form
    {

        public frmAddTrainingDepartmentCourseSeta()
        {
            InitializeComponent();
        }

        private void frmAddTrainingDepartmentCourseSeta_Load(object sender, EventArgs e)
        {
            this.populateAvailableSeta();
            this.populateLinkedSeta();
            this.setAddRemoveControls();
        }

        private void setAddRemoveControls()
        {
            if (bindingSourceAvailableSeta.Count > 0) { btnLinkSeta.Enabled = true; } else { btnLinkSeta.Enabled = false; }
            if (bindingSourceLinkedSeta.Count > 0) { btnRemoveSeta.Enabled = true; } else { btnRemoveSeta.Enabled = false; }
        }
        #region "Properties"
        public int CurriculumCourseID { get; set; }
        #endregion
        #region "Populate Controls"

        private void populateAvailableSeta()
        {
            using (var DbConnection = new MCDEntities())
            {
                bindingSourceAvailableSeta.DataSource = (from a in DbConnection.LookupSetas
                                                         select a).Except(from a in DbConnection.LookupSetas
                                                                          from b in a.CurriculumCourses
                                                                          where b.CurriculumCourseID == this.CurriculumCourseID
                                                                          select a).ToList<LookupSeta>();
            }
        }
        private void populateLinkedSeta()
        {
            using (var DbConnection = new MCDEntities())
            {
                bindingSourceLinkedSeta.DataSource = (from a in DbConnection.LookupSetas
                                                      from b in a.CurriculumCourses
                                                      where b.CurriculumCourseID == this.CurriculumCourseID
                                                      select a).ToList<LookupSeta>();
            }
        }
        #endregion
        #region "Link And Unlink Seta"
        private void btnLinkSeta_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                /*
                * this steps follow to both entities
                * 
                * 1 - create instance of entity with relative primary key
                * 
                * 2 - add instance to context
                * 
                * 3 - attach instance to context
                */

                LookupSeta s = (LookupSeta)bindingSourceAvailableSeta.Current;

                //1
                var SetaObj = new LookupSeta
                {
                    SetaID = s.SetaID
                };
                //2
                DbConnection.LookupSetas.Add(SetaObj);
                //3
                DbConnection.LookupSetas.Attach(SetaObj);
                // 1
                CurriculumCourse CurriculumCourseObj = new CurriculumCourse
                {
                    CurriculumCourseID = this.CurriculumCourseID
                };
                //// 2
                DbConnection.CurriculumCourses.Add(CurriculumCourseObj);
                //// 3
                DbConnection.CurriculumCourses.Attach(CurriculumCourseObj);

                // like previous method add instance to navigation property
                CurriculumCourseObj.LookupSetas.Add(SetaObj);

                // call SaveChanges
                DbConnection.SaveChanges();
            }
            this.populateAvailableSeta();
            this.populateLinkedSeta();
            this.setAddRemoveControls();
        }

        private void btnRemoveSeta_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                ////// return one instance each entity by primary key
                LookupSeta s = (LookupSeta)bindingSourceLinkedSeta.Current;
                var SetaObj = DbConnection.LookupSetas.FirstOrDefault(a => a.SetaID == s.SetaID);
                var CurriculumCourseObj = DbConnection.CurriculumCourses.FirstOrDefault(a => a.CurriculumCourseID == this.CurriculumCourseID);

                ////// call Remove method from navigation property for any instance
                CurriculumCourseObj.LookupSetas.Remove(SetaObj);

                ////// call SaveChanges from context
                DbConnection.SaveChanges();
            }
            this.populateAvailableSeta();
            this.populateLinkedSeta();
            this.setAddRemoveControls();
        }
        #endregion
    }
}
