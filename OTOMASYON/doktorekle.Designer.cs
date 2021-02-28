namespace OTOMASYON
{
    partial class doktorekle
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtbxtelefon = new System.Windows.Forms.TextBox();
            this.txtbxtcno = new System.Windows.Forms.TextBox();
            this.txtbxadsoyad = new System.Windows.Forms.TextBox();
            this.txtbxdoktorid = new System.Windows.Forms.TextBox();
            this.lbldoktorid = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltcno = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkapat);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.txtbxtelefon);
            this.groupBox1.Controls.Add(this.txtbxtcno);
            this.groupBox1.Controls.Add(this.txtbxadsoyad);
            this.groupBox1.Controls.Add(this.txtbxdoktorid);
            this.groupBox1.Controls.Add(this.lbldoktorid);
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lbltcno);
            this.groupBox1.Controls.Add(this.lbltelefon);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(84, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİLGİLER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(290, 237);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(83, 54);
            this.btnkapat.TabIndex = 10;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.button2_Click);
            this.btnkapat.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnkapat.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(186, 237);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(91, 54);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnkaydet.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // txtbxtelefon
            // 
            this.txtbxtelefon.Location = new System.Drawing.Point(186, 181);
            this.txtbxtelefon.Name = "txtbxtelefon";
            this.txtbxtelefon.Size = new System.Drawing.Size(187, 31);
            this.txtbxtelefon.TabIndex = 8;
            // 
            // txtbxtcno
            // 
            this.txtbxtcno.Location = new System.Drawing.Point(186, 134);
            this.txtbxtcno.Name = "txtbxtcno";
            this.txtbxtcno.Size = new System.Drawing.Size(187, 31);
            this.txtbxtcno.TabIndex = 7;
            this.txtbxtcno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtbxadsoyad
            // 
            this.txtbxadsoyad.Location = new System.Drawing.Point(186, 91);
            this.txtbxadsoyad.Name = "txtbxadsoyad";
            this.txtbxadsoyad.Size = new System.Drawing.Size(187, 31);
            this.txtbxadsoyad.TabIndex = 6;
            this.txtbxadsoyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbxdoktorid
            // 
            this.txtbxdoktorid.Location = new System.Drawing.Point(186, 49);
            this.txtbxdoktorid.Name = "txtbxdoktorid";
            this.txtbxdoktorid.Size = new System.Drawing.Size(187, 31);
            this.txtbxdoktorid.TabIndex = 5;
            this.txtbxdoktorid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbldoktorid
            // 
            this.lbldoktorid.AutoSize = true;
            this.lbldoktorid.Location = new System.Drawing.Point(61, 56);
            this.lbldoktorid.Name = "lbldoktorid";
            this.lbldoktorid.Size = new System.Drawing.Size(97, 25);
            this.lbldoktorid.TabIndex = 1;
            this.lbldoktorid.Text = "Doktor ID:";
            this.lbldoktorid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(61, 98);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(104, 25);
            this.lbladsoyad.TabIndex = 2;
            this.lbladsoyad.Text = "Adı Soyadı:";
            this.lbladsoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(61, 141);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(66, 25);
            this.lbltcno.TabIndex = 3;
            this.lbltcno.Text = "TC No:";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(61, 184);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(77, 25);
            this.lbltelefon.TabIndex = 4;
            this.lbltelefon.Text = "Telefon:";
            this.lbltelefon.Click += new System.EventHandler(this.label4_Click);
            // 
            // doktorekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 583);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "doktorekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DOKTOR KAYIT";
            this.Load += new System.EventHandler(this.doktorekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldoktorid;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.TextBox txtbxtelefon;
        private System.Windows.Forms.TextBox txtbxtcno;
        private System.Windows.Forms.TextBox txtbxadsoyad;
        private System.Windows.Forms.TextBox txtbxdoktorid;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnkaydet;
    }
}