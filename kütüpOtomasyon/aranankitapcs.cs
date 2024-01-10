using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüpOtomasyon
{
    public partial class aranankitapcs : Form
    {
        SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True");
        public aranankitapcs()
        {
            InitializeComponent();
        }

        private void kitapad_textBox1_TextChanged(object sender, EventArgs e)
        {
            listele2(kitapad_textBox1.Text);
        }
        private void listele2(string ad)
        {
            using (SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True"))
            {
                yenibaglanti.Open();
                string query = "SELECT * FROM tumKitaplar WHERE ad LIKE @ad + '%'";
                SqlCommand listeleeKomut = new SqlCommand(query, yenibaglanti);
                listeleeKomut.Parameters.AddWithValue("@ad", ad);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleeKomut);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void kyazar_textBox2_TextChanged(object sender, EventArgs e)
        {
            YazarAra(kyazar_textBox2.Text);
        }
        private void YazarAra(string yazar)
        {
            using (SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True"))
            {
                yenibaglanti.Open();
                string query = "SELECT * FROM tumKitaplar WHERE yazar LIKE @yazar + '%'";
                SqlCommand listeleeKomut = new SqlCommand(query, yenibaglanti);
                listeleeKomut.Parameters.AddWithValue("@yazar", yazar);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleeKomut);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void kyayın_textBox3_TextChanged(object sender, EventArgs e)
        {
            YayineviAra(kyayın_textBox3.Text);
        }
        private void YayineviAra(string yayınevi)
        {
            using (SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True"))
            {
                yenibaglanti.Open();
                string query = "SELECT * FROM tumKitaplar WHERE yayınevi LIKE @yayınevi + '%'";
                SqlCommand listeleeKomut = new SqlCommand(query, yenibaglanti);
                listeleeKomut.Parameters.AddWithValue("@yayınevi", yayınevi);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleeKomut);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
