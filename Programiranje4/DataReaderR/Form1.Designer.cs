namespace DataReaderR
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
            this.tabbibl = new System.Windows.Forms.TabControl();
            this.citaoci = new System.Windows.Forms.TabPage();
            this.autor = new System.Windows.Forms.TabPage();
            this.knjige = new System.Windows.Forms.TabPage();
            this.dGVCitaoci = new System.Windows.Forms.DataGridView();
            this.btprikazi = new System.Windows.Forms.Button();
            this.txtmesto = new System.Windows.Forms.TextBox();
            this.txtcitalac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvautor = new System.Windows.Forms.DataGridView();
            this.tabbibl.SuspendLayout();
            this.citaoci.SuspendLayout();
            this.autor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCitaoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvautor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbibl
            // 
            this.tabbibl.Controls.Add(this.citaoci);
            this.tabbibl.Controls.Add(this.autor);
            this.tabbibl.Controls.Add(this.knjige);
            this.tabbibl.Location = new System.Drawing.Point(54, 26);
            this.tabbibl.Name = "tabbibl";
            this.tabbibl.SelectedIndex = 0;
            this.tabbibl.Size = new System.Drawing.Size(634, 369);
            this.tabbibl.TabIndex = 0;
            this.tabbibl.SelectedIndexChanged += new System.EventHandler(this.tabbibl_SelectedIndexChanged);
            // 
            // citaoci
            // 
            this.citaoci.Controls.Add(this.txtmesto);
            this.citaoci.Controls.Add(this.btprikazi);
            this.citaoci.Controls.Add(this.dGVCitaoci);
            this.citaoci.Location = new System.Drawing.Point(4, 22);
            this.citaoci.Name = "citaoci";
            this.citaoci.Size = new System.Drawing.Size(626, 343);
            this.citaoci.TabIndex = 0;
            this.citaoci.Text = "CITAOCI";
            this.citaoci.UseVisualStyleBackColor = true;
            // 
            // autor
            // 
            this.autor.Controls.Add(this.dgvautor);
            this.autor.Controls.Add(this.button1);
            this.autor.Controls.Add(this.txtcitalac);
            this.autor.Location = new System.Drawing.Point(4, 22);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(626, 343);
            this.autor.TabIndex = 1;
            this.autor.Text = "AUTOR";
            this.autor.UseVisualStyleBackColor = true;
            // 
            // knjige
            // 
            this.knjige.Location = new System.Drawing.Point(4, 22);
            this.knjige.Name = "knjige";
            this.knjige.Size = new System.Drawing.Size(192, 74);
            this.knjige.TabIndex = 2;
            this.knjige.Text = "KNJIGE";
            this.knjige.UseVisualStyleBackColor = true;
            // 
            // dGVCitaoci
            // 
            this.dGVCitaoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCitaoci.Location = new System.Drawing.Point(49, 24);
            this.dGVCitaoci.Name = "dGVCitaoci";
            this.dGVCitaoci.Size = new System.Drawing.Size(537, 218);
            this.dGVCitaoci.TabIndex = 0;
            // 
            // btprikazi
            // 
            this.btprikazi.Location = new System.Drawing.Point(274, 279);
            this.btprikazi.Name = "btprikazi";
            this.btprikazi.Size = new System.Drawing.Size(75, 23);
            this.btprikazi.TabIndex = 1;
            this.btprikazi.Text = "PRIKAZI";
            this.btprikazi.UseVisualStyleBackColor = true;
            this.btprikazi.Click += new System.EventHandler(this.btprikazi_Click);
            // 
            // txtmesto
            // 
            this.txtmesto.Location = new System.Drawing.Point(113, 281);
            this.txtmesto.Name = "txtmesto";
            this.txtmesto.Size = new System.Drawing.Size(100, 20);
            this.txtmesto.TabIndex = 2;
            // 
            // txtcitalac
            // 
            this.txtcitalac.Location = new System.Drawing.Point(47, 83);
            this.txtcitalac.Name = "txtcitalac";
            this.txtcitalac.Size = new System.Drawing.Size(100, 20);
            this.txtcitalac.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvautor
            // 
            this.dgvautor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvautor.Location = new System.Drawing.Point(231, 33);
            this.dgvautor.Name = "dgvautor";
            this.dgvautor.Size = new System.Drawing.Size(334, 268);
            this.dgvautor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabbibl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabbibl.ResumeLayout(false);
            this.citaoci.ResumeLayout(false);
            this.citaoci.PerformLayout();
            this.autor.ResumeLayout(false);
            this.autor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCitaoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvautor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabbibl;
        private System.Windows.Forms.TabPage citaoci;
        private System.Windows.Forms.Button btprikazi;
        private System.Windows.Forms.DataGridView dGVCitaoci;
        private System.Windows.Forms.TabPage autor;
        private System.Windows.Forms.TabPage knjige;
        private System.Windows.Forms.TextBox txtmesto;
        private System.Windows.Forms.TextBox txtcitalac;
        private System.Windows.Forms.DataGridView dgvautor;
        private System.Windows.Forms.Button button1;
    }
}

