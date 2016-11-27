using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Windows.Forms;
using Impendulo.Data.Models;
using System.Data.Entity;

namespace StudentsReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //using (var Dbconnection = new MCDEntities())
            //{
            //    BindingSource bs = new BindingSource();
            //   List< Student> a  = (from s in Dbconnection.Students
            //                       select s).
            //        ;
            //    ////bs.DataSource = (from a in Dbconnection.Students
            //    ////                 select a).ToList<Student>();
            //    CrystalReport1 rpt = new CrystalReport1();
            //    rpt.SetDataSource(bs);
            //    crystalReportViewer1.ReportSource = rpt;
            //    crystalReportViewer1.RefreshReport();
            //};
        }
    }
}
