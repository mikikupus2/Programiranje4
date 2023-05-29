namespace GrafikaPravougaonik
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
            this.components = new System.ComponentModel.Container();
            this.btdodaj = new System.Windows.Forms.Button();
            this.btobrisi = new System.Windows.Forms.Button();
            this.txtelement = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btdodaj
            // 
            this.btdodaj.Location = new System.Drawing.Point(12, 38);
            this.btdodaj.Name = "btdodaj";
            this.btdodaj.Size = new System.Drawing.Size(100, 23);
            this.btdodaj.TabIndex = 0;
            this.btdodaj.Text = "Dodaj";
            this.btdodaj.UseVisualStyleBackColor = true;
            this.btdodaj.Click += new System.EventHandler(this.btdodaj_Click);
            // 
            // btobrisi
            // 
            this.btobrisi.Location = new System.Drawing.Point(12, 67);
            this.btobrisi.Name = "btobrisi";
            this.btobrisi.Size = new System.Drawing.Size(100, 23);
            this.btobrisi.TabIndex = 1;
            this.btobrisi.Text = "Obrisi";
            this.btobrisi.UseVisualStyleBackColor = true;
            this.btobrisi.Click += new System.EventHandler(this.btobrisi_Click);
            // 
            // txtelement
            // 
            this.txtelement.Location = new System.Drawing.Point(12, 12);
            this.txtelement.Name = "txtelement";
            this.txtelement.Size = new System.Drawing.Size(100, 20);
            this.txtelement.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtelement);
            this.Controls.Add(this.btobrisi);
            this.Controls.Add(this.btdodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdodaj;
        private System.Windows.Forms.Button btobrisi;
        private System.Windows.Forms.TextBox txtelement;
        private System.Windows.Forms.Timer timer1;
    }
}

