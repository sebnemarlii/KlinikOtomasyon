namespace OTOMASYON
{
    partial class doktorbilgileri
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
            this.grpbxdrbilgiler = new System.Windows.Forms.GroupBox();
            this.cmbxaramasecenekleri = new System.Windows.Forms.ComboBox();
            this.btnara = new System.Windows.Forms.Button();
            this.txtbxdrbilgi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpbxdrbilgiler
            // 
            this.grpbxdrbilgiler.Location = new System.Drawing.Point(78, 120);
            this.grpbxdrbilgiler.Name = "grpbxdrbilgiler";
            this.grpbxdrbilgiler.Size = new System.Drawing.Size(693, 283);
            this.grpbxdrbilgiler.TabIndex = 0;
            this.grpbxdrbilgiler.TabStop = false;
            this.grpbxdrbilgiler.Text = "BİLGİLER";
            // 
            // cmbxaramasecenekleri
            // 
            this.cmbxaramasecenekleri.FormattingEnabled = true;
            this.cmbxaramasecenekleri.Items.AddRange(new object[] {
            "Tümü",
            "TC Kimlik",
            "Adı Soyadı",
            "Telefon",
            "Adres",
            "Mail"});
            this.cmbxaramasecenekleri.Location = new System.Drawing.Point(353, 55);
            this.cmbxaramasecenekleri.Name = "cmbxaramasecenekleri";
            this.cmbxaramasecenekleri.Size = new System.Drawing.Size(199, 28);
            this.cmbxaramasecenekleri.TabIndex = 1;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(579, 54);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(94, 29);
            this.btnara.TabIndex = 2;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.MouseLeave += new System.EventHandler(this.btnara_MouseLeave);
            this.btnara.MouseHover += new System.EventHandler(this.btnara_MouseHover);
            // 
            // txtbxdrbilgi
            // 
            this.txtbxdrbilgi.Location = new System.Drawing.Point(201, 56);
            this.txtbxdrbilgi.Name = "txtbxdrbilgi";
            this.txtbxdrbilgi.Size = new System.Drawing.Size(125, 27);
            this.txtbxdrbilgi.TabIndex = 3;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnekle.Location = new System.Drawing.Point(412, 435);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 53);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            this.btnekle.MouseLeave += new System.EventHandler(this.btnekle_MouseLeave);
            this.btnekle.MouseHover += new System.EventHandler(this.btnekle_MouseHover);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsil.Location = new System.Drawing.Point(539, 435);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(94, 53);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.MouseLeave += new System.EventHandler(this.btnsil_MouseLeave);
            this.btnsil.MouseHover += new System.EventHandler(this.btnsil_MouseHover);
            // 
            // btnkapat
            // 
            this.btnkapat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnkapat.Location = new System.Drawing.Point(668, 435);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(94, 53);
            this.btnkapat.TabIndex = 6;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            this.btnkapat.MouseLeave += new System.EventHandler(this.btnkapat_MouseLeave);
            this.btnkapat.MouseHover += new System.EventHandler(this.btnkapat_MouseHover);
            // 
            // doktorbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 580);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtbxdrbilgi);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.cmbxaramasecenekleri);
            this.Controls.Add(this.grpbxdrbilgiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "doktorbilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Doktor Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxdrbilgiler;
        private System.Windows.Forms.ComboBox cmbxaramasecenekleri;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtbxdrbilgi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkapat;
    }
}