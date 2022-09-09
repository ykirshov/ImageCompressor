using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            { 
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    OriginalSize.Clear();
                    ActualLevel.Clear();
                    ActualSize.Clear();

                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    Bitmap bmp = new Bitmap(filePath);
                    PictureOld.Image = bmp;
                    PictureOld.Image.Tag = filePath;
                    OriginalSize.Text = ImageHandler.GetFileSize(filePath).ToFileSizeApi();
                }
            }
        }

        private void ButtonCompress_Click(object sender, EventArgs e)
        {
            DateTime start_time = DateTime.Now;
            Cursor = Cursors.WaitCursor;

            // Save with the indicated maximum file size.
            long max_size = 1024 * long.Parse(MaxSize.Value.ToString());
            int level;
            byte[] data = ImageHandler.SaveJpgAtFileSize(PictureOld.Image, max_size, out level);
            ActualLevel.Text = level.ToString();
            

            // Display the file.
            PictureNew.Image = ImageHandler.GetImageFromByteArray(data);

            // Display the actual size.
            ActualSize.Text = ((long)data.Length).ToFileSizeApi();

            Cursor = Cursors.Default;
            DateTime stop_time = DateTime.Now;
            TimeSpan elapsed = stop_time - start_time;
            Console.WriteLine("Level: " + ActualLevel.Text +
                ", Size: " + ActualSize.Text +
                ", Time: " + elapsed.TotalSeconds.ToString("0.00") + " sec");

        }
    }
}
