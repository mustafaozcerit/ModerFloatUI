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

namespace Deneme
{
    public partial class PersonelIslemleri : Form
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = OZCERITBEY\\MSSQLSERVER01; Initial Catalog = DenemePersoneller; Integrated Security = True");
        SqlCommand komut;
        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {

            this.Text = "Personel İslemleri";
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            PersonelGetir1();
        }
        void PersonelGetir1()
        {
            baglanti.Open();
            SqlDataAdapter dat = new SqlDataAdapter("SELECT *FROM PersonelBilgileri ", baglanti);
            DataTable tablo = new DataTable();
            dat.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM PersonelBilgileri WHERE TcNo=@TcNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue(@"TcNo", Convert.ToString(textBox1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelGetir1();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO PersonelBilgileri(TcNo,Adi,Soyadi,Yetki,KullaniciAdi,Sifre,Adres) VALUES (@TcNo,@Adi,@Soyadi,@Yetki,@KullaniciAdi,@Sifre,@Adres)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TcNo", textBox1.Text);
                komut.Parameters.AddWithValue("@Adi", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyadi", textBox3.Text);
                komut.Parameters.AddWithValue("@Yetki", comboBox1.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", textBox5.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox6.Text);
                komut.Parameters.AddWithValue("@Adres", textBox7.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                PersonelGetir1();
            }
            catch
            {
                MessageBox.Show("TNo Aynı Olamaz Lütfen Farklı Bir TcNo Giriniz"  );
            }
           
          
            //baglanti.Open();
            //komut = new SqlCommand("insert into PersonelBilgileri(TcNo,Adi,Soyadi,Yetki,KullaniciAdi,Sifre,Adres) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "','"
            //    + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "','" + textBox6.Text.ToString() + "','"
            //    + textBox7.Text.ToString() + "')", baglanti);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //PersonelGetir1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE PersonelBilgileri SET Adi=@Adi,Soyadi=@Soyadi,Yetki=@Yetki,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,Adres=@Adres WHERE TcNo=@TcNo";
            komut =new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TcNo", textBox1.Text);
            komut.Parameters.AddWithValue("@Adi", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyadi", textBox3.Text);
            komut.Parameters.AddWithValue("@Yetki", comboBox1.Text);
            komut.Parameters.AddWithValue("@KullaniciAdi", textBox5.Text);
            komut.Parameters.AddWithValue("@Sifre", textBox6.Text);
            komut.Parameters.AddWithValue("@Adres", textBox7.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            PersonelGetir1();    
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



 
  
