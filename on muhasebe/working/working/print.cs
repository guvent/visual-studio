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
    public partial class print : Form
    {
        public bool prnt;
        public string sahibi; public string irtibat; public string cihaz;
        public string sikayet; public string bilesen; public string tarih; public string etiket;
        

        public print(bool print,ref string sahib,ref string irtib,ref string cihz, ref string sikayt, ref string bilesn,ref string tarh,ref string etikt)
        {
            InitializeComponent(); 
            prnt = print;
            sahibi = sahib; irtibat = irtib; cihaz = cihz; sikayet = sikayt; bilesen = bilesn; tarih = tarh; etiket = etikt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            webBrowser1.ShowPrintDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string pth = Application.ExecutablePath.Replace("working.EXE", "");
            pth = pth.Replace("working.exe", "");

            webBrowser1.Navigate("file://" + pth + "olcek.htm");

        }

        private void print_Load(object sender, EventArgs e)
        {
            string pth = Application.ExecutablePath.Replace("working.EXE", "");
            pth = pth.Replace("working.exe", "");

            webBrowser1.Navigate("file://" + pth + "olcek.htm");

        }


        public void icerik() //string sahibi, string irtibat, string cihaz, string sikayet, string bilesen, string tarih)
        {
            webBrowser1.Document.GetElementById("sahibi").InnerHtml = sahibi;
            webBrowser1.Document.GetElementById("irtibat").InnerHtml = irtibat;
            webBrowser1.Document.GetElementById("cihaz").InnerHtml = cihaz;
            webBrowser1.Document.GetElementById("sikayet").InnerHtml = sikayet;
            webBrowser1.Document.GetElementById("bilesen").InnerHtml = bilesen;

            webBrowser1.Document.GetElementById("sahibi2").InnerHtml = sahibi;
            webBrowser1.Document.GetElementById("irtibat2").InnerHtml = irtibat;
            webBrowser1.Document.GetElementById("sikayet2").InnerHtml = sikayet;

            webBrowser1.Document.GetElementById("tarih").InnerHtml = tarih;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            
            string pth = Application.ExecutablePath.Replace("working.EXE", "");
            pth = pth.Replace("working.exe", "");



            webBrowser1.Document.GetElementById("resim1").SetAttribute("src", pth + "temp\\1.gif");

            webBrowser1.Document.GetElementById("resim2").SetAttribute("src", pth + "temp\\2.gif");
            
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
