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
using System.Reflection;
using Impendulo.Common.Reports;
using Impendulo.Common.ReportDataSources;

namespace Impendulo.StudentReports.Development
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
                var f = (from a in Dbconnection.Students
                         select a).ToList<Student>();
            };
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            using (var Dbconnection = new MCDEntities())
            {

                Impendulo.Common.Reports.rptStudents rpt = new Impendulo.Common.Reports.rptStudents();
                List<Reports_StudentReports_Result> ds = Dbconnection.Reports_StudentReports().ToList<Reports_StudentReports_Result>();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            };
        }

        private void Methods()
        {
            using (var Dbconnection = new MCDEntities())
            {
                Individual newIndividual = new Individual
                {
                    IndividualFirstName = "sdfgas",
                    IndividualLastname = "sdfsdf",
                    IndividualSecondName = "",
                    TitleID = 2,
                    Assessor = new Assessor
                    {
                        AssessorID = 0
                    }
                };

                Dbconnection.Individuals.Add(newIndividual);
                Dbconnection.SaveChanges();
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Methods();
        }
    }
}
