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
using Impendulo.DatabaseSettings;
using Impendulo.MainApplication;


namespace Impendulo.SystemLogin.Development
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public Employee CurrentEmployee { get; set; }
        public SystemAdministrator SystemAdminLogin { get; set; }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                //check to see if it is System Admin Login
                SystemAdministrator LocalSystemAdmin = (from a in Dbconnection.SystemAdministrators
                                                        select a).FirstOrDefault<SystemAdministrator>();
                if (LocalSystemAdmin.SystemUserName.ToLower().Equals(txtUserName.Text.ToLower().ToString()))
                {
                    //check the password
                    if (LocalSystemAdmin.SystemUserPassword == txtPassword.Text.ToString())
                    {
                        SystemAdminLogin = LocalSystemAdmin;
                    }
                }

                //check to see if username exists
                List<Impendulo.Data.Models.Login> LoginDetails = (from a in Dbconnection.Logins
                                                                  select a).ToList<Impendulo.Data.Models.Login>();
                foreach (Impendulo.Data.Models.Login CurrentLoginDetails in LoginDetails)
                {
                    if (CurrentLoginDetails.UserName.ToLower().Equals(txtUserName.Text.ToLower()))
                    {
                        //User Details Found
                        if (CurrentLoginDetails.Password.Equals(txtPassword.Text))
                        {
                            //Password matchs
                            CurrentEmployee = CurrentLoginDetails.Employee;
                        }
                    }
                }
                //  checked password if user found
                if (SystemAdminLogin != null || CurrentEmployee != null)
                {
                    MCDMainForm frm = new MCDMainForm();
                    if (this.CurrentEmployee != null)
                    {
                        frm.CurrentEmployee = this.CurrentEmployee;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        frm.SystemAdminLogin = this.SystemAdminLogin;
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("User Name and Password Incorrect Or Not Found!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {


        }

        private void btnDatabaseSetting_Click(object sender, EventArgs e)
        {
            frmDynamicallySetConnectionString frm = new frmDynamicallySetConnectionString();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
