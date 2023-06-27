using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veteriner
{
    public partial class Kayıt_Ol : Form
    {
        public Kayıt_Ol()
        {
            InitializeComponent();
        }

        veritabanı bgl = new veritabanı();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komutkayıt = new SqlCommand("insert into giriş (kullanıcı_Adı,Sifre,E_Posta) values (@c1,@c2,@c3)", bgl.baglanti());

                komutkayıt.Parameters.AddWithValue("@c1", kullanıcı_adı_txt.Text.Trim());
                komutkayıt.Parameters.AddWithValue("@c2",veritabanı.MD5Sifrele(kullanıcısifre_txt.Text));
                komutkayıt.Parameters.AddWithValue("@c3", E_Posta_.txt.Text);
                komutkayıt.ExecuteNonQuery();
                bgl.baglanti().Close();

                kullanıcı_adı_txt.Text = "";
                kullanıcısifre_txt.Text = "";
                E_Posta_txt.Text = "";

                MessageBox.Show("Yeni Kullanıcı Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grş.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanları boş geçmeyin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Giriş grş = new Giriş();
        private void button1_Click_1(object sender, EventArgs e)
        {
            grş.Show();
            this.Hide();
        }
    }
}
