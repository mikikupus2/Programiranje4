namespace UceniciMenu
{
    partial class GlavnaForma
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTxtSifra = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProsecnaOcena = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProsecnaOcenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbucenici = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSifraPrezime = new System.Windows.Forms.ToolStripTextBox();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItemUnos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.pretragaPoSifriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPoPrezimenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTxtSifra,
            this.toolStripSearch,
            this.toolStripSeparator1,
            this.toolStripDelete,
            this.toolStripSeparator2,
            this.toolStripProsecnaOcena});
            this.toolStrip1.Location = new System.Drawing.Point(0, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTxtSifra
            // 
            this.toolStripTxtSifra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtSifra.Name = "toolStripTxtSifra";
            this.toolStripTxtSifra.Size = new System.Drawing.Size(100, 50);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripProsecnaOcena
            // 
            this.toolStripProsecnaOcena.AutoSize = false;
            this.toolStripProsecnaOcena.Name = "toolStripProsecnaOcena";
            this.toolStripProsecnaOcena.Size = new System.Drawing.Size(150, 34);
            this.toolStripProsecnaOcena.Text = "Prosečna ocena:";
            this.toolStripProsecnaOcena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItemUnos,
            this.ListaToolStripMenuItem,
            this.ProsecnaOcenaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 42);
            this.toolStripMenuItem1.Text = "Show";
            // 
            // ListaToolStripMenuItem
            // 
            this.ListaToolStripMenuItem.Checked = true;
            this.ListaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem";
            this.ListaToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.ListaToolStripMenuItem.Text = "Lista";
            this.ListaToolStripMenuItem.Click += new System.EventHandler(this.ListaToolStripMenuItem_Click);
            // 
            // ProsecnaOcenaToolStripMenuItem
            // 
            this.ProsecnaOcenaToolStripMenuItem.Checked = true;
            this.ProsecnaOcenaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProsecnaOcenaToolStripMenuItem.Name = "ProsecnaOcenaToolStripMenuItem";
            this.ProsecnaOcenaToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.ProsecnaOcenaToolStripMenuItem.Text = "Prosečna ocena";
            this.ProsecnaOcenaToolStripMenuItem.Click += new System.EventHandler(this.ProsecnaOcenaToolStripMenuItem_Click);
            // 
            // lbucenici
            // 
            this.lbucenici.ContextMenuStrip = this.contextMenuStrip1;
            this.lbucenici.FormattingEnabled = true;
            this.lbucenici.Location = new System.Drawing.Point(21, 109);
            this.lbucenici.Name = "lbucenici";
            this.lbucenici.Size = new System.Drawing.Size(262, 238);
            this.lbucenici.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSifraPrezime,
            this.pretraziToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.pretragaPoSifriToolStripMenuItem,
            this.pretragaPoPrezimenuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 139);
            // 
            // toolStripSifraPrezime
            // 
            this.toolStripSifraPrezime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSifraPrezime.Name = "toolStripSifraPrezime";
            this.toolStripSifraPrezime.Size = new System.Drawing.Size(100, 23);
            // 
            // pretraziToolStripMenuItem
            // 
            this.pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pretraziToolStripMenuItem.Text = "Pretrazi";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.pretraziToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // unosToolStripMenuItemUnos
            // 
            this.unosToolStripMenuItemUnos.Name = "unosToolStripMenuItemUnos";
            this.unosToolStripMenuItemUnos.Size = new System.Drawing.Size(223, 30);
            this.unosToolStripMenuItemUnos.Text = "Unos";
            this.unosToolStripMenuItemUnos.Click += new System.EventHandler(this.UnosToolStripMenuItem_Click);
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.AutoSize = false;
            this.toolStripSearch.Image = global::UceniciMenu.res.Search;
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(70, 40);
            this.toolStripSearch.Text = "Pretraži";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripSearch_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.AutoSize = false;
            this.toolStripDelete.Image = global::UceniciMenu.res.Delete;
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(70, 40);
            this.toolStripDelete.Text = "Ukloni";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // pretragaPoSifriToolStripMenuItem
            // 
            this.pretragaPoSifriToolStripMenuItem.Name = "pretragaPoSifriToolStripMenuItem";
            this.pretragaPoSifriToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pretragaPoSifriToolStripMenuItem.Text = "PretragaPoSifri";
            this.pretragaPoSifriToolStripMenuItem.Click += new System.EventHandler(this.pretragaPoSifriToolStripMenuItem_Click);
            // 
            // pretragaPoPrezimenuToolStripMenuItem
            // 
            this.pretragaPoPrezimenuToolStripMenuItem.Name = "pretragaPoPrezimenuToolStripMenuItem";
            this.pretragaPoPrezimenuToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.pretragaPoPrezimenuToolStripMenuItem.Text = "PretragaPoPrezimenu";
            this.pretragaPoPrezimenuToolStripMenuItem.Click += new System.EventHandler(this.pretragaPoPrezimenuToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbucenici);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "Ucenici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtSifra;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.ToolStripLabel toolStripProsecnaOcena;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox lbucenici;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProsecnaOcenaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripSifraPrezime;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItemUnos;
        private System.Windows.Forms.ToolStripMenuItem pretragaPoSifriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPoPrezimenuToolStripMenuItem;
    }
}

