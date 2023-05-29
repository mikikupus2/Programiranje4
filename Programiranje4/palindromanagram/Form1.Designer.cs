namespace palindromanagram
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
            this.tba = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpalindrom = new System.Windows.Forms.Label();
            this.txtanagram = new System.Windows.Forms.Label();
            this.tbp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tba
            // 
            this.tba.Location = new System.Drawing.Point(440, 61);
            this.tba.Name = "tba";
            this.tba.Size = new System.Drawing.Size(100, 20);
            this.tba.TabIndex = 0;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(555, 61);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 20);
            this.tbb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palindrom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Anagram:";
            // 
            // txtpalindrom
            // 
            this.txtpalindrom.AutoSize = true;
            this.txtpalindrom.Location = new System.Drawing.Point(74, 47);
            this.txtpalindrom.Name = "txtpalindrom";
            this.txtpalindrom.Size = new System.Drawing.Size(35, 13);
            this.txtpalindrom.TabIndex = 6;
            this.txtpalindrom.Text = "label3";
            // 
            // txtanagram
            // 
            this.txtanagram.AutoSize = true;
            this.txtanagram.Location = new System.Drawing.Point(376, 98);
            this.txtanagram.Name = "txtanagram";
            this.txtanagram.Size = new System.Drawing.Size(35, 13);
            this.txtanagram.TabIndex = 7;
            this.txtanagram.Text = "label4";
            // 
            // tbp
            // 
            this.tbp.Location = new System.Drawing.Point(15, 64);
            this.tbp.Name = "tbp";
            this.tbp.Size = new System.Drawing.Size(100, 20);
            this.tbp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbp);
            this.Controls.Add(this.txtanagram);
            this.Controls.Add(this.txtpalindrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tba;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtpalindrom;
        private System.Windows.Forms.Label txtanagram;
        private System.Windows.Forms.TextBox tbp;
    }
}

