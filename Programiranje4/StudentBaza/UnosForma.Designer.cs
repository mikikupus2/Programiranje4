﻿namespace StudentBaza
{
    partial class UnosForma
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
            this.SQLtekst = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btizvrsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQLtekst
            // 
            this.SQLtekst.Location = new System.Drawing.Point(93, 50);
            this.SQLtekst.Name = "SQLtekst";
            this.SQLtekst.Size = new System.Drawing.Size(282, 188);
            this.SQLtekst.TabIndex = 0;
            this.SQLtekst.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL UPIT";
            // 
            // btizvrsi
            // 
            this.btizvrsi.Location = new System.Drawing.Point(93, 244);
            this.btizvrsi.Name = "btizvrsi";
            this.btizvrsi.Size = new System.Drawing.Size(282, 23);
            this.btizvrsi.TabIndex = 2;
            this.btizvrsi.Text = "IZVRSI KOMANDU";
            this.btizvrsi.UseVisualStyleBackColor = true;
            this.btizvrsi.Click += new System.EventHandler(this.btizvrsi_Click);
            // 
            // UnosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btizvrsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLtekst);
            this.Name = "UnosForma";
            this.Text = "UnosForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SQLtekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btizvrsi;
    }
}