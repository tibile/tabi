using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_folderPathJpeg_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_jpeg.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_folderPathRaw_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                this.txt_raw.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void btn_folderPathSaveTo_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
            {
                this.txt_saveto.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(txt_jpeg.SelectedText)) && (!string.IsNullOrWhiteSpace(txt_raw.SelectedText)) && (!string.IsNullOrWhiteSpace(txt_saveto.SelectedText)))
            {
                DirectoryInfo saveTOFolder = new DirectoryInfo(this.txt_saveto.SelectedText);
                DirectoryInfo jpegFolder = new DirectoryInfo(this.txt_jpeg.SelectedText);
                DirectoryInfo rawFolder = new DirectoryInfo(this.txt_jpeg.SelectedText);
                FileInfo[] jpegFiles = jpegFolder.GetFiles("*.JPG");
                FileInfo[] rawFiles = rawFolder.GetFiles("*.*");

                for (int i = 0; i < jpegFiles.Length; i++)
                {
                    for (int y = 0; i < rawFiles.Length; y++)
                    {
                        if (jpegFiles[i].ToString().Contains(rawFiles[y].ToString()))
                        {
                            foreach (var file in Directory.GetFiles(rawFolder.ToString()))
                                File.Copy(rawFiles[y].ToString(), Path.Combine(saveTOFolder.ToString(), Path.GetFileName(file)), true);
                        }
                    }
                }
                MessageBox.Show("Apps is awesome.");
            }
            MessageBox.Show("Please select all folders!");
        }
    }
}
