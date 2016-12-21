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

namespace MoveFile
{
    public partial class Form1 : Form
    {
        class searchFile
        {
            static public IEnumerable<FileInfo> GetFilesModifiedInLast24Hours(string path)
            {
                var directory = new DirectoryInfo(path);
                DateTime from_date = DateTime.Now.AddDays(-1);
                DateTime to_date = DateTime.Now;
                var files = directory.GetFiles()
                  .Where(file => file.LastWriteTime >= from_date && file.LastWriteTime <= to_date);
                return files.ToList();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        public void validateUserEntry()
        {

           if (sourceTextBox.Text.Length == 0)
           {
               string message = "Please choose a source folder";
              string caption = "Error Detected in Input";
                
                MessageBox.Show(message, caption);

            }

        }
        
        public void sourcebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceTextBox.Text = folderBrowserDialog1.SelectedPath;

                if (!Directory.Exists(sourceTextBox.Text))
                {
                    MessageBox.Show("not a valid directory." + sourceTextBox.Text);
                }
             
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destinationtextBox.Text = folderBrowserDialog1.SelectedPath;

                if (!Directory.Exists(destinationtextBox.Text))
                {
                    MessageBox.Show("not a valid directory." + destinationtextBox.Text);
                }

            }
        }


        public void moveButton_Click(object sender, EventArgs e)
        {


            validateUserEntry();

            var modifiedFiles = searchFile.GetFilesModifiedInLast24Hours(sourceTextBox.Text);
            var num = 0;

            foreach (var file in modifiedFiles)
            {

                num++;
                File.Copy(file.FullName, Path.Combine(destinationtextBox.Text, file.Name), true);

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

