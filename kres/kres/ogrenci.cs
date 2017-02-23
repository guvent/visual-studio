using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kres
{
    public partial class ogrenci : Form
    {
        public Form1 backf = null;

        public ogrenci()
        {
            InitializeComponent();
            
        }

        private void ogrenci_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }

        private void ogrenciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kbs.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kresDataSet);

        }

        private void ogrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kresDataSet.ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.kresDataSet.ogrenci);

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
                kbs.Filter = "[Adı :] like '" + textBox1.Text + "'";
                textBox1.Text = "";
            }
            else
            {
                kbs.Filter = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tC_No__TextBox.DataBindings.Control.Text != "")
            {
                backf.velisi("[Öğrenci TC :]="+ tC_No__TextBox.DataBindings.Control.Text);
            }
        }
    }
}
