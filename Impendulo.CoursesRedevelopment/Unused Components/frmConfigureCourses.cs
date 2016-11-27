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
    public partial class frmConfigureCourses : Form
    {
        public frmConfigureCourses()
        {
            InitializeComponent();
        }

        private void frmConfigureCourses_Load(object sender, EventArgs e)
        {
            /*************************************************
            Loads Each Section of the Form - the sequence is important as
            each section is dependant on the previous section to be loaded correctly be it can be loaded.
            eg. Departments must be loaded before Training-Departments can be loaded.
            ***********************************************************/
            this.refreshDepartments();
            this.refreshTrainingDepartments();
            this.refreshTrainingDepartmentCourses();
            this.refreshCourseMetaDataConfiguration();
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
            this.resetCourseFilter();
        }

        #region Panel Toggle Bar Methods

        private void lblExpandAndCollapse_Click(object sender, EventArgs e)
        {
            if (this.panelTrainingCourseSelector.Visible)
            {
                this.panelTrainingCourseSelector.Visible = false;
                //splitContainerCourseSelectionMain.Panel1Collapsed = true;
                splitContainerCourseSelectionMain.Panel1MinSize = 25;
                splitContainerCourseSelectionMain.SplitterDistance = 25;
                lblExpandAndCollapse.Text = "Expand Course Selection";

                //picBoxCourseSelection.Image = imageListCourseSelector.Images[0];
            }
            else
            {
                this.panelTrainingCourseSelector.Visible = true;
                //splitContainerCourseSelectionMain.Panel1Collapsed = false;
                splitContainerCourseSelectionMain.SplitterDistance = 375;
                splitContainerCourseSelectionMain.Panel1MinSize = 375;
                lblExpandAndCollapse.Text = "Collapse Course Selection";
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
            if (this.trainingDepartmentBindingSource.Count > 0)
            {
                gbCourse.Enabled = true;
            }
            else
            {
                gbCourse.Enabled = false;
            }
        }
        private void refreshTrainingDepartmentCourses()
        {
            int _TrainingDepartmentID = 0;
            if (cboTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue); }
            this.populateTrainingDepartmentCourses(_TrainingDepartmentID);
            if (lstTrainingDepartmentCourses.Items.Count > 0)
            {
                gbCourseMetaData.Enabled = true;
            }
            else
            {
                gbCourseMetaData.Enabled = false;
            }
        }

        private void refreshCourseMetaDataConfiguration()
        {
            int _TrainingDepartmentCourseID = 0;
            if (lstTrainingDepartmentCourses.SelectedValue != null)
            {
                _TrainingDepartmentCourseID = Convert.ToInt32(lstTrainingDepartmentCourses.SelectedValue);
            }
            this.populateCourseMetaData(_TrainingDepartmentCourseID);
        }

        private void refreshCourseAssignedSetas()
        {
            int _CourseMetaDataID = 0;

            if (courseMetaDataBindingSource.Count > 0)
            {
                //_CourseMetaDataID = ((CourseMetaData)(courseMetaDataBindingSource.Current)).CourseMetaDataID;
            }
            this.populateAssosiatedSetas(_CourseMetaDataID);
        }

        private void refreshModules()
        {
            int _CourseMetaDataID = 0;
            if (courseMetaDataBindingSource.Count > 0)
            {
                //_CourseMetaDataID = ((CourseMetaData)(courseMetaDataBindingSource.Current)).CourseMetaDataID;
            }
            this.populateModules(_CourseMetaDataID);
        }
        private void refreshActivities()
        {
            int _CourseMetaDataID = 0;
            int _ModuleID = 0;
            if (courseMetaDataBindingSource.Count > 0 && moduleBindingSource.Count > 0)
            {
                //_CourseMetaDataID = ((CourseMetaData)(courseMetaDataBindingSource.Current)).CourseMetaDataID;
                _ModuleID = ((Module)(moduleBindingSource.Current)).ModuleID;

            }
            this.populateActivities(_CourseMetaDataID, _ModuleID);
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

        private void populateAssosiatedSetas(int _CourseMetaDataID)
        {
            using (var DbConnection = new MCDEntities())
            {
                ////setaBindingSource.DataSource = (from a in DbConnection.Setas
                //                                from b in a.CourseMetaDatas
                //                                where b.CourseMetaDataID == _CourseMetaDataID
                //                                select a).ToList<Seta>();
            }
        }
        private void populateModules(int _CourseMetaDataID)
        {
            //using (var DbConnection = new MCDEntities())
            //{
            //    moduleBindingSource.DataSource = (from a in DbConnection.CourseMetaDataModules
            //                                      where a.CourseMetaDataID == _CourseMetaDataID
            //                                      select a.Module).ToList<Module>();
            //};
        }
        private void populateActivities(int _CourseMetaDataID, int _ModuleID)
        {
            //using (var DbConnection = new MCDEntities())
            //{
            //    activityBindingSource.DataSource = (from a in DbConnection.Activities
            //                                        from b in a.CourseMetaDataModules
            //                                        where b.CourseMetaDataID == _CourseMetaDataID &&
            //                                            b.ModuleID == _ModuleID
            //                                        select a).ToList<Activity>();
            //}
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
            this.refreshCourseMetaDataConfiguration();
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
            this.resetCourseFilter();
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
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
            this.resetCourseFilter();
        }




        #endregion
        #region Training Department Course Controls

        private void lstTrainingDepartmentCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshCourseMetaDataConfiguration();
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
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

        private void btnFilterTrainingDepartmentCourses_Click(object sender, EventArgs e)
        {
            this.refreshTrainingDepartmentCourses();
            this.refreshCourseMetaDataConfiguration();
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
        }

        private void tsbtnRefreshCourseSearch_Click(object sender, EventArgs e)
        {
            this.resetCourseFilter();
            this.refreshTrainingDepartmentCourses();
            this.refreshCourseMetaDataConfiguration();
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
        }
        #endregion
        #region Course Configuration Controls

        private void courseMetaDataBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshCourseAssignedSetas();
            this.refreshModules();
            this.refreshActivities();
        }
        private void tsbtnSelectCourseMetaData_Click(object sender, EventArgs e)
        {
            //frmAddCourseMetaData frm = new frmAddCourseMetaData();
            //frm.CourseID = Convert.ToInt32(lstTrainingDepartmentCourses.SelectedValue);
            //frm.SelectedCourseName = lstTrainingDepartmentCourses.Text;
            //frm.ShowDialog();
            //this.refreshCourseMetaDataConfiguration();
            //refresh Gridvew to show added Course Configuration.
        }


        private void dgvCourseMetaData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    //var CourseMetaDataObj = (CourseMetaData)(row.DataBoundItem);
                    //var CourseObj = (Course)CourseMetaDataObj.Course;
                    //var EnrollmentTypeObj = (LookupEnrollmentType)CourseMetaDataObj.LookupEnrollmentType;

                    //row.Cells[Course.Index].Value = CourseObj.CourseName.ToString();
                    //row.Cells[EnrollmentType.Index].Value = EnrollmentTypeObj.EnrollmentType.ToString();
                    ////
                    ////row.Cells[TrainingDepartment.Index].Value = TrainingDep.TrainingDepartmentName.ToString();
                }
            }
        }




        #endregion Region
        #region Seta Controls Moethods
        private void btnAddCourseAccosiatedSeta_Click(object sender, EventArgs e)
        {
            frmAddTrainingDepartmentCourseSeta frm = new frmAddTrainingDepartmentCourseSeta();
            //frm.CourseMetaDataID = ((CourseMetaData)(courseMetaDataBindingSource.Current)).CourseMetaDataID;
            frm.ShowDialog();
            this.refreshCourseAssignedSetas();
        }

        #endregion
        #region Modules Controls Methods
        private void moduleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshActivities();
        }

        #endregion
        #region Activity Controls Methods

        private void dgvCourseDatabaseModulesActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ActivityObj = (Activity)(row.DataBoundItem);
                    var ModuleObj = (Module)ActivityObj.Module;
                    //var EnrollmentTypeObj = (LookupEnrollmentType)CourseMetaDataObj.LookupEnrollmentType;

                    row.Cells[ModuleName.Index].Value = ModuleObj.ModuleName.ToString();
                    //row.Cells[EnrollmentType.Index].Value = EnrollmentTypeObj.EnrollmentType.ToString();
                    //
                    //row.Cells[TrainingDepartment.Index].Value = TrainingDep.TrainingDepartmentName.ToString();
                }
            }
        }
        #endregion
        private void frmConfigureCourses_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dgvCourseMetaData.Dispose();
        }

        
    }
}
