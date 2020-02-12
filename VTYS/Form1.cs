using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VTYS
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-CR7EU6U7;Initial Catalog=PorschBugaCars;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Personel where kullaniciadi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
