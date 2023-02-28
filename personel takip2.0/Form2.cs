using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;




namespace personel_takip2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }
           
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-QURV0EN;Initial Catalog=sqlpersoneltakip;Integrated Security=True");

        void temizle()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";


            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox6.Text = "";
            maskedTextBox4.Text = "";
            comboBox4.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox2.Text = "";
            txtara.Text = "";
           

            textBox3.Focus();

        }
         
           











        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sqlpersoneltakipDataSet9.dahadaartanbilgilerim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dahadaartanbilgilerimTableAdapter3.Fill(this.sqlpersoneltakipDataSet9.dahadaartanbilgilerim);


            this.Text = "Kullanıcı İşlemleri";
            

        }
        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.dahadaartanbilgilerimTableAdapter3.Fill(this.sqlpersoneltakipDataSet9.dahadaartanbilgilerim);
            verilerigöster("Select * from  dahadaartanbilgilerim ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into dahadaartanbilgilerim(ad,soyad,yas,maas,departman,cinsiyet,medenihal,izin_gunleri,calisma_saatleri,adres,telefon_no,ogrenim_durumu,is_tecrubesi,personel_no) values (@personel1,@personel2,@personel3,@personel4,@personel5,@personel6,@personel7,@personel8,@personel9,@personel10,@personel11,@personel12,@personel13,@personel14)", baglanti);

            komut.Parameters.AddWithValue("@personel1",textBox3.Text);
            komut.Parameters.AddWithValue("@personel2", textBox2.Text);
            komut.Parameters.AddWithValue("@personel3", textBox1.Text);
            komut.Parameters.AddWithValue("@personel4", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@personel5", textBox4.Text);
            komut.Parameters.AddWithValue("@personel6", textBox5.Text);
            komut.Parameters.AddWithValue("@personel7",comboBox1.Text);

            komut.Parameters.AddWithValue("@personel8", comboBox2.Text);
            komut.Parameters.AddWithValue("@personel9", comboBox3.Text);
            komut.Parameters.AddWithValue("@personel10", textBox6.Text);
            komut.Parameters.AddWithValue("@personel11", maskedTextBox4.Text);
            komut.Parameters.AddWithValue("@personel12", comboBox4.Text);
            komut.Parameters.AddWithValue("@personel13", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@personel14", maskedTextBox2.Text);
            

          komut.ExecuteNonQuery();
            
     
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox3.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();


            comboBox2.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[secim].Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secim].Cells[9].Value.ToString();
            maskedTextBox4.Text = dataGridView1.Rows[secim].Cells[10].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[secim].Cells[11].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[secim].Cells[12].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secim].Cells[13].Value.ToString();
           

           
            
            







        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlCommand sil = new SqlCommand("Delete From dahadaartanbilgilerim Where ad=@personel1", baglanti);
            sil.Parameters.AddWithValue("@personel1", textBox3.Text);
            sil.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update dahadaartanbilgilerim Set ad='" + textBox3.Text + "',soyad='" + textBox2.Text + "',yas='" + textBox1.Text + "',maas='" + maskedTextBox1.Text + "',departman='" + textBox4.Text+ "',cinsiyet='" + textBox5.Text + "',medenihal='" + comboBox1.Text+ "',izin_gunleri='" + comboBox2.Text+ "',calisma_saatleri='" + comboBox3.Text + "',adres='" + textBox6.Text + "',telefon_no='" + maskedTextBox4.Text + "',ogrenim_durumu='" + comboBox4.Text + "',is_tecrubesi='" + maskedTextBox3.Text + "',personel_no='" + maskedTextBox2.Text + "'", baglanti);
            
            
            guncelle.ExecuteNonQuery();
            verilerigöster("Select * from  dahadaartanbilgilerim ");
            baglanti.Close();
           
            MessageBox.Show("Personel Güncellemesi Tamamlandı");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            string kayit = "Select * From dahadaartanbilgilerim where soyad=@personel2";
            SqlCommand getir=new SqlCommand(kayit,baglanti);

            getir.Parameters.AddWithValue("@personel2",txtara.Text);
            SqlDataAdapter da =new SqlDataAdapter(getir);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 don = new Form1();
            don.Show();
        }
    }
}
