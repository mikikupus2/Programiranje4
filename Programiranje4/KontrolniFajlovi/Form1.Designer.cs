namespace KontrolniFajlovi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonDodaj = new System.Windows.Forms.ToolStripButton();
            this.lbfajlovi = new System.Windows.Forms.ListBox();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.BtDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtKreiraj = new System.Windows.Forms.Button();
            this.lbfolder = new System.Windows.Forms.ListBox();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonKreiraj = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.kreirajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDodaj,
            this.toolStripButtonKreiraj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kreirajToolStripMenuItem
            // 
            this.kreirajToolStripMenuItem.Name = "kreirajToolStripMenuItem";
            this.kreirajToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kreirajToolStripMenuItem.Text = "Kreiraj";
            this.kreirajToolStripMenuItem.Click += new System.EventHandler(this.BtKreiraj_Click);
            // 
            // toolStripButtonDodaj
            // 
            this.toolStripButtonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDodaj.Image")));
            this.toolStripButtonDodaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDodaj.Name = "toolStripButtonDodaj";
            this.toolStripButtonDodaj.Size = new System.Drawing.Size(42, 35);
            this.toolStripButtonDodaj.Text = "Dodaj";
            this.toolStripButtonDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDodaj.Click += new System.EventHandler(this.Form1_Load);
            // 
            // lbfajlovi
            // 
            this.lbfajlovi.FormattingEnabled = true;
            this.lbfajlovi.Location = new System.Drawing.Point(526, 65);
            this.lbfajlovi.Name = "lbfajlovi";
            this.lbfajlovi.Size = new System.Drawing.Size(219, 212);
            this.lbfajlovi.TabIndex = 2;
            // 
            // txtfolder
            // 
            this.txtfolder.Location = new System.Drawing.Point(116, 65);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(100, 20);
            this.txtfolder.TabIndex = 3;
            // 
            // BtDodaj
            // 
            this.BtDodaj.Location = new System.Drawing.Point(116, 91);
            this.BtDodaj.Name = "BtDodaj";
            this.BtDodaj.Size = new System.Drawing.Size(100, 34);
            this.BtDodaj.TabIndex = 4;
            this.BtDodaj.Text = "Dodaj";
            this.BtDodaj.UseVisualStyleBackColor = true;
            this.BtDodaj.Click += new System.EventHandler(this.BtDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesite ime foldera:";
            // 
            // BtKreiraj
            // 
            this.BtKreiraj.Location = new System.Drawing.Point(420, 65);
            this.BtKreiraj.Name = "BtKreiraj";
            this.BtKreiraj.Size = new System.Drawing.Size(100, 37);
            this.BtKreiraj.TabIndex = 6;
            this.BtKreiraj.Text = "Kreiraj";
            this.BtKreiraj.UseVisualStyleBackColor = true;
            this.BtKreiraj.Click += new System.EventHandler(this.BtKreiraj_Click);
            // 
            // lbfolder
            // 
            this.lbfolder.FormattingEnabled = true;
            this.lbfolder.Location = new System.Drawing.Point(222, 65);
            this.lbfolder.Name = "lbfolder";
            this.lbfolder.Size = new System.Drawing.Size(192, 225);
            this.lbfolder.TabIndex = 7;
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.BtDodaj_Click);
            // 
            // toolStripButtonKreiraj
            // 
            this.toolStripButtonKreiraj.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKreiraj.Image")));
            this.toolStripButtonKreiraj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKreiraj.Name = "toolStripButtonKreiraj";
            this.toolStripButtonKreiraj.Size = new System.Drawing.Size(44, 35);
            this.toolStripButtonKreiraj.Text = "Kreiraj";
            this.toolStripButtonKreiraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonKreiraj.Click += new System.EventHandler(this.BtKreiraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbfolder);
            this.Controls.Add(this.BtKreiraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtDodaj);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.lbfajlovi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonDodaj;
        private System.Windows.Forms.ListBox lbfajlovi;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.Button BtDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtKreiraj;
        private System.Windows.Forms.ListBox lbfolder;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonKreiraj;
    }
}

