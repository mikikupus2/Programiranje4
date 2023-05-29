namespace vezbastringovi
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
            this.tbunos = new System.Windows.Forms.TextBox();
            this.tbispis = new System.Windows.Forms.TextBox();
            this.lbrez = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbunos
            // 
            this.tbunos.Location = new System.Drawing.Point(86, 133);
            this.tbunos.Multiline = true;
            this.tbunos.Name = "tbunos";
            this.tbunos.Size = new System.Drawing.Size(201, 190);
            this.tbunos.TabIndex = 0;
            // 
            // tbispis
            // 
            this.tbispis.Location = new System.Drawing.Point(483, 133);
            this.tbispis.Multiline = true;
            this.tbispis.Name = "tbispis";
            this.tbispis.Size = new System.Drawing.Size(201, 190);
            this.tbispis.TabIndex = 1;
            // 
            // lbrez
            // 
            this.lbrez.FormattingEnabled = true;
            this.lbrez.Location = new System.Drawing.Point(296, 189);
            this.lbrez.Name = "lbrez";
            this.lbrez.Size = new System.Drawing.Size(181, 134);
            this.lbrez.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Primeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbrez);
            this.Controls.Add(this.tbispis);
            this.Controls.Add(this.tbunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbunos;
        private System.Windows.Forms.TextBox tbispis;
        private System.Windows.Forms.ListBox lbrez;
        private System.Windows.Forms.Button button1;
    }
}

