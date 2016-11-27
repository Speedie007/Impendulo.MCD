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


namespace Impendulo.TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshDepartments();
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
        }

        #region #Refresh Methods


        private void refreshDepartments()
        {
            populateDepartments();
        }

        private void refreshDepartmentCurriculums()
        {
            int _DepartmentID = 0;
            if (cboDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue); };
            this.populateDepartmentCurriculums(_DepartmentID);
        }

        private void refreshCurriculumCourses()
        {
            int _CurriculumCourseID = 0;
            if (lstDepartmentCourses.SelectedValue != null) { _CurriculumCourseID = Convert.ToInt32(lstDepartmentCourses.SelectedValue); };
            this.populateCurriculumCourses(_CurriculumCourseID);
        }
        #endregion


        #region Populate Departments
        private void populateDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                      select a).ToList<LookupDepartment>();
            };
        }
        private void populateDepartmentCurriculums(int _DepartmentID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                                                      where a.DepartmentID == _DepartmentID
                                                      select a).ToList<Curriculum>();
            };

        }
        private void populateCurriculumCourses(int _CurriculumID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseBindingSource.DataSource = (from a in Dbconnection.CurriculumCourses
                                                            where a.CurriculumID == _CurriculumID
                                                            select a).ToList<CurriculumCourse>();
            };
        }
        #endregion

        #region Curriculum Courses Methods
        private void dgvCurriculumCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumCourseObj = (CurriculumCourse)(row.DataBoundItem);
                    var CourseObj = (Course)CurriculumCourseObj.Course;
                    var EnrollmentTypeObj = (LookupEnrollmentType)CurriculumCourseObj.LookupEnrollmentType;
                    var DepartmentCurriculumObj = (Curriculum)CurriculumCourseObj.Curriculum;
                    //var CostingModelObj = (CostingModel)CurriculumCourseObj.CostingModel;
                    var DepartmentObj = (LookupDepartment)DepartmentCurriculumObj.LookupDepartment;

                    row.Cells[CourseName.Index].Value = CourseObj.CourseName.ToString();
                    row.Cells[DepartmentName.Index].Value = DepartmentObj.DepartmentName.ToString();

                    row.Cells[EnrollmentType.Index].Value = EnrollmentTypeObj.EnrollmentType.ToString();
                    //row.Cells[CostingModel.Index].Value = CostingModelObj.CostingModelName.ToString();
                    row.Cells[CurriculumName.Index].Value = DepartmentCurriculumObj.CurriculumName.ToString();
                }
            }
        }


        #endregion

        #region Modules Methods
        private void btnAddModules_Click(object sender, EventArgs e)
        {
            
        }

        #endregion


    }
}
