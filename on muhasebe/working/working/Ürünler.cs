using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace working
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        private void ürünlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ürünlerBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
                ürünlerBindingSource1.AddNew();
            }
            catch (Exception ers) { Program.izle("urunler_bind.nav.saveitem() | " + ers.Message); }
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.ürünler' table. You can move, or remove it, as needed.
            this.ürünlerTableAdapter.Fill(this.cagbilDataSet.ürünler);
            barkod_NoTextBox.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ürünlerBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
                ürünlerBindingSource1.AddNew();
            }
            catch (Exception ers) { Program.izle("urunler_button4click() | " + ers.Message); }
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {   ürünlerBindingSource1.CancelEdit();
                    ürünlerBindingSource1.AddNew();
                    barkod_NoTextBox.Focus();
                    tamamlaToolStripMenuItem.Enabled = true;
                    yeniKayıtToolStripMenuItem.Enabled = false; }
            catch (Exception er) { Program.izle(er.Message);    }
        }

        private void tamamlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ürünlerBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
                ürünlerBindingSource1.AddNew();
                tamamlaToolStripMenuItem.Enabled = false;
                yeniKayıtToolStripMenuItem.Enabled = true;
            }
            catch (Exception ers) { Program.izle("urunler_menu_tamamlaclk() | " + ers.Message); }
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barkod_NoTextBox.Text = ""; barkod_NoTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            if (barkod_NoTextBox.Text != "")
            {
                string tx = barkod_NoTextBox.Text;
                string cmd = "select * from [ürünler] where [Barkod No]='" + tx + "'";
                ürünlerTableAdapter.Adapter.SelectCommand.CommandText = cmd;
                ürünlerTableAdapter.Adapter.SelectCommand.Connection.Open();

                dr = ürünlerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    ürünlerBindingSource1.CancelEdit();
                    tableAdapterManager.UpdateAll(cagbilDataSet);
                }

                ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close();

                ürünlerBindingSource1.Filter = "[Barkod No]='" + tx + "'";


            }
            else
            {
                ürünlerBindingSource1.Filter = "";
            }

        }

        private void barkod_NoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SqlDataReader dr;
                if (barkod_NoTextBox.Text != "")
                {
                    string tx = barkod_NoTextBox.Text;
                    string cmd = "select * from [ürünler] where [Barkod No]='" + tx + "'";
                    ürünlerTableAdapter.Adapter.SelectCommand.CommandText = cmd;
                    ürünlerTableAdapter.Adapter.SelectCommand.Connection.Open();

                    dr = ürünlerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                    if (dr.HasRows)
                    {
                        ürünlerBindingSource1.CancelEdit();
                        tableAdapterManager.UpdateAll(cagbilDataSet);
                    }

                    ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close();
                    ürünlerBindingSource1.Filter = "";
                    ürünlerBindingSource1.Filter = "[Barkod No]='" + tx +"'";
                }
                else
                {
                    ürünlerBindingSource1.Filter = "";
                }
            }
        }
    }
}
