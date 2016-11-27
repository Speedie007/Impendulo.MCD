using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Impendulo.Data.Models;



namespace Impendulo.StudnetDemo
{
    public partial class Form1 : Form
    {
        public int StudentID { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentID = 3;
            using (var dbConnection = new MCDEntities())
            {
                lookupTitleBindingSource.DataSource = dbConnection.LookupTitles.ToList<LookupTitle>();
                lookupEthnicityBindingSource.DataSource = dbConnection.LookupEthnicities.ToList<LookupEthnicity>();
                lookupGenderBindingSource.DataSource = dbConnection.LookupGenders.ToList<LookupGender>();
                lookupQualificationLevelBindingSource.DataSource = dbConnection.LookupQualificationLevels.ToList<LookupQualificationLevel>();
                lookupMartialStatusBindingSource.DataSource = dbConnection.LookupMartialStatuses.ToList<LookupMartialStatus>();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbConnection = new MCDEntities())
            {
                dbConnection.Students.Add(new Student()
                {
                    EthnicityID = Convert.ToInt32(this.cboStudentEnthnicity.SelectedValue.ToString()),
                    GenderID = Convert.ToInt32(this.cboStudentGender.SelectedValue.ToString()),
                    MartialStatusID = Convert.ToInt32(cboStudentMaritialStatus.SelectedValue.ToString()),
                    QualificationLevelID = Convert.ToInt32(cboStudentQualificationLevel.SelectedValue.ToString()),
                    //TitleID = Convert.ToInt32(cboStudentTitle.SelectedValue.ToString()),
                    //StudentIDNumber = txtStudentIDNumber.Text.ToString(),
                    //StudentFirstName = txtStudentFirstName.Text.ToString(),
                    //StudentLastName = txtStudentLastName.Text.ToString()
                });

                //Saves the New Student To the Database.
                dbConnection.SaveChanges();

            }
        }

        public void SetStudentID(int StudentID)
        {
            MessageBox.Show(StudentID.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.frm1 = this;
            frm2.ShowDialog();
        }
    }
}
