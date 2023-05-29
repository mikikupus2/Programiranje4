namespace baze_5
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
            this.dgCitalac = new System.Windows.Forms.DataGridView();
            this.txtci = new System.Windows.Forms.TextBox();
            this.txtmbr = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtmesto = new System.Windows.Forms.TextBox();
            this.txtadresa = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btizmeni = new System.Windows.Forms.Button();
            this.btbrisi = new System.Windows.Forms.Button();
            this.btdodaj = new System.Windows.Forms.Button();
            this.btprikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitalac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCitalac
            // 
            this.dgCitalac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitalac.Location = new System.Drawing.Point(233, 12);
            this.dgCitalac.Name = "dgCitalac";
            this.dgCitalac.Size = new System.Drawing.Size(555, 299);
            this.dgCitalac.TabIndex = 0;
            this.dgCitalac.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCitalac_RowHeaderMouseClick);
            this.dgCitalac.SelectionChanged += new System.EventHandler(this.dgCitalac_SelectionChanged);
            // 
            // txtci
            // 
            this.txtci.Location = new System.Drawing.Point(76, 13);
            this.txtci.Name = "txtci";
            this.txtci.Size = new System.Drawing.Size(128, 20);
            this.txtci.TabIndex = 1;
            // 
            // txtmbr
            // 
            this.txtmbr.Location = new System.Drawing.Point(76, 60);
            this.txtmbr.Name = "txtmbr";
            this.txtmbr.Size = new System.Drawing.Size(128, 20);
            this.txtmbr.TabIndex = 2;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(76, 106);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(128, 20);
            this.txtime.TabIndex = 3;
            // 
            // txtmesto
            // 
            this.txtmesto.Location = new System.Drawing.Point(76, 195);
            this.txtmesto.Name = "txtmesto";
            this.txtmesto.Size = new System.Drawing.Size(128, 20);
            this.txtmesto.TabIndex = 4;
            // 
            // txtadresa
            // 
            this.txtadresa.Location = new System.Drawing.Point(76, 243);
            this.txtadresa.Name = "txtadresa";
            this.txtadresa.Size = new System.Drawing.Size(128, 20);
            this.txtadresa.TabIndex = 5;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(76, 290);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(128, 20);
            this.txttelefon.TabIndex = 6;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(76, 154);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(128, 20);
            this.txtprezime.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CitalacID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MaticniBroj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon";
            // 
            // btizmeni
            // 
            this.btizmeni.Location = new System.Drawing.Point(618, 372);
            this.btizmeni.Name = "btizmeni";
            this.btizmeni.Size = new System.Drawing.Size(75, 23);
            this.btizmeni.TabIndex = 15;
            this.btizmeni.Text = "Izmeni";
            this.btizmeni.UseVisualStyleBackColor = true;
            // 
            // btbrisi
            // 
            this.btbrisi.Location = new System.Drawing.Point(513, 372);
            this.btbrisi.Name = "btbrisi";
            this.btbrisi.Size = new System.Drawing.Size(75, 23);
            this.btbrisi.TabIndex = 16;
            this.btbrisi.Text = "Brisi";
            this.btbrisi.UseVisualStyleBackColor = true;
            // 
            // btdodaj
            // 
            this.btdodaj.Location = new System.Drawing.Point(412, 372);
            this.btdodaj.Name = "btdodaj";
            this.btdodaj.Size = new System.Drawing.Size(75, 23);
            this.btdodaj.TabIndex = 17;
            this.btdodaj.Text = "Dodaj";
            this.btdodaj.UseVisualStyleBackColor = true;
            this.btdodaj.Click += new System.EventHandler(this.btdodaj_Click);
            // 
            // btprikazi
            // 
            this.btprikazi.Location = new System.Drawing.Point(305, 372);
            this.btprikazi.Name = "btprikazi";
            this.btprikazi.Size = new System.Drawing.Size(75, 23);
            this.btprikazi.TabIndex = 18;
            this.btprikazi.Text = "Prikazi";
            this.btprikazi.UseVisualStyleBackColor = true;
            this.btprikazi.Click += new System.EventHandler(this.btprikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btprikazi);
            this.Controls.Add(this.btdodaj);
            this.Controls.Add(this.btbrisi);
            this.Controls.Add(this.btizmeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtadresa);
            this.Controls.Add(this.txtmesto);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.txtmbr);
            this.Controls.Add(this.txtci);
            this.Controls.Add(this.dgCitalac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgCitalac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCitalac;
        private System.Windows.Forms.TextBox txtci;
        private System.Windows.Forms.TextBox txtmbr;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtmesto;
        private System.Windows.Forms.TextBox txtadresa;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btizmeni;
        private System.Windows.Forms.Button btbrisi;
        private System.Windows.Forms.Button btdodaj;
        private System.Windows.Forms.Button btprikazi;
    }
}

