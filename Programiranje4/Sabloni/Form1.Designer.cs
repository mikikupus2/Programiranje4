namespace Sabloni
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttekst = new System.Windows.Forms.TextBox();
            this.txtsablon = new System.Windows.Forms.TextBox();
            this.btok = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sablon";
            // 
            // txttekst
            // 
            this.txttekst.Location = new System.Drawing.Point(130, 60);
            this.txttekst.Multiline = true;
            this.txttekst.Name = "txttekst";
            this.txttekst.Size = new System.Drawing.Size(221, 89);
            this.txttekst.TabIndex = 2;
            // 
            // txtsablon
            // 
            this.txtsablon.Location = new System.Drawing.Point(130, 155);
            this.txtsablon.Name = "txtsablon";
            this.txtsablon.Size = new System.Drawing.Size(221, 20);
            this.txtsablon.TabIndex = 3;
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(87, 181);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(264, 52);
            this.btok.TabIndex = 4;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.btok_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(357, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 290);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btok);
            this.Controls.Add(this.txtsablon);
            this.Controls.Add(this.txttekst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttekst;
        private System.Windows.Forms.TextBox txtsablon;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.ListBox listBox1;
    }
}

