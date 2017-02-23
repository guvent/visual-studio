using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace working
{
    public partial class print2 : Form
    {
        public bool prnt;
        public string[] urn = new string[20]; public string[] miktr = new string[20]; public string[] birm = new string[20]; public string[] tutr = new string[20]; 
        public string adr; public string tel; public string ism;

        public print2(bool print,ref string[] urun,ref string[] miktar,ref string[] birim,ref string[] tutar,ref string isim,ref string telf, ref string adres)
        {
            InitializeComponent();
            prnt = print; urn = urun; miktr = miktar; birm = birim; tutr = tutar; adr = adres; ism = isim; tel = telf;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            webBrowser1.ShowPrintDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string pth = Application.ExecutablePath.Replace("working.EXE", "");
            pth = pth.Replace("working.exe", "");

            webBrowser1.Navigate("file://" + pth + "olcek2.htm");

        }

        private void print_Load(object sender, EventArgs e)
        {
            string pth = Application.ExecutablePath.Replace("working.EXE", "");
            pth = pth.Replace("working.exe", "");

            webBrowser1.Navigate("file://" + pth + "olcek2.htm");

        }


        public void icerik() //string sahibi, string irtibat, string cihaz, string sikayet, string bilesen, string tarih)
        {
            string htm = ""; string adx = "";
            /*
            foreach (string ls in urn) { webBrowser1.Document.GetElementById("listele").InnerHtml = ls; }
            foreach (string ls2 in urn) { webBrowser1.Document.GetElementById("listele").InnerHtml = ls2; }
            foreach (string ls3 in urn) { webBrowser1.Document.GetElementById("listele").InnerHtml = ls3; }
            foreach (string ls4 in urn) { webBrowser1.Document.GetElementById("listele").InnerHtml = ls4; }
             */

            htm = "<table border=0><tr><td>No. </td><td class='style1'>Ürün Adı  </td><td class='style3'>Miktarı  </td><td class='style4'>Birimi  </td><td class='style5'>Fiyatı  </td></tr>";

            // htm = "<table border=0><tr><td>No : </td><td class='style1'>Ürün Adı : </td><td class='style4'>Miktarı : </td><td class='style2'>Birimi : </td><td class='style5'>Fiyatı : </td>";
            // htm = htm + "</tr></table>";

            for (int v = 0; v <= 15; v++)
            {
                if (urn[v] != "")
                {
                    htm = htm + "<tr><td>" + (v+1).ToString() + "</td><td>" + urn[v] + "</td><td>" + miktr[v] + "</td><td>" + birm[v] + "</td><td>" + tutr[v] + "</td></tr>";

                    
                }
            }

            adx = "<div style='padding-bottom:6px;'> İsim Soyisim - Tel : " + ism + " - " + tel + " </div>  <div>Adres Bilgileri : </div> <div> " + adr + "</div>";
            
            htm = htm + "</table>";

            //MessageBox.Show("ok");

            webBrowser1.Document.GetElementById("listesi").InnerHtml = htm;

            webBrowser1.Document.GetElementById("adresi").InnerHtml = adx;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

           // MessageBox.Show("ok");

            icerik();

            if (prnt)
            {
                webBrowser1.Print(); timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
