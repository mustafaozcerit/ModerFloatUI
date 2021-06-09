using Deneme;
using DevExpress.XtraEditors.ColorPick.Picker;
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

namespace ModernFlatUI
{
    public partial class GirisMenü : Form
    {
        public GirisMenü()
        {

            InitializeComponent();
        }
        // Veri Tabanı dosya yolu ve proveider nesnesinin belirlenmesi
        SqlConnection baglanti = new SqlConnection("Data Source = OZCERITBEY\\MSSQLSERVER01; Initial Catalog = DenemePersoneller; Integrated Security = True");
        SqlCommand komut = new SqlCommand();
        //Formlar arasında veri aktarımında kullanılacak değişkenler
        public static string tcno, adi, soyadi, yetki, radiosecili;
        string saat, tarih,girisTipi;
        bool move;
        int mouse_x;
        int mouse_y;
        int hak = 0;
        int saniye = 60;
        int dakika = 0;
        int deger = 5;

        private void GirisMenü_Load(object sender, EventArgs e)
        {
            tarihTimer.Start();
            radioButton1.Checked = true;
            label1.Hide();
            kalanDK.Hide();
            kalanSn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter kulanicilar = new SqlDataAdapter("SELECT KullaniciAdi FROM PersonelBilgileri ", baglanti);
            //SqlDataAdapter sifreler = new SqlDataAdapter("SELECT Sifre FROM PersonelBilgileri ", baglanti);
            string isim = isimText.Text;
            //string dönen = "Select Yetki  from PersonelBilgileri  where KullaniciAdi=@isim";

            if (hak < 3)
            {
                label1.Hide();
                kalanDK.Hide();
                kalanSn.Hide();
                baglanti.Open();
                string sql = "Select *from PersonelBilgileri where KullaniciAdi=@Adi  AND Sifre=@sifresi AND Yetki=@dönen";
                SqlParameter prm1 = new SqlParameter("adi", isimText.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", gizliText.Text.Trim());
                SqlParameter prm3 = new SqlParameter("dönen", radiosecili);
                //SqlParameter prm4 = new SqlParameter("dönen", kul );
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                komut.Parameters.Add(prm3);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    girisTipi = "Dogru";
                    TarihYaz();
                    MessageBox.Show("Sifre Doğru Sayfaya  Yönlendiriliyorsunuz");
                    if (radiosecili == "Kullanici")
                    {
                        GirisMenü giris = new GirisMenü();
                        giris.Close();
                        PersonelIslemleri personel = new PersonelIslemleri();
                        personel.Show();
                    }
                    else
                    {
                        GirisMenü giris = new GirisMenü();
                        giris.Close();
                        panelMenü yönetici = new panelMenü();
                        yönetici.Show();
                     
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Sifre Hatalı Lütfen Tekrar Deneyiniz");
                    girisTipi = "Hatali";
                    TarihYaz();
                    hak++;
                }
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                MessageBox.Show("3 Defa Hatalı Giriş Yaptınız Lütfen 5 Dakika Bekleyiniz");
                girisTipi = "Zorla";
                TarihYaz();
                button1.Hide();
                label1.Show();
                kalanDK.Show();
                kalanSn.Show();
                dakika = Convert.ToInt32(deger);
                hak = 0;
                cezaTimer.Start();
                panel3.BackColor = Color.Red;
                baglanti.Close();
                
            }
        }

        private void GirisMenü_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void cezaTimer_Tick(object sender, EventArgs e)
        {
            cezaTimer.Interval = 1000;
            saniye = saniye - 1;
            kalanSn.Text = Convert.ToString(saniye);
            kalanDK.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {
                dakika = dakika - 1;
                kalanDK.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (kalanDK.Text == "-1")
            {
                button1.Show();
                cezaTimer.Stop();
                kalanDK.Text = "00";
                kalanSn.Text = "00";
                panel3.BackColor  = System.Drawing.ColorTranslator.FromHtml("#1f1e44"); 

            }
        }

        private void GirisMenü_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
           
        }

        private void GirisMenü_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

    

        private void isimText_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void isimText_MouseClick(object sender, MouseEventArgs e)
        {
            isimText.Text = "";
           
        }

        private void isimText_MouseHover(object sender, EventArgs e)
        {
        }

        private void gizliText_MouseClick(object sender, MouseEventArgs e)
        {
            gizliText.Text = "";
        }

        private void tarihTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            tarihLGöster.Text = dt.ToLongDateString();
            saatLGöster.Text = dt.ToLongTimeString();
            saat = dt.ToLongTimeString();
            tarih = dt.ToShortDateString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
            radiosecili = "Kullanici";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiosecili = "Yönetici";
        }
        public void TarihYaz()
        {
            string sorgu1 = "INSERT INTO KullaniciKontrol(KullaniciAdi,Yetki,GirisTarihi,Saat,GirisTipi) VALUES (@KullaniciAdi,@Yetki,@GirisTarihi,@Saat,@GirisTipi)";
            komut = new SqlCommand(sorgu1, baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", isimText.Text);
            komut.Parameters.AddWithValue("@Yetki", radiosecili);
            komut.Parameters.AddWithValue("@GirisTarihi", tarih);
            komut.Parameters.AddWithValue("@Saat", saat);
            komut.Parameters.AddWithValue("@GirisTipi", girisTipi);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        
    }
}
