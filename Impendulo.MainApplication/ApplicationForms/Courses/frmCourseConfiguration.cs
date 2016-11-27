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
using Impendulo.Courses.SummaryForms;
using Impendulo.Courses.InputForms.Deployment;
using Impendulo.Courses.SummaryForms.Deployment;
using Impendulo.Courses.AddRemoveCurriculumCoursePreRequisteCourses.Deployment;

namespace Impendulo.Courses.Configuration.Deployment
{
    public partial class frmCourseConfiguration : Form
    {
        public frmCourseConfiguration()
        {
            InitializeComponent();
        }

        private void frmCourseConfiguration_Load(object sender, EventArgs e)
        {
            this.refreshDepartments();
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
            this.refreshCurriculumCourseListToBePrioritised();

            this.refreshCurriulumPreRequisites();
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
            int _CurriculumID = 0;
            if (curriculumBindingSource.Count > 0) { _CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID; };
            this.populateCurriculumCourses(_CurriculumID);
        }
        private void refreshCurriculumCouresModules()
        {
            int _CurriculumCourseID = 0;
            if (curriculumCourseBindingSource.Count > 0) { _CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID; };
            this.populateCurriculumCourseModules(_CurriculumCourseID);
        }
        private void refreshCurriculumCouresModuleActivities()
        {
            int _CurriculumCourseID = 0;
            int _ModuleID = 0;
            if (moduleBindingSource.Count > 0)
            {
                _CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
                _ModuleID = ((Module)(moduleBindingSource.Current)).ModuleID;
            };
            this.populateCurriculumCouresModuleActivities(_CurriculumCourseID, _ModuleID);
        }
        private void refreshCurriculumCourseListToBePrioritised()
        {
            int _CurriculumID = 0;
            Boolean IsSquenced = false;
            if (curriculumCourseBindingSource.Count > 0)
            {
                _CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
                if (((Curriculum)(curriculumBindingSource.Current)).CurriculumIsSequenced)
                {
                    IsSquenced = true;
                }
            };
            if (IsSquenced)
            {
                this.populateCurriculumCourseListToBePrioritised(_CurriculumID);
            }
            else
            {
                this.populateCurriculumCourseListToBePrioritised(0);
            }

        }
        private void refreshCurriculumCourseSeta()
        {
            int _CurriculumCourseID = 0;
            if (curriculumCourseBindingSource.Count > 0)
            {
                _CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
            };
            this.populateCurriculumCourseSeta(_CurriculumCourseID);
        }

        private void refreshCurriculumCourseMinMaxAndCourseCode()
        {
            int _CurriculumCourseID = 0;
            if (curriculumCourseBindingSource.Count > 0)
            {
                _CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
            };
            this.populateCurriculumCourseMinMaxAndCourseCode(_CurriculumCourseID);
        }

        private void refreshCurriulumPreRequisites()
        {
            int _CurriculumID = 0;
            if (curriculumBindingSource.Count > 0) { _CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID; };
            this.populateCurriculumCourses(_CurriculumID);
            this.populateCurriulumPreRequisites(_CurriculumID);
        }
        #endregion

        #region Populate Methods

