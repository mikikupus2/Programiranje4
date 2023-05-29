using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*Napisati program koji u listboxu na formi prikazuje sadrzaj nekog foldera na disku.*/
/*U listboxu prikazati nazive selektovanih fajlova iz nekog foldera*/
/*Omoguciti kopiranje selektovanih fajlova u novi folder na disku koji se kreira u folderu/ispod foldera
 iz koga su izabrani fajlovi*/
namespace Fajlovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void Form1_Load(object sender, EventArgs e)
        {
            path = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                path = Path.GetDirectoryName(folderBrowser.FileName);
            }
            if (Directory.Exists(path))
            {
                string[] fajlovi = Directory.GetFiles(path);
                foreach (string f in fajlovi)
                    lbfajlovi.Items.Add(f);
                string[] folderi = Directory.GetDirectories(path);
                foreach (string f in folderi)
                    lbfajlovi.Items.Add(f);
            }
            else MessageBox.Show("Folder ne postoji !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Multiselect = true;
            fd1.Filter = "txt files(*.txt)|*.txt|All files|*.*";
            fd1.FilterIndex = 2;
            fd1.InitialDirectory = @"D:\";

            if(fd1.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in fd1.FileNames)
                    lbf.Items.Add(f);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            string path1 = "";
            string path2 = "";
            string fname1 = "";
            string naziv1, naziv2;
            fd1.Multiselect = true;
            if (fd1.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in fd1.FileNames)
                {
                    path1 = Path.GetDirectoryName(f);
                    fname1 = Path.GetFileName(f);
                    path2 = path1 + "\\Kopija";
                    naziv1 = f;
                    naziv2 = Path.Combine(path2, fname1);
                    if (!Directory.Exists(path2))
                        Directory.CreateDirectory(path2);
                    File.Copy(f, naziv2, true);
                }
            }
        }
    }
}
