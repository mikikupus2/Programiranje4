namespace Context3
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
            this.components = new System.ComponentModel.Container();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.CMSTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KopirajAuB = new System.Windows.Forms.ToolStripMenuItem();
            this.KopirajBuA = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.ContextMenuStrip = this.CMSTextBox;
            this.txta.Location = new System.Drawing.Point(251, 204);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 0;
            // 
            // txtb
            // 
            this.txtb.ContextMenuStrip = this.CMSTextBox;
            this.txtb.Location = new System.Drawing.Point(390, 203);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 1;
            // 
            // CMSTextBox
            // 
            this.CMSTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KopirajAuB,
            this.KopirajBuA});
            this.CMSTextBox.Name = "CMSTextBox";
            this.CMSTextBox.Size = new System.Drawing.Size(141, 48);
            // 
            // KopirajAuB
            // 
            this.KopirajAuB.Name = "KopirajAuB";
            this.KopirajAuB.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.KopirajAuB.Size = new System.Drawing.Size(180, 22);
            this.KopirajAuB.Text = "A->B";
            this.KopirajAuB.Click += new System.EventHandler(this.KopirajAuB_Click);
            // 
            // KopirajBuA
            // 
            this.KopirajBuA.Name = "KopirajBuA";
            this.KopirajBuA.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.KopirajBuA.Size = new System.Drawing.Size(180, 22);
            this.KopirajBuA.Text = "B->A";
            this.KopirajBuA.Click += new System.EventHandler(this.KopirajBuA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CMSTextBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.ContextMenuStrip CMSTextBox;
        private System.Windows.Forms.ToolStripMenuItem KopirajAuB;
        private System.Windows.Forms.ToolStripMenuItem KopirajBuA;
    }
}

