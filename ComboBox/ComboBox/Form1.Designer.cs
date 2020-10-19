namespace ComboBox
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
            this.cmbIzbor = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnPoruka = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIzbor
            // 
            this.cmbIzbor.FormattingEnabled = true;
            this.cmbIzbor.Items.AddRange(new object[] {
            "",
            "Peugeot 308 1976.",
            "Yugo 45",
            "Golf II",
            "Ford Taurus 1974.",
            "Renault 8"});
            this.cmbIzbor.Location = new System.Drawing.Point(45, 30);
            this.cmbIzbor.Name = "cmbIzbor";
            this.cmbIzbor.Size = new System.Drawing.Size(331, 21);
            this.cmbIzbor.TabIndex = 0;
            this.cmbIzbor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(65, 315);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(311, 20);
            this.txtIspis.TabIndex = 1;
            // 
            // btnPoruka
            // 
            this.btnPoruka.Location = new System.Drawing.Point(602, 315);
            this.btnPoruka.Name = "btnPoruka";
            this.btnPoruka.Size = new System.Drawing.Size(113, 47);
            this.btnPoruka.TabIndex = 2;
            this.btnPoruka.Text = "Prikaži poruku";
            this.btnPoruka.UseVisualStyleBackColor = true;
            this.btnPoruka.Click += new System.EventHandler(this.btnPoruka_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(602, 179);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(113, 43);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbrisi";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnPoruka);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmbIzbor);
            this.Name = "Form1";
            this.Text = "ComboBox Vježba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIzbor;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnPoruka;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

