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

namespace kütüpOtomasyon
{
    public partial class tumkitaplar : Form
    {
        SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True");
        public tumkitaplar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var seciliId = dataGridView1.CurrentRow.Cells["id"].Value;

            yenibaglanti.Open();
            SqlCommand SilKomut = new SqlCommand("Delete from tumKitaplar where id = @pid", yenibaglanti);
            SilKomut.Parameters.AddWithValue("@pid", seciliId);
            SilKomut.ExecuteNonQuery();
            yenibaglanti.Close();

            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ekleKomut = new SqlCommand("INSERT INTO tumKitaplar (ad,yazar,sayfa,fiyat,yayınevi,turu) values (@ad,@yazar,@sayfa,@fiyat,@yayınevi,@turu)", yenibaglanti);
            ekleKomut.Parameters.AddWithValue("@ad", ad_textBox1.Text);
            ekleKomut.Parameters.AddWithValue("@yazar", yazar_textBox2.Text);
            ekleKomut.Parameters.AddWithValue("@sayfa", sayfa_textBox3.Text);
            ekleKomut.Parameters.AddWithValue("@fiyat", fiyat_textBox4.Text);
            ekleKomut.Parameters.AddWithValue("@yayınevi", yayın_textBox5.Text);
            ekleKomut.Parameters.AddWithValue("@turu", tur_textBox6.Text);
            yenibaglanti.Open();
            ekleKomut.ExecuteNonQuery();
            yenibaglanti.Close();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var seciliId = dataGridView1.CurrentRow.Cells["id"].Value;

            yenibaglanti.Open();
            SqlCommand guncelleKomut = new SqlCommand("Update tumKitaplar where id = @pid", yenibaglanti);
            guncelleKomut.Parameters.AddWithValue("@turu", yenibaglanti);
            guncelleKomut.Parameters.AddWithValue("@pid", seciliId);
            guncelleKomut.ExecuteNonQuery();
            yenibaglanti.Close();

            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ad_textBox1.Clear();
            yazar_textBox2.Clear();
            sayfa_textBox3.Clear();
            fiyat_textBox4.Clear();
            yayın_textBox5.Clear();
            tur_textBox6.Clear();
        }
        private void listele()
        {
            yenibaglanti.Open();
            SqlCommand listeleeKomut = new SqlCommand("Select *from tumKitaplar", yenibaglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleeKomut);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            yenibaglanti.Close();
        }
    }
}
