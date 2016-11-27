using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Company.AddCompany;
using Impendulo.Data.Models;
using Impendulo.Common.Enum;
using Impendulo.Contacts;
using Impendulo.Addresses;
using Impendulo.ContactDetails;
using Impendulo.Addresses.Deployment;
using Impendulo.ContactDetails.Deployment;
using Impendulo.Contacts.Deployment;
using Impendulo.Company.AddCompany.Deployment;

namespace Impendulo.Company.Deployment
{
    public partial class frmCompany : Form
    {
        public Individual NewIndividuialObj { get; set; }
        private string SerachCriteriaCompanyName { get; set; }
        private string SerachCriteriaContactName { get; set; }
        public frmCompany()
        {
            InitializeComponent();
        }

        #region RefreshMethods

        private void refreshCompanies()
        {

            this.populateCompanies();
            this.setCompanyDetails();
        }
        private void refreshCompanyContacts()
        {
            if (companyBindingSource.Count > 0)
            {
                this.populateCompanyContacts();
                btnAddContact.Enabled = true;
                btnUpdateContact.Enabled = true;
            }
            else
            {
                individualBindingSource.Clear();
                btnAddContact.Enabled = false;
                btnUpdateContact.Enabled = false;
            }
        }

        private void refreshCompanyAddresses()
        {
            if (companyBindingSource.Count > 0)
            {
                this.popoulateCompanyAddresses();
                this.btnAddCompanyAddress.Enabled = true;
                this.btnUpdateAddress.Enabled = true;
            }
            else
            {
                addressBindingSource.Clear();
                this.btnAddCompanyAddress.Enabled = false;
                this.btnUpdateAddress.Enabled = false;
            }

        }
        private void refreshCompanyContactDetails()
        {
            if (individualBindingSource.Count > 0)
            {
                this.populateCompanyContactDetails();
                this.btnAddContactInfo.Enabled = true;
                this.btnUpdateContactDetials.Enabled = true;
            }
            else
            {
                contactDetailBindingSource.Clear();
                this.btnAddContactInfo.Enabled = false;
                this.btnUpdateContactDetials.Enabled = false;
            }
        }
        #endregion


        #region Company Details

