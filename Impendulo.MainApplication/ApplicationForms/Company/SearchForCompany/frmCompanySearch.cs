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

namespace Impendulo.Company.SearchForCompany.Deployment
{
    public partial class frmCompanySearch : Form
    {
        private string SearchCompanyName { get; set; }
        private string SearchSicNumber { get; set; }
        private string SearchSARSRegNumber { get; set; }
        private string SearchSETANumber { get; set; }

        public Data.Models.Company CurrentCompany { get; set; }

        public frmCompanySearch()
        {
            InitializeComponent();
        }

        private void frmCompanySearch_Load(object sender, EventArgs e)
        {
            this.setSearchVariables();
            this.SearchForCompany();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.setSearchVariables();
            this.SearchForCompany();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSicCode.Text = "";
            this.txtSETANumber.Text = "";
            this.txtSARSRegNumber.Text = "";
            this.txtCompanyName.Text = "";
            this.setSearchVariables();
            SearchForCompany();
        }
        private void setSearchVariables()
        {
            this.SearchCompanyName = this.txtCompanyName.Text;
            this.SearchSicNumber = this.txtSicCode.Text;
            this.SearchSARSRegNumber = txtSARSRegNumber.Text;
            this.SearchSETANumber = txtSETANumber.Text;

        }
        private void SearchForCompany()
        {

            using (var DbConnection = new MCDEntities())
            {
                List<Data.Models.Company> resultByFilter = (from a in DbConnection.Companies
                                                            .Include("Individuals")
                                                            .Include("Individuals.ContactDetails")
                                                            .Include("Individuals.ContactDetails.LookupContactType")
                                                            .Include("Individuals.LookupTitle")
                                                            where
                                                            a.CompanyName.Contains(this.SearchCompanyName) &&
                                                            a.CompanySARSLevyRegistrationNumber.Contains(this.SearchSARSRegNumber) &&
                                                            a.CompanySETANumber.Contains(this.SearchSETANumber) &&
                                                            a.CompanySicCode.Contains(SearchSicNumber)
                                                            select a).Take<Data.Models.Company>(50).ToList<Data.Models.Company>();

                companyBindingSource.DataSource = resultByFilter;
            };
        }

        private void dgvCompanySearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                CurrentCompany = (Data.Models.Company)(senderGrid.Rows[e.RowIndex].DataBoundItem);
                this.Close();
            }
        }
    }
}
