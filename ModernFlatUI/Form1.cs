using Deneme;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace ModernFlatUI
{
    public partial class panelMenü : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public panelMenü()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 85);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        int mouse_x;
        int mouse_y;
        bool move;
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        private void ActiveteButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentForm.IconChar = currentBtn.IconChar;
                iconCurrentForm.IconColor = color;

            }
        }
        private void DisableButton()
        {

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
         
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBColors.color1);
            OpenChildForm(new PersonelIslemleri());
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBColors.color2);
            OpenChildForm(new UrunIslemeleri());
        }

        private void ıconButton4_Click_1(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBColors.color4);
          
        }

        private void ıconButton3_Click_1(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBColors.color3);
            OpenChildForm(new SirketAracları());
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            ActiveteButton(sender, RGBColors.color5);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentForm.IconChar = IconChar.Home    ;
            iconCurrentForm.IconColor = Color.MediumPurple;
            lblTitle.Text = "Giriş";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd , int wMsg , int  wParam,int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskop.Controls.Add(childForm);
            panelDeskop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCurrentForm_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            delay.Stop();

        }

        private void standaloneBarDockControl1_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenü_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panelMenü_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void panelMenü_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panelMenü_Load(object sender, EventArgs e)
        {

        }
    }
}
