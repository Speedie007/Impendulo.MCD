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

namespace Impendulo.Courses.Add.CourseDatabase
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
        public int TrainingDepartmentCourseMetaDataID { get; set; }
        #endregion
        #region "Populate Controls"

        private void populateAvailableSeta()
        {
            using (var DbConnection = new MCDEntities())
            {
                //bindingSourceAvailableSeta.DataSource = (from a in DbConnection.Setas
                //                                         select a).Except(from a in DbConnection.Setas
                //                                                          from b in a.TrainingDepartmentCourseMetaDatas
                //                                                          where b.TrainingDepartmentCourseMetaDataID == this.TrainingDepartmentCourseMetaDataID
                //                                                          select a).ToList<Seta>();
            }
        }
        private void populateLinkedSeta()
        {
            using (var DbConnection = new MCDEntities())
            {
                //bindingSourceLinkedSeta.DataSource = (from a in DbConnection.Setas
                //                                      from b in a.TrainingDepartmentCourseMetaDatas
                //                                      where b.TrainingDepartmentCourseMetaDataID == this.TrainingDepartmentCourseMetaDataID
                //                                      select a).ToList<Seta>();
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
                //TrainingDepartmentCourseMetaData TDCMD = new TrainingDepartmentCourseMetaData
                //{
                //    TrainingDepartmentCourseMetaDataID = this.TrainingDepartmentCourseMetaDataID
                //};
                // 2
               // DbConnection.TrainingDepartmentCourseMetaDatas.Add(TDCMD);
                // 3
                //DbConnection.TrainingDepartmentCourseMetaDatas.Attach(TDCMD);

                // like previous method add instance to navigation property
                //TDCMD.Setas.Add(SetaObj);

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
                //// return one instance each entity by primary key
                //Seta s = (Seta)bindingSourceLinkedSeta.Current;
                //var SetaObj = DbConnection.Setas.FirstOrDefault(a => a.SetaID == s.SetaID);
                //var TrainingDepartmentCourseMetaDataObj = DbConnection.TrainingDepartmentCourseMetaDatas.FirstOrDefault(a => a.TrainingDepartmentCourseMetaDataID == this.TrainingDepartmentCourseMetaDataID);

                //// call Remove method from navigation property for any instance
                //TrainingDepartmentCourseMetaDataObj.Setas.Remove(SetaObj);

                //// call SaveChanges from context
                //DbConnection.SaveChanges();
            }
            this.populateAvailableSeta();
            this.populateLinkedSeta();
            this.setAddRemoveControls();
        }
        #endregion
    }
}
