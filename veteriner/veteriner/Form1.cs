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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        veritabanı bgl = new veritabanı();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komutgiriş = new SqlCommand("Select * From giriş where kullanıcı_adı=@p1 and Sifre=@p2", bgl.baglanti());

            komutgiriş.Parameters.AddWithValue("@p1", kullanici_txt.Text);
            komutgiriş.Parameters.AddWithValue("@p2", veritabanı.MD5Sifrele(Sifre_txt.Text));
            //SqlDataAdapter da = new SqlDataAdapter(komutgiriş);
            SqlDataReader dr = komutgiriş.ExecuteReader();
            
            if (dr.Read())
            {
                VetClinic vet = new VetClinic();
                if (kullanici_txt.Text!="admin" && Sifre_txt.Text != "54321")
                {
                    vet.Show();
                    this.Hide();
                    vet.hastaGüncelle_btn.Visible = false;
                    vet.hastaSil_btn.Visible = false;
                    vet.hastaKaydet_btn.Visible = false;
                    vet.sahipGüncelle_btn.Visible = false;
                    vet.sahipSil_btn.Visible = false;
                    vet.sahipKaydet_btn.Visible = false;
                }
                else
                {
                    vet.Show();
                    this.Hide();
                }
            }
            else
            {
                
                MessageBox.Show("Hatalı Numara ya da Şifre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kaydol_btn_Click(object sender, EventArgs e)
        {
            Kayıt_Ol kayıt = new Kayıt_Ol();
            kayıt.Show();
            this.Hide();
        }
    }
}
