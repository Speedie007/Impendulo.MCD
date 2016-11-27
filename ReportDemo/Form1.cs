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

namespace ReportDemo
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
                BindingSource bs = new BindingSource();

                bs.DataSource = (from a in Dbconnection.Students
                                 select a).ToList<Student>();
                StudentReport rpt = new StudentReport();
                rpt.SetDataSource(bs);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            };
        }
    }
}
