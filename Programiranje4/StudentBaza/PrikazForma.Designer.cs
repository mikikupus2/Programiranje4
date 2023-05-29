namespace StudentBaza
{
    partial class PrikazForma
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
            this.dgvstudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstudenti
            // 
            this.dgvstudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudenti.Location = new System.Drawing.Point(85, 50);
            this.dgvstudenti.Name = "dgvstudenti";
            this.dgvstudenti.Size = new System.Drawing.Size(629, 323);
            this.dgvstudenti.TabIndex = 0;
            // 
            // PrikazForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvstudenti);
            this.Name = "PrikazForma";
            this.Text = "PrikazForma";
            this.Load += new System.EventHandler(this.PrikazForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstudenti;
    }
}