namespace StudentBaza
{
    partial class IzbaciForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbri = new System.Windows.Forms.TextBox();
            this.btizbaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj indeksa:";
            // 
            // txtbri
            // 
            this.txtbri.Location = new System.Drawing.Point(301, 110);
            this.txtbri.Name = "txtbri";
            this.txtbri.Size = new System.Drawing.Size(100, 20);
            this.txtbri.TabIndex = 1;
            // 
            // btizbaci
            // 
            this.btizbaci.Location = new System.Drawing.Point(230, 136);
            this.btizbaci.Name = "btizbaci";
            this.btizbaci.Size = new System.Drawing.Size(171, 23);
            this.btizbaci.TabIndex = 2;
            this.btizbaci.Text = "IZBACI";
            this.btizbaci.UseVisualStyleBackColor = true;
            this.btizbaci.Click += new System.EventHandler(this.btizbaci_Click);
            // 
            // IzbaciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btizbaci);
            this.Controls.Add(this.txtbri);
            this.Controls.Add(this.label1);
            this.Name = "IzbaciForma";
            this.Text = "IzbaciForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbri;
        private System.Windows.Forms.Button btizbaci;
    }
}