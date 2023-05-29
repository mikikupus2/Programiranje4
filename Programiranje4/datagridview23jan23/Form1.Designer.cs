namespace datagridview23jan23
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgstudent = new System.Windows.Forms.DataGridView();
            this.btbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtgodina = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtgodina);
            this.panel1.Controls.Add(this.txtprezime);
            this.panel1.Controls.Add(this.txtime);
            this.panel1.Controls.Add(this.txtindex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 129);
            this.panel1.TabIndex = 0;
            // 
            // dgstudent
            // 
            this.dgstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstudent.Location = new System.Drawing.Point(258, 57);
            this.dgstudent.MultiSelect = false;
            this.dgstudent.Name = "dgstudent";
            this.dgstudent.Size = new System.Drawing.Size(515, 285);
            this.dgstudent.TabIndex = 1;
            this.dgstudent.SelectionChanged += new System.EventHandler(this.dgstudent_SelectionChanged);
            // 
            // btbrisi
            // 
            this.btbrisi.Location = new System.Drawing.Point(45, 192);
            this.btbrisi.Name = "btbrisi";
            this.btbrisi.Size = new System.Drawing.Size(207, 150);
            this.btbrisi.TabIndex = 2;
            this.btbrisi.Text = "Brisi";
            this.btbrisi.UseVisualStyleBackColor = true;
            this.btbrisi.Click += new System.EventHandler(this.btbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj indexa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina Studija:";
            // 
            // txtindex
            // 
            this.txtindex.Location = new System.Drawing.Point(94, 14);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(100, 20);
            this.txtindex.TabIndex = 4;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(94, 40);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(100, 20);
            this.txtime.TabIndex = 5;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(94, 66);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(100, 20);
            this.txtprezime.TabIndex = 6;
            // 
            // txtgodina
            // 
            this.txtgodina.Location = new System.Drawing.Point(94, 92);
            this.txtgodina.Name = "txtgodina";
            this.txtgodina.Size = new System.Drawing.Size(100, 20);
            this.txtgodina.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbrisi);
            this.Controls.Add(this.dgstudent);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtgodina;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgstudent;
        private System.Windows.Forms.Button btbrisi;
    }
}

