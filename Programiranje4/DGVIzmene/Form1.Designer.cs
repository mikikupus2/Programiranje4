namespace DGVIzmene
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btprikazi = new System.Windows.Forms.Button();
            this.btsnimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(101, 28);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(576, 260);
            this.dgv1.TabIndex = 0;
            // 
            // btprikazi
            // 
            this.btprikazi.Location = new System.Drawing.Point(101, 294);
            this.btprikazi.Name = "btprikazi";
            this.btprikazi.Size = new System.Drawing.Size(208, 61);
            this.btprikazi.TabIndex = 1;
            this.btprikazi.Text = "PRIKAZI";
            this.btprikazi.UseVisualStyleBackColor = true;
            this.btprikazi.Click += new System.EventHandler(this.btprikazi_Click);
            // 
            // btsnimi
            // 
            this.btsnimi.Location = new System.Drawing.Point(469, 294);
            this.btsnimi.Name = "btsnimi";
            this.btsnimi.Size = new System.Drawing.Size(208, 61);
            this.btsnimi.TabIndex = 2;
            this.btsnimi.Text = "SNIMI";
            this.btsnimi.UseVisualStyleBackColor = true;
            this.btsnimi.Click += new System.EventHandler(this.btsnimi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsnimi);
            this.Controls.Add(this.btprikazi);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btprikazi;
        private System.Windows.Forms.Button btsnimi;
    }
}

