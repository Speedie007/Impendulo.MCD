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

namespace GridViewDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {
                enquiryBindingSource.DataSource = (from a in Dbconnection.Enquiries select a)
                                    .Include("Individuals")
                                    .Include("Individuals.ContactDetails")
                                    .Include("CurriculumEnquiries")
                                                   .ToList();

            };
        }
    }
}
