using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace working
{
    public partial class Form1 : Form
    {
        public Form mdi;
        
        public Form1(ref NotifyIcon nf)
        {
            InitializeComponent();
            nf = notifyIcon1;
            mdi = new MDIParent1();
        }

        public void sistemizle(string nediyor)
        {
            switch (nediyor)
            { 
                case "":
                //    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAreaEnabled;
                    mdi.Focus(); mdi.Show();
                    mdi.WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Location.Offset(Screen.PrimaryScreen.Bounds.Height - this.Size.Width, Screen.PrimaryScreen.Bounds.Height - this.Size.Height);

            //mdi = new MDIParent1();
            
            mdi.Show();
            if (reg.ayarlar.systray.ToLower() != "false")
            {
                notifyIcon1.ShowBalloonTip(1000);
            }

            mdi.Focus();

           // this.WindowState = FormWindowState.Minimized;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            notifyIcon1.Visible = false;

            Application.ExitThread();
           // mdi.WindowState = FormWindowState.Normal;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdi.Show();
            mdi.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            notifyIcon1.Visible = false;
        }
    }
}
