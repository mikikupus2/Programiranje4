namespace Baza2Zad
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
            this.dgstudent = new System.Windows.Forms.DataGridView();
            this.btprikazi = new System.Windows.Forms.Button();
            this.txtgod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgstudent
            // 
            this.dgstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstudent.Location = new System.Drawing.Point(12, 77);
            this.dgstudent.Name = "dgstudent";
            this.dgstudent.Size = new System.Drawing.Size(776, 361);
            this.dgstudent.TabIndex = 0;
            // 
            // btprikazi
            // 
            this.btprikazi.Location = new System.Drawing.Point(12, 33);
            this.btprikazi.Name = "btprikazi";
            this.btprikazi.Size = new System.Drawing.Size(123, 38);
            this.btprikazi.TabIndex = 1;
            this.btprikazi.Text = "PRIKAZI PODATKE STUDENTIMA";
            this.btprikazi.UseVisualStyleBackColor = true;
            this.btprikazi.Click += new System.EventHandler(this.btprikazi_Click);
            // 
            // txtgod
            // 
            this.txtgod.Location = new System.Drawing.Point(13, 7);
            this.txtgod.Name = "txtgod";
            this.txtgod.Size = new System.Drawing.Size(100, 20);
            this.txtgod.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgod);
            this.Controls.Add(this.btprikazi);
            this.Controls.Add(this.dgstudent);
            this.Name = "Form1";
            this.Text = "Godina";
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgstudent;
        private System.Windows.Forms.Button btprikazi;
        private System.Windows.Forms.TextBox txtgod;
    }
}

