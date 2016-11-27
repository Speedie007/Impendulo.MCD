using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Enrollments;
//using Impendulo.StudentEngineeringCourseErollment;
using Impendulo.Data.Models;
using Impendulo.StudentForms;
using Impendulo.Common.Enum;
using Impendulo.StudentForms.Deployment;

namespace Impendulo.Enrollments.Deployment
{
    public partial class frmStudentCourseEnrollment : Form
    {

        public int StudentID { get; set; }
        public string StudentFullName { get; set; }
        public string StudentIDNumber { get; set; }

        public frmStudentCourseEnrollment()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadStudentDetails()
        {
            this.txtStudentNumber.Text = this.StudentID.ToString();
            this.txtStudentFullName.Text = this.StudentFullName;
            this.txtStudentIdNumber.Text = this.StudentIDNumber;
        }


        private void frmStudentCourseEnrollment_Load(object sender, EventArgs e)
        {
            ///StudentID = 0;

        }

        #region Refresh Methods

        private void refreshCurrentEnrollments()
        {
            populateCurrentEnrollments();

            this.enableStudentEnrollmentApplications();
            this.enableProcessCourseEnrollment();

        }


        #endregion


        #region Populate Methods

        private void populateCurrentEnrollments()
        {

            using (var Dbconnection = new MCDEntities())
            {
                this.enrollmentBindingSource.DataSource = (from a in Dbconnection.Enrollments
                                                           where a.IndividualID == this.StudentID
                                                               && a.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress
                                                           select a).ToList<Enrollment>();
            };

        }
        #endregion

        /***********************************
         * All the methods to process the student selection logice and the assosiated control events and methods.
         * ******************************************************************************************************/
        #region Select Student Methods
        #region Select Student Procesing Logic Methods

        #endregion
        #region Select Student Control Methods
        private void showEditStudentButton()
        {
            picbtnEditCurrentStudent.Visible = true;
        }
        private void hideEditStudnetButton()
        {
            picbtnEditCurrentStudent.Visible = false;
        }
        #endregion
        #region Select Student Control Events
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbtnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frmStudent = new frmAddUpdateStudent();
            //frmStudent.EnrollmentForm = this;
            frmStudent.StudentID = 0;
            frmStudent.ShowDialog();
            if (StudentID != 0)
            {
                this.refreshCurrentEnrollments();
                this.refreshAvailableCurriculumCourses();
                this.refreshLinkedCurriculumCourses();
                this.showEditStudentButton();
            }
            else
            {
                this.disableStudentEnrollmentApplications();
                this.hideEditStudnetButton();
            }
        }
        /// <summary>
        /// Fires the event when the search student picture button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void picbtnEditCurrentStudent_Click(object sender, EventArgs e)
        {
            frmAddUpdateStudent frmStudent = new frmAddUpdateStudent();
            frmStudent.EnrollmentForm = this;
            frmStudent.StudentID = this.StudentID;
            frmStudent.ShowDialog();

        }
        private void picSearchStudents_Click(object sender, EventArgs e)
        {
            frmStudentSearchForStudent frmSearchStudent = new frmStudentSearchForStudent();
            frmSearchStudent.StudentCourseEnrollmentForm = this;
            frmSearchStudent.ShowDialog();

            //once student selected load student enrollment Application
            if (StudentID != 0)
            {
                this.refreshCurrentEnrollments();
                this.refreshAvailableCurriculumCourses();
                this.refreshLinkedCurriculumCourses();
                this.showEditStudentButton();
                this.txtdateScheduled.Text = DateTime.Now.ToString("D");
            }
            else
            {
                this.disableStudentEnrollmentApplications();
                this.disableProcessCourseEnrollment();
                this.hideEditStudnetButton();
            }

            //this.LoadStudentDetails();
        }
        private void picSearchStudents_MouseHover(object sender, EventArgs e)
        {
            picSearchStudents.BackColor = SystemColors.InactiveBorder;
        }
        private void picSearchStudents_MouseLeave(object sender, EventArgs e)
        {
            picSearchStudents.BackColor = SystemColors.Window;
        }
        private void picbtnAddStudent_MouseHover(object sender, EventArgs e)
        {
            picbtnAddStudent.BackColor = SystemColors.InactiveBorder;
        }
        private void picbtnAddStudent_MouseLeave(object sender, EventArgs e)
        {
            picbtnAddStudent.BackColor = SystemColors.Window;
        }
        private void picbtnEditCurrentStudent_MouseHover(object sender, EventArgs e)
        {
            picbtnEditCurrentStudent.BackColor = SystemColors.InactiveBorder;
        }

        private void picbtnEditCurrentStudent_MouseLeave(object sender, EventArgs e)
        {
            picbtnEditCurrentStudent.BackColor = SystemColors.Window;
        }
        #endregion
        #endregion
        /******************************************
         * End Of Student Selection Section */

