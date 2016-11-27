using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.ViewCurrentCourseSchedules
{
    public partial class ViewCurrentCourseSchedules : Form
    {
        int _CurrentMonth = 0;
        public ViewCurrentCourseSchedules()
        {
            InitializeComponent();
        }

        private void ViewCurrentCourseSchedules_Load(object sender, EventArgs e)
        {
            var myDate = System.DateTime.Now;
            _CurrentMonth = myDate.Month;
            this.setCurrentMonth();

            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

        }

        private void setCurrentMonth()
        {
            lblMonthName.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_CurrentMonth);


        }
    }
}
