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
using Impendulo.Common.Enum;


namespace Impendulo.ReportDemoStudentReport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities()) {
                List<LookupDepartment> curr = (from a in Dbconnection.LookupDepartments
                                   where a.DepartmentID == (int)EnumDepartments.Surface_Mobile_Equipment
                                   && a.DepartmentID == (int)EnumDepartments.Lifting_Operator_Training_LOPT
                                   select a).ToList<LookupDepartment>();

            };
        }
    }
}
