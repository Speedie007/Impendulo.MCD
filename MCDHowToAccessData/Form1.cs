using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Impendulo.Data;
//using Impendulo.Data.Models;

namespace MCDHowToAccessData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //    using (var dbConnection = new MCDEntities())
        //    {
        //        //example of how to populate the data source for the title combo box
        //        lookupTitleBindingSource.DataSource = dbConnection.LookupTitles.ToList<LookupTitle>();
        //        lookupQualificationLevelBindingSource.DataSource = dbConnection.LookupQualificationLevels.ToList<LookupQualificationLevel>();

        //        lookupMartialStatusBindingSource.DataSource = dbConnection.LookupMartialStatuses.ToList<LookupMartialStatus>();
        //        lookupGenderBindingSource.DataSource = dbConnection.LookupGenders.ToList<LookupGender>();

        //        //how to populate the combobox without a binding data source.
        //        cboStudentEnthnicity.DataSource = dbConnection.LookupEthnicities.ToList<LookupEthnicity>();
        //        cboStudentEnthnicity.ValueMember = "EthnicityID";
        //        cboStudentEnthnicity.DisplayMember = "Ethnicity";




        //    }

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (var dbConnection = new MCDEntities())
        //    {
        //        dbConnection.Students.Add(new Student()
        //        {
        //            EthnicityID = Convert.ToInt32(this.cboStudentEnthnicity.SelectedValue.ToString()),
        //            GenderID = Convert.ToInt32(this.cboStudentGender.SelectedValue.ToString()),
        //            MartialStatusID = Convert.ToInt32(cboStudentMaritialStatus.SelectedValue.ToString()),
        //            QualificationLevelID = Convert.ToInt32(cboStudentQualificationLevel.SelectedValue.ToString()),
        //            //TitleID = Convert.ToInt32(cboStudentTitle.SelectedValue.ToString()),
        //            //StudentIDNumber = txtStudentIDNumber.Text.ToString(),
        //            //StudentFirstName = txtStudentLastName.Text.ToString(),
        //            //StudentLastName = txtStudentLastName.Text.ToString()
        //        });

        //        //Saves the New Student To the Database.
        //        dbConnection.SaveChanges();

        //    }
        //}
    }
}
