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
    public partial class SirketAracları : Form
    {
        public SirketAracları()
        {
            InitializeComponent();
        }

            string Marka, Yakıt, Kasa, Model,Plaka;
            DataTable marka = new DataTable();
             DataTable aracgetir = new DataTable();

        SqlConnection baglanti = new SqlConnection("Data Source = OZCERITBEY\\MSSQLSERVER01; Initial Catalog = DenemePersoneller; Integrated Security = True");
            public SqlCommand komut;
      
            //DATA ÇEKME
            void MarkaGetir()
            {
                baglanti.Open();
                SqlDataAdapter dat = new SqlDataAdapter("SELECT *FROM Ürünler", baglanti);
                dat.Fill(marka);
                dataGridView1.DataSource = marka;
                baglanti.Close();
            }
            //SİLME METHODU
            public void sil()
            {
                string sorgu = "DELETE FROM SirketArabalari WHERE Plaka=@Plaka";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue(@"Plaka", Convert.ToString(textBox2.Text));
                MessageBox.Show("Plaka="+Plaka+" "+"Marka=" + Marka + " " + "Model=" + Model + " " + "Yakıt=" + Yakıt + " " + "Kasa=" + Kasa + " " + "Silindi");
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                marka.Clear();
                MarkaGetir();
            }


            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

       
          

            private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
            //SİLMEK İÇİN GEREKLİ TEXT
    

            private void göster_Click(object sender, EventArgs e)
            {
                SeciliÜrünGetir();
            }
            //SEÇİLEN ÜRÜN GETİRME
            public void SeciliÜrünGetir()
            {
                baglanti.Open();
                SqlCommand dat1 = new SqlCommand("SELECT * FROM Ürünler WHERE Marka=@Marka ", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(dat1);
                dat1.Parameters.AddWithValue(@"Marka", Marka.ToString());
                //dat1.Parameters.AddWithValue(@"Model", Model.ToString());
                //dat1.Parameters.AddWithValue(@"Yakıt", Yakıt.ToString());
                //dat1.Parameters.AddWithValue(@"Kasa", Kasa.ToString());
                marka.Clear();
                adapter.Fill(marka);
                dataGridView1.DataSource = marka;
                baglanti.Close();
            }

        private void SirketAracları_Load(object sender, EventArgs e)
        {
            gizliButton.Hide();
            textBox2.Hide();
            SahipOlunanAracGetir();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            UrunEkle();
            aracgetir.Clear();
            SahipOlunanAracGetir();
            
        }

        private void yenileButton_Click(object sender, EventArgs e)
        {
            marka.Clear();
            MarkaGetir();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ///// İD KULLANIYORUM HİDE TEXTBOX'A GÖNDERİLEN VERİYİ SİLDİRMEK İÇİN
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            markaText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            modelText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yakıtText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kasaText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Plaka = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Marka = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Model = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Yakıt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Kasa = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void SirketAracları_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                sil();
            }
            else if (e.KeyCode == Keys.F5)
            {
                aracgetir.Clear();
                SahipOlunanAracGetir();
            }
           else if (e.KeyCode == Keys.Enter)
            {
                UrunEkle();
                aracgetir.Clear();
                SahipOlunanAracGetir();
            }
            
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracgetir.Clear();
            SahipOlunanAracGetir();
        }

        private void UrunIslemeleri_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    sil();
                }
                else if (e.KeyCode == Keys.F5)
                {
                    marka.Clear();
                    MarkaGetir();
                }
            }
            public void UrunEkle()
            {
            if (Plaka != null && Marka != null && Model != null && Yakıt != null && Kasa != null)
            {
            try
                {
           

                    string sorgu = "INSERT INTO SirketArabalari(Plaka,Marka,Model,YakıtTipi,KasaTipi) VALUES (@Plaka,@Marka,@Model,@YakıtTipi,@KasaTipi)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@Plaka", plakaText.Text);
                    komut.Parameters.AddWithValue("@Marka", markaText.Text);
                    komut.Parameters.AddWithValue("@Model", modelText.Text);
                    komut.Parameters.AddWithValue("@YakıtTipi", yakıtText.Text);
                    komut.Parameters.AddWithValue("@KasaTipi", kasaText.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("Eksik veya tekrarlanan bilgi girmediğinizden emin olunuz");
                }
            }
        }

        public void SahipOlunanAracGetir()
        {
            baglanti.Open();
            SqlDataAdapter dat = new SqlDataAdapter("SELECT *FROM SirketArabalari", baglanti);
            dat.Fill(aracgetir);
            dataGridView1.DataSource = aracgetir;
            baglanti.Close();
        }

        }
    }



