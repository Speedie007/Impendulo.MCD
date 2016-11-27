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

namespace Impendulo.Courses.Add.MCDCourses
{
    public partial class frmLinkCourses : Form
    {
        public frmLinkCourses()
        {
            InitializeComponent();
        }
        #region "Properties"
        public int DepartmentID { get; set; }
        public int TrainingDepartmentID { get; set; }
        public int TrainingDepartmentCourseID { get; set; }
        #endregion

        private void frmLinkCourses_Load(object sender, EventArgs e)
        {

            this.populateDepartments();
            this.cboDepartments.SelectedValue = this.DepartmentID;
            this.refreshTrainingDepartments();
            this.cboTrainingDepartments.SelectedValue = this.TrainingDepartmentID;
            this.refreshAvaiableTrainingDepartmentCourse();
            this.refreshLinkedTrainingDepartmentCourse();
        }
        #region "Refresh Methods"

        private void refreshTrainingDepartments()
        {
            int _DepartmentID = 0;
            if (cboDepartments.SelectedValue != null) { _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue); }
            this.populateTrainingDepartments(_DepartmentID);
        }
        private void refreshAvaiableTrainingDepartmentCourse()
        {
            int _TrainingDepartmentID = 0;
            if (cboTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue); }
            this.populateAvailableTrainingDepartmentCourse(_TrainingDepartmentID);
        }
        private void refreshLinkedTrainingDepartmentCourse()
        {
            int _TrainingDepartmentID = 0;
            if (cboTrainingDepartments.SelectedValue != null) { _TrainingDepartmentID = Convert.ToInt32(cboTrainingDepartments.SelectedValue); }
            this.populateLinkedTrainingDepartmentCourse(_TrainingDepartmentID);
        }

        #endregion
        #region "Populate Methods"
        private void populateDepartments()
        {
            using (var DBConnection = new MCDEntities())
            {
                bindingSourceDepartments.DataSource = (from a in DBConnection.LookupDepartments select a).ToList<LookupDepartment>();

            };

        }
        private void populateTrainingDepartments(int _DepartmentID)
        {
            using (var DBConnection = new MCDEntities())
            {
                //bindingSourceTrainingDepartments.DataSource = (from a in DBConnection.TrainingDepartments
                //                                               where a.DepartmentID == _DepartmentID
                //                                               select a).ToList<TrainingDepartment>();

            };
        }
        private void populateAvailableTrainingDepartmentCourse(int _TrainingDepartmentID)
        {
            using (var DbConnection = new MCDEntities())

            {


                //List<TrainingDepartmentCourseEnrollmentTypeMetaData> lst = (
                //                        from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas
                //                        where a.TrainingDepartmentCourseMetaData.TrainingDepartmentID == _TrainingDepartmentID
                //                        orderby a.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName ascending
                //                        select a).Except(from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas
                //                                         from b in a.TrainingDepartmentCourseListings
                //                                         where b.TrainingDepartmentCourseID == this.TrainingDepartmentCourseID
                //                                         orderby a.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName ascending
                //                                         select a).ToList<TrainingDepartmentCourseEnrollmentTypeMetaData>();

                //bindingSourceAvailableTrainingDepartmentCourses.DataSource = from a in lst
                //                                                             orderby a.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName
                //                                                             select a;

            };
        }
        private void populateLinkedTrainingDepartmentCourse(int _TrainingDepartmentID)
        {
            using (var DbConnection = new MCDEntities())

            {
                //List<TrainingDepartmentCourseEnrollmentTypeMetaData> lst = (from a in DbConnection.TrainingDepartmentCourseEnrollmentTypeMetaDatas//.Include("TrainingDepartmentCourseListings")
                //                                                            from b in a.TrainingDepartmentCourseListings
                //                                                            where b.TrainingDepartmentCourseID == this.TrainingDepartmentCourseID
                //                                                            select a).ToList<TrainingDepartmentCourseEnrollmentTypeMetaData>();
                //bindingSourceLinkedTrainingDepartmentCourses.DataSource = from a in lst
                //                                                          orderby a.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName
                //                                                          select a;
            };
        }

        #endregion

        private void cboDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshTrainingDepartments();
            this.refreshAvaiableTrainingDepartmentCourse();
            this.refreshLinkedTrainingDepartmentCourse();
        }

        private void cboTrainingDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refreshAvaiableTrainingDepartmentCourse();
            this.refreshLinkedTrainingDepartmentCourse();

        }

        private void dgvAvailableCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            if (gridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        try
                        {
                            //var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);
                            //var LET = (LookupEnrollmentType)TDCETMD.LookupEnrollmentType;

                            //row.Cells[MetaDataCourseName.Index].Value = TDCETMD.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName.ToString();
                            //row.Cells[EnrollmentType.Index].Value = TDCETMD.LookupEnrollmentType.EnrollmentType.ToString();
                            //row.Cells[CourseCost.Index].Value = TDCETMD.TrainingDepartmentCourseMetaDataCourseCost;
                        }
                        catch (Exception)
                        {
                            //Display Error Message
                        }


                    }
                }
            }
        }

        private void btnLinkCourse_Click(object sender, EventArgs e)
        {
            //dgvAvailableCourses.EndEdit();
            //List<TrainingDepartmentCourseListing> TDCLObjects = new List<TrainingDepartmentCourseListing>();

            //foreach (DataGridViewRow row in dgvAvailableCourses.Rows)
            //{
            //    if (Convert.ToBoolean(row.Cells[SelectCourse.Index].Value))
            //    {
            //        var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);
            //        TrainingDepartmentCourseListing TDCL = new TrainingDepartmentCourseListing()
            //        {
            //            TrainingDepartmentCourseID = this.TrainingDepartmentCourseID,
            //            TrainingDepartmentCourseMetaDataID = TDCETMD.TrainingDepartmentCourseMetaDataID,
            //            TrainingDepartmentCourseEnrollmentTypeMetaDataID = TDCETMD.TrainingDepartmentCourseEnrollmentTypeMetaDataID
            //        };
            //        TDCLObjects.Add(TDCL);
            //    }
            //}

            //using (var DbConnection = new MCDEntities())
            //{
            //    DbConnection.TrainingDepartmentCourseListings.AddRange(TDCLObjects);
            //    DbConnection.SaveChanges();
            //};

            //if (TDCLObjects.Count > 0)
            //{
            //    this.refreshAvaiableTrainingDepartmentCourse();
            //    this.refreshLinkedTrainingDepartmentCourse();
            //}
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            dgvAvailableCourses.EndEdit();
            using (var DbConnection = new MCDEntities())
            {
                //List<TrainingDepartmentCourseListing> TDCLObjects = new List<TrainingDepartmentCourseListing>();

                //foreach (DataGridViewRow row in dgvLinkedCourses.Rows)
                //{
                //    if (Convert.ToBoolean(row.Cells[SelectCourse.Index].Value))
                //    {
                //        var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);

                //        var ListingObj = (from a in DbConnection.TrainingDepartmentCourseListings
                //                          where a.TrainingDepartmentCourseEnrollmentTypeMetaDataID == TDCETMD.TrainingDepartmentCourseEnrollmentTypeMetaDataID &&
                //                                 a.TrainingDepartmentCourseMetaDataID == TDCETMD.TrainingDepartmentCourseMetaDataID &&
                //                                  a.TrainingDepartmentCourseID == this.TrainingDepartmentCourseID
                //                          select a
                //                            ).FirstOrDefault();
                //        DbConnection.Entry(ListingObj).State = System.Data.Entity.EntityState.Deleted;
                //    }
                //}

                //DbConnection.SaveChanges();
            };
            this.refreshAvaiableTrainingDepartmentCourse();
            this.refreshLinkedTrainingDepartmentCourse();

        }

        private void dgvLinkedCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        //var TDCETMD = (TrainingDepartmentCourseEnrollmentTypeMetaData)(row.DataBoundItem);
                        //var LET = (LookupEnrollmentType)TDCETMD.LookupEnrollmentType;

                        //row.Cells[MetaDataCourseName.Index].Value = TDCETMD.TrainingDepartmentCourseMetaData.TrainingDepartmentCourseMetaDataCourseName.ToString();
                        //row.Cells[EnrollmentType.Index].Value = TDCETMD.LookupEnrollmentType.EnrollmentType.ToString();
                        //row.Cells[CourseCost.Index].Value = TDCETMD.TrainingDepartmentCourseMetaDataCourseCost;
                    }
                    catch (Exception)
                    {
                        //Display Error Message
                    }

                }
            }
        }

        private void dgvAvailableCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
