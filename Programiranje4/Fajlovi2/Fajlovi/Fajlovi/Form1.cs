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

namespace Fajlovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> stack2;
        Queue<string> red1;
        Queue<string> red2;
        string folder1_path = @"D:\folder1";
        string folder2_path = @"D:\folder2";
        private void Form1_Load(object sender, EventArgs e)
        {
            stack2 = new Stack<string>();
            red1 = new Queue<string>();
            red2 = new Queue<string>();
            /*if(Directory.Exists(folder1_path))
                Directory.Delete(folder1_path, true);
            if (Directory.Exists(folder2_path))
                Directory.Delete(folder2_path, true);*/
            if (!Directory.Exists(folder1_path))
                Directory.CreateDirectory(folder1_path);
            if (!Directory.Exists(folder2_path))
                Directory.CreateDirectory(folder2_path);
        }

        private void toolStripUkloni_Click(object sender, EventArgs e)
        {
            if(red1.Count > 0)
            {
                if (red2.Count < 10)
                {
                    string red1_dequeue = red1.Dequeue();
                    string ime_fajla = Path.GetFileName(red1_dequeue);
                    string odredisni_path = folder2_path;
                    string odredisno_puno_ime_fajla = Path.Combine(odredisni_path, ime_fajla);
                    File.Copy(red1_dequeue, odredisno_puno_ime_fajla, true);
                    if(File.Exists(red1_dequeue))
                        File.Delete(red1_dequeue);
                    red2.Enqueue(odredisno_puno_ime_fajla);
                }
                else
                {
                    red2.Dequeue();
                    string red1_dequeue = red1.Dequeue();
                    string ime_fajla = Path.GetFileName(red1_dequeue);
                    string odredisni_path = folder2_path;
                    string odredisno_puno_ime_fajla = Path.Combine(odredisni_path, ime_fajla);
                    File.Copy(red1_dequeue, odredisno_puno_ime_fajla, true);
                    red2.Dequeue();
                    red2.Enqueue(odredisno_puno_ime_fajla);
                }

            }
            UpdateListBox1();
            UpdateListBox2();
        }

        private void toolStripDodaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (red1.Count + ofd.FileNames.Length <= 10)
                {
                    foreach (string filename in ofd.FileNames)
                    {
                        string ime_fajla = Path.GetFileName(filename);
                        string odredisni_path = folder1_path;
                        string odredisno_puno_ime_fajla = Path.Combine(odredisni_path, ime_fajla);
                        if (filename != odredisno_puno_ime_fajla && !(red1.Contains(odredisno_puno_ime_fajla)))
                        {
                            File.Copy(filename, odredisno_puno_ime_fajla, true);
                            red1.Enqueue(odredisno_puno_ime_fajla);
                        }
                        else MessageBox.Show($"Fajl '{odredisno_puno_ime_fajla}' vec postoji u steku pa nece biti dodat!!!", "Vazno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (ofd.FileNames.Length + red1.Count > 10)
                {
                    MessageBox.Show($"Maksimalan broj fajlova je 10\n(sa ovom selekcijom imali biste {ofd.FileNames.Length + red1.Count} fajlova)","Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else MessageBox.Show("Maksimalan broj fajlova je 10", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateListBox1();
        }
        private void UpdateListBox1()
        {
            listBox1.Items.Clear();
            foreach (string s in red1)
                listBox1.Items.Add(s);
        }
        private void UpdateListBox2()
        {
            listBox2.Items.Clear();
            foreach (string s in red2)
                listBox2.Items.Add(s);
        }
    }
}
