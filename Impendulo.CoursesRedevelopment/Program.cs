using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.Courses;
using Impendulo.Courses.InputForms;
using Impendulo.Courses.Configuration;
using Impendulo.Courses.Configuration.Development;

namespace Impendulo.CoursesRedevelopment.Development
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCourseConfiguration());
        }
    }
}
