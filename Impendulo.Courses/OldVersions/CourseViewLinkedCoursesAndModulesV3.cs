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
    public partial class CourseViewLinkedCoursesAndModulesV3 : Form
    {

        public CourseViewLinkedCoursesAndModulesV3()
        {
            InitializeComponent();
        }

        private void CourseViewLinkedCoursesAndModulesV3_Load(object sender, EventArgs e)
        {
            this.populateTrainingDepartments();
            this.populateCourseCategoriesLinkedtoTrainingDepartment(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
            this.populateCoursesLinkedToTheTrainingDepartmentCatergory(Convert.ToInt32(cboCourseCategories.SelectedValue.ToString()));
            this.populatesTheModulesLinkedToCourse(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
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
        private void populateCourseCategoriesLinkedtoTrainingDepartment(int _TrainingDepartmentID)
        {
            using (var DbConnection = new MCDEntities())
            {
                //var _CourseCategory = from CourseCat in DbConnection.CourseCategories
                //                      where CourseCat.TrainingDepartmentID == _TrainingDepartmentID
                //                      select CourseCat;
                //this.courseCategoryBindingSource.DataSource = _CourseCategory.ToList<CourseCategory>();
            }
        }
        private void populateCoursesLinkedToTheTrainingDepartmentCatergory(int _CourseCategoryID)
        {
            using (var DbConnection = new MCDEntities())
            {
                //var CourseObj = from _Courses in DbConnection.Courses
                //                where _Courses.CourseCategoryID == _CourseCategoryID
                //                select _Courses;

                //courseBindingSource.DataSource = CourseObj.ToList<Course>();
                //if (lstCourses.Items.Count > 0)
                //{
                //    btnLinkCourseModule.Enabled = true;
                //    btnRemoveModuleLinkedToCourse.Enabled = true;
                //}
                //else
                //{
                //    btnLinkCourseModule.Enabled = false;
                //    btnRemoveModuleLinkedToCourse.Enabled = false;
                //}
            }
        }
        private void populatesTheModulesLinkedToCourse(int _CourseID)
        {
            using (var dbConnection = new MCDEntities())
            {
                // LINQ Query Syntax

                //var CurrentlySelectedModulesLinkedToCourse = from a in dbConnection.CourseModules.Include("Module")
                //                                             where a.CourseID == _CourseID
                //                                             //orderby a.Module descending
                //                                             select a;
                //this.courseModuleBindingSource.DataSource = CurrentlySelectedModulesLinkedToCourse.ToList<CourseModule>();

            }
        }
        #endregion

        private void resetTrainingDepartmentCategoryAndCouresAndCourseModules()
        {
            courseCategoryBindingSource.DataSource = null;
            courseBindingSource.DataSource = null;
            courseModuleBindingSource.DataSource = null;
        }
        private void resetCouresAndCourseModules()
        {
            courseBindingSource.DataSource = null;
            courseModuleBindingSource.DataSource = null;
        }
        private void cboTrainingDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //resetTrainingDepartmentCategoryAndCouresAndCourseModules();
            var TrainingDepartmentID = 0;
            var CourseCategoryID = 0;
            var CourseID = 0;

            //Must Build the Course Categories
            if (this.cboTrainingDepartment.SelectedValue != null) { TrainingDepartmentID = Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()); }
            //populate Course Categories Linked to Training Department
            this.populateCourseCategoriesLinkedtoTrainingDepartment(TrainingDepartmentID);

            if (this.cboCourseCategories.SelectedValue != null) { CourseCategoryID = Convert.ToInt32(cboCourseCategories.SelectedValue.ToString()); }
            //Populate Courses Linked To the Training Department Catergory
            this.populateCoursesLinkedToTheTrainingDepartmentCatergory(CourseCategoryID);

            if (this.lstCourses.SelectedValue != null) { CourseID = Convert.ToInt32(this.lstCourses.SelectedValue.ToString()); }
            //populates the Course Modules Linked to Course
            this.populatesTheModulesLinkedToCourse(CourseID);






        }

        private void btnAddNewCourseCategory_Click(object sender, EventArgs e)
        {
            //var frm = new frmAddNewCourse();
            //frm._TrainingDepartmentID = Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString());
            //frm.ShowDialog();
            //populateCourseCategoriesLinkedtoTrainingDepartment(Convert.ToInt32(this.cboTrainingDepartment.SelectedValue.ToString()));
        }

        private void cboCourseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CourseCategoryID = 0;
            var CourseID = 0;

            if (cboCourseCategories.SelectedValue != null) { CourseCategoryID = Convert.ToInt32(cboCourseCategories.SelectedValue.ToString()); }
            this.populateCoursesLinkedToTheTrainingDepartmentCatergory(CourseCategoryID);

            if (lstCourses.SelectedValue != null) { CourseID = Convert.ToInt32(this.lstCourses.SelectedValue.ToString()); }
            this.populatesTheModulesLinkedToCourse(CourseID);


        }

        private void btnLinkCourseToCategory_Click(object sender, EventArgs e)
        {
            var frm = new frmLinkCourseToDepartmentV3();
            frm._CourseCategoryID = Convert.ToInt32(cboCourseCategories.SelectedValue);
            frm.ShowDialog();
            this.populateCoursesLinkedToTheTrainingDepartmentCatergory(Convert.ToInt32(this.cboCourseCategories.SelectedValue.ToString()));
            //populatesTheModulesLinkedToCourse(Convert.ToInt32(lstCourses.SelectedValue.ToString()));
        }

        private void btnLinkCourseModule_Click(object sender, EventArgs e)
        {
            var frm = new LinkModuleToCourseV2();
            frm._GlobalCourseID = Convert.ToInt32(lstCourses.SelectedValue);
            frm._parentForm = this;
            frm.ShowDialog();
            this.populatesTheModulesLinkedToCourse(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var CourseID = 0;

            if (lstCourses.SelectedValue != null) { CourseID = Convert.ToInt32(this.lstCourses.SelectedValue.ToString()); }
            this.populatesTheModulesLinkedToCourse(CourseID);
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
                    //row.Cells[RemoveModule.Index].Value = false;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void courseModuleDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void courseModuleDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void courseModuleDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void courseModuleDataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void courseModuleDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnRemoveModuleLinkedToCourse_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //forces the any selections not yet commited to be committed.
                courseModuleDataGridView.EndEdit();

                //creates a list to collect all the CoureModules to be removed.
                //IList<CourseModule> removeCourseModules = new List<CourseModule>();

                ////Navigates through the Gridview to find all the items selected to be removed.
                //foreach (DataGridViewRow row in courseModuleDataGridView.Rows)
                //{
                //    foreach (DataGridViewCell Cell in row.Cells)
                //    {
                //        if (Cell.ColumnIndex == 0)
                //        {
                //            if (Cell.Value != null)
                //            {
                //                if (Convert.ToBoolean(Cell.Value))
                //                {
                //                    var item = (from c in DbConnection.CourseModules
                //                                where c.CourseModuleID == ((CourseModule)row.DataBoundItem).CourseModuleID
                //                                select c).FirstOrDefault<CourseModule>();
                //                    DbConnection.CourseModules.Remove(item);
                //                }
                //            }

                //        }
                //    }
                //}
                DbConnection.SaveChanges();
                this.populatesTheModulesLinkedToCourse(Convert.ToInt32(lstCourses.SelectedValue));
            }
            //using (var DbConnection = new MCDEntities())
            //{
            //    var a = (CourseModule)(courseModuleDataGridView.SelectedRows[0].DataBoundItem);
            //    MessageBox.Show(Convert.ToString(a.CourseID));
            //    this.populatesTheModulesLinkedToCourse(Convert.ToInt32(this.lstCourses.SelectedValue.ToString()));

            //    //LinkModuleToCourseV2
            //}
        }

        private void courseModuleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            courseModuleDataGridView.CurrentRow.Selected = true;

            //if (e.ColumnIndex == 0)
            //{
            //    if (Convert.ToBoolean(courseModuleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            //    {

            //        courseModuleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            //    }
            //    else { courseModuleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true; }
            //}

        }

        private void courseModuleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initializes the variables to pass to the MessageBox.Show method.

            string message = "Are You Sure?";
            string caption = "Removal of Category";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {

                // Delete Coures



            }
        }
    }
}
