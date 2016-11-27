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
using System.Data.SqlClient;

namespace GridViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.refreshGridView();
            this.refreshCotrols();





            int _DepartmentID = Convert.ToInt32(cboDepartments.SelectedValue);

            using (var Dbconnection = new MCDEntities())
            {

                List<Course> AvailableCourses = (from a in Dbconnection.Courses
                                                 where a.DepartmentID == _DepartmentID
                                                 select a).ToList<Course>();

            };


            dataGridView1.EndEdit();

            List<LookupSeta> CoursesToLink = new List<LookupSeta>();
            int iRowCounter = 0;
            foreach (DataRow dtRow in dataGridView1.Rows)
            {
                dtRow.EndEdit();
                if (Convert.ToBoolean(dtRow.Field<DataGridViewCheckBoxCell>(0).Value))
                {
                    setaBindingSource.Position = iRowCounter;
                    CoursesToLink.Add(((LookupSeta)setaBindingSource.Current));
                }
                iRowCounter++;
            }
            using (var Dbconnection = new MCDEntities())
            {

            };



        }

        #region Refresh Controls

        private void refreshGridView()
        {
            this.populateSetaGridview();
            this.SetContorls();

        }
        private void refreshCotrols()
        {

        }





        #endregion



        #region Populate Controls

        private void populateSetaGridview()
        {

            using (var Dbconnection = new Impendulo.Data.Models.MCDEntities())
            {
                setaBindingSource.DataSource = (from a in Dbconnection.LookupSetas
                                                select a).ToList<LookupSeta>();
            };

        }

        #endregion

        #region  Seta Gridview Controls Methods

        private void ClearControls()
        {
            txtSeta.Clear();
            txtSetaName.Clear();
        }
        private void SetContorls()
        {
            if (setaBindingSource.Count > 0)
            {
                LookupSeta setaObj = (LookupSeta)(setaBindingSource.Current);
                txtSeta.Text = setaObj.SetaAbbriviation;
                txtSetaName.Text = setaObj.SetsName;
                btnAddEditSeta.Text = "Update";
            }
            else
            {
                this.ClearControls();
                btnAddEditSeta.Text = "Add";
            }
        }
        #endregion

        #region Seta Adding and Updating Controls
        private void btnAddEditSeta_Click(object sender, EventArgs e)
        {
            if (btnAddEditSeta.Text.ToLower().Equals("add"))
            {
                /*Step 1
               GEt Seta Values
               ***********************************************/
                var newSetaObj = new LookupSeta
                {
                    SetsName = txtSetaName.Text,
                    SetaAbbriviation = txtSeta.Text

                };
                /*Step 2
                Insert Seta Values into Database
                ***********************************************/
                this.insertSeta(newSetaObj);
                /*Step 3
                Refresh Gridview
                ***********************************************/
                this.refreshGridView();
                /*Step 4
                Set Seta Text Controls
                ***********************************************/
                this.SetContorls();

            }
            else
            {

            }


            //if (btnAddEditSeta.Text.ToLower().Equals("add"))
            //{
            //    using (var Dbconnection = new MCDEntities())
            //    {
            //        var newSetaObj = new Seta
            //        {
            //            SetsName = txtSetaName.Text,
            //            SetaAbbriviation = txtSeta.Text

            //        };

            //        Dbconnection.Setas.Add(newSetaObj);
            //        Dbconnection.SaveChanges();
            //        this.refreshGridView();
            //        this.SetContorls();
            //        btnAddEditSeta.Text = "Update";
            //    };
            //}
            //else
            //{
            //    using (var Dbconnection = new MCDEntities())
            //    {
            //        Seta setaObj = (Seta)(setaBindingSource.Current);

            //        setaObj.SetsName = txtSetaName.Text;
            //        setaObj.SetaAbbriviation = txtSeta.Text;

            //        Dbconnection.Entry(setaObj).State = System.Data.Entity.EntityState.Modified;

            //        Dbconnection.SaveChanges();
            //        this.refreshGridView();
            //        this.SetContorls();
            //    };


            //}


        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.ClearControls();
            this.btnAddEditSeta.Text = "Add";
        }

        #endregion

        private void setaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("here");

            this.SetContorls();
        }

        private void insertSeta(LookupSeta setaObj)
        {
            using (var Dbconnection = new Impendulo.Data.Models.MCDEntities())
            {
                Dbconnection.LookupSetas.Add(setaObj);
                Dbconnection.SaveChanges();
            };
        }
        private static void CreateCommand(string queryString, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int icount = reader.RecordsAffected;
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }
            }
        }
    }
}
