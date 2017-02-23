using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kres
{
    public partial class etkinlik : Form
    {
        public etkinlik()
        {
            InitializeComponent();
        }

        private void etkinlik_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void etkinlikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kbs.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kresDataSet);

        }

        private void etkinlik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresDataSet.etkinlik' table. You can move, or remove it, as needed.
            this.etkinlikTableAdapter.Fill(this.kresDataSet.etkinlik);

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            kbs.AddNew();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                kbs.RemoveCurrent();
            }
            else
            {
                kbs.CancelEdit();
                tableAdapterManager.UpdateAll(kresDataSet);
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            kbs.EndEdit();
            tableAdapterManager.UpdateAll(kresDataSet);
            button1.Enabled = true;
        }
    }
}
