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
using Impendulo.Common.Enum;

namespace Impendulo.Enrollments.Development
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
            this.txtStudentNember.Text = this.StudentID.ToString();
            this.txtStudentFullName.Text = this.StudentFullName;
            this.txtStudentIdNumber.Text = this.StudentIDNumber;
        }


        private void frmStudentCourseEnrollment_Load(object sender, EventArgs e)
        {
            StudentID = 6;
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
                                                           //where a.IndividualID == this.StudentID
                                                           //    && a.LookupEnrollmentProgressStateID == (int)EnumEnrollmentProgressStates.In_Progress
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

            if (StudentID != 0)
            {
                this.refreshCurrentEnrollments();
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
        private void picSearchStudents_Click(object sender, EventArgs e)
        {
            //Impendulo.StudentsAddNewStudent.frmStudentSearchForStudent frmSearchStudent = new Impendulo.StudentsAddNewStudent.frmStudentSearchForStudent();
            // frmSearchStudent.frmCourseEnrollment = this;
            //frmSearchStudent.ShowDialog();
            //once student selected load student enrollment Application
            if (StudentID != 0)
            {
                this.refreshCurrentEnrollments();
                this.showEditStudentButton();
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
            frmEnrollmentSelectCourseCurriculum frm = new frmEnrollmentSelectCourseCurriculum();
            frm.Show();
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


    }
}
