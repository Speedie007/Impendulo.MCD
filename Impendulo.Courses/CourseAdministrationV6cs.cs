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
    public partial class CourseAdministrationV6cs : Form
    {
        MCDEntities DbConnection;
        public CourseAdministrationV6cs()
        {
            InitializeComponent();
        }

        private void CourseAdministrationV6cs_Load(object sender, EventArgs e)
        {
            DbConnection = new MCDEntities();
            this.loadupAllItems();
        }

        #region "MCD Courses"


        #endregion



        #region "Course Database"


        #endregion

        #region "Loadup Items"
        private void loadupAllItems()
        {
            this.populateDepartments();
            this.populateTrainingDepartments(Convert.ToInt32(lstMCDCoursesDepartments.SelectedValue));
            this.populateTrainingDepartmentCourses(Convert.ToInt32(lstMCDCoursesTrainingDepartments.SelectedValue));
            this.populateMCDCoursesTRainingDepartmentCoursesCompositions(Convert.ToInt32(this.lstMCDCoursesTrainingDepartmentCourses.SelectedValue));
        }

        #endregion


        #region "Populate MCD Courses Items"

        private void populateDepartments()
        {

            BindingSourceMCDCoursesDepartments.DataSource = (from d in DbConnection.LookupDepartments
                                                             select d).ToList<LookupDepartment>();

        }
        private void populateTrainingDepartments(int _DepartmentID)
        {

            //this.BindingSourceMCDCoursesTrainingDepartments.DataSource =
            //    (from d in DbConnection.TrainingDepartments
            //     where d.DepartmentID == _DepartmentID
            //     select d).ToList<TrainingDepartment>();
        }
        private void populateTrainingDepartmentCourses(int _TrainingDepartmentID)
        {

            //this.BindingSourceMCDCoursesTrainingDepartmentCourses.DataSource =
            //    (from d in DbConnection.TrainingDepartmentCourses
            //     where d.TrainingDepartmentID == _TrainingDepartmentID
            //     select d).ToList<TrainingDepartmentCourse>();



        }

        private void populateMCDCoursesTRainingDepartmentCoursesCompositions(int _TrainingDepartmentCourseID)
        {

            //this.BindingSourceMCDCoursesTrainingDepartmentCourseComposition.DataSource = (from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas
            //                                                                              from b in a.TrainingDepartmentCourseListings
            //                                                                              where b.TrainingDepartmentCourseID == _TrainingDepartmentCourseID
            //                                                                              orderby a.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName
            //                                                                              select a).ToList<TrainingDepartmentCourseEnrollmentTypeMetaData>();

        }
        #endregion

        #region "Adding Items"

        private void tsbtnMCDCoursesAddDepartment_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "Selected Index Changed"
        private void lstMCDCoursesDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _DepartmentID = 0;
            if (lstMCDCoursesDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(lstMCDCoursesDepartments.SelectedValue); }
            this.populateTrainingDepartments(_DepartmentID);

            int _TrainingDepartmentID = 0;
            if (lstMCDCoursesTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(lstMCDCoursesTrainingDepartments.SelectedValue); }
            this.populateTrainingDepartmentCourses(_TrainingDepartmentID);

            int _TrainingDepartmentCourseID = 0;
            if (lstMCDCoursesTrainingDepartmentCourses.SelectedValue != null) { _TrainingDepartmentCourseID = Convert.ToInt32(lstMCDCoursesTrainingDepartmentCourses.SelectedValue); }
            this.populateMCDCoursesTRainingDepartmentCoursesCompositions(_TrainingDepartmentCourseID);

            //int _DepartmentID = 0;
            // if (lstMCDCoursesDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(lstMCDCoursesDepartments.SelectedValue); }
            //this.populateTrainingDepartments(_DepartmentID);
        }

        private void lstCourseSetupTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _TrainingDepartmentID = 0;

            if (lstMCDCoursesTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(lstMCDCoursesTrainingDepartments.SelectedValue); }
            //toolStripLabel2.Text = "test";

            this.populateTrainingDepartmentCourses(_TrainingDepartmentID);

            int _TrainingDepartmentCourseID = 0;
            if (lstMCDCoursesTrainingDepartmentCourses.SelectedValue != null) { _TrainingDepartmentCourseID = Convert.ToInt32(lstMCDCoursesTrainingDepartmentCourses.SelectedValue); }
            this.populateMCDCoursesTRainingDepartmentCoursesCompositions(_TrainingDepartmentCourseID);

            // MessageBox.Show(BindingNavigatorMCDCourseTrainingDepartmentCourses.CountItem.Text);
        }

        #endregion



        #region "Populate Course Database Items"
        private void populateCourseDatabaseDepartments()
        {
            BindingSourceCourseDatabaseDepartments.DataSource = DbConnection.LookupDepartments.ToList<LookupDepartment>();
        }
        private void populateCourseDatabaseTrainingDepartments(int _DepartmentID)
        {
            //BindingSourceCourseDatabaseTrainingDepartment.DataSource = (from a in DbConnection.TrainingDepartments
            //                                                            where a.DepartmentID == _DepartmentID
            //                                                            select a).ToList<TrainingDepartment>();
        }
        private void populateCourseDatabaseTrainingDepartmentCourseMetaData(int _TrainingDepartmentID)
        {
            //BindingSourceCourseDatabaseTrainingDepartmentCoursesMetaData.DataSource = (from a in DbConnection.TrainingDepartmentCourseMetaDatas
            //                                                                           where a.TrainingDepartmentID == _TrainingDepartmentID
            //                                                                           select a).ToList<TrainingDepartmentCourseMetaData>();
        }
        private void populateCourseDatabaseTrainingDepartmentCourseSetas(int _TrainingDepartmentCourseMetaDataID)
        {
            //BindingSourceCourseDatabaseTrainingDepartmentCoursesMetaDataSetaAccreditions.DataSource =
            //    (from a in DbConnection.TrainingDepartmentCourseMetaDatas
            //     from b in a.Setas
            //     where a.TrainingDepartmentCourseMetaDataID == _TrainingDepartmentCourseMetaDataID
            //     select b).ToList<Seta>();
        }
        private void populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(int _TrainingDepartmentCourseMetaDataID)
        {
            //BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.DataSource =
            //    (from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas
            //     where a.TrainingDepartmentCourseMetaDataID == _TrainingDepartmentCourseMetaDataID
            //     select a).ToList<TrainingDepartmentCourseEnrollmentTypeMetaData>();
        }
        private void populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(int _TrainingDepartmentCourseEnrolmentTypeMetaDataID)
        {
            //BindingSourceCourseDatabaseModules.DataSource =
            //    (from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeModules
            //     where a.TrainingDepartmentCourseEnrollmentTypeMetaDataID == _TrainingDepartmentCourseEnrolmentTypeMetaDataID
            //     select a.Module).ToList<Module>();
        }
        private void populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(int _TrainingDepartmentCourseEnrolmentTypeMetaDataID, int _ModuleID)
        {
            //BindingSourceCourseDatabaseActivities.DataSource =
            //        (from a in DbConnection.Activities
            //         from b in a.TrainingDepartmentCourseEnrollmentTypeModules
            //         where b.ModuleID == _ModuleID && b.TrainingDepartmentCourseEnrollmentTypeMetaDataID == _TrainingDepartmentCourseEnrolmentTypeMetaDataID
            //         select a)
            //         .ToList<Activity>();
        }
        #endregion
        private void loadupAllCourseDatabaseItems()
        {
            this.BindingSourceCourseDatabaseDepartments.Clear();
            this.populateCourseDatabaseDepartments();

            int _DepartmentID = 0;
            int _TrainingDepartmentID = 0;
            int _TrainingDepartmentCoursesMetaDataID = 0;
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;

            if (cboCourseDatabaseDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboCourseDatabaseDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartments(_DepartmentID);

            if (cboCourseDatabaseTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseMetaData(_TrainingDepartmentID);

            if (lstCourseDatabaseTrainingDepartmentCoures.SelectedValue != null) { _TrainingDepartmentCoursesMetaDataID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseSetas(_TrainingDepartmentCoursesMetaDataID);
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(_TrainingDepartmentCoursesMetaDataID);

            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(_TrainingDepartmentCourseEnrolmentTypeMetaDataID);

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);

        }
        private void loadupAllCourseDatabaseTrainingDepartmentItems()
        {

            int _DepartmentID = 0;
            int _TrainingDepartmentID = 0;

            if (cboCourseDatabaseDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboCourseDatabaseDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartments(_DepartmentID);

            if (cboCourseDatabaseTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseMetaData(_TrainingDepartmentID);
        }
        private void tabControlCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlCourses.SelectedIndex)
            {
                case 0:
                    //Console.WriteLine("Case 1");
                    break;
                case 1:
                    this.loadupAllCourseDatabaseItems();
                    break;
                default:
                    //Console.WriteLine("Default case");
                    break;
            }
        }
        #region "Course Database Selected Index Changed"
        private void cboCourseDatabaseDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _DepartmentID = 0;
            int _TrainingDepartmentID = 0;
            int _TrainingDepartmentCoursesMetaDataID = 0;
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;

            if (cboCourseDatabaseDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboCourseDatabaseDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartments(Convert.ToInt32(cboCourseDatabaseDepartments.SelectedValue));

            if (cboCourseDatabaseTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseMetaData(_TrainingDepartmentID);

            if (lstCourseDatabaseTrainingDepartmentCoures.SelectedValue != null) { _TrainingDepartmentCoursesMetaDataID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseSetas(_TrainingDepartmentCoursesMetaDataID);
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(_TrainingDepartmentCoursesMetaDataID);

            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(_TrainingDepartmentCourseEnrolmentTypeMetaDataID);

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);


        }
        private void cboCourseDatabaseTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

            int _TrainingDepartmentID = 0;
            int _TrainingDepartmentCoursesMetaDataID = 0;
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;

            if (cboCourseDatabaseTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseMetaData(_TrainingDepartmentID);

            if (lstCourseDatabaseTrainingDepartmentCoures.SelectedValue != null) { _TrainingDepartmentCoursesMetaDataID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseSetas(_TrainingDepartmentCoursesMetaDataID);
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(_TrainingDepartmentCoursesMetaDataID);

            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(_TrainingDepartmentCourseEnrolmentTypeMetaDataID);

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);

        }

        private void lstCourseDatabaseTrainingDepartmentCoures_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _TrainingDepartmentCoursesMetaDataID = 0;
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;

            if (lstCourseDatabaseTrainingDepartmentCoures.SelectedValue != null) { _TrainingDepartmentCoursesMetaDataID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue); }
            this.populateCourseDatabaseTrainingDepartmentCourseSetas(_TrainingDepartmentCoursesMetaDataID);
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(_TrainingDepartmentCoursesMetaDataID);

            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(_TrainingDepartmentCourseEnrolmentTypeMetaDataID);

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);
        }
        #endregion

        private void btnCourseDatabaseAddNewDepartment_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.CourseDatabase.frmAddDepartment frm = new Impendulo.Courses.Add.CourseDatabase.frmAddDepartment();
            frm.ShowDialog();
            this.loadupAllCourseDatabaseItems();

        }

        private void btnAddTrainingDepartments_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartment frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartment();
            frm.DepartmentID = Convert.ToInt32(cboCourseDatabaseDepartments.SelectedValue);
            frm.ShowDialog();
            this.loadupAllCourseDatabaseTrainingDepartmentItems();
        }

        private void tsbtnCourseDatabaseAddCourse_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourse frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourse();
            frm.TrainingDepartmentID = Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue);
            frm.ShowDialog();
            this.populateCourseDatabaseTrainingDepartmentCourseMetaData(Convert.ToInt32(cboCourseDatabaseTrainingDepartments.SelectedValue));
        }

        private void dgvCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    //var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);
                    //var LET = TDCETMD.LookupEnrollmentType;

                    //row.Cells[Enrollment.Index].Value = LET.EnrollmentType;
                }
            }
        }

        private void dgvCourseDatabaseTrainingDepartmentEnrollmentTypeModules_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgvCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData_SelectionChanged(object sender, EventArgs e)
        {
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;


            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(_TrainingDepartmentCourseEnrolmentTypeMetaDataID);

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);
        }

        private void dgvCourseDatabaseTrainingDepartmentEnrollmentTypeModules_SelectionChanged(object sender, EventArgs e)
        {
            int _TrainingDepartmentCourseEnrolmentTypeMetaDataID = 0;
            int _ModuleID = 0;


            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                //var obj = (TrainingDepartmentCourseEnrollmentTypeMetaData)BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current;
                //_TrainingDepartmentCourseEnrolmentTypeMetaDataID = obj.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            }

            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                var obj = (Module)BindingSourceCourseDatabaseModules.Current;
                _ModuleID = obj.ModuleID;
            }
            populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(_TrainingDepartmentCourseEnrolmentTypeMetaDataID, _ModuleID);
        }

        private void tsbtnCourseDatabaseAddCourseMetaData_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue);
            Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCoursesEnrollmentTypeMetaData();
            frm.TrainingDepartmentCourseMetaDataID = ID;
            frm.ShowDialog();
            this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData(ID);
        }

        private void BindingSourceCourseDatabaseTrainingDepartmentCoursesMetaData_DataSourceChanged(object sender, EventArgs e)
        {
            //checks to see if there are any coursess loaded
            if (this.BindingSourceCourseDatabaseTrainingDepartmentCoursesMetaData.Count > 0)
            {
                //enable the add button for the Course meta data
                tsbtnCourseDatabaseAddCourseMetaData.Enabled = true;
                tsbtnCourseDatabaseAddSetaAcceditiations.Enabled = true;

            }
            else
            {
                //disable the add button for the Course meta data
                tsbtnCourseDatabaseAddCourseMetaData.Enabled = false;
                tsbtnCourseDatabaseAddSetaAcceditiations.Enabled = false;
            }
        }

        private void dgvCourseDatabaseSetaAcceditations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData_DataSourceChanged(object sender, EventArgs e)
        {

            if (BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Count > 0)
            {
                tsbtnCourseDatabaseAddCourseModules.Enabled = true;
            }
            else
            {
                tsbtnCourseDatabaseAddCourseModules.Enabled = false;
            }
        }

        private void BindingSourceCourseDatabaseModules_DataSourceChanged(object sender, EventArgs e)
        {
            if (BindingSourceCourseDatabaseModules.Count > 0)
            {
                tsbtnCourseDatabaseAddCourseModuleActivities.Enabled = true;
            }
            else
            {
                tsbtnCourseDatabaseAddCourseModuleActivities.Enabled = false;
            }
        }

        private void tsbtnCourseDatabaseAddCourseModules_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseEnrollmentTypeModules frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseEnrollmentTypeModules();
            //TrainingDepartmentCourseEnrollmentTypeMetaData a = (TrainingDepartmentCourseEnrollmentTypeMetaData)(BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current);
            //frm.TrainingDepartmentCourseEnrollmentTypeMetaDataID = a.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            frm.ShowDialog();
            //this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeModules(a.TrainingDepartmentCourseEnrollmentTypeMetaDataID);

        }

        private void tsbtnCourseDatabaseAddCourseModuleActivities_Click(object sender, EventArgs e)
        {
            //Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseEnrollmentTypeModuleActivities frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseEnrollmentTypeModuleActivities();
            //TrainingDepartmentCourseEnrollmentTypeMetaData a = (TrainingDepartmentCourseEnrollmentTypeMetaData)(BindingSourceCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData.Current);
            //Module obj = (Module)BindingSourceCourseDatabaseModules.Current;
            //frm.TrainingDepartmentCourseEnrollmentTypeMetaDataID = a.TrainingDepartmentCourseEnrollmentTypeMetaDataID;
            //frm.ModuleID = obj.ModuleID;
            //frm.Text = obj.ModuleName + " - " + frm.Text;
            //frm.ShowDialog();
            //this.populateCourseDatabaseTrainingDepartmentCourseEnrollmentTypeActivities(a.TrainingDepartmentCourseEnrollmentTypeMetaDataID, obj.ModuleID);
        }

        private void tsbtnCourseDatabaseAddSetaAcceditiations_Click(object sender, EventArgs e)
        {
            //Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseSeta frm = new Impendulo.Courses.Add.CourseDatabase.frmAddTrainingDepartmentCourseSeta();
            //frm.TrainingDepartmentCourseMetaDataID = Convert.ToInt32(lstCourseDatabaseTrainingDepartmentCoures.SelectedValue);
            //frm.ShowDialog();
            //this.populateCourseDatabaseTrainingDepartmentCourseSetas(frm.TrainingDepartmentCourseMetaDataID);
        }

        private void tsbtnMCDCoursesLinkCoures_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.MCDCourses.frmLinkCourses frm = new Impendulo.Courses.Add.MCDCourses.frmLinkCourses();
            frm.DepartmentID = Convert.ToInt32(this.lstMCDCoursesDepartments.SelectedValue);
            frm.TrainingDepartmentID = Convert.ToInt32(this.lstMCDCoursesTrainingDepartments.SelectedValue);
            frm.TrainingDepartmentCourseID = Convert.ToInt32(this.lstMCDCoursesTrainingDepartmentCourses.SelectedValue);
            frm.ShowDialog();
            this.populateMCDCoursesTRainingDepartmentCoursesCompositions(frm.TrainingDepartmentCourseID);
        }

        private void tsbtnMCDCourseAddCourse_Click(object sender, EventArgs e)
        {
            Impendulo.Courses.Add.MCDCourses.frmAddTrainingDepartmentCourses frm = new Impendulo.Courses.Add.MCDCourses.frmAddTrainingDepartmentCourses();
            frm.TrainingDepartmentID = Convert.ToInt32(this.lstMCDCoursesTrainingDepartments.SelectedValue);
            frm.ShowDialog();
            int _TrainingDepartmentID = 0;
            if (lstMCDCoursesTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(lstMCDCoursesTrainingDepartments.SelectedValue); }
            this.populateTrainingDepartmentCourses(_TrainingDepartmentID);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void lstMCDCoursesTrainingDepartmentCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _TrainingDepartmentCourseID = 0;
            if (lstMCDCoursesTrainingDepartmentCourses.SelectedValue != null) { _TrainingDepartmentCourseID = Convert.ToInt32(lstMCDCoursesTrainingDepartmentCourses.SelectedValue); }
            this.populateMCDCoursesTRainingDepartmentCoursesCompositions(_TrainingDepartmentCourseID);
        }

        private void dgvCourseSetupCourseComposition_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //CourseName

            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    //var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);
                    //var LET = (LookupEnrollmentType)TDCETMD.LookupEnrollmentType;
                    //var TrainingDep = (TrainingDepartment)TDCETMD.TrainingDepartmentCourseMetaData.TrainingDepartment;

                    //row.Cells[CourseName.Index].Value = TDCETMD.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName.ToString();
                    //row.Cells[EnrollmentTypeName.Index].Value = TDCETMD.LookupEnrollmentType.EnrollmentType.ToString();
                    ////
                    //row.Cells[TrainingDepartment.Index].Value = TrainingDep.TrainingDepartmentName.ToString();
                }
            }
        }

        private void dgvCourseDatabaseModulesActivities_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var act = (Activity)(row.DataBoundItem);
                    //var M = TDCETM.Module;
                    int hours = 0;
                    int min = 0;
                    //hours = Convert.ToInt32(Math.Floor(Convert.ToDecimal(act.ActivityDuration) / 60));
                    //min = act.ActivityDuration - (hours * 60);

                    row.Cells[TotalDuration.Index].Value = hours + " H " + min + " min";
                    row.Cells[ModuleName.Index].Value = act.Module.ModuleName.ToString();
                }
            }
        }

        private void dgvCourseDatabaseTrainingDepartmentCourseEnrollmentTypeMetaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
