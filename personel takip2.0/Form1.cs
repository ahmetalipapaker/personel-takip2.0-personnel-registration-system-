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
using System.Data.SqlClient;
using System.Data.Sql;

namespace personel_takip2._0
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QURV0EN;Initial Catalog=sqlpersoneltakip;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand com;
        
        



        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = button1;
            
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string user = textBox1.Text;
            string password=textBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-QURV0EN;Initial Catalog=sqlpersoneltakip;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Kullanici_Bilgisi where kullanici_adi='" + textBox2.Text + "'And sifre='" + textBox1.Text + "'";
            
            dr=com.ExecuteReader();
           
            
            if (dr.Read())
            {

                this.Hide();
                Form2 gecis=new Form2();
                gecis.Show();
               
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre");
            }
            con.Close();

         }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 gecis=new Form4();
            gecis.Show();
            
        }

        public void sifre(TextBox kullanici_adi, TextBox soru, TextBox cevap,TextBox sifre, TextBox sifretekrar) 
        {
            if (sifre.Text == sifretekrar.Text)
            {
                con.Open();
                com = new SqlCommand("select * from Kullanici_Bilgisi where kullanici_adi='" + kullanici_adi.Text + "'", con);
                dr = com.ExecuteReader();
                if (dr.Read() == true)
                {
                    if (soru.Text == dr["soru"].ToString() && cevap.Text == dr["cevap"].ToString())
                    {
                        con.Close();
                        con.Open();
                        com = new SqlCommand("Update Kullanici_bilgisi set sifre='"+ sifre.Text +"'Where kullanici_adi='"+ kullanici_adi.Text+"'",con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("işlem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı hariç diğer bilgilerinizi kontrol ediniz", "Hata1");
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz", "Hata2");
                }
                con.Close();
            }
            

            else
            {
                MessageBox.Show("Şifreler uyuşmuyor","Hata3");
            }
        
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) 
            {
                textBox1.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";         
            }
        }
    }
    
    
    
    
    
    
    
    }








