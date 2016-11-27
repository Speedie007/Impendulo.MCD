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

namespace Impendulo.Courses
{
    public partial class CourseViewLinkedCoursesAndModulesV2 : Form
    {
        public CourseViewLinkedCoursesAndModulesV2()
        {
            InitializeComponent();
        }

        private void CourseViewLinkedCoursesAndModulesV2_Load(object sender, EventArgs e)
        {
            this.populateTrainingDepartments();
            if (this.cboTrainingDepartment.SelectedValue != null)
            {
                this.populateCourseCategories(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
                this.populateLinkedCategoryCourse(Convert.ToInt32(this.cboCourseCategories.SelectedValue.ToString()));
                this.populateLinkedCourseModules(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
                //this.populateModulesDetailsForEditing();
            }


        }

        #region "Populate Methods"
        private void populateTrainingDepartments()
        {
            using (var DbConnection = new MCDEntities())
            {

                var TrainingDepartmentEntities = from TrainingDep in DbConnection.TrainingDepartments
                                                 select TrainingDep;
                this.trainingDepartmentBindingSource.DataSource = TrainingDepartmentEntities.ToList<TrainingDepartment>();
            }
        }
        private void populateCourseCategories(int _TrainingDepartment)
        {
            //using (var DbConnection = new MCDEntities())
            //{

            //    var _CourseCategory = from CourseCat in DbConnection.CourseCategories
            //                          where CourseCat.TrainingDepartmentID == _TrainingDepartment
            //                          select CourseCat;
            //    this.courseCategoryBindingSource.DataSource = _CourseCategory.ToList<CourseCategory>();
            //}
        }
        private void populateLinkedCategoryCourse(int _CourseCategoryID)
        {
            using (var dbConnection = new MCDEntities())
            {
                //// LINQ Query Syntax
                //var nestedQuesryOfCourses = from AllCourseRows in dbConnection.Courses
                //                            where AllCourseRows.CourseCategoryID == _CourseCategoryID
                //                            select AllCourseRows;
                //this.courseBindingSource.DataSource = nestedQuesryOfCourses.ToList<Course>();
            }
        }
        private void populateLinkedCourseModules(int _CourseID)
        {
            //using (var dbConnection = new MCDEntities())
            //{
            //    // LINQ Query Syntax
            //    var nestedQuesryOfCourses = from a in dbConnection.CourseModules.Include("Module")
            //                                where a.CourseID == _CourseID
            //                                select a;
            //    this.courseModuleBindingSource.DataSource = nestedQuesryOfCourses.ToList<CourseModule>();
            //}
        }
        #endregion

        private void ResetControls()
        {

        }
        #region "SelectIndexChanged Metohds"
        private void cboTrainingDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTrainingDepartment.SelectedValue != null)
            {
                this.populateCourseCategories(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
                this.populateLinkedCategoryCourse(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
                if (this.lstCourses.SelectedValue != null) {
                    this.populateLinkedCourseModules(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
                } else { this.populateLinkedCourseModules(0); }
                //this.populateModulesDetailsForEditing();
            }
        }
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTrainingDepartment.SelectedValue != null && lstCourses.SelectedValue != null)
            {
                this.populateLinkedCourseModules(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
            }
            else { this.populateLinkedCourseModules(0); }
        }

        #endregion

        private void btnLinkCourseToDepartment_Click(object sender, EventArgs e)
        {
            var frm = new frmLinkCourseToDepartmentV3();
            frm._CourseCategoryID = Convert.ToInt32(cboCourseCategories.SelectedValue);

            frm.ShowDialog();
            this.populateLinkedCategoryCourse(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
            populateLinkedCourseModules(Convert.ToInt32(lstCourses.SelectedValue.ToString()));
        }

        private void btnLinkModuleToCourse_Click(object sender, EventArgs e)
        {
            var frm = new LinkModuleToCourseV2();
            frm._GlobalCourseID = Convert.ToInt32(lstCourses.SelectedValue);
            frm._GlobalTrainingDepartmentID = Convert.ToInt32(cboTrainingDepartment.SelectedValue.ToString());
            frm.ShowDialog();

            if (this.cboTrainingDepartment.SelectedValue != null)
            {
                this.populateLinkedCourseModules(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
            }
        }

        private void btnUpdateCourseModule_Click(object sender, EventArgs e)
        {
            ////TrainingDepartmentCourseModule UpdateTrainingDepartmentCourseModule;

            ////using (var dbConnection = new MCDEntities())
            ////{
            ////    int _CourseID = Convert.ToInt32(this.lstCourses.SelectedValue.ToString());
            ////    int _TrainingDepartmentID = Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString());


            ////    int _ModuleID = Convert.ToInt32(lstModules.SelectedValue);
            ////    int _TrainingDepartmentCourseID = (from s in dbConnection.TrainingDepartmentCourses
            ////                                       where s.CourseID == _CourseID && s.TrainingDepartmentID == _TrainingDepartmentID
            ////                                       select s).FirstOrDefault<TrainingDepartmentCourse>().TrainingDepartmentCourseID;



            ////    UpdateTrainingDepartmentCourseModule = dbConnection.TrainingDepartmentCourseModules.Where(s => s.TrainingDepartmentCourseID == _TrainingDepartmentCourseID && s.ModuleID == _ModuleID).FirstOrDefault<TrainingDepartmentCourseModule>();

            ////    if (UpdateTrainingDepartmentCourseModule != null)
            ////    {
            ////        UpdateTrainingDepartmentCourseModule.TrainingDepartmentCourseModuleDefaultPrice = Convert.ToDecimal(this.txtCourseModuleDefaultPriceUPDATE.Text.ToString());
            ////        UpdateTrainingDepartmentCourseModule.TrainingDepartmentCourseModuleDefaultDuration = Convert.ToInt32(this.txtCourseModuleDefaultDurationUPDATE.Text.ToString());
            ////    }
            ////    //3. Mark entity as modified
            ////    dbConnection.Entry(UpdateTrainingDepartmentCourseModule).State = System.Data.Entity.EntityState.Modified;

            ////    //4. call SaveChanges
            ////    dbConnection.SaveChanges();
            ////}





            //populateModulesDetailsForEditing();
        }

        private void lstModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void courseModuleDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    //var _CourseModule = (CourseModule)(row.DataBoundItem);
                    //var _Module = _CourseModule.Module;

                    //row.Cells[ModuleName.Index].Value = _Module.ModuleName.ToString();
                }
            }
        }

        private void btnLinkCourseModule_Click(object sender, EventArgs e)
        {
            var frm = new LinkModuleToCourseV2();
            frm._GlobalCourseID = Convert.ToInt32(lstCourses.SelectedValue);

            frm.ShowDialog();
            this.populateLinkedCourseModules(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                MessageBox.Show(Convert.ToString(courseModuleDataGridView.CurrentCell.Value));

                //LinkModuleToCourseV2
            }
        }

        private void cboCourseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            if (cbo.SelectedValue != null) {
                this.populateLinkedCategoryCourse(Convert.ToInt32(cbo.SelectedValue.ToString()));
                if (lstCourses.SelectedValue != null) {
                    populateLinkedCourseModules(Convert.ToInt32(lstCourses.SelectedValue.ToString()));
                }
                else {
                    populateLinkedCourseModules(0);
                }
                

            } else {
                this.populateLinkedCategoryCourse(0);
            }
            
            //this.populateLinkedCourseModules(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString(
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
