

using Impendulo.WizardForm.ClientEnquiry.Deployment;
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
using Impendulo.Common;

namespace Impendulo.ClientEnquiry.Depolyment
{
    public partial class frmClientEnquiry : Form
    {

        public Employee CurrentEmployeeLoggedIn
        {
            get;
            set;
        }

        #region All Datasets

        #region New Equiry

        #endregion

        #endregion
        public frmClientEnquiry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region All Sections

        #region Common Methods
        private void openNewEnquiry()
        {
            frmNewEnquiry frm = new frmNewEnquiry();
            frm.CurrentEmployeeLoggedIn = this.CurrentEmployeeLoggedIn;
            frm.ShowDialog();
        }
        #endregion

        #region Enquiry Summary Page 

        #region New Equiry Summary Details

        #region Control Events
        private void btnAddNewEnquiry_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.openNewEnquiry();
        }
        #endregion
        #endregion
        #endregion

        #region New Equiry Workbench
        #region Refresh Methods
        private void refreshNewEquiry()
        {
            this.populateNewEquiry();
        }
        private void refreshOverDueEquiry()
        {
            this.populateOverDueEquiry();
        }
        #endregion

        #region Populate Methods
        private void populateNewEquiry()
        {

            using (var Dbconnection = new MCDEntities())
            {
                NewEnquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries
                                                      from b in a.CurriculumEnquiries
                                                      where b.EnquiryStatusID == (int)Common.Enum.EnumEnquiryStatuses.New &&
                                                       (DateTime)a.EnquiryDate <= DateTime.Now.AddDays(2.0)
                                                      select a).ToList<Data.Models.Enquiry>();
            };
        }
        private void populateOverDueEquiry()
        {

            using (var Dbconnection = new MCDEntities())
            {

            };
        }
        #endregion


        #endregion

        #region In Progress Work Bench

        #endregion

        #region Compelted Enquiry Workbench

        #endregion


        #endregion

        private void btnAddNewEnquiry_Click(object sender, EventArgs e)
        {

        }



        private void tabEnquiryWorkbench_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
