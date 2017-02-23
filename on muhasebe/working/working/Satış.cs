using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace working
{
    public partial class Satış : Form
    {
        public Satış()
        {
            InitializeComponent();
        }

        private void satışBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.satisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
            }
            catch (Exception eee) {
                Program.izle("satis_bind.nav.savitemclick() | " + eee.Message);

            }
        }

        private void Satış_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.satılanlar' table. You can move, or remove it, as needed.
            this.satılanlarTableAdapter.Fill(this.cagbilDataSet.satılanlar);
            // TODO: This line of code loads data into the 'cagbilDataSet.satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.cagbilDataSet.satis);
            // TODO: This line of code loads data into the 'cagbilDataSet.satış' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.cagbilDataSet.satis);
            
        }

        private void satisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.satisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
            }
            catch (Exception ert) { Program.izle("satis_bind.nav.saveitemclck() | " + ert.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.satisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
            }
            catch (Exception ert) { Program.izle("satis_bind.nav.savitemcl2() | " + ert.Message); }
        }
    }
}
