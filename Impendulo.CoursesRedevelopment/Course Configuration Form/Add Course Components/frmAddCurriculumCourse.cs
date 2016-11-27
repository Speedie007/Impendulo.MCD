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

namespace Impendulo.Courses.InputForms.Development
{
    public partial class frmAddCurriculumCourse : Form
    {
        public int CurriculumID { get; set; }
        public int DepartmentID { set; get; }

        public string SelectedCurriculumName { set; get; }
        public frmAddCurriculumCourse()
        {
            InitializeComponent();
        }

        private void frmAddCourseMetaData_Load(object sender, EventArgs e)
        {
            this.refreshDepartments();
            this.cboDepartments.SelectedValue = DepartmentID;
            this.refreshEnrollmentTypes();
            this.refreshCourses();
            
            // this.refreshSelectedCourseTextBox();
            this.gbCourseProperties.Text = SelectedCurriculumName + " " + gbCourseProperties.Text;
            // this.lblReferenceCourse.Text = SelectedCourseName;
        }
        #region Refresh Methods


        private void resetCourseFilter()
        {
            this.txtCourseFilterCriteria.Clear();
        }
        private void refreshDepartments()
        {
            this.populateDepartments();
        }

        private void refreshCourses()
        {
            int _DepartmentID = 0;
            int _EnrollmentTypeID = 0;
            if (cboDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue); }
            if (cboEnrollmentTypes.SelectedValue != null) { _EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue); }
            this.populateCourses(_DepartmentID, _EnrollmentTypeID);
            if (this.lstCourses.Items.Count > 0)
            {
                btnAddTrainingDepartmentCourseMetaData.Enabled = true;
            }
            else
            {
                btnAddTrainingDepartmentCourseMetaData.Enabled = false;
            }
        }
        private void refreshEnrollmentTypes()
        {
            this.populateEnrollemntTypes();
        }
        #endregion
        #region Populate Methods
        private void populateDepartments()
        {
            using (var DBConnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = (from a in DBConnection.LookupDepartments select a).ToList<LookupDepartment>();

            };

        }

        private void populateCourses(int _DepartmentID,int _EnrollmentTypeID)
        {
            using (var DbConnection = new MCDEntities())
            {
                string SearchString = txtCourseFilterCriteria.Text.ToString();



                List<Course> AllCourses = (from a in DbConnection.Courses
                                           where a.DepartmentID == _DepartmentID
                                           orderby a.CourseName ascending
                                           select a).Except(from a in DbConnection.Courses
                                                            from b in a.CurriculumCourses
                                                            where b.CurriculumID == this.CurriculumID
                                                            && b.EnrollmentTypeID == _EnrollmentTypeID
                                                            select a).ToList<Course>();

                courseBindingSource.DataSource = (from a in AllCourses
                                                  where a.CourseName.ToLower().Contains(SearchString.ToLower())
                                                  select a).ToList<Course>();
                
            }
        }
        private void populateEnrollemntTypes()
        {
            using (var DbConnection = new MCDEntities())
            {
                lookupEnrollmentTypeBindingSource.DataSource = (from a in DbConnection.LookupEnrollmentTypes
                                                                select a).ToList<LookupEnrollmentType>();
            }
        }

        #endregion




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Department Controls Methods

        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.resetCourseFilter();
            this.refreshCourses();
        }

        #endregion

        #region Training Department Controls Methods
        private void cboTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshCourses();
        }

        #endregion

        #region Training Department Course Controls Methods
        private void lstTrainingDepartmentCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.refreshSelectedCourseTextBox();
        }
        private void tsbtnSearchCourses_Click(object sender, EventArgs e)
        {
            this.refreshCourses();
            //this.refreshSelectedCourseTextBox();
        }
        private void tsbtnResetSearchFilters_Click(object sender, EventArgs e)
        {
            this.resetCourseFilter();
            this.refreshCourses();
            //this.refreshSelectedCourseTextBox();
        }
        private void tsbtnAddTrainingDepartmentCourse_Click(object sender, EventArgs e)
        {
            if (this.txtTrainingDepartmentCourse.Text.Length > 0)
            {
                using (var DbConnection = new MCDEntities())
                {
                    Course CourseObj = new Course
                    {
                        CourseName = txtTrainingDepartmentCourse.Text.ToString(),
                        DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue),
                        CourseDescription = ""
                    };

                    DbConnection.Courses.Add(CourseObj);
                    DbConnection.SaveChanges();
                };
                this.refreshCourses();
                this.txtTrainingDepartmentCourse.Clear();
                this.resetCourseFilter();
            }
        }


        private void cboEnrollmentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshCourses();
        }
        #endregion

        private void btnAddTrainingDepartmentCourseMetaData_Click(object sender, EventArgs e)
        {


            if (this.txtCourseCost.Text.Length > 0)
            {
                using (var DbConnection = new MCDEntities())
                {
                    CurriculumCourse newCourseObj = new CurriculumCourse
                    {
                        CourseID = Convert.ToInt32(this.lstCourses.SelectedValue),
                        CurriculumID = this.CurriculumID,
                        EnrollmentTypeID = Convert.ToInt32(cboEnrollmentTypes.SelectedValue),
                        Cost = Convert.ToDecimal(txtCourseCost.Text.Replace(".", ",")),
                        Duration = Convert.ToInt32(nudCourseDuration.Value),
                        CurricullumCourseCode = new CurricullumCourseCode
                        {
                            CurricullumCourseCodeValue = txtCourseCourseCode.Text
                        },
                        CurriculumCourseMinimumMaximum = new CurriculumCourseMinimumMaximum
                        {
                            CurriculumCourseMaximum = Convert.ToInt32(nudCourseMaximumAllowed.Value),
                            CurriculumCourseMinimum = Convert.ToInt32(nudCourseMinimumAllowed.Value)
                        }
                    };
                    DbConnection.CurriculumCourses.Add(newCourseObj);
                    DbConnection.SaveChanges();
                    this.Close();
                };
            }
            else
            {
                MessageBox.Show("Ensure that the cost has been allocated!", "Add Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
