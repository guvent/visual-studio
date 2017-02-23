using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace working
{
    public partial class faaliyet : Form
    {
        #region initializng

        public faaliyet()
        {
            InitializeComponent();
        }

        ListViewGroup lg;

        private void faaliyet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.faaliyet' table. You can move, or remove it, as needed.
            this.faaliyetTableAdapter.Fill(this.cagbilDataSet.faaliyet);
            lg = listView1.Groups.Add("thday", "Bugün");

            axShockwaveFlash1.LoadMovie(0, Application.StartupPath +"\\saat.swf");

            
            

            oku();
            
        }

        private void faaliyet_Enter(object sender, EventArgs e)
        {
            musteri.Focus();
        }

        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
        }


        #region control
        
        


        private void button1_Click(object sender, EventArgs e)
        {

            dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            kaydet();

            dateTimePicker1.CustomFormat = "dd MMMM yyyy dddd hh:mm:ss";

            oku();

            
            timer1.Enabled = true; planp.Visible = false; panel1.Visible = true;
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            musteri.Text = ""; faaliyt.Text = ""; button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; planp.Visible = false; panel1.Visible = true;
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            musteri.Text = ""; faaliyt.Text = ""; button3.Enabled = false;
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            planp.Visible = true;
            panel1.Visible = false;
        }

        private void planp_VisibleChanged(object sender, EventArgs e)
        {
            if (planp.Visible == true)
            {

                musteri.TabStop = false; faaliyt.TabStop = false;

                textBox1.TabStop = true; textBox2.TabStop = true; textBox3.TabStop = true;

                button3.Enabled = true;

            }
            else
            {

                musteri.TabStop = true; faaliyt.TabStop = true;

                textBox1.TabStop = false; textBox2.TabStop = false; textBox3.TabStop = false;

            }
        }
        
        #endregion

        #region text is

        private void musteri_TextChanged(object sender, EventArgs e)
        {
            texstat(musteri);
        }

        public void texstat(TextBox txs)
        {
            if ((musteri.Text != "" && faaliyt.Text != "") || (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""))
            
            { button1.Enabled = true; } else { button1.Enabled = false; }


            if ((musteri.Text != "" || faaliyt.Text != "" || textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""))
            
            { button3.Enabled = true; } // else { button3.Enabled = false; }

        }

        private void faaliyt_TextChanged(object sender, EventArgs e)
        {
            texstat(faaliyt);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            texstat(textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            texstat(textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            texstat(textBox3);
        }

        #endregion

        #region functions

        public void kaydet()
        {
            string cnn = working.Properties.Settings.Default.cagbilConnectionString;
            string cmd = "";

            if (panel1.Visible)
            {
                cmd = "exec f_ekle @musteri='" + musteri.Text + "', @faaliyet='" + faaliyt.Text + "', @tarih='" + dateTimePicker1.Text + "', @telefon='-', @durum='Bekliyor' ;";
            }
            else
            {
                cmd = "exec f_ekle @musteri='" + textBox1.Text + "', @faaliyet='" + textBox3.Text + "', @tarih='" + dateTimePicker1.Text + "', @telefon='" + textBox2.Text + "', @durum='Not Edildi' ;";
            }

            SqlDataReader dr;

            faaliyetTableAdapter.Adapter.SelectCommand.Connection.ConnectionString = cnn;
            faaliyetTableAdapter.Adapter.SelectCommand.Connection.Open();
            faaliyetTableAdapter.Adapter.SelectCommand.CommandText = cmd;

            dr = faaliyetTableAdapter.Adapter.SelectCommand.ExecuteReader();

            while (dr.Read())
            {
               // MessageBox.Show(dr[0].ToString());

            }
            dr.Close(); faaliyetTableAdapter.Adapter.SelectCommand.Connection.Close();

        }

        public void oku()
        {
            string cnn = working.Properties.Settings.Default.cagbilConnectionString;
            string cmd = "select * from faaliyet";

            SqlDataReader dr;

            faaliyetTableAdapter.Adapter.SelectCommand.Connection.ConnectionString = cnn;
            faaliyetTableAdapter.Adapter.SelectCommand.Connection.Open();
            faaliyetTableAdapter.Adapter.SelectCommand.CommandText = cmd;

            dr = faaliyetTableAdapter.Adapter.SelectCommand.ExecuteReader();

            listView1.Items.Clear();

            while (dr.Read())
            {

                ListViewItem li = new ListViewItem(dr[1].ToString(), lg);

                
                li.SubItems.Add(dr[2].ToString());
                li.SubItems.Add(dr[3].ToString());
                li.SubItems.Add(dr[4].ToString());
                li.SubItems.Add(dr[5].ToString());
                
                listView1.Items.Add(li);

            }
            dr.Close();
            faaliyetTableAdapter.Adapter.SelectCommand.Connection.Close();
        }

        #endregion

    }
}