        #region Student Enrollment Applications Methods
        #region Student Enrollment Applications Processing Logic Methods
        private void enableStudentEnrollmentApplications()
        {
            gbEnrollmentApplications.Enabled = true;
        }
        private void disableStudentEnrollmentApplications()
        {
            gbEnrollmentApplications.Enabled = false;
        }
        #endregion
        #region Enrollment Application Events

        private void btnAddNewEnrollmentApplication_Click(object sender, EventArgs e)
        {
            frmEnrollmentSelectCourseCurriculum frm = new frmEnrollmentSelectCourseCurriculum(this.StudentID);
            frm.ShowDialog();

            this.refreshCurrentEnrollments();
        }
        private void dgvEnrollmentApplications_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var EnrollmentObj = (Enrollment)(row.DataBoundItem);
                    Curriculum CurriculumObj = EnrollmentObj.Curriculum;
                    LookupDepartment DepartmentObj = CurriculumObj.LookupDepartment;
                    ApprienticeshipEnrollment ApprienticeshipEnrollmentObj = EnrollmentObj.ApprienticeshipEnrollment;
                    LookupSectionalEnrollmentType LookupSectionalEnrollmentTypeObj = ApprienticeshipEnrollmentObj.LookupSectionalEnrollmentType;

                    row.Cells[CurriculumName.Index].Value = CurriculumObj.CurriculumName;
                    row.Cells[Department.Index].Value = DepartmentObj.DepartmentName;
                    row.Cells[EnrollmentType.Index].Value = LookupSectionalEnrollmentTypeObj.LookupSectionalEnrollmentTypeName;
                }
            }
        }
        #endregion
        #endregion

        #region Process Course Enrollment Methods
        #region Process Course Enrollment Processing Logic Methods
        private void enableProcessCourseEnrollment()
        {
            gbProcessEnrollment.Enabled = true;
        }
        private void disableProcessCourseEnrollment()
        {
            gbProcessEnrollment.Enabled = false;
        }
        #endregion
        #endregion

        private void btnAddNewEnrollment_Click(object sender, EventArgs e)
        {
            //frmStudentAddNewStudent frmNewStudent = new frmStudentAddNewStudent();
            //frmNewStudent.StudentID = 0;
            //frmNewStudent.ShowDialog();
        }


        /*Section of Code Needs To Be Reorginsed
         * **********************************/

        private void refreshAvailableCurriculumCourses()
        {
            int _CurriculumID = 0;
            int _EnrollmentID = 0;
            if (enrollmentBindingSource.Count > 0)
            {
                Enrollment emroll = ((Enrollment)enrollmentBindingSource.Current);
                _CurriculumID = emroll.CurriculumID;
                _EnrollmentID = emroll.EnrollmentID;
            };
            populateAvailableCurriculumCourses(_CurriculumID, _EnrollmentID);
        }
        private void refreshLinkedCurriculumCourses()
        {
            int _EnrollmentID = 0;
            int _CurriculumID = 0;
            if (enrollmentBindingSource.Count > 0)
            {
                Enrollment emroll = ((Enrollment)enrollmentBindingSource.Current);
                _EnrollmentID = emroll.EnrollmentID;
                _CurriculumID = emroll.CurriculumID;
            };
            populateLinkedCurriculumCourses(_EnrollmentID, _CurriculumID);
        }
        private void populateAvailableCurriculumCourses(int _CurriculumID, int _EnrollmentID)
        {

            using (var Dbconnection = new MCDEntities())
            {
                CurriculumCoursesbindingSourceAvailableCourses.DataSource =
                (from a in Dbconnection.CurriculumCourses
                 where a.CurriculumID == _CurriculumID
                 select a).Except(from a in Dbconnection.CurriculumCourses
                                  from b in a.CurriculumCourseEnrollments
                                  where b.EnrollmentID == _EnrollmentID
                                  select a).ToList<CurriculumCourse>();

                /*
                 * */

            };

        }

        private void populateLinkedCurriculumCourses(int _EnrollmentID, int _CurriculumID)
        {
            using (var Dbconnection = new MCDEntities())
            {
                //List<CurriculumCourse> LinkeCourses = (from a in Dbconnection.CurriculumCourses
                //                                       from b in a.CurriculumCourseEnrollments
                //                                       where b.EnrollmentID == _EnrollmentID
                //                                       select a).ToList<CurriculumCourse>();
                CurriculumCoursesbindingSourceLinkedCourses.DataSource = (from a in Dbconnection.CurriculumCourses
                                                                          from b in a.CurriculumCourseEnrollments
                                                                          where b.EnrollmentID == _EnrollmentID
                                                                          select a).ToList<CurriculumCourse>(); ;
                curriculumCourseBindingSource.DataSource = (from a in Dbconnection.GetCurriculumCourseInOrder(_CurriculumID)
                                                            from b in a.CurriculumCourseEnrollments
                                                            where b.EnrollmentID == _EnrollmentID
                                                            select a).ToList<CurriculumCourse>(); ;

                /*
                 * */

            };
        }

        private void dgvAvailableCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumObj = (CurriculumCourse)(row.DataBoundItem);
                    var CourseObj = CurriculumObj.Course;

                    row.Cells[AvailableCourse.Index].Value = CourseObj.CourseName.ToString();
                }
            }
        }

        private void dgvLinkedCourses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var CurriculumObj = (CurriculumCourse)(row.DataBoundItem);
                    var CourseObj = CurriculumObj.Course;

                    row.Cells[LinkedCourse.Index].Value = CourseObj.CourseName.ToString();
                }
            }
        }

        private void btnLinkAvaiableCourse_Click(object sender, EventArgs e)
        {
            int _CurriculumCourseID = 0;
            int _EnrollmentID = 0;
            if (CurriculumCoursesbindingSourceAvailableCourses.Count > 0)
            {
                _CurriculumCourseID = ((CurriculumCourse)CurriculumCoursesbindingSourceAvailableCourses.Current).CurriculumCourseID;
                _EnrollmentID = ((Enrollment)enrollmentBindingSource.Current).EnrollmentID;
                using (var Dbconnection = new MCDEntities())
                {
                    CurriculumCourseEnrollment newItem = new CurriculumCourseEnrollment
                    {
                        EnrollmentID = _EnrollmentID,
                        CurriculumCourseID = _CurriculumCourseID
                    };

                    Dbconnection.CurriculumCourseEnrollments.Add(newItem);
                    Dbconnection.SaveChanges();

                };
            };



            refreshAvailableCurriculumCourses();
            refreshLinkedCurriculumCourses();
        }

        private void btnRemoveLinkedCourse_Click(object sender, EventArgs e)
        {
            int _CurriculumCourseID = 0;
            int _EnrollmentID = 0;
            if (CurriculumCoursesbindingSourceLinkedCourses.Count > 0)
            {

                _CurriculumCourseID = ((CurriculumCourse)CurriculumCoursesbindingSourceLinkedCourses.Current).CurriculumCourseID;
                _EnrollmentID = ((Enrollment)enrollmentBindingSource.Current).EnrollmentID;

                using (var Dbconnection = new MCDEntities())
                {
                    CurriculumCourseEnrollment currentItem = (from a in Dbconnection.CurriculumCourseEnrollments
                                                              where a.CurriculumCourseID == _CurriculumCourseID
                                                              && a.EnrollmentID == _EnrollmentID
                                                              select a).FirstOrDefault<CurriculumCourseEnrollment>();
                    Dbconnection.CurriculumCourseEnrollments.Remove(currentItem);
                    Dbconnection.SaveChanges();
                };
            };


            refreshAvailableCurriculumCourses();
            refreshLinkedCurriculumCourses();
        }

        private void dgvCurriculumCourseSelectionSummary_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DateTime CurrentDate = DateTime.Now;
            CurrentDate = CurrentDate.AddDays(1);
            if (CurrentDate.DayOfWeek == DayOfWeek.Saturday)
            {
                CurrentDate = CurrentDate.AddDays(1);
            }
            if (CurrentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                CurrentDate = CurrentDate.AddDays(1);
            }
            //Boolean IsFirstCourse = true;

            //int PreviousCourseDuration = 0;

            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {

                if (!row.IsNewRow)
                {

                    var CurriculumObj = (CurriculumCourse)(row.DataBoundItem);
                    var CourseObj = CurriculumObj.Course;

                    //PreviousCourseDuration = CurriculumObj.Duration;
                    row.Cells[PreliminaryStartDate.Index].Value = CurrentDate.ToString("D");



                    for (int iLoop = 0; iLoop < CurriculumObj.Duration - 1; iLoop++)
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                        if (CurrentDate.DayOfWeek == DayOfWeek.Saturday)
                        {
                            CurrentDate = CurrentDate.AddDays(1);
                        }
                        if (CurrentDate.DayOfWeek == DayOfWeek.Sunday)
                        {
                            CurrentDate = CurrentDate.AddDays(1);
                        }
                    }
                    //next Start Date will be
                    CurrentDate = CurrentDate.AddDays(1);
                    if (CurrentDate.DayOfWeek == DayOfWeek.Saturday)
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                    }
                    if (CurrentDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        CurrentDate = CurrentDate.AddDays(1);
                    }


                    row.Cells[CourseName.Index].Value = CourseObj.CourseName.ToString();

                }
            }
        }

      




        /*END
         * **********************************/
    }
}
