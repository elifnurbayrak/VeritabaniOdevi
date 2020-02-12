using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CR7EU6U7;Initial Catalog=PorschBugaCars;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
                string gelenkomut = "SELECT Marka FROM Marka";
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = gelenkomut;
                SqlDataAdapter adaptor = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                adaptor.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenkomut = textBox1.Text;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = gelenkomut;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            

            try
            {
                adaptor.Fill(dt);
            }
            catch(Exception)
            {
                MessageBox.Show("Girdiğiniz komut hatalıdır. Lütfen kontrol ediniz");
            }
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'porschBugaCarsDataSet.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.porschBugaCarsDataSet.Departman);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string gelenkomut = "SELECT * FROM Personel";
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = gelenkomut;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string gelenkomut = "SELECT * FROM Personel";
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = gelenkomut;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string gelenkomut = "SELECT * FROM Personel";
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = gelenkomut;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
