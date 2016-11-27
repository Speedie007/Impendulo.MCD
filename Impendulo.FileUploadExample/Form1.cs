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

namespace Impendulo.FileUploadExample.Development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int FileImageId { get; set; }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            this.openFileDialogOpenFiles.ShowDialog();
            if (openFileDialogOpenFiles.FileNames.Count() > 0)
            {
                //Char FileSplitdelimiter = new  Char();
                //FileSplitdelimiter = ".";


                using (var DbConnection = new MCDEntities())
                {
                    foreach (string LocalFileName in openFileDialogOpenFiles.FileNames)
                    {

                        FileInfo fileInfo = new FileInfo(LocalFileName);
                        FileStream fs;
                        BinaryReader br;
                        Byte[] fileToUpload = new Byte[Convert.ToInt32(fileInfo.Length)];

                        try
                        {
                            fs = new FileStream(LocalFileName, FileMode.Open, FileAccess.Read);
                            br = new BinaryReader(fs);
                            fileToUpload = br.ReadBytes(Convert.ToInt32(fileInfo.Length));
                            this.SaveImageToDatabase(fileInfo, fileToUpload);
                            if (br != null)
                            {
                                br.Close();
                            }
                            if (fs != null)
                            {
                                fs.Close();
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        };





                    }
                };

            }
        }

        private void SaveImageToDatabase(FileInfo info, Byte[] FileImage)
        {
            Char delimiter = '.';
            //var newFile = new Impendulo.Data.Models.Image
            //{
            //    FileName = info.Name.Split(delimiter)[0],
            //    FileExtension = info.Extension.Replace(".", ""),
            //    ContentType = "",
            //    DateCreated = DateTime.Now,
            //    FileImage = FileImage
            //};

            using (var DbConnection = new MCDEntities())
            {
               // DbConnection.Images.Add(newFile);
                DbConnection.SaveChanges();
               // FileImageId = newFile.ImageID;
            };
        }
        //private Impendulo.Data.Models.Image GetFileImageObj()
        //{
        //    Impendulo.Data.Models.Image MyDocument;

        //    using (var DbConnection = new MCDEntities())
        //    {
        //        MyDocument = (from a in DbConnection.Images
        //                      where a.ImageID == FileImageId
        //                      select a).FirstOrDefault<Impendulo.Data.Models.Image>();
        //    }
        //    return MyDocument;
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            //MemoryStream ms = new MemoryStream(GetFileImageObj().FileImage);
            //System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            //pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            //pictureBox1.Image = returnImage;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
