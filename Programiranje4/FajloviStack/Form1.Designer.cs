namespace FajloviStack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbfajlovi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sTACKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dODAJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uKLONIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIKAZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pRIKAZITEMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbfajlovi
            // 
            this.lbfajlovi.ContextMenuStrip = this.contextMenuStrip1;
            this.lbfajlovi.FormattingEnabled = true;
            this.lbfajlovi.Location = new System.Drawing.Point(12, 65);
            this.lbfajlovi.Name = "lbfajlovi";
            this.lbfajlovi.Size = new System.Drawing.Size(701, 329);
            this.lbfajlovi.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTACKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sTACKToolStripMenuItem
            // 
            this.sTACKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dODAJToolStripMenuItem,
            this.uKLONIToolStripMenuItem,
            this.pRIKAZIToolStripMenuItem});
            this.sTACKToolStripMenuItem.Name = "sTACKToolStripMenuItem";
            this.sTACKToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sTACKToolStripMenuItem.Text = "STACK";
            // 
            // dODAJToolStripMenuItem
            // 
            this.dODAJToolStripMenuItem.Name = "dODAJToolStripMenuItem";
            this.dODAJToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dODAJToolStripMenuItem.Text = "DODAJ";
            this.dODAJToolStripMenuItem.Click += new System.EventHandler(this.dODAJToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 35);
            this.toolStripButton1.Text = "DODAJ";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.dODAJToolStripMenuItem_Click);
            // 
            // uKLONIToolStripMenuItem
            // 
            this.uKLONIToolStripMenuItem.Name = "uKLONIToolStripMenuItem";
            this.uKLONIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uKLONIToolStripMenuItem.Text = "UKLONI";
            // 
            // pRIKAZIToolStripMenuItem
            // 
            this.pRIKAZIToolStripMenuItem.Name = "pRIKAZIToolStripMenuItem";
            this.pRIKAZIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pRIKAZIToolStripMenuItem.Text = "PRIKAZI";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(53, 35);
            this.toolStripButton2.Text = "UKLONI";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRIKAZITEMPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // pRIKAZITEMPToolStripMenuItem
            // 
            this.pRIKAZITEMPToolStripMenuItem.Name = "pRIKAZITEMPToolStripMenuItem";
            this.pRIKAZITEMPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pRIKAZITEMPToolStripMenuItem.Text = "PRIKAZI TEMP";
            this.pRIKAZITEMPToolStripMenuItem.Click += new System.EventHandler(this.pRIKAZITEMPToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbfajlovi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbfajlovi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTACKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dODAJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uKLONIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIKAZIToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRIKAZITEMPToolStripMenuItem;
    }
}

