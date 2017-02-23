using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kres
{
    public partial class veli : Form
    {
        public Form1 backf = null;

        public veli()
        {
            InitializeComponent();
        }

        private void veli_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void veliBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kbs.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kresDataSet);

        }

        private void veli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresDataSet.veli' table. You can move, or remove it, as needed.
            this.veliTableAdapter.Fill(this.kresDataSet.veli);

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                kbs.Filter = "[Veli Adı Soyadı :] like '" + textBox1.Text + "'";
                textBox1.Text = "";
            }
            else
            {
                kbs.Filter = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (öğrenci_TC__TextBox.DataBindings.Control.Text != "")
            {
                backf.ogrencisi("[TC No :]=" + öğrenci_TC__TextBox.DataBindings.Control.Text );
            }
        }
    }
}
