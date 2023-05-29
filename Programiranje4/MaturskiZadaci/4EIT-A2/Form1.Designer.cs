namespace _4EIT_A2
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsifra = new System.Windows.Forms.TextBox();
            this.tbime = new System.Windows.Forms.TextBox();
            this.tbprezime = new System.Windows.Forms.TextBox();
            this.tbrodjen = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tsbtbrisanje = new System.Windows.Forms.ToolStripButton();
            this.tsbtanaliza = new System.Windows.Forms.ToolStripButton();
            this.tsbtoaplikaciji = new System.Windows.Forms.ToolStripButton();
            this.tsbtizlaz = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtbrisanje,
            this.tsbtanaliza,
            this.tsbtoaplikaciji,
            this.tsbtizlaz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rođen";
            // 
            // tbsifra
            // 
            this.tbsifra.Location = new System.Drawing.Point(103, 82);
            this.tbsifra.Name = "tbsifra";
            this.tbsifra.Size = new System.Drawing.Size(142, 20);
            this.tbsifra.TabIndex = 5;
            // 
            // tbime
            // 
            this.tbime.Location = new System.Drawing.Point(103, 108);
            this.tbime.Name = "tbime";
            this.tbime.Size = new System.Drawing.Size(141, 20);
            this.tbime.TabIndex = 6;
            // 
            // tbprezime
            // 
            this.tbprezime.Location = new System.Drawing.Point(103, 137);
            this.tbprezime.Name = "tbprezime";
            this.tbprezime.Size = new System.Drawing.Size(142, 20);
            this.tbprezime.TabIndex = 7;
            // 
            // tbrodjen
            // 
            this.tbrodjen.Location = new System.Drawing.Point(103, 163);
            this.tbrodjen.Name = "tbrodjen";
            this.tbrodjen.Size = new System.Drawing.Size(142, 20);
            this.tbrodjen.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(251, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 272);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // tsbtbrisanje
            // 
            this.tsbtbrisanje.Image = global::_4EIT_A2.Properties.Resources.seo_mistakes_avoid;
            this.tsbtbrisanje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtbrisanje.Name = "tsbtbrisanje";
            this.tsbtbrisanje.Size = new System.Drawing.Size(52, 51);
            this.tsbtbrisanje.Text = "Brisanje";
            this.tsbtbrisanje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtbrisanje.Click += new System.EventHandler(this.tsbtbrisanje_Click);
            // 
            // tsbtanaliza
            // 
            this.tsbtanaliza.Image = global::_4EIT_A2.Properties.Resources.graph_1_800x600;
            this.tsbtanaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtanaliza.Name = "tsbtanaliza";
            this.tsbtanaliza.Size = new System.Drawing.Size(49, 51);
            this.tsbtanaliza.Text = "Analiza";
            this.tsbtanaliza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtanaliza.Click += new System.EventHandler(this.tsbtanaliza_Click);
            // 
            // tsbtoaplikaciji
            // 
            this.tsbtoaplikaciji.Image = global::_4EIT_A2.Properties.Resources.Apps_gnome_info_icon_31789;
            this.tsbtoaplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtoaplikaciji.Name = "tsbtoaplikaciji";
            this.tsbtoaplikaciji.Size = new System.Drawing.Size(69, 51);
            this.tsbtoaplikaciji.Text = "O aplikaciji";
            this.tsbtoaplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtizlaz
            // 
            this.tsbtizlaz.Image = global::_4EIT_A2.Properties.Resources.door_exit;
            this.tsbtizlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtizlaz.Name = "tsbtizlaz";
            this.tsbtizlaz.Size = new System.Drawing.Size(36, 51);
            this.tsbtizlaz.Text = "Izlaz";
            this.tsbtizlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbrodjen);
            this.Controls.Add(this.tbprezime);
            this.Controls.Add(this.tbime);
            this.Controls.Add(this.tbsifra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Autor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtbrisanje;
        private System.Windows.Forms.ToolStripButton tsbtanaliza;
        private System.Windows.Forms.ToolStripButton tsbtoaplikaciji;
        private System.Windows.Forms.ToolStripButton tsbtizlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbsifra;
        private System.Windows.Forms.TextBox tbime;
        private System.Windows.Forms.TextBox tbprezime;
        private System.Windows.Forms.TextBox tbrodjen;
        private System.Windows.Forms.ListView listView1;
    }
}

