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
    public partial class frmAddTrainingDepartmentCourseEnrollmentTypeModules : Form
    {
        public frmAddTrainingDepartmentCourseEnrollmentTypeModules()
        {
            InitializeComponent();
        }

        public int TrainingDepartmentCourseEnrollmentTypeMetaDataID { get; set; }

        private void btnLinkModule_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //TrainingDepartmentCourseEnrollmentTypeModule TDCETM = new TrainingDepartmentCourseEnrollmentTypeModule()
                //{
                //    TrainingDepartmentCourseEnrollmentTypeMetaDataID = this.TrainingDepartmentCourseEnrollmentTypeMetaDataID,
                //    ModuleID = Convert.ToInt32(lstAvailableModules.SelectedValue)
                //};
                //DbConnection.TrainingDepartmentCourseEnrollmentTypeModules.Add(TDCETM);
                //DbConnection.SaveChanges();
            };
            this.populateAvailableModules();
            this.populateLinkedModules();
        }
        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                int ID = Convert.ToInt32(lstLinkedModules.SelectedValue);
                //TrainingDepartmentCourseEnrollmentTypeModule LinkedModuleToRemove = DbConnection.TrainingDepartmentCourseEnrollmentTypeModules
                //                                .Where(TDCETM => TDCETM.ModuleID ==  ID
                //                                                    && TDCETM.TrainingDepartmentCourseEnrollmentTypeMetaDataID == this.TrainingDepartmentCourseEnrollmentTypeMetaDataID)
                //                                                        .FirstOrDefault<TrainingDepartmentCourseEnrollmentTypeModule>();

               // DbConnection.Entry(LinkedModuleToRemove).State = System.Data.Entity.EntityState.Deleted;
                DbConnection.SaveChanges();
            };
            this.populateAvailableModules();
            this.populateLinkedModules();
        }

        #region "Populate Methods"

        private void populateAvailableModules()
        {
            using (var DbConnection = new MCDEntities())
            {
                //List<Module> AvaliableModules = (from a in DbConnection.Modules
                //                                 select a).Except(
                //                                            from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeModules
                //                                            orderby a.Module.ModuleName
                //                                            where a.TrainingDepartmentCourseEnrollmentTypeMetaDataID == TrainingDepartmentCourseEnrollmentTypeMetaDataID
                //                                            select a.Module).ToList<Module>();

                //this.bindingSourceAvailableModules.DataSource = (from a in AvaliableModules
                //                                                 orderby a.ModuleName
                //                                                 select a).ToList<Module>();
            };
        }
        private void populateLinkedModules()
        {
            using (var DbConnection = new MCDEntities())
            {
                //List<Module> LinkedModules = (from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeModules
                //                              where a.TrainingDepartmentCourseEnrollmentTypeMetaDataID == TrainingDepartmentCourseEnrollmentTypeMetaDataID
                //                              select a.Module).ToList<Module>();

                //this.bindingSourceLinkedModules.DataSource = (from a in LinkedModules
                //                                              orderby a.ModuleName
                //                                              select a).ToList<Module>();
            };
        }

        #endregion

        private void frmAddTrainingDepartmentCourseEnrollmentTypeModules_Load(object sender, EventArgs e)
        {
            this.populateAvailableModules();
            this.populateLinkedModules();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                Module mod = new Module()
                {
                    ModuleName = txtModuleBindingNavigator.Text.ToString()
                };
                DbConnection.Modules.Add(mod);
                DbConnection.SaveChanges();
            }
            this.txtModuleBindingNavigator.Text = "";
            this.populateAvailableModules();
        }
    }
}


