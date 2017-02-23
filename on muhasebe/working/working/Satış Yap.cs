using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace working
{
    public partial class Satış_Yap : Form
    {
        public string bn;

        public bool tmm = false;

        #region variable declr

        public int adetsay = 1;  static int sattim = 0;  Timer zm = new Timer();

        public string[] urn = new string[20]; public string[] miktr = new string[20]; public string[] birm = new string[20]; public string[] tutr = new string[20];

        string misim; string mtel; string madres;

        #endregion



        #region init start

        public Satış_Yap()
        {
            InitializeComponent();
        }

        public void init()
        {
         /*   try   { /* */

                adetsay = 1;
                sattim = 0;

                textBox1.Text = "";
                textBox2.Text = adetsay.ToString();
                kDVTextBox.Text = "";
                tOPLAMTextBox.Text = "";
                listView1.Items.Clear();

                textBox1.BackColor = Color.Yellow;
                textBox1.Focus(); textBox1.Update();

                textBox1.BackColor = Color.Yellow;
                textBox2.Text = adetsay.ToString();

                zm.Tick += new System.EventHandler(this.saat);
                zm.Interval = 990; zm.Enabled = true;

                tOPLAMTextBox.Text = "0";
                kDVTextBox.Text = "0";
                textBox1.Focus(); textBox1.Update();
            /* /
            }
            catch (Exception evv) { Program.izle("satisyap_init() | "+evv.Message); }
        
          */
          }

        private void Satış_Yap_Load_1(object sender, EventArgs e)
        {
            
            satılanlarTableAdapter.Connection = new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
            satisTableAdapter.Connection =  new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
            ürünlerTableAdapter.Connection =  new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
            ürünlerTableAdapter1.Connection =  new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
            müşterilerTableAdapter.Connection =  new SqlConnection(Properties.Settings.Default.cagbilConnectionString);

            this.tableAdapterManager.Connection = new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
            


            // TODO: This line of code loads data into the 'cagbilDataSet.satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.cagbilDataSet.satis);
            // TODO: This line of code loads data into the 'cagbilDataSet.satılanlar' table. You can move, or remove it, as needed.
            this.satılanlarTableAdapter.Fill(this.cagbilDataSet.satılanlar);

            SqlDataReader rd;

            // TODO: This line of code loads data into the 'cagbilDataSet.müşteriler' table. You can move, or remove it, as needed.
            this.müşterilerTableAdapter.Fill(this.cagbilDataSet.müşteriler);
            // TODO: This line of code loads data into the 'cagbilDataSet.satış' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.cagbilDataSet.satis);
            // TODO: This line of code loads data into the 'cagbilDataSet.ürünler' table. You can move, or remove it, as needed.
            this.ürünlerTableAdapter.Fill(this.cagbilDataSet.ürünler);

            sized();
            
            #region musteri

            müşterilerTableAdapter.Adapter.SelectCommand.Connection.Open();
            müşterilerTableAdapter.Adapter.SelectCommand.CommandText = "select * from [müşteriler]";
            müşterilerTableAdapter.Adapter.Fill(cagbilDataSet);

            try
            {
                 
                rd= müşterilerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                
                while(rd.Read()) {
                    müşteri___Kurum_AdıTextBox.AutoCompleteCustomSource.Add(rd[1].ToString());
                  //  rd.Close();
                }
                
              
            }
            catch (Exception exr) {
                
                Program.izle("satisyap_load() | "+exr.Message); 
            }

            müşterilerTableAdapter.Adapter.SelectCommand.Connection.Close();

            #endregion


            #region urunler

            ürünlerTableAdapter.Adapter.SelectCommand.Connection.Open();
            ürünlerTableAdapter.Adapter.SelectCommand.CommandText = "select * from [ürünler]";
            ürünlerTableAdapter.Adapter.Fill(cagbilDataSet);

            try
            {
                
                rd = ürünlerTableAdapter.Adapter.SelectCommand.ExecuteReader();


                while (rd.Read())
                {
                    textBox1.AutoCompleteCustomSource.Add(rd[1].ToString());
                }
                rd.Close();

            }
            catch (Exception exr)
            {
                Program.izle("satisyap_load_2() | " + exr.Message);
            }

            ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close();

            #endregion

            init();

            

        }

        public void sized()
        {


            panel3.Height = satisDataGridView.Height + 70;

            listView1.Height = Height - (panel3.Height + 114);
            
            listView1.Width = Width - (panel2.Width + 19);

            panel5.Left = (this.Width - (panel5.Width + panel6.Width) ) - 30;
            
            panel6.Left = Width - 235;

        }

        private void Satış_Yap_Resize(object sender, EventArgs e)
        {
            sized();
        }

        #endregion



        #region funtion saat()

        public void saat(object de, EventArgs ee)
        {
            İşlem_SaatiTextBox.Text = DateTime.Now.ToLongTimeString();
            
        }

        #endregion

        #region function ekle()

        public void ekle()
        {
            if (!varmi())  { SqlDataReader rd; string bno = textBox1.Text;

               /* */     try {  /* */

                        if (ürünlerTableAdapter.Adapter.SelectCommand.Connection.State.ToString().ToLower() == "open")
                        {
                            ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close();
                        }
                        ürünlerTableAdapter.Adapter.SelectCommand.Connection.Open();
                        
                        string cmd = "select * from [ürünler] where [Barkod No]='" + textBox1.Text + "'";
                        ürünlerTableAdapter.Adapter.SelectCommand.CommandText = cmd;
                        
                        rd = ürünlerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                        if (rd.HasRows)
                        {
                            
                                listView1.Items.Add(textBox1.Text);

                                while (rd.Read())
                                {
                                    listView1.Items[sattim].SubItems.Add(rd[2].ToString());
                                    listView1.Items[sattim].SubItems.Add(rd[13].ToString());
                                    listView1.Items[sattim].SubItems.Add(textBox2.Text);
                                    listView1.Items[sattim].SubItems.Add(rd[10].ToString());
                                    listView1.Items[sattim].SubItems.Add("");
                                    topla();
                                } 
                        }
                        else { textBox1.BackColor = Color.Red; } rd.Close();
                /* */
                        } catch (Exception efr) { Program.izle("satisyap_ekle() | " + efr.Message); sattim--; }
                    /* */
                                // ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close(); 

                        }  textBox1.Text = ""; if (!varmi())  { sattim++; }    
        }

        #endregion

        #region function topla()

        public void topla()
        {
            try
            {
                int total = 0;

                if (listView1.Items.Count >= 1)
                {
                    for (int g = 1; g <= listView1.Items.Count; g++)
                    {
                        string bkno = listView1.Items[g - 1].SubItems[0].Text;
                        double fiyat = Convert.ToDouble(listView1.Items[g - 1].SubItems[2].Text);
                        int miktar = Convert.ToInt32(listView1.Items[g - 1].SubItems[3].Text);

                        int sonuc = miktar * ((int)fiyat);
                        listView1.Items[g - 1].SubItems[5].Text = sonuc.ToString();

                        total = total + sonuc;
                        tOPLAMTextBox.Text = total.ToString();
                        kDVTextBox.Text = KDV(total).ToString();
                        /* */
                        //MessageBox.Show(kalan(bkno, miktar.ToString()).ToLower() +" - " + bkno + " - " + miktar.ToString());
                        if (kalan(bkno, miktar.ToString()).ToLower() == "eksik")
                        { listView1.Items[g - 1].BackColor = Color.LightPink; }
                        else
                        { listView1.Items[g - 1].BackColor = Color.White; }

                        /* */
                    }
                }
                else
                {
                    tOPLAMTextBox.Text = "0";
                    kDVTextBox.Text = "0";
                }
            }
            catch (Exception er) { Program.izle("satisyap_topla() | " + er.Message); }
        }

        #endregion

        #region function KDV()

        public double KDV(int total)
        {

            return (( total - (total / 1.18))); 
        }

        #endregion

        #region function varmi()

        public bool varmi()
        {
            
            bool ch = false;

            try
            {

                if (listView1.Items.Count >= 1)
                {
                    for (int g = 1; g <= listView1.Items.Count; g++)
                    {

                        if (listView1.Items[g-1].Text == textBox1.Text)
                        {
                            sattim--;
                            int miktars = Convert.ToInt32(listView1.Items[g-1].SubItems[3].Text);
                            miktars=miktars+ Convert.ToInt32( textBox2.Text ); 
                            listView1.Items[g-1].SubItems[3].Text = miktars.ToString();
                            
                            ch = true;
                            topla();
                        }

                    }

                }
            }
            catch (Exception edd) { Program.izle("satisyap_varmi() | " + edd.Message); }


            return ch;
        }

        #endregion

        #region function tamamla()

        public void tamamla()
        {
            try {

            // boş ise doldur
            if (satış_YapanTextBox.Text == "") { satış_YapanTextBox.Text = "admin"; }
            if (müşteri___Kurum_AdıTextBox.Text == "") { müşteri___Kurum_AdıTextBox.Text = "-"; }
            if (müşteri_Hesap_NoTextBox.Text == "") { müşteri_Hesap_NoTextBox.Text = "0"; }
            if (müşteri_Vergi_DairesiTextBox.Text == "") { müşteri_Vergi_DairesiTextBox.Text = "0"; }
            if (müşteri_Vergi_NoTextBox.Text == "") { müşteri_Vergi_NoTextBox.Text = "0"; }

            //liste no aktarır
            satılan_ÜrünTextBox.Text = bn;
            
            this.Validate();
            satisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cagbilDataSet);

            int total = 0;

            //satılanlar tablosuna aktarım yapılır
            if (listView1.Items.Count >= 1)
            {
                //belge_NoTextBox1.Text = satılan_ÜrünTextBox.Text;
                for (int g = 1; g <= listView1.Items.Count; g++)
                {
                    satılanlarBindingSource.AddNew();

                    satılan_Ürün_AdıTextBox.Text = listView1.Items[g - 1].SubItems[1].Text;
                    miktarıTextBox.Text = listView1.Items[g - 1].SubItems[3].Text;
                    birimiTextBox.Text = listView1.Items[g - 1].SubItems[4].Text;
                    satış_FiyatıTextBox.Text = listView1.Items[g - 1].SubItems[2].Text;
                    satış_TutarıTextBox.Text = listView1.Items[g - 1].SubItems[5].Text;

                    kDVTextBox1.Text = Convert.ToString( Convert.ToInt32(listView1.Items[g - 1].SubItems[5].Text) - Convert.ToInt32( KDV(Convert.ToInt32(listView1.Items[g - 1].SubItems[5].Text))) );

                    satış_NoTextBox.Text = bn;


                    satılanlarBindingSource.EndEdit();
                    
                    //miktarlarla stok bilgisi güncellenir
                    miktar(listView1.Items[g - 1].SubItems[0].Text, listView1.Items[g - 1].SubItems[3].Text);

                }


            }


            }
            catch (Exception er) { Program.izle("satisyap_tamamla() | " + er.Message); }
        }

        #endregion

        #region function miktar()

        public string miktar(string barkodd,string mktar)
        {
             SqlDataReader dd; string gelen = "";
            try
            {
               
                if (ürünlerTableAdapter.Adapter.SelectCommand.Connection.State.ToString().ToLower() == "open")
                {
                    ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close();
                }
                ürünlerTableAdapter.Adapter.SelectCommand.Connection.Open();
                ürünlerTableAdapter.Adapter.SelectCommand.CommandText = "exec dbo.miktarla @indx='" + barkodd + "', @miktar=" + mktar + " ;";
                dd = ürünlerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                while (dd.Read())
                {

                    gelen = dd[0].ToString();

                }
            }
            catch (Exception er) { Program.izle("satisyap_miktar() | " + er.Message); }

           // ürünlerTableAdapter.Adapter.SelectCommand.Connection.Close(); 
            return gelen;
        }

        #endregion

        #region function kalan()

        public string kalan(string barkodd,string mktar)
        {
            SqlDataReader dd; string gelen = "";
         /* */   try
            { /* */
             
             
             ürünlerTableAdapter1.Adapter.SelectCommand = new SqlCommand("exec dbo.kalan @bno='" + barkodd + "', @mkt='" + mktar + "'");
             ürünlerTableAdapter1.Adapter.SelectCommand.Connection = new SqlConnection(Properties.Settings.Default.cagbilConnectionString);
                
             ürünlerTableAdapter1.Adapter.SelectCommand.Connection.Open();
                
                dd = ürünlerTableAdapter1.Adapter.SelectCommand.ExecuteReader();
                
             /* */
                if (dd.HasRows)
                {
                    while (dd.Read())
                    { gelen = dd[0].ToString(); }

                }
                dd.Close();
       /* */     }
            catch (Exception er) { Program.izle("satisyap_kalan() | " + er.Message); }
            /* */
            ürünlerTableAdapter1.Adapter.SelectCommand.Connection.Close();
            return gelen;
        }

        #endregion

        #region function musterigel()

        public void musterigel()
        {
            SqlDataReader rd;
            try
            {
                müşterilerTableAdapter.Adapter.SelectCommand.CommandText = "select * from [müşteriler] where [Müşteri Ad Soyad]='" + müşteri___Kurum_AdıTextBox.Text + "'";
                müşterilerTableAdapter.Adapter.Fill(cagbilDataSet);
                müşterilerTableAdapter.Adapter.SelectCommand.Connection.Open();

                rd = müşterilerTableAdapter.Adapter.SelectCommand.ExecuteReader();

                if (rd.HasRows)
                {
                    button5.Enabled = true;
                    while (rd.Read())
                    {

                        müşteri_Vergi_NoTextBox.Text = rd[6].ToString();
                        müşteri_Vergi_DairesiTextBox.Text = rd[7].ToString();
                        müşteri_Hesap_NoTextBox.Text = rd[8].ToString();

                        misim = rd[1].ToString(); mtel = rd[2].ToString(); madres = rd[3].ToString(); 

                        //   MessageBox.Show(rd[0].ToString());
                    }
                } else { button5.Enabled = false; }
                rd.Close();
           

            müşterilerTableAdapter.Adapter.SelectCommand.Connection.Close();
            if (müşteri___Kurum_AdıTextBox.Text == "")
            { satisBindingSource.Filter = "[Müşteri / Kurum Adı] ='" + müşteri___Kurum_AdıTextBox.Text + "'"; }
            else { satisBindingSource.Filter = ""; } }
            catch (Exception exr) { Program.izle(" -  TEKRAR DENE....! \n \n \n" + exr.Message); }
        }

        #endregion

        #region buttons

        private void button1_Click(object sender, EventArgs e)
        {

            ekle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tamamdir();
        }

        public void tamamdir()
        { /* */
            try
            { /* */

                tamamla();

                satılan_ÜrünTextBox.Text = "0";


                ürünlerTableAdapter.Update(cagbilDataSet);

                //  satisBindingSource.AddNew();

                /* */

            }
            catch (Exception eer) { Program.izle("satisyap_button2click() | " + eer.Message); }
            /* */

            init();

            İşlem_TarihiDateTimePicker.Value = DateTime.Now.AddDays(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            zm.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            musterigel();
        }

        

        #endregion

        #region textboxs

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show(e.KeyChar.ToString());

            e.Handled = !char.IsDigit(e.KeyChar);
           
            
            
                switch (e.KeyChar.ToString())
                {
                    case "+":
                        if (adetsay >= 1)
                        {
                            adetsay++;
                            textBox2.Text = (adetsay).ToString();
                        }
                        break;
                    case "-":
                        if (adetsay > 1)
                        {
                            adetsay--;
                            textBox2.Text = (adetsay).ToString();
                        }
                        break;

                        
                
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            if (e.KeyCode == Keys.Escape) { textBox1.Text = ""; }
            if (e.KeyCode == Keys.Return) { ekle(); }
            if (e.KeyCode == Keys.Delete) { init(); }
            if (e.KeyCode == Keys.End) { tamamdir(); }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            adetsay = Convert.ToInt32(textBox2.Text);
            if (adetsay == 0) { adetsay++; }
            textBox2.Text = adetsay.ToString();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
            
        }

        private void müşteri___Kurum_AdıTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.Return:
                    musterigel();
                    break;
                case Keys.Escape:
                    müşteri___Kurum_AdıTextBox.Text = "";
                    button5.Enabled = false;
                    break;
            }
        }

        #endregion

        #region listview

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listView1.SelectedItems.Count != 0)
            {

                listView1.Items[listView1.SelectedItems[0].Index].Remove();
                sattim--;

                topla();

            }

          

        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int miktar = 0;
                switch (e.KeyChar)
                {

                    case '-':
                        if (listView1.SelectedItems[0].SubItems[3].Text != "1")
                        {
                            miktar = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                            miktar = miktar - Convert.ToInt32(textBox2.Text);
                            listView1.SelectedItems[0].SubItems[3].Text = miktar.ToString();

                            topla();
                        }
                        break;
                    case '+':

                        miktar = Convert.ToInt32(listView1.SelectedItems[0].SubItems[3].Text);
                        miktar = miktar + Convert.ToInt32(textBox2.Text);
                        listView1.SelectedItems[0].SubItems[3].Text = miktar.ToString();

                        topla();
                        break;

                }
            }
        }

        #endregion


        #region navigator buttons

        private void ürünlerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ürünlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ürünlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cagbilDataSet);

        }

        private void müşteri_Hesap_NoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void İşlem_SaatiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

       
        #region caption control

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Height = 630; this.Width = 1150;
            satisDataGridView.Height = 220;
            panel2.Width = 220;
            panel6.Width = 210;
            infol.Visible = true;
            sized();
        }
        private void siparişiTamamlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tamamla();

                satılan_ÜrünTextBox.Text = "0";

                this.Validate();
                satisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cagbilDataSet);

                ürünlerTableAdapter.Update(cagbilDataSet);

                satisBindingSource.AddNew();



            }
            catch (Exception eer) { Program.izle("satisyap_button2click() | " + eer.Message); }

           
            init();
            
           İşlem_TarihiDateTimePicker.Value = DateTime.Now.AddDays(0);

        }

        private void satisDataGridView_DoubleClick(object sender, EventArgs e)
        {
            bn = Belge_NoTextBox.Text;

            //MessageBox.Show(bn);
            satisBindingSource.CancelEdit();

            if (bn != "")
            {
                #region müşteri bilgisi
                SqlDataReader dr;
                satisTableAdapter.Adapter.SelectCommand.Connection.Open();
                satisTableAdapter.Adapter.SelectCommand.CommandText = "select * from [satis] where [Belge No]='" + Belge_NoTextBox.Text + "'";
                dr = satisTableAdapter.Adapter.SelectCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        müşteri___Kurum_AdıTextBox.Text   = dr[3].ToString();
                        müşteri_Vergi_NoTextBox.Text      = dr[4].ToString();
                        müşteri_Vergi_DairesiTextBox.Text = dr[10].ToString();
                        müşteri_Hesap_NoTextBox.Text      = dr[5].ToString();
                    }
                } dr.Close(); satisTableAdapter.Adapter.SelectCommand.Connection.Close();
                #endregion

                #region satılanlar listesi

                SqlDataReader rr; int ix = 0; listView1.Items.Clear();
                satılanlarTableAdapter.Adapter.SelectCommand.Connection.Open();
                satılanlarTableAdapter.Adapter.SelectCommand.CommandText = "select * from [satılanlar] where [Satış No]='" + Belge_NoTextBox.Text + "'";
                rr = satılanlarTableAdapter.Adapter.SelectCommand.ExecuteReader();

                if (rr.HasRows)
                {
                    button5.Enabled = true;
                    while (rr.Read())
                    {
                        listView1.Items.Add(" - ");
                        listView1.Items[ix].SubItems.Add(rr[2].ToString());
                        listView1.Items[ix].SubItems.Add(rr[6].ToString());
                        listView1.Items[ix].SubItems.Add(rr[3].ToString());
                        listView1.Items[ix].SubItems.Add(rr[4].ToString());
                        listView1.Items[ix].SubItems.Add(rr[7].ToString());
                        ix++;
                    }
                }  else { button5.Enabled = false; } 
                rr.Close(); satılanlarTableAdapter.Adapter.SelectCommand.Connection.Close();
                #endregion

            }


        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
                satisBindingSource.AddNew();
                İşlem_TarihiDateTimePicker.Value = DateTime.Now.Date;
            
        }

        private void satisDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            satisBindingSource.CancelEdit();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            bn = Belge_NoTextBox.Text;
            if (!tmm)
            {
                satisBindingSource.CancelEdit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count >= 1)
            {
                for (int v = 0; v <= (listView1.Items.Count - 1); v++)
                {
                    
                    urn[v] = listView1.Items[v].SubItems[1].Text;
                    miktr[v] = listView1.Items[v].SubItems[3].Text;
                    birm[v] = listView1.Items[v].SubItems[4].Text;
                    tutr[v] = listView1.Items[v].SubItems[5].Text;

                }

                Form pff = new print2(true, ref urn, ref miktr, ref birm, ref tutr,ref misim,ref mtel,ref madres);
                pff.Show();

            }
        }

        #endregion

        private void button2_MouseHover(object sender, EventArgs e)
        {
            tmm = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            tmm = false;
        }


        
    }
}
