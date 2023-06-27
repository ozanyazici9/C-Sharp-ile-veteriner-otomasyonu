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
    public partial class HastaSahibi : Form
    {
        public HastaSahibi()
        {
            InitializeComponent();
        }

        veritabanı bgl = new veritabanı();
        private void Sahipgüncelle_btn_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle2 = new SqlCommand("Update Hasta_Sahibi set Ad=@j1,Soyad=@j2,Kayıt_Tarihi=@j3,Telefon=@j4,Adres=@j5,Mail=@j6 where ID=@j7", bgl.baglanti());

            komutguncelle2.Parameters.AddWithValue("@j1", SahipAd_txt.Text);
            komutguncelle2.Parameters.AddWithValue("@j2", SahipSoyad_txt.Text);
            komutguncelle2.Parameters.AddWithValue("@j3", kayıttarih_mskdtxt.Text);
            komutguncelle2.Parameters.AddWithValue("@j4", SahipTel_mskdtxt.Text);
            komutguncelle2.Parameters.AddWithValue("@j5", Adres_richtxt.Text);
            komutguncelle2.Parameters.AddWithValue("@j6", Mail_txt.Text);
            komutguncelle2.Parameters.AddWithValue("@j7", sahipID_txt.Text);
            komutguncelle2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Hasta Sahibi Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            VetClinic form2 = new VetClinic();
           
            form2.HastaSahibiGenel_Listele();
            this.Hide();
        }
    }
}