        private void populateDepartments()
        {
            using (var Dbconnection = new MCDEntities())
            {
                departmentBindingSource.DataSource = (from a in Dbconnection.LookupDepartments
                                                      orderby a.DepartmentName
                                                      select a).ToList<LookupDepartment>();
            };
        }
        private void populateDepartmentCurriculums(int _DepartmentID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumBindingSource.DataSource = (from a in Dbconnection.Curriculums
                                                      where a.DepartmentID == _DepartmentID &&
                                                      a.CurriculumName.Contains(this.txtCurriculumFilterCriteria.Text)
                                                      orderby a.CurriculumName
                                                      select a).ToList<Curriculum>();
            };

        }
        private void populateCurriculumCourses(int _CurriculumID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<CurriculumCourse> configuredCoures = (from a in Dbconnection.CurriculumCourses.Include("CurricullumCourseCode").Include("CurriculumCourseMinimumMaximum")
                                                           where a.CurriculumID == _CurriculumID
                                                           select a).ToList<CurriculumCourse>();
                curriculumCourseBindingSource.DataSource = (from a in configuredCoures
                                                            where a.Course.CourseName.ToLower().Contains(txtCurriculumCourseFilterCriteria.Text)
                                                            select a).ToList<CurriculumCourse>();
            };
        }

        private void populateCurriculumCourseModules(int _CurriculumCourseID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                moduleBindingSource.DataSource = (from a in Dbconnection.Modules
                                                  from b in a.CurriculumCourseModules
                                                  where b.CurriculumCourseID == _CurriculumCourseID
                                                  orderby a.ModuleName
                                                  select a).ToList<Module>();
            };
        }
        private void populateCurriculumCouresModuleActivities(int _CurriculumCourseID, int _ModuleID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                activityBindingSource.DataSource = (from a in Dbconnection.Activities
                                                    from b in a.CurriculumCourseModules
                                                    where b.ModuleID == _ModuleID && b.CurriculumCourseID == _CurriculumCourseID
                                                    select a).ToList<Activity>();
            };
        }
        private void populateCurriculumCourseSeta(int _CurriculumCourseID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                setaBindingSource.DataSource = (from a in Dbconnection.LookupSetas
                                                from b in a.CurriculumCourses
                                                where b.CurriculumCourseID == _CurriculumCourseID
                                                select a).ToList<LookupSeta>();
            };

        }
        private void populateCurriculumCourseMinMaxAndCourseCode(int _CurriculumCourseID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurricullumCourseCode curCourseCourseCodeObj = (from a in Dbconnection.CurricullumCourseCodes
                                                                where a.CurriculumCourseID == _CurriculumCourseID
                                                                select a).FirstOrDefault<CurricullumCourseCode>();

                CurriculumCourseMinimumMaximum minmaxObj = (from a in Dbconnection.CurriculumCourseMinimumMaximums
                                                            where a.CurriculumCourseID == _CurriculumCourseID
                                                            select a).FirstOrDefault<CurriculumCourseMinimumMaximum>();

                //if (curCourseCourseCodeObj != null)
                //{
                //    txtCurriculumCourseCode.Text = curCourseCourseCodeObj.CurricullumCourseUSID;
                //}
                //else
                //{
                //    txtCurriculumCourseCode.Text = "";
                //}
                //if (minmaxObj != null)
                //{
                //    nudMaximumAllowed.Value = minmaxObj.CurriculumCourseMaximum;
                //    nudMinimumAllowed.Value = minmaxObj.CurriculumCourseMinimum;
                //}
                //else
                //{
                //    nudMaximumAllowed.Value = 0;
                //    nudMinimumAllowed.Value = 0;
                //}

            };
        }

        private void populateCurriculumCourseListToBePrioritised(int _CurriculumID)
        {
            curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Clear();
            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseBindingSourceForCourseRequiredToBeScheduled.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                                          where a.CurriculumID == _CurriculumID
                                                                                          select a).ToList<CurriculumCourse>();
            };
        }

        private void populateCurriulumPreRequisites(int _CurriculumID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                //CoursePreRequisitesBindingSource.DataSource = (from a in Dbconnection.CurriculumPrequisiteCourses
                //                                               .Include("Curriculum.LookupDepartment")
                //                                               where a.CurriculumID == _CurriculumID
                //                                               select a).ToList<CurriculumPrequisiteCourse>();

                CoursePreRequisitesBindingSource.DataSource = (from a in Dbconnection.CurriculumPrequisiteCourses
                                                               .Include("Curriculum.LookupDepartment")
                                               .Include("CurriculumCourse")
                                               .Include("CurriculumCourse.Curriculum")
                                               .Include("CurriculumCourse.Course")
                                               .Include("Curriculum")
                                                               where a.CurriculumID == _CurriculumID
                                                               select a).ToList<CurriculumPrequisiteCourse>();
            };
        }
        #endregion

        #region Departments Methods

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddDepartment frm = new frmAddDepartment();
            frm.ShowDialog();
            this.refreshDepartments();
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseListToBePrioritised();
        }

        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
            this.refreshCurriculumCourseListToBePrioritised();
            this.refreshCurriulumPreRequisites();
        }

        #endregion 

        #region Curriculum Control Methods

        private void dgvCurriculum_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumObj = (Curriculum)(row.DataBoundItem);
                    var CostingModelObj = CurriculumObj.CostingModel;

                    row.Cells[CostingModelName.Index].Value = CostingModelObj.CostingModelName.ToString();
                }
            }
        }


        private void btnAddCurriculum_Click(object sender, EventArgs e)
        {

            frmAddCurriculum frm = new frmAddCurriculum();
            frm.DepartmentID = Convert.ToInt32(this.cboDepartments.SelectedValue);
            frm.IsUpdating = false;
            frm.ShowDialog();

            //Keeps the curremtSelect 
            if (curriculumBindingSource.Count > 0)
            {
                int _CurrentIndex = 0;
                int _CurrentCurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
                this.refreshDepartmentCurriculums();
                foreach (Curriculum cur in curriculumBindingSource.List)
                {
                    if (cur.CurriculumID == _CurrentCurriculumID)
                    {
                        curriculumBindingSource.Position = _CurrentIndex;
                        break;
                    }
                    _CurrentIndex++;
                }
            }
            else
            {
                this.refreshDepartmentCurriculums();
            }


        }
        private void btnFilterCurriculum_Click(object sender, EventArgs e)
        {
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
            this.refreshCurriculumCourseListToBePrioritised();
        }
        private void tsbtnRefreshCourseSearch_Click(object sender, EventArgs e)
        {
            this.resetCurriculumSearchCriteria();
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
            this.refreshCurriculumCourseListToBePrioritised();
        }
        private void resetCurriculumSearchCriteria()
        {
            this.txtCurriculumFilterCriteria.Text = "";
        }
        private void curriculumBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
            this.refreshCurriculumCourseListToBePrioritised();
            //this.refreshCurriculumCourseListToBePrioritised();
            this.refreshCurriulumPreRequisites();
            tabControlCourseProperties.SelectedIndex = 0;
        }
        #endregion

        #region Curriculum Course Methods
        private void btnRemoveCurriculumCourse_Click(object sender, EventArgs e)
        {
            DialogResult resl = MessageBox.Show("Note This Will remove the course and all assosiated Modules and Activities!", "Remove Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resl == DialogResult.Yes)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    CurriculumCourse CurriculumCourseObj = (CurriculumCourse)(this.curriculumCourseBindingSource.Current);
                    Dbconnection.CurriculumCourses.Attach(CurriculumCourseObj);
                    Dbconnection.CurriculumCourses.Remove(CurriculumCourseObj);
                    Dbconnection.SaveChanges();
                    this.refreshCurriculumCourses();
                    this.refreshCurriculumCourseListToBePrioritised();
                    //this.refreshCurriculumCourseListToBePrioritised();
                };
            }
        }
        private void curriculumCourseBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
        }
        private void btnFilterCurriculumCourse_Click(object sender, EventArgs e)
        {
            this.refreshCurriculumCourses();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
        }

        private void btnClearCurriculumCourseFilter_Click(object sender, EventArgs e)
        {
            this.resetCurriculumCourseSearchCriteria();
            this.refreshCurriculumCouresModules();
            this.refreshCurriculumCouresModuleActivities();
            this.refreshCurriculumCourseSeta();
            this.refreshCurriculumCourseMinMaxAndCourseCode();
        }
        private void resetCurriculumCourseSearchCriteria()
        {
            this.txtCurriculumCourseFilterCriteria.Clear();
            this.refreshCurriculumCourses();
        }
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
                    var DepartmentObj = (LookupDepartment)CourseObj.LookupDepartment;

                    row.Cells[CourseName.Index].Value = CourseObj.CourseName.ToString();
                    row.Cells[DepartmentName.Index].Value = DepartmentObj.DepartmentName.ToString();

                    row.Cells[EnrollmentType.Index].Value = EnrollmentTypeObj.EnrollmentType.ToString();
                    row.Cells[CurriculumName.Index].Value = DepartmentCurriculumObj.CurriculumName.ToString();
                    row.Cells[CourseCodeValue.Index].Value = CurriculumCourseObj.CurricullumCourseCode.CurricullumCourseCodeValue.ToString();
                    row.Cells[CurriculumCourseMaximumValue.Index].Value = CurriculumCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMaximum.ToString();
                    row.Cells[CurriculumCourseMinimumValue.Index].Value = CurriculumCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMinimum.ToString();

                }
            }
        }

        private void btnAddCurriculumCourse_Click(object sender, EventArgs e)
        {
            frmAddCurriculumCourse frm = new frmAddCurriculumCourse();
            if (curriculumBindingSource.Count > 0)
            {
                frm.CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
                frm.DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);
                frm.ShowDialog();
                this.refreshCurriculumCourses();
                this.refreshCurriculumCourseListToBePrioritised();
                if (curriculumCourseBindingSource.Count < 0)
                {
                    int _CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;

                    // this.refreshCurriculumCourseListToBePrioritised();
                    if (curriculumCourseBindingSource.Count < 0)
                    {
                        int _CurrentID = 0;
                        foreach (CurriculumCourse cur in curriculumCourseBindingSource.List)
                        {
                            if (cur.CurriculumCourseID == _CurriculumCourseID)
                            {
                                curriculumCourseBindingSource.Position = _CurrentID;
                            }
                            _CurrentID++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Add Curriculum First!", "Add Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnViewCurriculumSummary_Click(object sender, EventArgs e)
        {
            frmCurriculumCourseSummary frm = new frmCurriculumCourseSummary();
            frm.CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
            frm.CurriculumName = ((Curriculum)(curriculumBindingSource.Current)).CurriculumName;
            frm.ShowDialog();
        }
        private void btnUpdateCurriculumCourseOptions_Click(object sender, EventArgs e)
        {
            if (curriculumCourseBindingSource.Count > 0)
            {
                CurriculumCourse CurrentSelectedCourse = ((CurriculumCourse)(curriculumCourseBindingSource.Current));
                frmUpdateCurriculumCourse frm = new frmUpdateCurriculumCourse();
                frm.CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;

                frm.txtCourseCost.Text = CurrentSelectedCourse.Cost.ToString();
                frm.nudCourseDuration.Value = CurrentSelectedCourse.Duration;
                frm.nudCourseMaximumAllowed.Value = CurrentSelectedCourse.CurriculumCourseMinimumMaximum.CurriculumCourseMaximum;
                frm.nudCourseMinimumAllowed.Value = CurrentSelectedCourse.CurriculumCourseMinimumMaximum.CurriculumCourseMinimum;
                frm.txtCourseCourseCode.Text = CurrentSelectedCourse.CurricullumCourseCode.CurricullumCourseCodeValue;
                frm.ShowDialog();
                this.refreshCurriculumCourses();
            }
            else
            {
                MessageBox.Show("Add Course First!", "Add Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Modules Methods
        private void btnAddModules_Click(object sender, EventArgs e)
        {
            frmAddModules frm = new frmAddModules();
            if (curriculumCourseBindingSource.Count > 0)
            {
                frm.CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
                frm.DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);
                frm.ShowDialog();
                this.refreshCurriculumCouresModules();
                this.refreshCurriculumCouresModuleActivities();
            }
            else
            {
                MessageBox.Show("Add Course First!", "Add Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void moduleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshCurriculumCouresModuleActivities();
        }


        #endregion

        #region Actvities Methods

        private void dgvCourseDatabaseModulesActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ActivitiesmObj = (Activity)(row.DataBoundItem);
                    var ModuleObj = ActivitiesmObj.Module;

                    row.Cells[ModuleName.Index].Value = ModuleObj.ModuleName.ToString();
                }
            }
        }

        private void btnAddModuleActivity_Click(object sender, EventArgs e)
        {
            frmAddModuleActivities frm = new frmAddModuleActivities();
            if (moduleBindingSource.Count > 0)
            {
                frm.ModuleID = ((Module)(moduleBindingSource.Current)).ModuleID;
                frm.CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
                frm.ShowDialog();
                this.refreshCurriculumCouresModuleActivities();

            }
            else
            {
                MessageBox.Show("Link Module First!", "Add Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        #endregion

        #region SETA Methods
        private void btnAddCourseAccosiatedSeta_Click(object sender, EventArgs e)
        {

            frmAddTrainingDepartmentCourseSeta frm = new frmAddTrainingDepartmentCourseSeta();
            frm.CurriculumCourseID = ((CurriculumCourse)(curriculumCourseBindingSource.Current)).CurriculumCourseID;
            frm.ShowDialog();

            refreshCurriculumCourseSeta();
        }
        #endregion

        #region Form Methods
        private void dgvModules_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvModuleActivities_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvCurrriculumCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvCurriculum_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }


        #endregion



        private void btnUpdateCurriculum_Click(object sender, EventArgs e)
        {
            frmAddCurriculum frm = new frmAddCurriculum();
            frm.DepartmentID = Convert.ToInt32(this.cboDepartments.SelectedValue);
            Curriculum CurriculumObj = ((Curriculum)(curriculumBindingSource.Current));

            frm.CurriculumName = CurriculumObj.CurriculumName;
            frm.CurriculumID = CurriculumObj.CurriculumID;
            frm.CostingModelID = CurriculumObj.CostingModelID;
            frm.IsSquenced = CurriculumObj.CurriculumIsSequenced;
            frm.IsUpdating = true;
            frm.ShowDialog();
            this.refreshDepartmentCurriculums();
            this.refreshCurriculumCourseListToBePrioritised();
        }

        private void btnHideShowCurriculumSelection_Click(object sender, EventArgs e)
        {

            if (splitContainerMain.Panel1Collapsed)
            {
                splitContainerMain.Panel1Collapsed = false;
            }
            else
            {
                splitContainerMain.Panel1Collapsed = true;
            }

        }

        private void curriculumCourseBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void dgvPrerequestiteCoursesAllCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                    var DepartmentObj = (LookupDepartment)CourseObj.LookupDepartment;

                    row.Cells[CourseNameToPosition.Index].Value = CourseObj.CourseName.ToString();
                    row.Cells[Department.Index].Value = DepartmentObj.DepartmentName.ToString();
                    row.Cells[Curriculum.Index].Value = DepartmentCurriculumObj.CurriculumName.ToString();

                }
            }
        }

        private void btnEditCoursePreRequisites_Click(object sender, EventArgs e)
        {
            frmAddPreRequisteCourses frm = new frmAddPreRequisteCourses();
            frm.SelectedCurriculumID = ((Data.Models.Curriculum)curriculumBindingSource.Current).CurriculumID;
            frm.ShowDialog();
            refreshCurriulumPreRequisites();

        }

        private void dgvCoursePreRequisites_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumPrequisiteCourseObj = (CurriculumPrequisiteCourse)(row.DataBoundItem);

                    row.Cells[colCuriculumPrerequisiteDepartment.Index].Value = CurriculumPrequisiteCourseObj.Curriculum.LookupDepartment.DepartmentName.ToString();
                    row.Cells[colCuriculumPrerequisiteCourseName.Index].Value = CurriculumPrequisiteCourseObj.CurriculumCourse.Course.CourseName.ToString();
                    row.Cells[colCuriculumPrerequisiteCurriculum.Index].Value = CurriculumPrequisiteCourseObj.CurriculumCourse.Curriculum.CurriculumName;

                }
            }
        }

        private void dgvCoursePreRequisites_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void curriculumCourseBindingSourceForCourseRequiredToBeScheduled_PositionChanged(object sender, EventArgs e)
        {
            this.refreshCurriculumCourseListOfAvaiableCourseToPrioritise();
            this.refreshCurriculumCourseListOfPrioritisedCourses();
        }

        private void refreshCurriculumCourseListOfAvaiableCourseToPrioritise()
        {
            int _CurriculumID = 0;
            int _CurriculumCourseID = -1;
            if (curriculumCourseBindingSource.Count > 0 && curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Count > 0)
            {
                _CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
                _CurriculumCourseID = ((CurriculumCourse)curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Current).CurriculumCourseID;
            };
            this.populateCurriculumCourseListOfAvaiableCourseToPrioritise(_CurriculumID, _CurriculumCourseID);
        }
        private void refreshCurriculumCourseListOfPrioritisedCourses()
        {
            int _CurriculumID = 0;
            int _CurriculumCourseParentID = 0;
            if (curriculumCourseBindingSource.Count > 0 && curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Count > 0)
            {
                _CurriculumID = ((Curriculum)(curriculumBindingSource.Current)).CurriculumID;
                _CurriculumCourseParentID = ((CurriculumCourse)curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Current).CurriculumCourseParentID;
            };
            populateCurriculumCourseListOfPrioritisedCourses(_CurriculumID, _CurriculumCourseParentID);
        }
        private void populateCurriculumCourseListOfAvaiableCourseToPrioritise(int _CurriculumID, int _CurriculumCourseID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseBindingSourceForPredessesorSelection.DataSource =
                    (from a in Dbconnection.CurriculumCourses
                     where a.CurriculumID == _CurriculumID
                     && a.CurriculumCourseID != _CurriculumCourseID
                     && a.CurriculumCourseParentID != _CurriculumCourseID
                     select a).ToList<CurriculumCourse>();
            };
        }
        private void populateCurriculumCourseListOfPrioritisedCourses(int _CurriculumID, int _CurriculumCourseParentID)
        {
            //curriculumCourseBindingSourceForPredessesorSelection

            using (var Dbconnection = new MCDEntities())
            {
                curriculumCourseBindingSourceForPredessesorSelected.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                                  where a.CurriculumID == _CurriculumID && a.CurriculumCourseID == _CurriculumCourseParentID
                                                                                  select a.Course).ToList<Course>();

            };

        }

        private void btnResetAllCourseSequencing_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                int _CurriculumID = 0;
                if (curriculumBindingSource.Count > 0)
                {
                    _CurriculumID = ((Curriculum)curriculumBindingSource.Current).CurriculumID;
                }
                List<CurriculumCourse> lstCurr = (from a in Dbconnection.CurriculumCourses
                                                  where a.CurriculumID == _CurriculumID
                                                  select a).ToList<CurriculumCourse>();
                foreach (CurriculumCourse a in lstCurr)
                {
                    a.CurriculumCourseParentID = 0;
                }

                Dbconnection.SaveChanges();
            };
            this.refreshCurriculumCourseListToBePrioritised();
            this.refreshCurriculumCourseListOfAvaiableCourseToPrioritise();
            this.refreshCurriculumCourseListOfPrioritisedCourses();
        }

        private void tbnRemoveCurriculumCourseParent_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                CurriculumCourse CurrCourse = (from a in Dbconnection.CurriculumCourses
                                               where a.CurriculumCourseID == 0
                                               select a).FirstOrDefault<CurriculumCourse>();
                CurrCourse.CurriculumCourseParentID = 0;
                Dbconnection.SaveChanges();
            };
            this.refreshCurriculumCourseListToBePrioritised();
            this.refreshCurriculumCourseListOfAvaiableCourseToPrioritise();
            this.refreshCurriculumCourseListOfPrioritisedCourses();
        }
        private void AddCurriculumCoursePreRequesiteCourse(int _CurrCourseParentID, int _CurrCourseChildID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurriculumCourse currCourseObj = (from a in Dbconnection.CurriculumCourses
                                                  where a.CurriculumCourseID == _CurrCourseChildID
                                                  select a).FirstOrDefault<CurriculumCourse>();

                currCourseObj.CurriculumCourseParentID = _CurrCourseParentID;
                Dbconnection.Entry(currCourseObj).State = System.Data.Entity.EntityState.Modified;
                Dbconnection.SaveChanges();

            };
        }

        private void dgvPrerequestiteCoursesForSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                CurriculumCourse CurrCourseParentObject = ((CurriculumCourse)curriculumCourseBindingSourceForPredessesorSelection.List[e.RowIndex]);
                CurriculumCourse CurrCourseChildObject = ((CurriculumCourse)curriculumCourseBindingSourceForCourseRequiredToBeScheduled.Current);

                this.AddCurriculumCoursePreRequesiteCourse(CurrCourseParentObject.CurriculumCourseID, CurrCourseChildObject.CurriculumCourseID);
                this.refreshCurriculumCourses();
                this.refreshCurriculumCourseListToBePrioritised();
                this.refreshCurriculumCourseListOfAvaiableCourseToPrioritise();
                this.refreshCurriculumCourseListOfPrioritisedCourses();
            }
        }

        private void dgvPrerequestiteCoursesForSelection_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                    var DepartmentObj = (LookupDepartment)CourseObj.LookupDepartment;

                    row.Cells[CourseForSelection.Index].Value = CourseObj.CourseName.ToString();
                    row.Cells[DepartmentForSelection.Index].Value = DepartmentObj.DepartmentName.ToString();
                    row.Cells[SelectItemForSelection.Index].Value = "Set";

                    //row.Cells[EnrollmentType.Index].Value = EnrollmentTypeObj.EnrollmentType.ToString();
                    row.Cells[CurriculumForSelection.Index].Value = DepartmentCurriculumObj.CurriculumName.ToString();
                    //row.Cells[CourseCodeValue.Index].Value = CurriculumCourseObj.CurricullumCourseCode.CurricullumCourseCodeValue.ToString();
                    // row.Cells[CurriculumCourseMaximumValue.Index].Value = CurriculumCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMaximum.ToString();
                    // row.Cells[CurriculumCourseMinimumValue.Index].Value = CurriculumCourseObj.CurriculumCourseMinimumMaximum.CurriculumCourseMinimum.ToString();

                }
            }
        }

        private void dgvPrerequestiteCoursesAllCourses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvPrerequestiteCoursesForSelection_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvCourseDatabaseSetaAcceditations_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvModules_DataMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
