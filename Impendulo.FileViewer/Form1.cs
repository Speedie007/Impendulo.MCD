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
using System.IO;
using Impendulo.Email;
using Impendulo.Email.Development;

namespace Impendulo.FileViewer.Development
{
    public partial class Form1 : Form
    {
        public Impendulo.Data.Models.File CurrentFile { get; set; }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            using (var Dbconnection = new MCDEntities())
            {

                CurrentFile = (from a in Dbconnection.Files
                               where a.ImageID == 1029
                               select a).FirstOrDefault<Impendulo.Data.Models.File>();
            };

            //System.IO.File.WriteAllBytes()
            txtFileName.Text = CurrentFile.FileName + " " + CurrentFile.FileExtension;

            if (checkIfTempFolderExists())
            {
                string path = Directory.GetCurrentDirectory() + "\\Temp" + "\\" + CurrentFile.FileName + "." + CurrentFile.FileExtension;
                System.IO.File.WriteAllBytes(path, CurrentFile.FileImage);
                wbFileDisplay.Navigate(new System.Uri("file:///" + path, System.UriKind.Absolute), "_top", CurrentFile.FileImage,null);
               // wbFileDisplay.Url = new System.Uri("file:///" + path, System.UriKind.Absolute);
                wbFileDisplay.Refresh();


            }
        }

        private Boolean checkIfTempFolderExists()
        {
            Boolean FolderExists = false;
            string path = Directory.GetCurrentDirectory() + "\\Temp";
            if ((Directory.Exists(path)))
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
                FolderExists = true;
            }
            else
            {
                Directory.CreateDirectory(path);
                FolderExists = true;
            }

            return FolderExists;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            folderBrowserDialogForDownloading.ShowDialog();

            string path = folderBrowserDialogForDownloading.SelectedPath + "\\" + CurrentFile.FileName + "." + CurrentFile.FileExtension;
            System.IO.File.WriteAllBytes(path, CurrentFile.FileImage);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmSendEmail frm = new frmSendEmail();
            string path = Directory.GetCurrentDirectory() + "\\Temp" + "\\" + CurrentFile.FileName + "." + CurrentFile.FileExtension;
            frm.Attachments.Add(path);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void wbFileDisplay_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
           
        }
    }
}
