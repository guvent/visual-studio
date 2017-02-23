using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace ajanda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            takvim.SelectionStart = DateTime.Now;
            takvim.SelectionEnd = DateTime.Now;

        }

        private void takvim_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            dosyalar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; 
            tamam.Visible = true;
            iptal.Visible = true;
            textBox1.Enabled = true;
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            dosyaolustur();
        }

        private void dosyaolustur()
        {
            if (textBox1.Text != "")
            {
                string file = "notlar\\" + takvim.SelectionStart.ToShortDateString() + " " + textBox1.Text;
                StreamWriter wr = new StreamWriter(Application.StartupPath + "\\" + file, false);

                wr.Write(textBox2.Text);
                wr.Flush();
                wr.Close();

                tamam.Visible = false; iptal.Visible = false;
            }
            else
            {
                textBox1.BackColor = Color.LightBlue;
                textBox1.Focus();
            }
            dosyalar();

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            tamam.Visible = false; iptal.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void dosyalar()
        {
            DirectoryInfo dr = new DirectoryInfo(Application.StartupPath + "\\notlar\\");

            FileInfo[] fl = dr.GetFiles();

            listBox1.Items.Clear();
            for (int i = 0; i < fl.Length; i++)
            {
                if(fl[i].Name.StartsWith(takvim.SelectionStart.ToShortDateString()))
                {
                    listBox1.Items.Add(fl[i].Name);
                }

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dosyalar();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string b = listBox1.SelectedItem.ToString();
                b = b.Replace(takvim.SelectionStart.ToShortDateString() + " ", "");
                textBox1.Text = b;
                oku(listBox1.SelectedItem.ToString());
                iptal.Visible = true;
                tamam.Visible = true;
                textBox1.Enabled = false;
            }
        }

        private void oku(string d)
        {
            StreamReader rd = new StreamReader(Application.StartupPath + "\\notlar\\" + d);

            textBox2.Text = rd.ReadToEnd();
            rd.Close();
        }

        private void iptal_VisibleChanged(object sender, EventArgs e)
        {
            switch (iptal.Visible)
            {
                case false:
                    notlar.Visible = true;
                    button2.Visible = true;
                    break;
                case true:
                    notlar.Visible = false;
                    button2.Visible = false;
                    break;
            }
        }

    }
}
