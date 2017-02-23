using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace working
{
    public partial class Yapılan_İşlemler : Form
    {
        public Yapılan_İşlemler()
        {
            InitializeComponent();
        }

        private void yapılanişlemlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.yapılanişlemlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cagbilDataSet);

        }

        private void Yapılan_İşlemler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.yapılanişlemler' table. You can move, or remove it, as needed.
            this.yapılanişlemlerTableAdapter.Fill(this.cagbilDataSet.yapılanişlemler);

        }

        private void yapılan_İşlemLabel_Click(object sender, EventArgs e)
        {

        }

        private void yapılan_İşlemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
