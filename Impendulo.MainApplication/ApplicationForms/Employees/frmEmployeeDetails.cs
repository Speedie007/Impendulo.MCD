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
using Impendulo.Employees.AddUpdateEmployee.Deployment;
using Impendulo.Addresses.Deployment;
using Impendulo.Employees.EmployeeUserNamePassword.Deployment;
using Impendulo.Employees.LinkAssociatedDepartments.Deployment;
using Impendulo.ContactDetails.Deployment;

namespace Impendulo.Employees.Deployment1
{
    public partial class frmAddUpdateEmployeeDetails : Form
    {
        public Employee CurrentEmployee { get; set; }
        public int EmployeeID { get; set; }
        public frmAddUpdateEmployeeDetails()
        {
            EmployeeID = 0;
            InitializeComponent();
        }

        private void refreshEmpoyeeDetils()
        {
            populateEmployeeDetails();
        }
        private void refreshEmployeeAddressDetails()
        {
            if (employeeBindingSource.Count > 0)
            {
                this.populateEmployeeAddressDetails();
            }
        }
        private void refreshEmployeeContactDetails()
        {
            if (employeeBindingSource.Count > 0)
            {
                this.populateEmployeeContactDetails();
            }
        }



        private void frmAddUpdateEmployeeDetails_Load(object sender, EventArgs e)
        {
            setFilterCriteria();
            refreshEmpoyeeDetils();
            refreshEmployeeAddressDetails();
            refreshEmployeeContactDetails();
        }

        #region Employee Detials

        #region Employee Details Populate Methods
        private void populateEmployeeDetails()
        {
            using (var Dbconnection = new MCDEntities())
            {
                List<Employee> AllEmployees = (from a in Dbconnection.Employees
                                                    .Include("Individual.LookupTitle")
                                                        .Include("Individual.Addresses")
                                                        .Include("Individual.ContactDetails")
                                                        .Include("Individual.ContactDetails.LookupContactType")
                                                        .Include("Individual.Addresses.LookupAddressType")
                                                        .Include("Individual.Addresses.LookupProvince")
                                                        .Include("Individual.Addresses.LookupCountry")
                                                        .Include("Logins")

                                               where a.Individual.IndividualFirstName.Contains(this.SearchEmployeeName)
                                               || a.Individual.IndividualSecondName.Contains(this.SearchEmployeeName)
                                               || a.Individual.IndividualLastname.Contains(this.SearchEmployeeName)

                                               orderby a.Individual.IndividualFirstName
                                               select a).ToList<Employee>();
                if (AllEmployees.Count > 0)
                {
                    employeeBindingSource.DataSource = AllEmployees;
                }
                else
                {
                    employeeBindingSource.Clear();
                    addressesBindingSource.Clear();
                    contactDetailBindingSource.Clear();
                }


            };
        }
        #endregion

        #region Employee Details Logical Methods

        #endregion

        #region Employee Details Control Events
        private void dgvEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.CurrentEmployee = new Employee();

            frm.ShowDialog();

            this.refreshEmpoyeeDetils();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();
            frm.CurrentEmployee = (Employee)employeeBindingSource.Current;

            frm.ShowDialog();

            int currentEmployeeID = ((Employee)employeeBindingSource.Current).EmployeeID;

            this.refreshEmpoyeeDetils();

