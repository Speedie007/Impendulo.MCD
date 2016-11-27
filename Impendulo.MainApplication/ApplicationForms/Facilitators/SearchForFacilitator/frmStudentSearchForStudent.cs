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
using Impendulo.StudentForms;
using Impendulo.Enrollments;
using Impendulo.MainApplication;
using Impendulo.Enrollments.Deployment;
using Impendulo.StudentEngineeringCourseErollment.Deployment;

namespace Impendulo.Facilitators.Deployment
{
    public partial class frmStudentSearchForFacilitator : Form
    {
        public frmStudentSearchForFacilitator()
        {
            InitializeComponent();
        }

        private int SearchStudentNumber { get; set; }
        private string SearchStudentIDNumber { get; set; }
        private string SearchStudentFirstName { get; set; }
        private string SearchStudentLastName { get; set; }
        public Facilitator CurrentFacilitator { get; set; }

        public frmStudentCourseEnrollmentV2 StudentCourseEnrollmentForm { get; set; }

        public MCDMainForm frmParentForm { get; set; }

        private void frmStudentSearchForFacilitator_Load(object sender, EventArgs e)
        {
            this.setSearchVariables();
            this.SearchForFacilitator();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.setSearchVariables();
            this.SearchForFacilitator();
        }
        private void setSearchVariables()
        {
            this.SearchStudentFirstName = this.txtFirstName.Text;
            this.SearchStudentLastName = txtLastName.Text;

        }
        private void setAddStudentButtonVisablity()
        {
            //if (studentBindingSource.Count == 0)
            //{
            //    picbtnAddStudent.Visible = true;
            //}
            //else
            //{
            //    picbtnAddStudent.Visible = false;
            //}
        }
        private void SearchForFacilitator()
        {

            using (var DbConnection = new MCDEntities())
            {
                List<Facilitator> resultByFilter = (from a in DbConnection.Facilitators
                                                    where
                                                    a.Individual.IndividualFirstName.Contains(this.SearchStudentFirstName) &&
                                                    a.Individual.IndividualLastname.Contains(this.SearchStudentLastName)
                                                    select a).Take<Facilitator>(50).ToList<Facilitator>();

                individualBindingSource.DataSource = resultByFilter;
            };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.setSearchVariables();
            SearchForFacilitator();
        }

        private void dgvStudentSearchResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var gridView = (DataGridView)sender;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    var FacilitatorObj = (Facilitator)(row.DataBoundItem);
                    var IndividualObj = FacilitatorObj.Individual;

                    row.Cells[colFirstName.Index].Value = IndividualObj.IndividualFirstName;
                    row.Cells[colLastName.Index].Value = IndividualObj.IndividualLastname;
                }
            }
        }

        private void dgvStudentSearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                CurrentFacilitator = (Facilitator)(senderGrid.Rows[e.RowIndex].DataBoundItem);

                //if (this.frmParentForm != null)
                //{
                //    foreach (Form f in frmParentForm.MdiChildren)
                //    {
                //        if (f.GetType() == typeof(frmAddUpdateStudent))
                //        {
                //            f.Activate();
                //            f.WindowState = FormWindowState.Maximized;
                //            this.Close();
                //            return;
                //        }
                //    }

                //    frmAddUpdateStudent frm = new frmAddUpdateStudent();
                //    frm.StudentID = stud.StudentID;
                //    frm.MdiParent = frmParentForm;
                //    frm.Show();
                //    this.Close();
                //}
                //MessageBox.Show(stud.StudentID.ToString());
                this.Close();
            }
        }

        private void picbtnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void gbSearchForStudent_Enter(object sender, EventArgs e)
        {

        }
    }
}
