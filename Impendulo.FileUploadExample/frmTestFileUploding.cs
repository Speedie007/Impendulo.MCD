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
using Impendulo.Common.FileHandeling;

namespace Impendulo.FileUploadExample.Development
{
    public partial class frmTestFileUploding : Form
    {
        public frmTestFileUploding()
        {
            InitializeComponent();
        }

        private void frmTestFileUploding_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<File> UploadedFiles = FileHandeling. UploadFile();
            foreach (File CurrentFile in UploadedFiles)
            {
    
            }
        }
    }
}
