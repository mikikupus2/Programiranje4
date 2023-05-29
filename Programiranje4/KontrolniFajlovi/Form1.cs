using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Nazivi foldera unose se preko textboxa u Queue stringova, omoguciti kreiranje
 ovih foldera u korenskom direktorijumu diska D:, a zatim u prvi od njih iskopirati fajlove
sa proizvoljne putanje izabrane pomocu OpenFileDialoga, nakon toga fajlove kopirati u drugi
folder tako sto se njihovom nazivu dodaje kao prefix Copy1, u sledecem folderu Copy2
Napisati programo koji dodaje u stack nazive foldera koje treba kreirati na disku pocevsi od
 foldera koji se bira pomocu ofd priliom pokretanja programa. Foldere iz stecka na disku kreirati
hijerarhijski jedan unutar drugog,desni klik na listbox prikazuje trenutno poslednju aktivnu putanju.*/
namespace KontrolniFajlovi
{
    public partial class Form1 : Form
    {
        string root = @"D:\";
        Queue<string> red_foldera;
        Stack<string> stack_foldera;
        string temp = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            red_foldera = new Queue<string>();
            stack_foldera = new Stack<string>();
            BtKreiraj.Visible = kreirajToolStripMenuItem.Visible = toolStripButtonKreiraj.Visible = false;
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                stack_foldera.Push(Path.GetDirectoryName(ofd.FileName));
                root = stack_foldera.Peek();
                temp = root;
            }
        }

        private void BtDodaj_Click(object sender, EventArgs e)
        {
            if (txtfolder.Text != "")
            {
                stack_foldera.Push(Path.Combine(temp, txtfolder.Text));
                temp = stack_foldera.Peek();
            }
            else MessageBox.Show("Text box je prazan", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (stack_foldera.Count > 0)
            {
                BtKreiraj.Visible = kreirajToolStripMenuItem.Visible = toolStripButtonKreiraj.Visible = true;
                UpdateLbFolder();
            }
            txtfolder.Text = "";
        }

        private void UpdateLbFolder()
        {
            lbfolder.Items.Clear();
            foreach(string folder in stack_foldera)
                lbfolder.Items.Add(folder);
        }

        private void BtKreiraj_Click(object sender, EventArgs e)
        {
            string temp = root;
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
            foreach(string folder in stack_foldera)
            {
                temp = Path.Combine(folder, Path.GetFileName(folder));
                if (!Directory.Exists(temp))
                {
                    Directory.CreateDirectory(temp);
                }

            }
        }
    }
}
