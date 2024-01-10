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
    public partial class kitapcesid : Form
    {
        SqlConnection yenibaglanti = new SqlConnection("Data Source=EXCALIBUR\\SQLEXPRESS;Initial Catalog=kutupOtomasyon;Integrated Security=True");
        public kitapcesid()
        {
            InitializeComponent();
        }
        private void listele1()
        {
            yenibaglanti.Open();
            SqlCommand listeleeKomut = new SqlCommand("Select *from kitapCesid", yenibaglanti);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listeleeKomut);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            yenibaglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand ekleyenKomut = new SqlCommand("INSERT INTO kitapCesid (turAdi) values (@turAdi)", yenibaglanti);
            ekleyenKomut.Parameters.AddWithValue("@turAdi", tur_textBox.Text);
            yenibaglanti.Open();
            ekleyenKomut.ExecuteNonQuery();
            yenibaglanti.Close();

            listele1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var seciliId = dataGridView1.CurrentRow.Cells["id"].Value;

            yenibaglanti.Open();
            SqlCommand SilKomut = new SqlCommand("Delete from kitapCesid where id = @pid", yenibaglanti);
            SilKomut.Parameters.AddWithValue("@pid", seciliId);
            SilKomut.ExecuteNonQuery();
            yenibaglanti.Close();

            listele1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var seciliId = dataGridView1.CurrentRow.Cells["id"].Value;

            yenibaglanti.Open();
            SqlCommand guncelleKomut = new SqlCommand("Update kitapCesid SET kitapTuru=@kitapTuru WHERE id=@pid", yenibaglanti);
            guncelleKomut.Parameters.AddWithValue("@turAdi", tur_textBox.Text);
            guncelleKomut.Parameters.AddWithValue("@pid", seciliId);
            guncelleKomut.ExecuteNonQuery();
            yenibaglanti.Close();

            listele1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tur_textBox.Clear();
        }
    }
}
