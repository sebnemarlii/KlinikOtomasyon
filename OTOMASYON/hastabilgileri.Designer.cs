namespace OTOMASYON
{
    partial class hastabilgileri
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
            this.cmbxhastasecenekleri = new System.Windows.Forms.ComboBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtbxhastabilgi = new System.Windows.Forms.TextBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxhastasecenekleri
            // 
            this.cmbxhastasecenekleri.FormattingEnabled = true;
            this.cmbxhastasecenekleri.Items.AddRange(new object[] {
            "Tümü",
            "TC No",
            "Adı Soyadı",
            "Hasta ID",
            "Telefon",
            "Adres",
            "Mail"});
            this.cmbxhastasecenekleri.Location = new System.Drawing.Point(349, 47);
            this.cmbxhastasecenekleri.Name = "cmbxhastasecenekleri";
            this.cmbxhastasecenekleri.Size = new System.Drawing.Size(151, 28);
            this.cmbxhastasecenekleri.TabIndex = 1;
            this.cmbxhastasecenekleri.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(540, 46);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(94, 29);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            this.btnara.MouseLeave += new System.EventHandler(this.btnara_MouseLeave);
            this.btnara.MouseHover += new System.EventHandler(this.btnara_MouseHover);
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnekle.Location = new System.Drawing.Point(441, 424);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(112, 60);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtbxhastabilgi
            // 
            this.txtbxhastabilgi.Location = new System.Drawing.Point(184, 46);
            this.txtbxhastabilgi.Name = "txtbxhastabilgi";
            this.txtbxhastabilgi.Size = new System.Drawing.Size(125, 27);
            this.txtbxhastabilgi.TabIndex = 5;
            // 
            // btnkapat
            // 
            this.btnkapat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnkapat.Location = new System.Drawing.Point(593, 424);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(106, 60);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // hastabilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 552);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.txtbxhastabilgi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.cmbxhastasecenekleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "hastabilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hasta Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxhastasecenekleri;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtbxhastabilgi;
        private System.Windows.Forms.Button btnkapat;
    }
}