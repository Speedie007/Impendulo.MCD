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
using Impendulo.Common.AppSettings;
using Impendulo.Common;
using Impendulo.Common.EntityFrameWorkHelper;
using Impendulo.Common.SqlHelper;
using Impendulo.Enrollments.Deployment;
using Impendulo.Courses.Configuration.Deployment;
using Impendulo.EmailSettings.Deployment;
using Impendulo.DatabaseSettings.Deployment;
using Impendulo.Company.Deployment;
using Impendulo.StudentForms.Deployment;
using Impendulo.Facilitators.Deployment;
using Impendulo.MessageTemplates.Deployment;
using Impendulo.ClientEnquiry.Depolyment;
using Impendulo.Employees.Deployment1;
using Impendulo.Enquiry.Deployment.EnquiryV2;
using Impendulo.StudentEngineeringCourseErollment.Deployment;

namespace Impendulo.MainApplication
{
    public partial class MCDMainForm : Form
    {
        public MCDMainForm()
        {
            InitializeComponent();
        }

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }
        public SystemAdministrator SystemAdminLogin { get; set; }
        private Boolean _IsLogOut = true;
        public Boolean IsLogOut
        {
            get { return _IsLogOut; }
            set { _IsLogOut = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //RibbonButton btn = new RibbonButton("here");
            //ribbonPanel2.Items.Add(btn);
            //btn.Canvas.Refresh();
        }

        //private void AddStudentRribbonButton_Click(object sender, EventArgs e)
        //{
        //    foreach (Form f in this.MdiChildren)
        //    {
        //        if (f.GetType() == typeof(Impendulo.ViewCurrentCourseSchedules.ViewCurrentCourseSchedules))
        //        {
        //            f.Activate();
        //            return;
        //        }
        //    }

        //    Form form = new temp.Form1();
        //    form.MdiParent = this;
        //    form.Show();

        //}

        private void ExitRibbonOrbMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure," + Environment.NewLine + "Make Sure All Work Is Saved!", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (DialogResult.Yes == result)
            {
                this.IsLogOut = false;
                this.Close();
            }

        }

        private void ribbon1_Click(object sender, EventArgs e)
        {

        }

        private void ribbtnConfigureEngApprenticeshipCourses_Click(object sender, EventArgs e)
        {


        }

        private void ribbonPanel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ResetTransform();
        }

        private void ribbon1_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Refresh();
        }

        //private void rbtnAdministerCourses_Click(object sender, EventArgs e)
        //{
        //    foreach (Form f in this.MdiChildren)
        //    {
        //        if (f.GetType() == typeof(CourseAdministrationV6cs))
        //        {
        //            f.Activate();
        //            return;
        //        }
        //    }

        //    CourseAdministrationV6cs frm = new CourseAdministrationV6cs();
        //    //frm._CourseType = ((RibbonButton)sender).Tag.ToString();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        private void btnoinr_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helllo");
        }

        private void rbtnNeweditStudnetEnrollment_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmStudentCourseEnrollmentV2))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmStudentCourseEnrollmentV2 frm = new frmStudentCourseEnrollmentV2();
            //frm._CourseType = ((RibbonButton)sender).Tag.ToString();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbtnCourseAdministration_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmCourseConfiguration))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmCourseConfiguration frm = new frmCourseConfiguration();

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEmailSettings_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmEmailConfiguration))
                {
                    f.Activate();
                    return;
                }
            }

            frmEmailConfiguration frm = new frmEmailConfiguration();

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDatabaseSettings_CanvasChanged(object sender, EventArgs e)
        {

        }

        private void btnDatabaseSettings_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmDynamicallySetConnectionString))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmDynamicallySetConnectionString frm = new frmDynamicallySetConnectionString();

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmCompany))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmCompany frm = new frmCompany();

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAdminStudent_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmStudentSearchForStudent))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmStudentSearchForStudent frm = new frmStudentSearchForStudent();
            //frm.frmParentForm = this;

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmAddUpdateEmployeeDetails))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmAddUpdateEmployeeDetails frm = new frmAddUpdateEmployeeDetails();
            // frm.frmParentForm = this;

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFacilitators_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmAddUpdateFacilitatorDetails))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmAddUpdateFacilitatorDetails frm = new frmAddUpdateFacilitatorDetails();
            // frm.frmParentForm = this;

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEquiryList_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmClientEnquiryV2))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmClientEnquiryV2 frm = new frmClientEnquiryV2();

            frm.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;

            frm.MdiParent = this;
            frm.Show();
        }

        private void btnEditMessageTeplates_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(frmMessageTemplates))
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }

            frmMessageTemplates frm = new frmMessageTemplates();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
