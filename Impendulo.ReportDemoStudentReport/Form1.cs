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
using Impendulo.ReportDemoStudentReport.Reports;

namespace Impendulo.ReportDemoStudentReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities()) {
                BindingSource bs = new BindingSource();
                bs.DataSource = (from a in Dbconnection.Students
                                 select a) .ToList<Student>();
                StudentReports rpt = new StudentReports();
                rpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            };
          
        }
    }
}
