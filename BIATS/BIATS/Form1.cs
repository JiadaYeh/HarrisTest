using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIATS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private const int HT_CLIENT = 0x1;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.Capture = false;
            panel3.Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref   msg);
        }

        private void tsBtn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Gainsboro;
            label4.BackColor = Color.FromArgb(22, 173, 218);
            label4.ForeColor = Color.White;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.White;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Gainsboro;
            label5.BackColor = Color.FromArgb(22, 173, 218);
            label5.ForeColor = Color.White;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.White;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            flowLayoutPanel1.Controls.Add(uc1);
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();

            flowLayoutPanel1.Controls.Add(uc1);
        }

        private void tsBtn_Max_Click(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            if (this.WindowState != FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
