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

using Impendulo.StudentInfoReports.Reports;

namespace Impendulo.StudentInfoReports.Development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                rptStudentInfo rpt = new rptStudentInfo();
                List<Report_StudentInfo_Result> ds = Dbconnection.Report_StudentInfo().ToList<Report_StudentInfo_Result>();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
