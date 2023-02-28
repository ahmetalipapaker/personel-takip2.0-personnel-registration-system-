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

namespace personel_takip2._0
{
    public partial class Form4 : Form
    {

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QURV0EN;Initial Catalog=sqlpersoneltakip;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }
        Form1 k = new Form1();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            

            baglan.Open();
            string user;
            string password;
            user = textBox1.Text;
            password = textbox33.Text;

            SqlCommand sorgu = new SqlCommand("select * from Kullanici_bilgisi where kullanici_adi='" + user + "' ", baglan);
            SqlDataReader oku = sorgu.ExecuteReader();

            // Yukarıda okuduğu sql bilgilerini, aşşagıda kullanıcı ismi doğru ise güncelliyor
            if (oku.Read())
            {
                oku.Close();
                SqlCommand guncelle = new SqlCommand("update Kullanici_bilgisi set sifre='" + password + "' where kullanici_adi='" + user + "'", baglan);
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Şifreniz Başarı İle Güncellendi");
            }
            else
            {
                MessageBox.Show("Kullanici Adi Bulunamamakta.");
            }

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 git = new Form1();
            git.Show();
        }
    }
}
