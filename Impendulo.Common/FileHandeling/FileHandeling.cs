using System;
using System.Collections.Generic;
using System.Linq;

using Impendulo.Data.Models;
using System.Windows.Forms;
using System.IO;

namespace Impendulo.Common.FileHandeling
{

    public static class FileHandeling
    {

        // private static OpenFileDialog openFileDialogOpenFiles { get; set; }
        // public static Impendulo.Data.Models.File[] CurrentlyUploadedFiles { get; set; }

        public static List<Impendulo.Data.Models.File> UploadFile()
        {

            List<Impendulo.Data.Models.File> CurrentlyUploadedFiles = new List<Impendulo.Data.Models.File>();
            OpenFileDialog openFileDialogOpenFiles = new OpenFileDialog();
            openFileDialogOpenFiles.Multiselect = true;
            openFileDialogOpenFiles.ShowDialog();
            if (openFileDialogOpenFiles.FileNames.Count() > 0)
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

                        Char delimiter = '.';
                        var newFile = new Impendulo.Data.Models.File
                        {
                            FileName = fileInfo.Name.Split(delimiter)[0],
                            FileExtension = fileInfo.Extension.Replace(".", ""),
                            ContentType = "",
                            DateCreated = DateTime.Now,
                            FileImage = fileToUpload,
                        };

                        if (br != null)
                        {
                            br.Close();
                        }
                        if (fs != null)
                        {
                            fs.Close();
                        }
                        CurrentlyUploadedFiles.Add(newFile);
                    }
                    catch (Exception)
                    {
                        throw;
                    };

                }
                if (CurrentlyUploadedFiles.Count > 0)
                {
                    using (var DbConnection = new MCDEntities())
                    {
                        DbConnection.Files.AddRange(CurrentlyUploadedFiles);
                        DbConnection.SaveChanges();
                    };
                }
            }
            return CurrentlyUploadedFiles;
        }

        public static Impendulo.Data.Models.File GetFile(int FileID)
        {

            Impendulo.Data.Models.File CurrentFile = null;

            using (var Dbconnection = new MCDEntities())
            {
                CurrentFile = (from a in Dbconnection.Files
                               where a.ImageID == FileID
                               select a).FirstOrDefault<Impendulo.Data.Models.File>();
            };
            return CurrentFile;
        }
    }
}
