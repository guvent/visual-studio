using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace working
{
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.müşteriler' table. You can move, or remove it, as needed.
            this.müşterilerTableAdapter.Fill(this.cagbilDataSet.müşteriler);

           // Program.izle("açıldı.....");

        }

        private void müşterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.müşterilerBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
            }
            catch (Exception ee) { Program.izle("musteriler_bind.nav.sav.item() | " + ee.Message); }
        }

        private void İşyeri_BilgileriTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hesap_NumarasıLabel_Click(object sender, EventArgs e)
        {

        }

        private void müşterilerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
