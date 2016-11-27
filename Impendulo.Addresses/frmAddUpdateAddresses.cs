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

namespace Impendulo.Addresses.Development
{
    public partial class frmAddUpdateAddresses : Form
    {
        public int AddressID { get; set; }
        public Address CurrentAddress { get; set; }
        public frmAddUpdateAddresses()
        {
            AddressID = 0;
            InitializeComponent();
        }

        private void frmAddresses_Load(object sender, EventArgs e)
        {

            this.populateAddressType();
            this.populateAddressProvinces();
            this.populateAddressCountries();
            if (AddressID != 0)
            {


                if (CurrentAddress != null)
                {
                    cboStudentAddressAddressType.SelectedValue = CurrentAddress.AddressTypeID;
                    cboStudentAddressCountry.SelectedValue = CurrentAddress.CountryID;
                    cboStudentAddressProvince.SelectedValue = CurrentAddress.ProvinceID;
                    chkStudnetAddressIsDefault.Checked = CurrentAddress.AddressIsDefault;
                    cboStudentAddressCountry.SelectedValue = CurrentAddress.CountryID;
                    cboStudentAddressProvince.SelectedValue = CurrentAddress.ProvinceID;
                    txtStudentAddressLineTwo.Text = CurrentAddress.AddressLineTwo;
                    txtStudentAddressLineOne.Text = CurrentAddress.AddressLineOne;
                    txtStudentAddressTown.Text = CurrentAddress.AddressTown;
                    txtStudentAddressSuburb.Text = CurrentAddress.AddressSuburb;
                    txtStudentAddressAreaCode.Text = CurrentAddress.AddressAreaCode;
                }
                else
                {
                    using (var Dbconnection = new MCDEntities())
                    {
                        Address AddressToUpdate = (from a in Dbconnection.Addresses
                                                   where a.AddressID == this.AddressID
                                                   select a).FirstOrDefault<Address>();

                        cboStudentAddressAddressType.SelectedValue = AddressToUpdate.AddressTypeID;
                        cboStudentAddressCountry.SelectedValue = AddressToUpdate.CountryID;
                        cboStudentAddressProvince.SelectedValue = AddressToUpdate.ProvinceID;
                        chkStudnetAddressIsDefault.Checked = AddressToUpdate.AddressIsDefault;
                        cboStudentAddressCountry.SelectedValue = AddressToUpdate.CountryID;
                        cboStudentAddressProvince.SelectedValue = AddressToUpdate.ProvinceID;
                        txtStudentAddressLineTwo.Text = AddressToUpdate.AddressLineTwo;
                        txtStudentAddressLineOne.Text = AddressToUpdate.AddressLineOne;
                        txtStudentAddressTown.Text = AddressToUpdate.AddressTown;
                        txtStudentAddressSuburb.Text = AddressToUpdate.AddressSuburb;
                        txtStudentAddressAreaCode.Text = AddressToUpdate.AddressAreaCode;

                    };
                }
            };
            this.setAddUpdateButtons();
        }
        private void setAddUpdateButtons()
        {
            if (AddressID == 0)
            {
                this.btnAddAddress.Visible = true;
                this.btnUpdateAddress.Visible = false;
            }
            else
            {
                this.btnAddAddress.Visible = false;
                this.btnUpdateAddress.Visible = true;
            }
        }

        private void populateAddressType()
        {
            using (var Dbconnection = new MCDEntities())
            {
                this.lookupAddressTypeBindingSource.DataSource = (from a in Dbconnection.LookupAddressTypes
                                                                  select a).ToList<LookupAddressType>();
            };
        }
        private void populateAddressProvinces()
        {
            using (var Dbconnection = new MCDEntities())
            {
                this.lookupProvinceBindingSource.DataSource = (from a in Dbconnection.LookupProvinces
                                                               select a).ToList<LookupProvince>();
            };
        }
        private void populateAddressCountries()
        {
            using (var Dbconnection = new MCDEntities())
            {
                this.lookupCountryBindingSource.DataSource = (from a in Dbconnection.LookupCountries
                                                              select a).ToList<LookupCountry>();
            };
        }

        private void populateAddress()
        {
            using (var Dbconnection = new MCDEntities())
            {

            };
        }

        private void btnStudentAddressCancelAddUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStudentAddressAddUpdate_Click(object sender, EventArgs e)
        {
            //using (var Dbconnection = new MCDEntities())
            //{
            //    Address AddressToUpdate = (from a in Dbconnection.Addresses
            //                               where a.AddressID == this.AddressID
            //                               select a).FirstOrDefault<Address>();

            //    AddressToUpdate.AddressTypeID = Convert.ToInt32(cboStudentAddressAddressType.SelectedValue);
            //    AddressToUpdate.AddressIsDefault = chkStudnetAddressIsDefault.Checked;
            //    AddressToUpdate.CountryID = Convert.ToInt32(cboStudentAddressCountry.SelectedValue);
            //    AddressToUpdate.ProvinceID = Convert.ToInt32(cboStudentAddressProvince.SelectedValue);
            //    AddressToUpdate.AddressLineTwo = txtStudentAddressLineTwo.Text.ToString();
            //    AddressToUpdate.AddressLineOne = txtStudentAddressLineOne.Text.ToString();
            //    AddressToUpdate.AddressTown = txtStudentAddressTown.Text.ToString();
            //    AddressToUpdate.AddressSuburb = txtStudentAddressSuburb.Text.ToString();
            //    AddressToUpdate.AddressAreaCode = txtStudentAddressAreaCode.Text.ToString();
            //    AddressToUpdate.AddressModifiedDate = DateTime.Now;

            //    Dbconnection.SaveChanges();

            //    Dbconnection.Entry(AddressToUpdate).Reference(a => a.LookupAddressType).Load();
            //    Dbconnection.Entry(AddressToUpdate).Reference(a => a.LookupProvince).Load();
            //    Dbconnection.Entry(AddressToUpdate).Reference(a => a.LookupCountry).Load();


            //};

            using (var Dbconnection = new MCDEntities())
            {
                if (CurrentAddress != null)
                {
                    Dbconnection.Addresses.Attach(CurrentAddress);

                    CurrentAddress.AddressTypeID = Convert.ToInt32(cboStudentAddressAddressType.SelectedValue);
                    CurrentAddress.AddressIsDefault = chkStudnetAddressIsDefault.Checked;
                    CurrentAddress.CountryID = Convert.ToInt32(cboStudentAddressCountry.SelectedValue);
                    CurrentAddress.ProvinceID = Convert.ToInt32(cboStudentAddressProvince.SelectedValue);
                    CurrentAddress.AddressLineTwo = txtStudentAddressLineTwo.Text.ToString();
                    CurrentAddress.AddressLineOne = txtStudentAddressLineOne.Text.ToString();
                    CurrentAddress.AddressTown = txtStudentAddressTown.Text.ToString();
                    CurrentAddress.AddressSuburb = txtStudentAddressSuburb.Text.ToString();
                    CurrentAddress.AddressAreaCode = txtStudentAddressAreaCode.Text.ToString();

                    Dbconnection.SaveChanges();

                    Dbconnection.Entry(CurrentAddress).Reference(a => a.LookupAddressType).Load();
                    Dbconnection.Entry(CurrentAddress).Reference(a => a.LookupProvince).Load();
                    Dbconnection.Entry(CurrentAddress).Reference(a => a.LookupCountry).Load();
                };
            };
            this.Close();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            //Address NewAddress;
            using (var Dbconnection = new MCDEntities())
            {
                CurrentAddress = new Address
                {
                    AddressTypeID = Convert.ToInt32(cboStudentAddressAddressType.SelectedValue),
                    AddressIsDefault = chkStudnetAddressIsDefault.Checked,
                    CountryID = Convert.ToInt32(cboStudentAddressCountry.SelectedValue),
                    ProvinceID = Convert.ToInt32(cboStudentAddressProvince.SelectedValue),
                    AddressLineTwo = txtStudentAddressLineTwo.Text.ToString(),
                    AddressLineOne = txtStudentAddressLineOne.Text.ToString(),
                    AddressTown = txtStudentAddressTown.Text.ToString(),
                    AddressSuburb = txtStudentAddressSuburb.Text.ToString(),
                    AddressAreaCode = txtStudentAddressAreaCode.Text.ToString(),
                    AddressModifiedDate = DateTime.Now
                };
                Dbconnection.Addresses.Add(CurrentAddress);
                Dbconnection.SaveChanges();
            };
            this.Close();
        }
    }
}
