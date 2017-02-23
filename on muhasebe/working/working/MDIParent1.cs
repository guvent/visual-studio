using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;



namespace working
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0; public string helpt;

        public settingd opt; public string hl;

        public MDIParent1()
        {
            InitializeComponent();
            opt = new settingd(ref timer1);
            opt.MdiParent = this;

           
         //   yardimt = helpd;

        }

        public Ping ping;

        static public Form yazici;


        #region form & dialog..

        private void MDIParent1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        #endregion

        #region forms..

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            if (reg.ayarlar.topmost.ToLower() != "false") { this.TopMost = true; }

            solust.Left = Width - 540;

            Program.izle("Checking network connect...");

            ping = new Ping();

            chekc();
            try
            {
                ping.PingCompleted += new PingCompletedEventHandler(re);
            }
            catch (Exception er) { Program.izle(er.Message); }
            
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void MDIParent1_Resize(object sender, EventArgs e)
        {

            solust.Left = Width - 540;
        }

        
        #endregion

        #region menu

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedDialog)
                {
                    childForm.Close();
                }
            }
        }
        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form satis = new Satış();
            satis.MdiParent = this;

            satis.Show();

        }
        private void tamireGelenÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tamir = new Tamire_Gelen();

            tamir.MdiParent = this;
            tamir.Show();

        }
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form musteri = new Müşteriler();

            musteri.MdiParent = this;
            musteri.Show();

        }
        private void satılanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form satilan = new Satılanlar();

            satilan.MdiParent = this;
            satilan.Show();

        }
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form urunler = new Ürünler();

            urunler.MdiParent = this;
            urunler.Show();

        }
        private void yapılanİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form islemler = new Yapılan_İşlemler();

            islemler.MdiParent = this;
            islemler.Show();
        }
        private void satışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form satisyap = new Satış_Yap();

            satisyap.MdiParent = this;
            satisyap.Show();
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.smart-gt.com");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            exitme();
        }
        private void helpMenu_Click(object sender, EventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.MdiParent = this;
            about.Show();
        }
        private void ayağaHizmetServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Servis();
            fr.MdiParent = this;
            fr.Show();

        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt.Show();
        }
        private void yazıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string prf = null; string[] prfs = {};
            Form pf = new print(false,ref prf, ref prf, ref prf, ref prf, ref prf, ref prf, ref prf);
            Form pff = new print2(false, ref prfs, ref prfs, ref prfs, ref prfs, ref prf,ref prf,ref prf);
            
            pf.MdiParent = this;
            pf.Show();

            pff.MdiParent = this;
            pff.Show();
            //***/
        }
        private void barkodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string brf = null;
            Form br = new barkod(ref brf);
            br.MdiParent = this;
            br.Show();
        }

#endregion

        #region toolstrip

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form fr = new Satış_Yap();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form fr2 = new Tamire_Gelen();
            fr2.MdiParent = this;
            fr2.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form fr = new Müşteriler();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form fr = new Ürünler();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form fr = new Satış();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form fr = new Satılanlar();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Form fr = new Yapılan_İşlemler();
            fr.MdiParent = this;
            fr.Show();
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            exitme();
        }
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Form tamir = new Tamire_Gelen();

            tamir.MdiParent = this;
            tamir.Show();

        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Form tamir = new Servis();

            tamir.MdiParent = this;
            tamir.Show();

        }
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Form tamir = new faaliyet();

            tamir.MdiParent = this;
            tamir.Show();

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.smart-gt.com");
        }
        private void faaliyetlerPlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tamir = new faaliyet();

            tamir.MdiParent = this;
            tamir.Show();

        }

#endregion


        public static void exitme()
        {
            if (MessageBox.Show(working.Properties.Resources.cikisyap,"Uyarı.!!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation).ToString().ToLower() == "yes")
            {
                Application.ExitThread();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Form childForm in MdiChildren)
            {
                if (childForm.FormBorderStyle != System.Windows.Forms.FormBorderStyle.FixedDialog)
                {
                    childForm.Close();
                }
            }

            DataTable dt = new cagbilDataSet.müşterilerDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt = new cagbilDataSet.satılanlarDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt = new cagbilDataSet.satisDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt = new cagbilDataSet.tamiregelenDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt = new cagbilDataSet.ürünlerDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            dt = new cagbilDataSet.yapılanişlemlerDataTable();

            dt.Columns[0].AutoIncrementSeed = 1;
            dt.Columns[0].AutoIncrementStep = 1;

            timer1.Enabled = false;
        }

        static public void gt(ref string sahib, ref string irtib, ref string cihz, ref string sikayt, ref string bilesn, ref string tarh, ref string etikt)
        {
            
            
            yazici = new print(true,ref sahib,ref irtib,ref cihz,ref sikayt ,ref bilesn,ref tarh,ref etikt);
            //yazici.MdiParent = this;
            
            yazici.Show();
            
        }
        bool tur = false;

        

        public void helpme()
    {
        
        
    
    }

        #region yardım

        

        

       
       
 
        



        #endregion

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        #region check net connect...

        private void timer3_Tick(object sender, EventArgs e)
        {
            chekc();
  
        }
        
        public void chekc()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            { netstat.Enabled = true; }
            else
            { netstat.Enabled = false; }

            try
            {
                ping.SendAsync("www.google.com", new object[] { true });

            }
            catch (Exception er) {  Program.izle(er.Message); }
        }

        public void re(object o,PingCompletedEventArgs e)
        {
            this.Invoke(new func1(func2),new object[] {e.Reply});

            //MessageBox.Show(e.Reply.Status.ToString());
        }

        public delegate void func1(PingReply rp);

        public void func2(PingReply rp)
        {
            webstat.Enabled = false; 
                
            try
            {
                if (rp.Status == IPStatus.Success)
                {  webstat.Enabled = true; }
                

            }
            catch (Exception er) { }
            
        }


        #endregion

    }
}
 