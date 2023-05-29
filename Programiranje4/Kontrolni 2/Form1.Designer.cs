namespace Kontrolni_2
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
            this.txtind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgstudent
            // 
            this.dgstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgstudent.Location = new System.Drawing.Point(262, 29);
            this.dgstudent.Name = "dgstudent";
            this.dgstudent.Size = new System.Drawing.Size(469, 254);
            this.dgstudent.TabIndex = 0;
            // 
            // btprikazi
            // 
            this.btprikazi.Location = new System.Drawing.Point(91, 29);
            this.btprikazi.Name = "btprikazi";
            this.btprikazi.Size = new System.Drawing.Size(75, 23);
            this.btprikazi.TabIndex = 1;
            this.btprikazi.Text = "Prikazi";
            this.btprikazi.UseVisualStyleBackColor = true;
            this.btprikazi.Click += new System.EventHandler(this.btprikazi_Click);
            // 
            // txtind
            // 
            this.txtind.Location = new System.Drawing.Point(91, 88);
            this.txtind.Name = "txtind";
            this.txtind.Size = new System.Drawing.Size(100, 20);
            this.txtind.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj indexa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtind);
            this.Controls.Add(this.btprikazi);
            this.Controls.Add(this.dgstudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgstudent;
        private System.Windows.Forms.Button btprikazi;
        private System.Windows.Forms.TextBox txtind;
        private System.Windows.Forms.Label label1;
    }
}

