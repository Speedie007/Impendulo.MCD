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

namespace Impendulo.Employees.EmployeeUserNamePassword.Deployment
{
    public partial class frmEmployeeUserNamePassword : Form
    {
        public Employee CurrentEmployee { get; set; }
        public frmEmployeeUserNamePassword()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                List<Login> AllLogin = (from a in Dbconnection.Logins
                                        where a.UserName.ToString().ToLower().Equals(txtUsername.Text.ToString().ToLower())
                                        select a).ToList<Login>();


                if (AllLogin.Count == 0)
                {
                    if (txtPassword.Text.ToLower().Equals(txtPasswordConfirmation.Text.ToLower()))
                    {
                        Impendulo.Data.Models.Login EmployeeLogin = new Impendulo.Data.Models.Login
                        {
                            IndividualID = CurrentEmployee.EmployeeID,
                            UserName = txtUsername.Text.ToString(),
                            Password = txtPassword.Text.ToLower(),
                            DateLastChanged = DateTime.Now
                        };
                        Dbconnection.Employees.Attach(CurrentEmployee);
                        CurrentEmployee.Logins.Add(EmployeeLogin);
                        Dbconnection.SaveChanges();
                        MessageBox.Show("Details Successfully Created!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Does not Match please correct before proceeding!", "Password Miss Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else
                {
                    MessageBox.Show("UserName Exists Please Select Another!", "Duplicate User Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                Login EmployeeLogin = (from a in CurrentEmployee.Logins
                                       select a).FirstOrDefault<Login>();
                EmployeeLogin.UserName = txtUsername.Text.ToString();
                if (txtPassword.Text.ToLower().Equals(txtPasswordConfirmation.Text.ToLower()))
                {
                    Dbconnection.Employees.Attach(CurrentEmployee);
                    EmployeeLogin.Password = txtPassword.Text.ToString();
                    EmployeeLogin.DateLastChanged = DateTime.Now;

                    Dbconnection.Entry(CurrentEmployee).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                    MessageBox.Show("Details Successfully Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Does not Match please correct before proceeding!", "Password Miss Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployeeUserNamePassword_Load(object sender, EventArgs e)
        {
            if (CurrentEmployee.Logins.Count == 0)
            {
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                this.txtUsername.Text = (from a in CurrentEmployee.Logins
                                         select a.UserName).First<string>();
                btnCreate.Visible = false;
                btnUpdate.Visible = true;
            }
        }
    }
}