        #region Company Populate Methods
        private void populateCompanies()
        {

            using (var Dbconnection = new MCDEntities())
            {

                companyBindingSource.DataSource = (from a in Dbconnection.Companies
                                                    .Include("ContactDetails")
                                                    .Include("Individuals")
                                                    .Include("Individuals.ContactDetails")
                                                    .Include("Individuals.ContactDetails.LookupContactType")
                                                    .Include("Addresses")
                                                    .Include("Addresses.LookupAddressType")
                                                    .Include("Addresses.LookupProvince")
                                                    .Include("Addresses.LookupCountry")

                                                   where a.CompanyName.Contains(this.SerachCriteriaCompanyName)
                                                   select a).ToList<Impendulo.Data.Models.Company>();
            };
            this.setCompanyDetails();
        }
        #endregion
        #region Company Logical Processing Methods
        private void setCompanySearchCriteria()
        {
            SerachCriteriaCompanyName = this.txtCompaniesFilterCriteria.Text;
        }
        private void setCompanyDetails()
        {
            if (companyBindingSource.Count > 0)
            {
                gbCompanyDetails.Enabled = true;
                Impendulo.Data.Models.Company CurrentSelectedCOmpany = ((Data.Models.Company)(companyBindingSource.Current));

                txtCompanySETANumber.Text = CurrentSelectedCOmpany.CompanySETANumber;
                txtSARSLevyRegistration.Text = CurrentSelectedCOmpany.CompanySARSLevyRegistrationNumber;
                txtSicCode.Text = CurrentSelectedCOmpany.CompanySicCode;
                foreach (ContactDetail CompContactDetial in CurrentSelectedCOmpany.ContactDetails)
                {
                    if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Email_Address)
                    {
                        txtCompanyEmailAddress.Text = CompContactDetial.ContactDetailValue;
                    };
                    if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Office_Number)
                    {
                        txtCompanyOfficeNumber.Text = CompContactDetial.ContactDetailValue;
                    };
                    if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Fax_Number)
                    {
                        txtCompanyFaxNumber.Text = CompContactDetial.ContactDetailValue;
                    };
                }
            }
            else
            {
                gbCompanyDetails.Enabled = false;
                txtCompanySETANumber.Clear();
                txtSARSLevyRegistration.Clear();
                txtSicCode.Clear();
                txtCompanyEmailAddress.Clear();
                txtCompanyOfficeNumber.Clear();
                txtCompanyFaxNumber.Clear();
            }
        }
        private void UpdateCompanyContactDetails(Data.Models.Company CurrentSelectedCOmpany)
        {
            foreach (ContactDetail CompContactDetial in CurrentSelectedCOmpany.ContactDetails)
            {
                if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Email_Address)
                {
                    CompContactDetial.ContactDetailValue = txtCompanyEmailAddress.Text;
                };
                if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Office_Number)
                {
                    CompContactDetial.ContactDetailValue = txtCompanyOfficeNumber.Text;
                };
                if (CompContactDetial.ContactTypeID == (int)EnumContactTypes.Fax_Number)
                {
                    CompContactDetial.ContactDetailValue = txtCompanyFaxNumber.Text;
                };
            }
        }
        #endregion

        #region Company Controls Events
        private void btnFilterCompanies_Click(object sender, EventArgs e)
        {
            this.setCompanySearchCriteria();

            this.refreshCompanies();
            this.refreshCompanyAddresses();
            this.refreshCompanyContacts();
            this.refreshCompanyContactDetails();
        }

        private void tsbtnRefreshCourseSearch_Click(object sender, EventArgs e)
        {
            this.txtCompaniesFilterCriteria.Clear();
            this.setCompanySearchCriteria();

            this.refreshCompanies();
            this.refreshCompanyAddresses();
            this.refreshCompanyContacts();
            this.refreshCompanyContactDetails();

        }
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            frmAddCompany frm = new frmAddCompany();
            frm.ShowDialog();
            this.refreshCompanies();
            this.refreshCompanyContacts();
            this.refreshCompanyAddresses();
            this.refreshCompanyContactDetails();

        }
        private void companyBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setCompanyDetails();
            this.refreshCompanyContacts();
            this.refreshCompanyAddresses();
            this.refreshCompanyContactDetails();

        }
        private void btnUpdateCompanyDetails_Click(object sender, EventArgs e)
        {
            Data.Models.Company CompanyToUpdate = (Data.Models.Company)companyBindingSource.Current;
            CompanyToUpdate.CompanySARSLevyRegistrationNumber = this.txtSARSLevyRegistration.Text.ToString();
            CompanyToUpdate.CompanySETANumber = this.txtCompanySETANumber.Text.ToString();
            CompanyToUpdate.CompanySicCode = this.txtSicCode.Text.ToString();
            this.UpdateCompanyContactDetails(CompanyToUpdate);

            using (var Dbconnection = new MCDEntities())
            {

                Dbconnection.Companies.Attach(CompanyToUpdate);
                Dbconnection.Entry(CompanyToUpdate).State = System.Data.Entity.EntityState.Modified;
                foreach (ContactDetail contactDetailToUpdate in CompanyToUpdate.ContactDetails)
                {
                    Dbconnection.Entry(contactDetailToUpdate).State = System.Data.Entity.EntityState.Modified;
                }
                Dbconnection.SaveChanges();

            };
        }
        #endregion
        #endregion


        #region Company Contacts
        #region Company Contacts Populate Methods
        private void populateCompanyContacts()
        {
            // Data.Models.Company CurrentCompany = (Data.Models.Company)companyBindingSource.Current;

            List<Individual> CompanyContacts = ((Data.Models.Company)companyBindingSource.Current).Individuals.ToList<Individual>();

            individualBindingSource.DataSource = (from a in CompanyContacts
                                                  where a.IndividualFirstName.ToLower().Contains(SerachCriteriaContactName)
                                                  || a.IndividualSecondName.ToLower().Contains(SerachCriteriaContactName) ||
                                                  a.IndividualLastname.ToLower().Contains(SerachCriteriaContactName)
                                                  select a).ToList<Individual>();
        }
        #endregion

        #region Company Contacts Logical Processing Methods

        #endregion

        #region Company Contacts Controls Events

        private void individualBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.refreshCompanyContactDetails();
        }
        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            frmContacts frm = new frmContacts();

            var IndividualObj = individualBindingSource.Current;

            Data.Models.Company CompanyObj = (Data.Models.Company)companyBindingSource.Current;

            Individual IndividualToUpdate = null;
            foreach (Individual CurrentIndividualObj in CompanyObj.Individuals)
            {
                System.Type type = IndividualObj.GetType();
                if (CurrentIndividualObj.IndividualID == (int)type.GetProperty("IndividualID").GetValue(IndividualObj, null))
                {
                    IndividualToUpdate = CurrentIndividualObj;
                }
            }
            if (IndividualToUpdate != null)
            {
                frm.CurrentContact = IndividualToUpdate;
                frm.IndividualID = IndividualToUpdate.IndividualID;
                frm.ShowDialog();
                this.refreshCompanyContacts();
            }
        }
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmContacts frm = new frmContacts();
            frm.ShowDialog();
            Data.Models.Company CompanyObj = (Data.Models.Company)companyBindingSource.Current;

            if (frm.CurrentContact.IndividualID != 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Companies.Attach(CompanyObj);
                    Dbconnection.Individuals.Attach(frm.CurrentContact);
                    CompanyObj.Individuals.Add(frm.CurrentContact);
                    Dbconnection.SaveChanges();
                };
            }
            // CompanyObj.Individuals.Add(NewContact);
            this.refreshCompanyContacts();
        }
        private void btnFilterContacts_Click(object sender, EventArgs e)
        {
            this.setContactNameSearchCriteria();
            this.refreshCompanyContacts();
            this.refreshCompanyContactDetails();
        }

        private void setContactNameSearchCriteria()
        {
            SerachCriteriaContactName = txtContactsFilterCriteria.Text.ToLower().ToString();
        }

        private void btnRefreshContactsearch_Click(object sender, EventArgs e)
        {
            this.txtContactsFilterCriteria.Clear();
            setContactNameSearchCriteria();
            this.refreshCompanyContacts();
            this.refreshCompanyContactDetails();
        }
        #endregion

        #endregion

        #region Company Contact Details
        #region Company Contact Details Populate Methods
        private void populateCompanyContactDetails()
        {
            Individual IndividualObj = (Individual)individualBindingSource.Current;
            //System.Type type = IndividualObj.GetType();
            //var ContactDetialObj = (Individual)type.GetProperty("").GetValue(IndividualObj, null);
            List<ContactDetail> Results = (from a in IndividualObj.ContactDetails
                                           select a).ToList<ContactDetail>();


            contactDetailBindingSource.DataSource = Results;


        }
        #endregion
        #region Company Contact Details logical Processing Methods
        #endregion
        #region  #region Company Contact Controls Events
        private void btnAddContactInfo_Click(object sender, EventArgs e)
        {
            Individual CurrentContact = (Individual)individualBindingSource.Current;
            frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails();
            frm.ShowDialog();
            if (frm.CurrentDetail != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Individuals.Attach(CurrentContact);

                    Dbconnection.ContactDetails.Attach(frm.CurrentDetail);

                    CurrentContact.ContactDetails.Add(frm.CurrentDetail);

                    Dbconnection.SaveChanges();

                    Dbconnection.Entry(frm.CurrentDetail).Reference("LookupContactType").Load();
                };
                this.refreshCompanyContactDetails();
            }

        }
        private void btnUpdateContactDetials_Click(object sender, EventArgs e)
        {
            frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails();
            frm.ContactDetailID = ((ContactDetail)contactDetailBindingSource.Current).ContactDetailID;
            frm.CurrentDetail = (ContactDetail)contactDetailBindingSource.Current;
            frm.ShowDialog();
            if (frm.CurrentDetail != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.ContactDetails.Attach(frm.CurrentDetail);
                    Dbconnection.Entry(frm.CurrentDetail).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                };

                this.refreshCompanyContactDetails();
            }
        }
        private void dgvStudentContactInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ContactDetailObj = (ContactDetail)(row.DataBoundItem);
                    //var lookupAddressTypeObj = AddressObj.LookupAddressType.AddressType;

                    row.Cells[ContactType.Index].Value = ContactDetailObj.LookupContactType.ContactType.ToString();
                }
            }
        }
        #endregion
        #endregion




        #region Company Addresses
        #region Company Address Populate Methods
        private void popoulateCompanyAddresses()
        {
            List<Address> CompanyAddresses = ((Data.Models.Company)companyBindingSource.Current).Addresses.ToList<Data.Models.Address>();
            addressBindingSource.DataSource = CompanyAddresses;
        }
        #endregion
        #region Company Address Logical Processing Methods

        #endregion
        #region Company Address Controls Events
        private void dgvCompanyAddresses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var AddressObj = (Data.Models.Address)(row.DataBoundItem);
                    //var lookupAddressTypeObj = AddressObj.LookupAddressType.AddressType;

                    row.Cells[AddressType.Index].Value = AddressObj.LookupAddressType.AddressType.ToString();
                    row.Cells[Province.Index].Value = AddressObj.LookupProvince.Province.ToString();
                    row.Cells[Country.Index].Value = AddressObj.LookupCountry.CountryName.ToString();
                }
            }
        }
        private void btnAddStudentAddress_Click(object sender, EventArgs e)
        {
            frmAddUpdateAddresses frm = new frmAddUpdateAddresses();

            frm.ShowDialog();

            if (frm.CurrentAddress.AddressID != 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Data.Models.Company CurrentCompany = ((Data.Models.Company)companyBindingSource.Current);
                    Dbconnection.Companies.Attach(CurrentCompany);                 
                    Dbconnection.Addresses.Attach(frm.CurrentAddress);

                    CurrentCompany.Addresses.Add(frm.CurrentAddress);
                    
                    Dbconnection.SaveChanges();
                    Dbconnection.Entry(frm.CurrentAddress).Reference("LookupAddressType").Load();
                    Dbconnection.Entry(frm.CurrentAddress).Reference("LookupProvince").Load();
                    Dbconnection.Entry(frm.CurrentAddress).Reference("LookupCountry").Load();
                };
                refreshCompanyAddresses();
            }
        }
        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            Address CompanyAddressToBeUpdated = (Address)addressBindingSource.Current;
            frmAddUpdateAddresses frm = new frmAddUpdateAddresses();
            frm.AddressID = CompanyAddressToBeUpdated.AddressID;
            frm.CurrentAddress = CompanyAddressToBeUpdated;
            frm.ShowDialog();
            refreshCompanyAddresses();


        }
        #endregion
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            this.setCompanySearchCriteria();
            this.setContactNameSearchCriteria();
            this.refreshCompanies();
            this.refreshCompanyContacts();
            this.refreshCompanyAddresses();
            this.refreshCompanyContactDetails();
        }

    }
}
