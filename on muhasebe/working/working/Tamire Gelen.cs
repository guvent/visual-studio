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
    public partial class Tamire_Gelen : Form
    {
        public Tamire_Gelen()
        {
            InitializeComponent();
        }

        private void tamiregelenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try {
            this.Validate();
            this.tamiregelenBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
            bindingNavigatorAddNewItem.Enabled = true;

            tamiregelenBindingSource1.AddNew();

            etiket_NoTextBox.Text= kodolustur();
            }
            catch (Exception err) { Program.izle("tamiregelen_bind.nav.saveitemclck() | " + err.Message); }

        }

        public string kodolustur()
        {
            string code = ""; int gcode = 0;

            DateTime dt = DateTime.Now;

            gcode = 10000 + (dt.Hour * 10000) + (dt.Minute * 100); //+ dt.Second;

            gcode = (1000000 + Convert.ToInt32(belge_NoTextBox.Text)) * gcode ;

            if (gcode <= 0) { gcode = gcode * (-1); }

            code =  gcode.ToString();

            teslim_AlmaDateTimePicker.Value = DateTime.Now.AddDays(0);

            return code;
        
        }

        private void Tamire_Gelen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cagbilDataSet.müşteriler' table. You can move, or remove it, as needed.
            this.müşterilerTableAdapter.Fill(this.cagbilDataSet.müşteriler);


            // TODO: This line of code loads data into the 'cagbilDataSet.tamiregelen' table. You can move, or remove it, as needed.
            this.tamiregelenTableAdapter.Fill(this.cagbilDataSet.tamiregelen);

            #region urunler
            
            SqlDataReader rd;
            
            try
            {
            müşterilerTableAdapter.Adapter.SelectCommand.Connection.Open();
            müşterilerTableAdapter.Adapter.SelectCommand.CommandText = "select * from [müşteriler]";
            müşterilerTableAdapter.Adapter.Fill(cagbilDataSet);

            

                rd = müşterilerTableAdapter.Adapter.SelectCommand.ExecuteReader();


                while (rd.Read())
                {
                    sahibiTextBox.AutoCompleteCustomSource.Add(rd[1].ToString());
                }
                rd.Close();

            müşterilerTableAdapter.Adapter.SelectCommand.Connection.Close();

            }
            catch (Exception exr) { Program.izle("tamiregelen_load() | " + exr.Message); }


            #endregion

            
        }

        private void İrtibat_TelefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void tamiregelenBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tamiregelenBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            Program.izle("tamiregelen_bind.nav.sour.data.err() | " + e.Exception.Message.ToString());
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void yapılan_İşlemLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yapılan_İşlemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void belge_NoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void şikayet___İstekTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public string sahibi; public string irtibat; public string cihaz;
        public string sikayet; public string bilesen; public string tarih; public string etiket;
        

        private void yazdir() {
            


            /**/
             sahibi = sahibiTextBox.Text;
             irtibat = İrtibat_TelefonTextBox.Text;
             cihaz = cihaz_AdıTextBox.Text;
             sikayet = şikayet___İstekTextBox.Text;
             bilesen = bileşenlerTextBox.Text;

             tarih = teslim_AlmaDateTimePicker.Text;
            //**/
            working.MDIParent1.gt(ref sahibi, ref irtibat, ref cihaz, ref sikayet, ref bilesen, ref tarih,ref etiket);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            string brf =  etiket_NoTextBox.Text;
            
            bool hata=false;



                try
                {

                    this.Validate();
                    this.tamiregelenBindingSource1.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
                    bindingNavigatorAddNewItem.Enabled = true;

                }
                catch (Exception err) {
                 //   tamiregelenBindingSource.CancelEdit();
                 //   tamiregelenBindingSource.Clear();
                    hata = true; Program.izle("tamiregelen_button2click() | " + err.Message); 
                }

                if (!hata && !musteri())
                {
            
                    Form br = new barkod(ref brf);
                    //  br.MdiParent = this;
                    br.Show();
            
                    yazdir();

                    tamiregelenBindingSource1.AddNew();

                    etiket_NoTextBox.Text = kodolustur();

                    sahibiTextBox.Focus();
                }
            
        }

        private void Tamire_Gelen_Enter(object sender, EventArgs e)
        {
            try {
            tamiregelenBindingSource1.AddNew();


            etiket_NoTextBox.Text = kodolustur();

            sahibiTextBox.Focus(); sahibiTextBox.Update();
            }
            catch (Exception err) { Program.izle("tamiregelen_enter() | " + err.Message); }
        }

        

        private void tAMAMLAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            string brf = etiket_NoTextBox.Text;

            bool hata = false;



            try
            {

                this.Validate();
                this.tamiregelenBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);
                bindingNavigatorAddNewItem.Enabled = true;

            }
            catch (Exception err)
            {
                //   tamiregelenBindingSource.CancelEdit();
                //   tamiregelenBindingSource.Clear();
                hata = true; Program.izle("tamiregelen_button2click() | " + err.Message);
            }

            if (!hata && !musteri())
            {

                Form br = new barkod(ref brf);
                //  br.MdiParent = this;
                br.Show();

                yazdir();

                tamiregelenBindingSource1.AddNew();

                etiket_NoTextBox.Text = kodolustur();

                sahibiTextBox.Focus();
            }
        }

        private void bileşenlerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sahibiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public bool musteri() 
        {

            SqlDataReader rd; bool hata = false;

            try
            {
                müşterilerTableAdapter.Adapter.SelectCommand.Connection.Open();
                müşterilerTableAdapter.Adapter.SelectCommand.CommandText = "select * from [müşteriler] where [Müşteri Ad Soyad]='" + sahibiTextBox.Text +"'";
                müşterilerTableAdapter.Adapter.Fill(cagbilDataSet);

                rd = müşterilerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                if (!rd.HasRows)
                {
                    rd.Close();  müşterilerTableAdapter.Adapter.SelectCommand.Connection.Close();
                    
                    müşterilerBindingSource1.AddNew();

                    müşteri_Ad_SoyadTextBox.Text = sahibiTextBox.Text;
                    İrtibat_TelefonTextBox1.Text = İrtibat_TelefonTextBox.Text;

                    müşterilerBindingSource1.EndEdit();
                    müşterilerTableAdapter.Update(cagbilDataSet);

                }
            }
            catch (Exception exr) {

                müşterilerBindingSource1.CancelEdit();
               // müşterilerBindingSource.Clear();
                Program.izle("tamiregelen_musteri() | " + exr.Message); hata = true;
            }

            return hata;
        }

        private void sahibiTextBox_KeyDown(object sender, KeyEventArgs e)
        {


            //if (e.KeyCode == Keys.Return) { musteri(); }

            }

        private void İrtibat_TelefonTextBox_Leave(object sender, EventArgs e)
        {
           // musteri();
        }

        private void tamiregelenDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ıPTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tamiregelenBindingSource1.CancelEdit();
        }
        }
    }

