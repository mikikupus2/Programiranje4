using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Genericka kolekcija Stack puni se nazivima izabranih fajlova iz nekog foldera na disku, izbor vrisiti pomocu openfiledialog kontrole
elementi stacka koji se izbacuju/uklanjaju. predstavljaju nazive fajlova koje treba iskopirati u folder tmp.
ukoliko folder ne postoji kreirati ga,a obrisati iz izvornog foldera. Sadrzaj Stack-a prikazuje listbox na formi.
za listbox vezati konteksni meni koji omogucava poziv metode koja prikazuje trenutni sadrzaj direktorijuma temp na disku.
maksimalna velicina Stacka je 30 elemenata*/
namespace FajloviStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> fajlovi;

        private void Form1_Load(object sender, EventArgs e)
        {
            fajlovi = new Stack<string>();
        }
        private void dODAJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Multiselect = true;
            if (fd1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in fd1.FileNames)
                {
                    if (fajlovi.Count < 30)
                        fajlovi.Push(filename);
                    else
                    {
                        MessageBox.Show("Stack JE PUN !!!");
                        break;
                    }
                }
            }
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            lbfajlovi.Items.Clear();
            foreach (string filename in fajlovi)
                lbfajlovi.Items.Add(filename);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string pocetni_path = "";
            string odredisni_path = @"D:\\TEMP";
            string ime_fajla = "";
            if (fajlovi.Count > 0)
            {
                pocetni_path = fajlovi.Pop();
                if (!Directory.Exists(odredisni_path))
                    Directory.CreateDirectory(odredisni_path);
                ime_fajla = Path.GetFileName(pocetni_path);
                odredisni_path = Path.Combine(odredisni_path, ime_fajla);
                File.Copy(pocetni_path, odredisni_path, true);
                if (File.Exists(pocetni_path))
                    if(MessageBox.Show("FAJL" + pocetni_path + " CE BITI OBRISAN", "BRISANJE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    File.Delete(pocetni_path);
                UpdateListBox();
            }
            else MessageBox.Show("Stack JE PRAZAN !!!");
        }

        private void pRIKAZITEMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\TEMP";
            ofd.ShowDialog();
        }
    }
}
