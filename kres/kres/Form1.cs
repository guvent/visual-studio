using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kres
{
    public partial class Form1 : Form
    {
        etkinlik etkinlik = new etkinlik();
        ogrenci ogrenci = new ogrenci();
        personel personel = new personel();
        veli veli = new veli();
        yemek yemek = new yemek();

        bool kapat = true;

        public Form1()
        {
            InitializeComponent();

            

        }

        public void velisi(string velikim)
        {
            veli.backf = this;
            veli.kbs.Filter = velikim;
            veli.Show();
            veli.Focus();
        }

        public void ogrencisi(string ogrencikim)
        {
            ogrenci.backf = this;
            ogrenci.kbs.Filter = ogrencikim;
            ogrenci.Show();
            ogrenci.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci.backf = this;
            ogrenci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veli.backf = this;
            veli.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yemek.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            etkinlik.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cvb = MessageBox.Show("Emin misiniz kapatırken yarım kalan işlemler iptal olur.!","Kapanıyor..!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning).ToString();
            if (cvb == "Yes") { kapat = false; Application.ExitThread(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = kapat;
        }
    }
}
