using Impendulo.Data.Models;
using Impendulo.StudentForms.Development;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.StudentEngineeringCourseErollment.Devlopment.CurriculumEmrollmentForms.ApprenticeshipEnrollment
{
    public partial class frmApprenticeshipEnrollmentForm : Form
    {
        public Enrollment CurrentEnrollments { get; set; }
        public frmApprenticeshipEnrollmentForm()
        {
            InitializeComponent();
            CurrentEnrollments = new Enrollment();

            CurrentEnrollments.LookupEnrollmentProgressStateID = (int)Common.Enum.EnumEnrollmentProgressStates.In_Progress;
            CurrentEnrollments.DateIntitiated = DateTime.Now;
            CurrentEnrollments.EnrolmentParentID = 0;

        }

        private void frmApprenticeshipEnrollmentForm_Load(object sender, EventArgs e)
        {

        }

        private void picSearchStudents_Click(object sender, EventArgs e)
        {
            frmStudentSearchForStudent frm = new frmStudentSearchForStudent();
            frm.ShowDialog();
            if (frm.CurrentSelectedStudent != null)
            {
                txtStudentFullName.Text = frm.CurrentSelectedStudent.Individual.IndividualFirstName + " " + frm.CurrentSelectedStudent.Individual.IndividualLastname;
                txtStudentIdNumber.Text = frm.CurrentSelectedStudent.StudentIDNumber;
                txtStudentNember.Text = frm.CurrentSelectedStudent.StudentID.ToString();
                CurrentEnrollments.Student = frm.CurrentSelectedStudent;
                CurrentEnrollments.IndividualID = frm.CurrentSelectedStudent.StudentID;

            }
            ////if (StudentID != 0)
            ////{
            ////    this.refreshCurrentEnrollments();
            ////    this.showEditStudentButton();
            ////}
            ////else
            ////{
            ////    //this.disableStudentEnrollmentApplications();
            ////    //this.disableProcessCourseEnrollment();
            ////    //this.hideEditStudnetButton();
            ////}
        }

        private void picbtnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void picbtnEditCurrentStudent_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentNember_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
