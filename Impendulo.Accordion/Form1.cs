using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impendulo.Accordion.Development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelAccordionOne.Height == 0)
            {
                panelAccordionOne.Height = 200;
            }
            else{
                panelAccordionOne.Height = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
