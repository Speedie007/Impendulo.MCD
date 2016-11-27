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

using Impendulo.Courses.InputForms;

namespace Impendulo.CoursesRedevelopment
{
    public partial class frmTrainingDepartmentCourses : Form
    {

        private Boolean isClosing = false;
        private void frmTrainingDepartmentCourses_Load(object sender, EventArgs e)
        {
            //Sets the inital Image for the panel toggle bar
            // picBoxCourseSelection.Image = imageListCourseSelector.Images[1];

            this.refreshDepartments();
            this.refreshTrainingDepartments();
            this.refreshTrainingDepartmentCourses();
            this.refreshCourseMetaDataConfiguration();
        }

        public frmTrainingDepartmentCourses()
        {
            InitializeComponent();
            //Set the curent view state of the Training Department Course Selection Panel.
        }
        #region Panel Toggle Bar Methods
        private void panelTrainingCourseSelectionHandler_Click(object sender, EventArgs e)
        {
            if (this.panelTrainingCourseSelector.Visible)
            {
                this.panelTrainingCourseSelector.Visible = false;
                splitContainerCourseSelectionMain.SplitterDistance = 17;
                //picBoxCourseSelection.Image = imageListCourseSelector.Images[0];
            }
            else
            {
                this.panelTrainingCourseSelector.Visible = true;
                splitContainerCourseSelectionMain.SplitterDistance = 375;
                //picBoxCourseSelection.Image = imageListCourseSelector.Images[1];
            }
        }
        #endregion

        #region Refresh Methods

        private void refreshDepartments()
        {
            this.populateDepartments();
        }
        private void refreshTrainingDepartments()
        {
            int _DepartmentID = 0;
            if (cboDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue); }
            this.populateTrainingDepartments(_DepartmentID);
        }
        private void refreshTrainingDepartmentCourses()
        {
            int _TrainingDepartmentID = 0;
            if (cboTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue); }
            this.populateTrainingDepartmentCourses(_TrainingDepartmentID);
            if (lstCourses.Items.Count > 0)
            {
                gbCourseMeataData.Enabled = true;
            }
            else
            {
                gbCourseMeataData.Enabled = false;
            }
        }

        private void refreshCourseMetaDataConfiguration()
        {
            int _TrainingDepartmentCourseID = 0;
            if (lstCourses.SelectedValue != null)
            {
                _TrainingDepartmentCourseID = Convert.ToInt32(lstCourses.SelectedValue);
                this.populateCourseMetaData(_TrainingDepartmentCourseID);
            }

        }
        #endregion

        #region Populate Methods
        private void populateDepartments()
        {
            using (var DBConnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = (from a in DBConnection.Departments select a).ToList<Department>();

            };

        }
        private void populateTrainingDepartments(int _DepartmentID)
        {
            using (var DBConnection = new MCDEntities())
            {
                //trainingDepartmentBindingSource.DataSource = (from a in DBConnection.TrainingDepartments
                //                                              where a.DepartmentID == _DepartmentID
                //                                              select a).ToList<TrainingDepartment>();

            };
        }
        private void populateTrainingDepartmentCourses(int _TrainingDepartmentID)
        {
            using (var DbConnection = new MCDEntities())
            {
                string SearchString = txtCourseFilterCriteria.Text.ToString();

                //List<TrainingDepartmentCourse> trainingDepartmentCourseResults = (from a in DbConnection.TrainingDepartmentCourses
                //                                                                  where a.TrainingDepartmentID == _TrainingDepartmentID
                //                                                                  orderby a.TrainingDepartmentCourseName ascending
                //                                                                  select a).ToList<TrainingDepartmentCourse>();
                //trainingDepartmentCourseBindingSource.DataSource = (from a in trainingDepartmentCourseResults
                //                                                    where a.TrainingDepartmentCourseName.ToLower().Contains(SearchString.ToLower())
                //                                                    select a).ToList<TrainingDepartmentCourse>();
            }
        }

        private void populateCourseMetaData(int _TrainingDepartmentCourseID)
        {
            using (var DbConnection = new MCDEntities())
            {
                //courseMetaDataBindingSource.DataSource = (from a in DbConnection.CourseMetaDatas
                //                                          where a.TrainingDepartmentCourseID == _TrainingDepartmentCourseID
                //                                          select a).ToList<CourseMetaData>();
            };
        }

        #endregion

        #region Search Methods

        private void resetCourseFilter()
        {
            this.txtCourseFilterCriteria.Clear();
        }
        private void filterCourses()
        {

        }
        #endregion

        #region Department Controls
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddDepartment frm = new frmAddDepartment();
            frm.ShowDialog();

        }
        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshTrainingDepartments();

            this.refreshTrainingDepartmentCourses();
            this.resetCourseFilter();

            if (this.trainingDepartmentBindingSource.Count > 0)
            {
                gbCourses.Enabled = true;
            }
            else
            {
                gbCourses.Enabled = false;
            }
        }

        #endregion
        #region Training Department Controls

        private void btnAddTrainingDepartement_Click(object sender, EventArgs e)
        {
            //frmAddTrainingDepartment frm = new frmAddTrainingDepartment();
            //frm.DepartmentID = Convert.ToInt32(this.cboDepartments.SelectedValue);
            //frm.ShowDialog();
            //this.refreshTrainingDepartments();
        }

        private void cboTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshTrainingDepartmentCourses();
            this.resetCourseFilter();
            this.refreshCourseMetaDataConfiguration();
        }



        #endregion

        #region Traing Department Course Controls
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstCourses.IsDisposed)
            {
                this.refreshCourseMetaDataConfiguration();
            }

        }
        private void btnAddTrainingDepartmentCourses_Click(object sender, EventArgs e)
        {
            frmAddTrainingDeparmentCourses frm = new frmAddTrainingDeparmentCourses();
            int _TrainingDepartmentID = 0;
            if (cboTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue); }
            frm.TrainingDepartmentID = _TrainingDepartmentID;
            frm.ShowDialog();
            this.refreshTrainingDepartmentCourses();
        }

        private void tsbtnSearchForCourse_Click(object sender, EventArgs e)
        {
            this.refreshTrainingDepartmentCourses();
        }

        private void tsbtnRefreshCourseSearch_Click(object sender, EventArgs e)
        {
            this.resetCourseFilter();
            this.refreshTrainingDepartmentCourses();
        }
        #endregion
        #region Course Configuration Controls
        private void tsbtnSelectCourseMetaData_Click(object sender, EventArgs e)
        {
            //frmAddCourseMetaData frm = new frmAddCourseMetaData();
            //frm.CourseID = Convert.ToInt32(lstCourses.SelectedValue);
            //frm.SelectedCourseName = lstCourses.Text;
            //frm.ShowDialog();
            //refresh Gridvew to show added Course Configuration.
        }






        #endregion Region

        private void courseMetaDataBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            // e.Exception.
        }

        private void frmTrainingDepartmentCourses_FormClosing(object sender, FormClosingEventArgs e)
        {
           // dgvCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Dispose();
        }

    }
}