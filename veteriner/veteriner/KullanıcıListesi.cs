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
    public partial class KullanıcıListesi : Form
    {
        public KullanıcıListesi()
        {
            InitializeComponent();
        }

        veritabanı bgl = new veritabanı();
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * From giriş", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
