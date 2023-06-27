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
    public partial class VetClinic : Form
    {
        public VetClinic()
        {
            InitializeComponent();
        }

        veritabanı bgl = new veritabanı();
        void Hasta_Listele()
        {
            SqlCommand komut3 = new SqlCommand("Select * From Hasta where Hasta_Adı=@h1 and Tür=@h2",bgl.baglanti());
            komut3.Parameters.AddWithValue("@h1", ad_txt.Text);
            komut3.Parameters.AddWithValue("@h2", tür_txt.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komut3.ExecuteReader();

            if (dr.Read())
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Hatalı Ad ya da Tür girdiniz. Lütfen Kontrol Edin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            ad_txt.Text = "";
            tür_txt.Text = "";
        }

        public void HastaGenel_Listele()
        {
            SqlCommand komut4 = new SqlCommand("Select * From Hasta", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public void HastaSahibiGenel_Listele()
        {
            SqlCommand komut5 = new SqlCommand("Select * From Hasta_Sahibi", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut5);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void hastaListele_btn_Click(object sender, EventArgs e)
        {

            if(ad_txt.Text == "" && tür_txt.Text == "")
            {
                HastaGenel_Listele();
            }
            else
            {
                Hasta_Listele();
            }

        }

        void Sahip_Listele()
        {
            SqlCommand komut2 = new SqlCommand("Select * From Hasta_Sahibi where Ad=@s1 and Soyad=@s2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@s1", sahipAd_txt.Text);
            komut2.Parameters.AddWithValue("@s2", sahipSoyad_txt.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            SqlDataReader dr = komut2.ExecuteReader();

            if(dr.Read())
            {
                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Hatalı Ad ya da Soyad girdiniz. Lütfen Kontrol Edin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            sahipAd_txt.Text = "";
            sahipSoyad_txt.Text = "";

        }
        private void sahipListele_btn_Click(object sender, EventArgs e)
        {

            if (sahipAd_txt.Text == "" && sahipSoyad_txt.Text == "")
            {
                HastaSahibiGenel_Listele();
            }
            else
            {
                Sahip_Listele();
            }

        }

        private void hastaSil_btn_Click(object sender, EventArgs e)
        {

            SqlCommand komutsil = new SqlCommand("Delete From Hasta where Hasta_Adı=@f1 and Tür=@f2", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@f1", ad_txt.Text);
            komutsil.Parameters.AddWithValue("@f2", tür_txt.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Hasta Veri Tabanından Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ad_txt.Text = "";
            tür_txt.Text = "";

            HastaGenel_Listele();
        }

        HastaGüncelle frm = new HastaGüncelle();
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ad_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tür_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.ıd_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            frm.gnchastaAd_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.gncdoktor_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.gncdoğum_mskdtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();   
            frm.gnctür_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.gncırk_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            frm.gncağırlık_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            frm.gncalerji_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            frm.gncdurum_combo.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        HastaSahibi frm4 = new HastaSahibi();   
        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sahipAd_txt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            sahipSoyad_txt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm4.sahipID_txt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            frm4.SahipAd_txt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();   
            frm4.SahipSoyad_txt.Text = dataGridView2.Rows[e.RowIndex ].Cells[2].Value.ToString();   
            frm4.kayıttarih_mskdtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm4.SahipTel_mskdtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm4.Adres_richtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            frm4.Mail_txt.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void sahipSil_btn_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil2 = new SqlCommand("Delete From Hasta_Sahibi where Ad=@z1 and Soyad=@z2", bgl.baglanti());
            komutsil2.Parameters.AddWithValue("@z1", sahipAd_txt.Text);
            komutsil2.Parameters.AddWithValue("@z2", sahipSoyad_txt.Text);
            komutsil2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Hasta Sahibi Veri Tabanından Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            sahipAd_txt.Text = "";
            sahipSoyad_txt.Text = "";

            HastaSahibiGenel_Listele();
           
        }

        public void hastaKaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutekle = new SqlCommand("insert into Hasta (Hasta_Adı,Doktor,Doğum_Tarihi,Tür,Irk,Cinsiyet,Ağırlık,Alerji,Durum) values (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8,@v9)", bgl.baglanti());

                komutekle.Parameters.AddWithValue("@v1", yenihastaAd_txt.Text);
                komutekle.Parameters.AddWithValue("@v2", yenihastaDoktor_txt.Text);
                komutekle.Parameters.AddWithValue("@v3", yenihastaDoğum_mskdtxt.Text);
                komutekle.Parameters.AddWithValue("@v4", yenihastaTür_txt.Text);
                komutekle.Parameters.AddWithValue("@v5", yenihastaIrk_txt.Text);

                foreach (Control rb in Cinsiyet_grpbox.Controls)
                {
                    if (((RadioButton)rb).Checked)
                    {
                        komutekle.Parameters.AddWithValue("@v6", rb.Text);
                    }
                }
                
                komutekle.Parameters.AddWithValue("@v7", yenihastaAğırlık_txt.Text);
                komutekle.Parameters.AddWithValue("@v8", yenihastaAlerji_txt.Text);
                komutekle.Parameters.AddWithValue("@v9", yenihastaDurum_combo.Text);
                komutekle.ExecuteNonQuery();
                bgl.baglanti().Close();

                yenihastaAd_txt.Text = "";
                yenihastaDoktor_txt.Text = "";
                yenihastaDoğum_mskdtxt.Text = "";
                yenihastaTür_txt.Text = "";
                yenihastaIrk_txt.Text = "";
                yenihastaAğırlık_txt.Text = "";
                yenihastaAlerji_txt.Text = "";
                yenihastaDurum_combo.Text = "";

                MessageBox.Show("Hasta Veri Tabanına Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Alanları Boş Geçmeyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void sahipKaydet_btn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komutekle2 = new SqlCommand("insert into Hasta_Sahibi (Ad,Soyad,Kayıt_Tarihi,Telefon,Adres,Mail) values (@r1,@r2,@r3,@r4,@r5,@r6)", bgl.baglanti());

                komutekle2.Parameters.AddWithValue("@r1", yenisahipAd_txt.Text);
                komutekle2.Parameters.AddWithValue("@r2", yenisahipSoyad_txt.Text);
                komutekle2.Parameters.AddWithValue("@r3", yenikayıttarih_mskdtxt.Text);
                komutekle2.Parameters.AddWithValue("@r4", yenisahipTel_mskdtxt.Text);
                komutekle2.Parameters.AddWithValue("@r5", yenisahipAdres_richtxt.Text);
                komutekle2.Parameters.AddWithValue("@r6", yenisahipMail_txt.Text);
                komutekle2.ExecuteNonQuery();
                bgl.baglanti().Close();

                yenisahipAd_txt.Text = "";
                yenisahipSoyad_txt.Text = "";
                yenikayıttarih_mskdtxt.Text = "";
                yenisahipTel_mskdtxt.Text = "";
                yenisahipAdres_richtxt.Text = "";
                yenisahipMail_txt.Text = "";

                MessageBox.Show("Hasta Sahibi Veri Tabanına Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen alanları boş geçmeyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void hastaGüncelle_btn_Click(object sender, EventArgs e)
        { 
           frm.Show();
        }

        public void sahipGüncelle_btn_Click(object sender, EventArgs e)
        {  
           frm4.Show(); 
        }

        private void yönetici_btn_Click(object sender, EventArgs e)
        {
            Giriş grş = new Giriş();
            grş.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
