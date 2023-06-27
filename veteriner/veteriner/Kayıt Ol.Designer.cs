namespace veteriner
{
    partial class Kayıt_Ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt_Ol));
            this.label1 = new System.Windows.Forms.Label();
            this.Kaydol_btn = new System.Windows.Forms.Button();
            this.kullanıcı_adı_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanıcısifre_txt = new System.Windows.Forms.TextBox();
            this.E_Posta_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(47, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // Kaydol_btn
            // 
            this.Kaydol_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydol_btn.ForeColor = System.Drawing.Color.Purple;
            this.Kaydol_btn.Location = new System.Drawing.Point(50, 268);
            this.Kaydol_btn.Name = "Kaydol_btn";
            this.Kaydol_btn.Size = new System.Drawing.Size(99, 23);
            this.Kaydol_btn.TabIndex = 1;
            this.Kaydol_btn.Text = "Kaydol";
            this.Kaydol_btn.UseVisualStyleBackColor = true;
            this.Kaydol_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullanıcı_adı_txt
            // 
            this.kullanıcı_adı_txt.Location = new System.Drawing.Point(170, 90);
            this.kullanıcı_adı_txt.Name = "kullanıcı_adı_txt";
            this.kullanıcı_adı_txt.Size = new System.Drawing.Size(100, 20);
            this.kullanıcı_adı_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(47, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(47, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Posta";
            // 
            // kullanıcısifre_txt
            // 
            this.kullanıcısifre_txt.Location = new System.Drawing.Point(170, 146);
            this.kullanıcısifre_txt.Name = "kullanıcısifre_txt";
            this.kullanıcısifre_txt.Size = new System.Drawing.Size(100, 20);
            this.kullanıcısifre_txt.TabIndex = 5;
            // 
            // E_Posta_txt
            // 
            this.E_Posta_txt.Location = new System.Drawing.Point(170, 202);
            this.E_Posta_txt.Name = "E_Posta_txt";
            this.E_Posta_txt.Size = new System.Drawing.Size(100, 20);
            this.E_Posta_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(249, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yeni Kayıt";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(417, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Giriş Sayfasınına Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Kayıt_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.E_Posta_txt);
            this.Controls.Add(this.kullanıcısifre_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanıcı_adı_txt);
            this.Controls.Add(this.Kaydol_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kayıt_Ol";
            this.Text = "Kayıt_Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kaydol_btn;
        private System.Windows.Forms.TextBox kullanıcı_adı_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanıcısifre_txt;
        private System.Windows.Forms.TextBox E_Posta_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}