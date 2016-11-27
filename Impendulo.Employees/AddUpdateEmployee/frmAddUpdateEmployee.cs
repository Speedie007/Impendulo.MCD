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
using System.Data.Entity.Validation;

namespace Impendulo.Employees.AddUpdateEmployee.Development
{
    public partial class frmAddUpdateEmployee : Form
    {
        public Employee CurrentEmployee { get; set; }
        public frmAddUpdateEmployee()
        {
            InitializeComponent();
        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            this.populateEmployeeTitles();
            this.setAddUpdateButtons();
            if (CurrentEmployee.EmployeeID != 0)
            {
                setEmployeeDetails();
            }

        }
        private void setAddUpdateButtons()
        {
            if (CurrentEmployee.EmployeeID == 0)
            {
                btnAddEmployee.Visible = true;
                btnUpdateEmployee.Visible = false;
                gbUsernameAndPassword.Visible = true;
            }
            else
            {
                gbUsernameAndPassword.Visible = false;
                btnAddEmployee.Visible = false;
                btnUpdateEmployee.Visible = true;
                this.Height = this.Height - 106;
            }
        }
        private void populateEmployeeTitles()
        {

            using (var Dbconnection = new MCDEntities())
            {

                lookupTitleBindingSource.DataSource = (from a in Dbconnection.LookupTitles
                                                       select a).ToList<LookupTitle>();
            };
        }

        private void setEmployeeDetails()
        {
            txtEmployeeNumber.Text = CurrentEmployee.EmployeeNumber;
            cboEmployeeTitle.SelectedValue = CurrentEmployee.Individual.TitleID;
            txtEmployeeFirstName.Text = CurrentEmployee.Individual.IndividualFirstName;
            txtEmployeeSecondName.Text = CurrentEmployee.Individual.IndividualSecondName;
            txtEmployeeLastName.Text = CurrentEmployee.Individual.IndividualLastname;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                string ValidatedPassword = null;

                if (txtPassword.Text.ToString().Equals(txtPasswordConfirmation.Text.ToString()))
                {
                    ValidatedPassword = txtPassword.Text.ToString();
                    CurrentEmployee = new Employee
                    {
                        EmployeeNumber = txtEmployeeNumber.Text.ToString(),
                        Individual = new Individual
                        {
                            TitleID = Convert.ToInt32(cboEmployeeTitle.SelectedValue),
                            IndividualFirstName = txtEmployeeFirstName.Text.ToString(),
                            IndividualSecondName = txtEmployeeSecondName.Text.ToString(),
                            IndividualLastname = txtEmployeeLastName.Text.ToString(),
                        }
                    };

                    Login LoginDetails = new Login
                    {
                        UserName = txtEmployeeFirstName.Text,
                        Password = txtPassword.Text.ToString()
                    };

                    CurrentEmployee.Logins.Add(LoginDetails);

                    Dbconnection.Employees.Add(CurrentEmployee);

                    Dbconnection.SaveChanges();
                    this.CurrentEmployee = (from a in Dbconnection.Employees
                                            where a.EmployeeID == CurrentEmployee.EmployeeID
                                            select a).FirstOrDefault<Employee>();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Does Not Match.", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
               
                // Dbconnection.Entry(NewIndividual).Reference(a => a.LookupTitle).Load();
            };
            
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                Dbconnection.Employees.Attach(CurrentEmployee);

                CurrentEmployee.EmployeeNumber = txtEmployeeNumber.Text.ToString();
                CurrentEmployee.Individual.TitleID = Convert.ToInt32(this.cboEmployeeTitle.SelectedValue);
                CurrentEmployee.Individual.IndividualFirstName = txtEmployeeFirstName.Text.ToString();
                CurrentEmployee.Individual.IndividualSecondName = txtEmployeeSecondName.Text.ToString();
                CurrentEmployee.Individual.IndividualLastname = txtEmployeeLastName.Text.ToString();
               


                Dbconnection.Entry<Employee>(CurrentEmployee).State = System.Data.Entity.EntityState.Modified;

                Dbconnection.SaveChanges();

                //Dbconnection.Entry(CurrentEmployee).Reference(a => a.Individual.LookupTitle).Load();
                //Dbconnection.Entry(CurrentEmployee).Reference(a => a.LookupProvince).Load();
                //Dbconnection.Entry(CurrentEmployee).Reference(a => a.LookupCountry).Load();

            };

            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
