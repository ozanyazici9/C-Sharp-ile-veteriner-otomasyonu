namespace veteriner
{
    partial class HastaGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGüncelle));
            this.güncelle_btn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gncdurum_combo = new System.Windows.Forms.ComboBox();
            this.gncdoğum_mskdtxt = new System.Windows.Forms.MaskedTextBox();
            this.gncalerji_txt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gncağırlık_txt = new System.Windows.Forms.TextBox();
            this.gncırk_txt = new System.Windows.Forms.TextBox();
            this.gnctür_txt = new System.Windows.Forms.TextBox();
            this.gnchastaAd_txt = new System.Windows.Forms.TextBox();
            this.gncdoktor_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cinsiyet_grpbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ıd_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cinsiyet_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelle_btn
            // 
            this.güncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelle_btn.Location = new System.Drawing.Point(203, 542);
            this.güncelle_btn.Name = "güncelle_btn";
            this.güncelle_btn.Size = new System.Drawing.Size(113, 32);
            this.güncelle_btn.TabIndex = 53;
            this.güncelle_btn.Text = "Güncelle";
            this.güncelle_btn.UseVisualStyleBackColor = true;
            this.güncelle_btn.Click += new System.EventHandler(this.güncelle_btn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(207, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(105, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dişi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // gncdurum_combo
            // 
            this.gncdurum_combo.FormattingEnabled = true;
            this.gncdurum_combo.Items.AddRange(new object[] {
            "Taburcu Edildi",
            "Muayenede"});
            this.gncdurum_combo.Location = new System.Drawing.Point(170, 474);
            this.gncdurum_combo.Name = "gncdurum_combo";
            this.gncdurum_combo.Size = new System.Drawing.Size(146, 21);
            this.gncdurum_combo.TabIndex = 50;
            // 
            // gncdoğum_mskdtxt
            // 
            this.gncdoğum_mskdtxt.Location = new System.Drawing.Point(170, 233);
            this.gncdoğum_mskdtxt.Mask = "0/0/0000";
            this.gncdoğum_mskdtxt.Name = "gncdoğum_mskdtxt";
            this.gncdoğum_mskdtxt.Size = new System.Drawing.Size(146, 20);
            this.gncdoğum_mskdtxt.TabIndex = 49;
            this.gncdoğum_mskdtxt.ValidatingType = typeof(System.DateTime);
            // 
            // gncalerji_txt
            // 
            this.gncalerji_txt.Location = new System.Drawing.Point(170, 426);
            this.gncalerji_txt.Name = "gncalerji_txt";
            this.gncalerji_txt.Size = new System.Drawing.Size(146, 20);
            this.gncalerji_txt.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.SkyBlue;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(62, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 16);
            this.label19.TabIndex = 47;
            this.label19.Text = "Durum";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.SkyBlue;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(62, 429);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 46;
            this.label18.Text = "Alerji";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 416);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.SkyBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(62, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 44;
            this.label16.Text = "Ağırlığı";
            // 
            // gncağırlık_txt
            // 
            this.gncağırlık_txt.Location = new System.Drawing.Point(170, 389);
            this.gncağırlık_txt.Name = "gncağırlık_txt";
            this.gncağırlık_txt.Size = new System.Drawing.Size(146, 20);
            this.gncağırlık_txt.TabIndex = 43;
            // 
            // gncırk_txt
            // 
            this.gncırk_txt.Location = new System.Drawing.Point(170, 309);
            this.gncırk_txt.Name = "gncırk_txt";
            this.gncırk_txt.Size = new System.Drawing.Size(146, 20);
            this.gncırk_txt.TabIndex = 42;
            // 
            // gnctür_txt
            // 
            this.gnctür_txt.Location = new System.Drawing.Point(170, 274);
            this.gnctür_txt.Name = "gnctür_txt";
            this.gnctür_txt.Size = new System.Drawing.Size(146, 20);
            this.gnctür_txt.TabIndex = 41;
            // 
            // gnchastaAd_txt
            // 
            this.gnchastaAd_txt.Location = new System.Drawing.Point(170, 185);
            this.gnchastaAd_txt.Name = "gnchastaAd_txt";
            this.gnchastaAd_txt.Size = new System.Drawing.Size(146, 20);
            this.gnchastaAd_txt.TabIndex = 40;
            // 
            // gncdoktor_txt
            // 
            this.gncdoktor_txt.Location = new System.Drawing.Point(170, 138);
            this.gncdoktor_txt.Name = "gncdoktor_txt";
            this.gncdoktor_txt.Size = new System.Drawing.Size(146, 20);
            this.gncdoktor_txt.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.SkyBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(62, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Irkı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.SkyBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(62, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Türü";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.SkyBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(62, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Doğum Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(62, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Hasta Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Doktor";
            // 
            // cinsiyet_grpbox
            // 
            this.cinsiyet_grpbox.BackColor = System.Drawing.Color.SkyBlue;
            this.cinsiyet_grpbox.Controls.Add(this.radioButton2);
            this.cinsiyet_grpbox.Controls.Add(this.radioButton1);
            this.cinsiyet_grpbox.Location = new System.Drawing.Point(54, 339);
            this.cinsiyet_grpbox.Name = "cinsiyet_grpbox";
            this.cinsiyet_grpbox.Size = new System.Drawing.Size(262, 44);
            this.cinsiyet_grpbox.TabIndex = 56;
            this.cinsiyet_grpbox.TabStop = false;
            this.cinsiyet_grpbox.Text = "Cinsiyet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "Hasta Güncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "ID";
            // 
            // ıd_txt
            // 
            this.ıd_txt.Location = new System.Drawing.Point(170, 103);
            this.ıd_txt.Name = "ıd_txt";
            this.ıd_txt.Size = new System.Drawing.Size(146, 20);
            this.ıd_txt.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // HastaGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinsiyet_grpbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ıd_txt);
            this.Controls.Add(this.güncelle_btn);
            this.Controls.Add(this.gncdurum_combo);
            this.Controls.Add(this.gncdoğum_mskdtxt);
            this.Controls.Add(this.gncalerji_txt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gncağırlık_txt);
            this.Controls.Add(this.gncırk_txt);
            this.Controls.Add(this.gnctür_txt);
            this.Controls.Add(this.gnchastaAd_txt);
            this.Controls.Add(this.gncdoktor_txt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaGüncelle";
            this.Text = "Hasta Güncelleme Ekranı";
            this.cinsiyet_grpbox.ResumeLayout(false);
            this.cinsiyet_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button güncelle_btn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.ComboBox gncdurum_combo;
        public System.Windows.Forms.MaskedTextBox gncdoğum_mskdtxt;
        public System.Windows.Forms.TextBox gncalerji_txt;
        public System.Windows.Forms.TextBox gncağırlık_txt;
        public System.Windows.Forms.TextBox gncırk_txt;
        public System.Windows.Forms.TextBox gnctür_txt;
        public System.Windows.Forms.TextBox gnchastaAd_txt;
        public System.Windows.Forms.TextBox gncdoktor_txt;
        public System.Windows.Forms.GroupBox cinsiyet_grpbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ıd_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}