            int iCurrentIndex = 0;
            foreach (Employee EmployeeObj in employeeBindingSource.List)
            {
                if (EmployeeObj.EmployeeID == currentEmployeeID)
                {
                    employeeBindingSource.Position = iCurrentIndex;
                }
                iCurrentIndex++;
            }
        }
        private void dgvEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var EmployeeObj = (Employee)(row.DataBoundItem);
                    row.Cells[EmployeeName.Index].Value = EmployeeObj.Individual.IndividualFirstName.ToString() + " " + EmployeeObj.Individual.IndividualSecondName.ToString() + " " + EmployeeObj.Individual.IndividualLastname.ToString();
                }
            }
        }
        #endregion
        #endregion

        #region Employee Address Details

        #region Employee Address Details Populate Methods
        private void populateEmployeeAddressDetails()
        {
            Employee CurrentEmployee = (Employee)this.employeeBindingSource.Current;
            addressesBindingSource.DataSource = (from a in CurrentEmployee.Individual.Addresses
                                                 select a).ToList<Address>();
        }

        #endregion

        #region Employee Address Details Controls Event Methods
        private void dgvEmployeeAddresses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var AddressObj = (Data.Models.Address)(row.DataBoundItem);
                    row.Cells[AddressType.Index].Value = AddressObj.LookupAddressType.AddressType.ToString();
                    row.Cells[Province.Index].Value = AddressObj.LookupProvince.Province.ToString();
                    row.Cells[Country.Index].Value = AddressObj.LookupCountry.CountryName.ToString();
                }
            }
        }
        private void dgvEmployeeAddresses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            Address EmployeeAddressToBeUpdated = (Address)addressesBindingSource.Current;
            frmAddUpdateAddresses frm = new frmAddUpdateAddresses();
            frm.AddressID = EmployeeAddressToBeUpdated.AddressID;
            frm.CurrentAddress = EmployeeAddressToBeUpdated;
            frm.ShowDialog();
            refreshEmployeeAddressDetails();
        }
        private void btnAddEmployeeAddress_Click(object sender, EventArgs e)
        {
            frmAddUpdateAddresses frm = new frmAddUpdateAddresses();
            Address NewAddress = new Address
            {
                AddressID = 0
            };
            frm.CurrentAddress = NewAddress;
            frm.ShowDialog();
            if (frm.CurrentAddress.AddressID != 0)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Employee CurrentEmployee = ((Employee)employeeBindingSource.Current);

                    Dbconnection.Employees.Attach(CurrentEmployee);
                    Dbconnection.Addresses.Attach(frm.CurrentAddress);

                    CurrentEmployee.Individual.Addresses.Add(frm.CurrentAddress);

                    Dbconnection.SaveChanges();

                   // Dbconnection.Entry(CurrentEmployee).Reference(a => a.Individual.Addresses).Load();
                    //                Dbconnection.Entry(CurrentEmployee).Reference(a => a.LookupProvince).Load();
                    ////                    Dbconnection.Entry(CurrentEmployee).Reference(a => a.LookupCountry).Load();
                };
                refreshEmployeeAddressDetails();
            }
        }
        #endregion
        #endregion

        #region Employee Contact Details

        #region Employee Contact Details Populate Methods
        private void populateEmployeeContactDetails()
        {
            Employee CurrentEmpolyeeObj = (Employee)employeeBindingSource.Current;

            List<ContactDetail> result = (from a in CurrentEmpolyeeObj.Individual.ContactDetails
                                          select a).ToList<ContactDetail>();
            contactDetailsBindingSource.DataSource = result;
        }
        #endregion

        #region Employee Conact Details Controls Events
        private void contactDetailDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var ContactDetailObj = (ContactDetail)(row.DataBoundItem);
                    row.Cells[EmployeeName.Index].Value = ContactDetailObj.LookupContactType.ContactType.ToString();
                }
            }
        }

        private void btnAddContactInfo_Click(object sender, EventArgs e)
        {
            Employee CurrentEmployeeObj = (Employee)employeeBindingSource.Current;
            frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails();
            frm.ShowDialog();
            if (frm.CurrentDetail != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.Employees.Attach(CurrentEmployeeObj);

                    Dbconnection.ContactDetails.Attach(frm.CurrentDetail);

                    CurrentEmployeeObj.Individual.ContactDetails.Add(frm.CurrentDetail);

                    Dbconnection.SaveChanges();

                    Dbconnection.Entry(frm.CurrentDetail).Reference("LookupContactType").Load();
                };
                this.refreshEmployeeContactDetails();
            }
        }

        private void btnUpdateContactDetials_Click(object sender, EventArgs e)
        {
            frmAddUpdateContactDetails frm = new frmAddUpdateContactDetails();
            frm.ContactDetailID = ((ContactDetail)contactDetailsBindingSource.Current).ContactDetailID;
            frm.CurrentDetail = (ContactDetail)contactDetailsBindingSource.Current;
            frm.ShowDialog();
            if (frm.CurrentDetail != null)
            {
                using (var Dbconnection = new MCDEntities())
                {
                    Dbconnection.ContactDetails.Attach(frm.CurrentDetail);
                    Dbconnection.Entry(frm.CurrentDetail).State = System.Data.Entity.EntityState.Modified;
                    Dbconnection.SaveChanges();
                };

                this.refreshEmployeeContactDetails();
            }
        }
        private void contactDetailDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }






        #endregion

        #endregion

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            refreshEmpoyeeDetils();
            refreshEmployeeAddressDetails();
            refreshEmployeeContactDetails();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (var Dbconnection = new MCDEntities())
                {


                };
            }
        }

        private void btnFilterEmployees_Click(object sender, EventArgs e)
        {
            this.setFilterCriteria();
            this.refreshEmpoyeeDetils();
            this.refreshEmployeeAddressDetails();
            this.refreshEmployeeContactDetails();
        }
        private string SearchEmployeeName { get; set; }
        private void setFilterCriteria()
        {
            SearchEmployeeName = txtEmployeeFilterCriteria.Text.ToLower().ToString();
        }
        private void resetFilterCriteria()
        {
            SearchEmployeeName = "";
            txtEmployeeFilterCriteria.Clear();
        }
        private void btnRefreshEmployeeSearch_Click(object sender, EventArgs e)
        {
            resetFilterCriteria();
            this.refreshEmpoyeeDetils();
            this.refreshEmployeeAddressDetails();
            this.refreshEmployeeContactDetails();
        }

        private void btnUsernamePassword_Click(object sender, EventArgs e)
        {
            frmEmployeeUserNamePassword frm = new frmEmployeeUserNamePassword();
            frm.CurrentEmployee = (Employee)employeeBindingSource.Current;
            frm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployeeAssociatedDepartments frm = new frmEmployeeAssociatedDepartments();
            frm.CurrentEmployee = (Employee)employeeBindingSource.Current;
            frm.ShowDialog();
        }

        private void btnRemoveStudentClientInfo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    Employee CurrentEmployeeObj = (Employee)employeeBindingSource.Current;
                    ContactDetail ContactDetailObj = (ContactDetail)contactDetailsBindingSource.Current;

                    Dbconnection.Employees.Attach(CurrentEmployeeObj);

                    Dbconnection.ContactDetails.Attach(ContactDetailObj);

                    CurrentEmployeeObj.Individual.ContactDetails.Remove(ContactDetailObj);

                    Dbconnection.SaveChanges();
                };
                this.refreshEmployeeContactDetails();
            }

        }

        private void btnRemoveStudentAddress_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Remove Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                using (var Dbconnection = new MCDEntities())
                {
                    Employee CurrentEmployeeObj = (Employee)employeeBindingSource.Current;
                    Address AddressObj = (Address)addressesBindingSource.Current;

                    Dbconnection.Employees.Attach(CurrentEmployeeObj);

                    Dbconnection.Addresses.Attach(AddressObj);

                    CurrentEmployeeObj.Individual.Addresses.Remove(AddressObj);

                    Dbconnection.SaveChanges();
                };
                this.refreshEmployeeAddressDetails();
            }
        }
    }
}
