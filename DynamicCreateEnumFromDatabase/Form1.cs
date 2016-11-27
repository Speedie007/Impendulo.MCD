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
using Impendulo.Common.Enum;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DynamicCreateEnumFromDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {

                dataGridView1.DataSource = (from a in Dbconnection.CurriculumCourses.Include("Course")
                                            select a).ToList<CurriculumCourse>();

                
            };

        }
    }
}
