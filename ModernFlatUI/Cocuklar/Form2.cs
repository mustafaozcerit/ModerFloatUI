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
namespace Deneme
{
  
    public partial class Yönetici : Form
    {
        int deger=0;
        public Yönetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = OZCERITBEY\\MSSQLSERVER01; Initial Catalog = DenemePersoneller; Integrated Security = True");
        SqlCommand komut = new SqlCommand();
        private void Yönetici_Load(object sender, EventArgs e)
        {
            this.Text = "Yönetici Paneli";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            mb1.Hide();
            mb2.Hide();
            mb3.Hide();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personelislem = new PersonelIslemleri();
            personelislem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunIslemeleri urunıslem = new UrunIslemeleri();
            urunıslem.Show();
           
        }

        private void menüBar_Click(object sender, EventArgs e)
        {
            deger++;
            if (deger % 2 == 0)
            {
                mb1.Show();
                mb2.Show();
                mb3.Show();

            }
            else
            {
                mb1.Hide();
                mb2.Hide();
                mb3.Hide();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void loader_Tick(object sender, EventArgs e)
        //{
        //    if(bunifuCircleProgressbar1.Value<100){
        //        bunifuCircleProgressbar1.Value++;
        //    }
        //    else
        //    {
        //        panel1.Visible = false;
        //    }

        //}
    }
}
