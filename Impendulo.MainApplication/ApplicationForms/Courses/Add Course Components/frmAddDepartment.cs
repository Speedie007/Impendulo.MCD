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

namespace Impendulo.Courses.InputForms.Deployment
{
    public partial class frmAddDepartment : Form
    {
        public frmAddDepartment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                LookupDepartment newDep = new LookupDepartment()
                {
                    DepartmentName = this.txtAddDepartment.Text.ToString()
                };

                DbConnection.LookupDepartments.Add(newDep);
                DbConnection.SaveChanges();
                this.Close();
            }
        }

        private void frmAddDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
