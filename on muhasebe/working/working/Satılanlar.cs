using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace working
{
    public partial class Satılanlar : Form
    {
        public Satılanlar()
        {
            InitializeComponent();
        }

        private void satılanlarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.satılanlarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cagbilDataSet);

        }

        private void Satılanlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.satılanlar' table. You can move, or remove it, as needed.
            this.satılanlarTableAdapter.Fill(this.cagbilDataSet.satılanlar);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
