namespace StudentBaza
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
            this.GlavniMenu = new System.Windows.Forms.MenuStrip();
            this.lISTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dODAJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZBRISIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZBACIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRIKAZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lbstudenti = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlavniMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlavniMenu
            // 
            this.GlavniMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GlavniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTAToolStripMenuItem});
            this.GlavniMenu.Location = new System.Drawing.Point(0, 0);
            this.GlavniMenu.Name = "GlavniMenu";
            this.GlavniMenu.Size = new System.Drawing.Size(800, 24);
            this.GlavniMenu.TabIndex = 0;
            this.GlavniMenu.Text = "menuStrip1";
            // 
            // lISTAToolStripMenuItem
            // 
            this.lISTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dODAJToolStripMenuItem,
            this.iZBRISIToolStripMenuItem,
            this.iZBACIToolStripMenuItem,
            this.pRIKAZIToolStripMenuItem});
            this.lISTAToolStripMenuItem.Name = "lISTAToolStripMenuItem";
            this.lISTAToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.lISTAToolStripMenuItem.Text = "LISTA";
            // 
            // dODAJToolStripMenuItem
            // 
            this.dODAJToolStripMenuItem.Name = "dODAJToolStripMenuItem";
            this.dODAJToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.dODAJToolStripMenuItem.Text = "DODAJ";
            this.dODAJToolStripMenuItem.Click += new System.EventHandler(this.dODAJToolStripMenuItem_Click);
            // 
            // iZBRISIToolStripMenuItem
            // 
            this.iZBRISIToolStripMenuItem.Name = "iZBRISIToolStripMenuItem";
            this.iZBRISIToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.iZBRISIToolStripMenuItem.Text = "IZBRISI";
            this.iZBRISIToolStripMenuItem.Click += new System.EventHandler(this.iZBRISIToolStripMenuItem_Click);
            // 
            // iZBACIToolStripMenuItem
            // 
            this.iZBACIToolStripMenuItem.Name = "iZBACIToolStripMenuItem";
            this.iZBACIToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.iZBACIToolStripMenuItem.Text = "IZBACI";
            this.iZBACIToolStripMenuItem.Click += new System.EventHandler(this.iZBACIToolStripMenuItem_Click);
            // 
            // pRIKAZIToolStripMenuItem
            // 
            this.pRIKAZIToolStripMenuItem.Name = "pRIKAZIToolStripMenuItem";
            this.pRIKAZIToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pRIKAZIToolStripMenuItem.Text = "PRIKAZI";
            this.pRIKAZIToolStripMenuItem.Click += new System.EventHandler(this.pRIKAZIToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lbstudenti
            // 
            this.lbstudenti.ContextMenuStrip = this.contextMenuStrip1;
            this.lbstudenti.FormattingEnabled = true;
            this.lbstudenti.Location = new System.Drawing.Point(125, 52);
            this.lbstudenti.Name = "lbstudenti";
            this.lbstudenti.Size = new System.Drawing.Size(447, 329);
            this.lbstudenti.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortirajToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // sortirajToolStripMenuItem
            // 
            this.sortirajToolStripMenuItem.Name = "sortirajToolStripMenuItem";
            this.sortirajToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.sortirajToolStripMenuItem.Text = "Sortiraj";
            this.sortirajToolStripMenuItem.Click += new System.EventHandler(this.sortirajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbstudenti);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GlavniMenu);
            this.MainMenuStrip = this.GlavniMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GlavniMenu.ResumeLayout(false);
            this.GlavniMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GlavniMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem lISTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dODAJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZBRISIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZBACIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRIKAZIToolStripMenuItem;
        private System.Windows.Forms.ListBox lbstudenti;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortirajToolStripMenuItem;
    }
}

