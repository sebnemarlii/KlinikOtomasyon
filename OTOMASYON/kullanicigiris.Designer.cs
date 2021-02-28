namespace OTOMASYON
{
    partial class kullanicigiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtbxsifre = new System.Windows.Forms.TextBox();
            this.txtbxkullaniciadi = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkapat);
            this.groupBox1.Controls.Add(this.btngiris);
            this.groupBox1.Controls.Add(this.txtbxsifre);
            this.groupBox1.Controls.Add(this.txtbxkullaniciadi);
            this.groupBox1.Controls.Add(this.lblsifre);
            this.groupBox1.Controls.Add(this.lblkullaniciadi);
            this.groupBox1.Location = new System.Drawing.Point(112, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(555, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(331, 250);
            this.btnkapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(118, 52);
            this.btnkapat.TabIndex = 7;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.button2_Click);
            this.btnkapat.MouseLeave += new System.EventHandler(this.btnkapat_MouseLeave);
            this.btnkapat.MouseHover += new System.EventHandler(this.btnkapat_MouseHover);
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(215, 250);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(109, 52);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.button1_Click);
            this.btngiris.MouseLeave += new System.EventHandler(this.btngiris_MouseLeave);
            this.btngiris.MouseHover += new System.EventHandler(this.btngiris_MouseHover);
            // 
            // txtbxsifre
            // 
            this.txtbxsifre.Location = new System.Drawing.Point(215, 151);
            this.txtbxsifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxsifre.Name = "txtbxsifre";
            this.txtbxsifre.PasswordChar = '*';
            this.txtbxsifre.Size = new System.Drawing.Size(233, 31);
            this.txtbxsifre.TabIndex = 4;
            this.txtbxsifre.TextChanged += new System.EventHandler(this.txtbxsifre_TextChanged);
            // 
            // txtbxkullaniciadi
            // 
            this.txtbxkullaniciadi.Location = new System.Drawing.Point(215, 71);
            this.txtbxkullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxkullaniciadi.Name = "txtbxkullaniciadi";
            this.txtbxkullaniciadi.Size = new System.Drawing.Size(233, 31);
            this.txtbxkullaniciadi.TabIndex = 3;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(69, 151);
            this.lblsifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(59, 25);
            this.lblsifre.TabIndex = 1;
            this.lblsifre.Text = "Şifre :";
            this.lblsifre.Click += new System.EventHandler(this.txtsifre_Click);
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(69, 80);
            this.lblkullaniciadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(124, 25);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // kullanicigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 581);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kullanicigiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.kullanicigiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtbxsifre;
        private System.Windows.Forms.TextBox txtbxkullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblkullaniciadi;
    }
}