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

namespace Impendulo.Courses
{
    public partial class frmLinkCourseToDepartmentV3 : Form
    {
        public int _CourseCategoryID = 0;
        public frmLinkCourseToDepartmentV3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            using (var DbConnection = new MCDEntities())
            {
                //var _Course = new Course()
                //{
                //    CourseName = txtNewCourse.Text.ToString(),
                //    //CourseCategoryID = _CourseCategoryID
                //};

                //DbConnection.Courses.Add(_Course);
                DbConnection.SaveChanges();
            }

            this.Close();
        }

        private void btnCloseCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
