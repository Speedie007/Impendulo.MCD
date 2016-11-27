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

namespace Impendulo.Facilitators.Deployment
{
    public partial class frmAddUpdateFacilitator : Form
    {
        public Facilitator CurrentFaclilitator { get; set; }
        public frmAddUpdateFacilitator()
        {
            InitializeComponent();
        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            this.populateEmployeeTitles();
            this.setAddUpdateButtons();
            if (CurrentFaclilitator.FacilitatorID != 0)
            {
                setEmployeeDetails();
            }

        }
        private void setAddUpdateButtons()
        {
            if (CurrentFaclilitator.FacilitatorID == 0)
            {
                btnAddEmployee.Visible = true;
                btnUpdateEmployee.Visible = false;
            }
            else
            {
                btnAddEmployee.Visible = false;
                btnUpdateEmployee.Visible = true;
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
            cboEmployeeTitle.SelectedValue = CurrentFaclilitator.Individual.TitleID;
            txtEmployeeFirstName.Text = CurrentFaclilitator.Individual.IndividualFirstName;
            txtEmployeeSecondName.Text = CurrentFaclilitator.Individual.IndividualSecondName;
            txtEmployeeLastName.Text = CurrentFaclilitator.Individual.IndividualLastname;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {
                CurrentFaclilitator = new Facilitator
                {
                    Individual = new Individual
                    {
                        TitleID = Convert.ToInt32(cboEmployeeTitle.SelectedValue),
                        IndividualFirstName = txtEmployeeFirstName.Text.ToString(),
                        IndividualSecondName = txtEmployeeSecondName.Text.ToString(),
                        IndividualLastname = txtEmployeeLastName.Text.ToString(),
                    }
                };

                Dbconnection.Facilitators.Add(CurrentFaclilitator);

                Dbconnection.SaveChanges();
                this.CurrentFaclilitator = (from a in Dbconnection.Facilitators
                                            where a.FacilitatorID == CurrentFaclilitator.FacilitatorID
                                            select a).FirstOrDefault<Facilitator>();
                // Dbconnection.Entry(NewIndividual).Reference(a => a.LookupTitle).Load();
            };
            this.Close();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                Dbconnection.Facilitators.Attach(CurrentFaclilitator);

                CurrentFaclilitator.Individual.TitleID = Convert.ToInt32(this.cboEmployeeTitle.SelectedValue);
                CurrentFaclilitator.Individual.IndividualFirstName = txtEmployeeFirstName.Text.ToString();
                CurrentFaclilitator.Individual.IndividualSecondName = txtEmployeeSecondName.Text.ToString();
                CurrentFaclilitator.Individual.IndividualLastname = txtEmployeeLastName.Text.ToString();


                Dbconnection.Entry<Facilitator>(CurrentFaclilitator).State = System.Data.Entity.EntityState.Modified;

                Dbconnection.SaveChanges();

                //Dbconnection.Entry(CurrentFaclilitator).Reference(a => a.Individual.LookupTitle).Load();
                //Dbconnection.Entry(CurrentFaclilitator).Reference(a => a.LookupProvince).Load();
                //Dbconnection.Entry(CurrentFaclilitator).Reference(a => a.LookupCountry).Load();

            };

            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
