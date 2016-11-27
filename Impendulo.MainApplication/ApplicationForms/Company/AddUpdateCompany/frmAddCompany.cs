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

namespace Impendulo.Company.AddCompany.Deployment
{
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                Impendulo.Data.Models.Company NewCompany = new Data.Models.Company
                {
                    CompanyName = this.txtComapnyName.Text.ToString(),
                    CompanySETANumber = this.txtSARSLevyRegistration.Text.ToString(),
                    CompanySicCode = this.txtSicCode.Text.ToString(),
                    CompanySARSLevyRegistrationNumber = this.txtSARSLevyRegistration.Text.ToString()
                };
                foreach (ContactDetail ConDetail in GetCompanyContactDetails())
                {
                    NewCompany.ContactDetails.Add(ConDetail);
                };
                Dbconnection.Companies.Add(NewCompany);
                Dbconnection.SaveChanges();

            };
            this.Close();
        }
        private List<ContactDetail> GetCompanyContactDetails()
        {
            List<ContactDetail> AllCompanyContactDetails = new List<ContactDetail>();
            //Adds the Comapany Email adddress to the ContactDetails
            AllCompanyContactDetails.Add(new ContactDetail
            {
                ContactTypeID = (int)EnumContactTypes.Email_Address,
                ContactDetailValue = txtEmailAddress.Text.ToString()
            });
            //Adds the Comapany Office Number to the ContactDetails
            AllCompanyContactDetails.Add(new ContactDetail
            {
                ContactTypeID = (int)EnumContactTypes.Office_Number,
                ContactDetailValue = txtOfficeNumber.Text.ToString()
            });
            //Adds the Comapany Fax Number to the ContactDetails
            AllCompanyContactDetails.Add(new ContactDetail
            {
                ContactTypeID = (int)EnumContactTypes.Fax_Number,
                ContactDetailValue = txtFaxNumber.Text.ToString()
            });
            return AllCompanyContactDetails;
        }
    }
}
