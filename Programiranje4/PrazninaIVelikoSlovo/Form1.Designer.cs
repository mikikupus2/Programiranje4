namespace PrazninaIVelikoSlovo
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
            this.tbulazni = new System.Windows.Forms.TextBox();
            this.tbizlazni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbautomatski = new System.Windows.Forms.CheckBox();
            this.btobrni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbulazni
            // 
            this.tbulazni.Location = new System.Drawing.Point(58, 98);
            this.tbulazni.Multiline = true;
            this.tbulazni.Name = "tbulazni";
            this.tbulazni.Size = new System.Drawing.Size(258, 214);
            this.tbulazni.TabIndex = 0;
            this.tbulazni.TextChanged += new System.EventHandler(this.tbulazni_TextChanged);
            // 
            // tbizlazni
            // 
            this.tbizlazni.Location = new System.Drawing.Point(448, 98);
            this.tbizlazni.Multiline = true;
            this.tbizlazni.Name = "tbizlazni";
            this.tbizlazni.Size = new System.Drawing.Size(257, 214);
            this.tbizlazni.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prepravi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbautomatski
            // 
            this.cbautomatski.AutoSize = true;
            this.cbautomatski.Location = new System.Drawing.Point(322, 213);
            this.cbautomatski.Name = "cbautomatski";
            this.cbautomatski.Size = new System.Drawing.Size(120, 17);
            this.cbautomatski.TabIndex = 3;
            this.cbautomatski.Text = "Automatski Prepravi";
            this.cbautomatski.UseVisualStyleBackColor = true;
            this.cbautomatski.CheckedChanged += new System.EventHandler(this.cbautomatski_CheckedChanged);
            // 
            // btobrni
            // 
            this.btobrni.Location = new System.Drawing.Point(322, 236);
            this.btobrni.Name = "btobrni";
            this.btobrni.Size = new System.Drawing.Size(120, 32);
            this.btobrni.TabIndex = 4;
            this.btobrni.Text = "Obrni";
            this.btobrni.UseVisualStyleBackColor = true;
            this.btobrni.Click += new System.EventHandler(this.btobrni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btobrni);
            this.Controls.Add(this.cbautomatski);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbizlazni);
            this.Controls.Add(this.tbulazni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbulazni;
        private System.Windows.Forms.TextBox tbizlazni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbautomatski;
        private System.Windows.Forms.Button btobrni;
    }
}

