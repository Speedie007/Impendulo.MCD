using Impendulo.Data.Models;
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
using Impendulo.Common.Enum;

namespace Impendulo.DashBoardQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Query();


        }

        private void Query()
        {
            using (var Dbconnection = new MCDEntities())
            {
                int _Amount_Enquiy_New = (from a in Dbconnection.Enquiries
                                              /*Include Sections */
                                              from b in a.CurriculumEnquiries

                                              /* Where Sections */
                                          where
                                                /*Filters*/
                                               ( a.EnquiryDate >= dtpFrom.Value &&
                                                a.EnquiryDate <= dtpTo.Value) &&
                                                //Sections
                                                b.Curriculum.DepartmentID == (int)EnumDepartments.Apprenticeship
                                                //Contains Statement
                                                && b.Curriculum.CurriculumName.Contains("")

                                               
                                          select a)
                                          /*Aggregation*/
                                          .Count<Data.Models.Enquiry>();

                MessageBox.Show(_Amount_Enquiy_New.ToString());

            };
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Query();
        }
    }
}
