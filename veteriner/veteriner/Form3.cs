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
    public partial class HastaGüncelle : Form
    {
       
        public HastaGüncelle()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
       

        veritabanı bgl = new veritabanı();
        private void güncelle_btn_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Hasta set Hasta_Adı=@k1,Doktor=@k2,Doğum_Tarihi=@k3,Tür=@k4,Irk=@k5,Cinsiyet=@k6,Ağırlık=@k7,Alerji=@k8,Durum=@k9 where HastaID=@k10", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@k1", gnchastaAd_txt.Text);
            komutguncelle.Parameters.AddWithValue("@k2", gncdoktor_txt.Text);
            komutguncelle.Parameters.AddWithValue("@k3", gncdoğum_mskdtxt.Text);
            komutguncelle.Parameters.AddWithValue("@k4", gnctür_txt.Text);
            komutguncelle.Parameters.AddWithValue("@k5", gncırk_txt.Text);

            foreach (Control rb in cinsiyet_grpbox.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    komutguncelle.Parameters.AddWithValue("@k6", rb.Text);
                }
            }

            komutguncelle.Parameters.AddWithValue("@k7", gncağırlık_txt.Text);
            komutguncelle.Parameters.AddWithValue("@k8", gncalerji_txt.Text);
            komutguncelle.Parameters.AddWithValue("@k9", gncdurum_combo.SelectedItem.ToString());
            komutguncelle.Parameters.AddWithValue("@k10", ıd_txt.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Hasta Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            VetClinic frm2 = new VetClinic();
            
            frm2.HastaGenel_Listele();
            this.Hide();
        }
    }
}
