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
    public partial class settingd : Form
    {

        public Timer mf;

        public settingd(ref Timer m)
        {
            InitializeComponent();
            if (m != null)
            {
                mf = m;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "server", "CAGSERVER\\SQLSERVER");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "user", "database");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "pass", "102030data");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "backupdir", "d:\\backup");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "bktime", "5");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\database", "bkarch", "y");

            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\application", "logdir", "d:\\log");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\application", "syslock", "y");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\application", "syslook", "y");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\application", "systray", "y");
            reg.newkey(reg.HKEY.HKCU, @"", @"SOFTWARE\smart-gt.com\working\application", "topmost", "y");
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            execute(); this.Hide();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingd_Load(object sender, EventArgs e)
        {
          /** /  try
            { /***/
                textBox1.Text = reg.ayarlar.server;
                textBox2.Text = reg.ayarlar.sruser;
                textBox3.Text = reg.ayarlar.srpass;
                textBox4.Text = reg.ayarlar.bkpdir;
                comboBox1.Text = reg.ayarlar.bktime;

                textBox5.Text = reg.ayarlar.logdir;
                if (reg.ayarlar.bkarch.ToLower() != "false") { checkBox1.Checked = true; }
                if (reg.ayarlar.syslock.ToLower() != "false") { checkBox2.Checked = true; }
                if (reg.ayarlar.topmost.ToLower() != "false") { checkBox3.Checked = true; }
                if (reg.ayarlar.systray.ToLower() != "false") { checkBox4.Checked = true; }
                if (reg.ayarlar.applook.ToLower() != "false") { checkBox5.Checked = true; }

                if (mf == null) { button10.Enabled = false; }
          /*/  }
            catch (Exception er) { }
            /**/
        }

        public void execute()
        {
            
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "server", textBox1.Text);
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "user", textBox2.Text );
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "pass", textBox3.Text );
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "backupdir", textBox4.Text );
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "bktime", comboBox1.Text );
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "bkarch", checkBox1.Checked.ToString());

            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "logdir",textBox5.Text );
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "syslock", checkBox2.Checked.ToString());
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "syslook", checkBox5.Checked.ToString());
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "systray", checkBox4.Checked.ToString());
            reg.setkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "topmost", checkBox3.Checked.ToString());

            if (MessageBox.Show("Yapılan Değişiklikler Yeniden Başlatılana Denk geçerli olmayabilir. \n - Yeniden Başlatılsınmı.?", "Önemli!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString() == "Yes")
            {
                if (reg.ayarlar.applook.ToLower() == "false" || reg.ayarlar.syslock == "false")
                {  Application.Restart();  }
                else { Application.ExitThread(); }
            }
            if (mf == null ) { Application.Restart(); }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            execute();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fbdlg.ShowDialog();
            textBox4.Text = fbdlg.SelectedPath;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fbdlg.ShowDialog();
            textBox5.Text = fbdlg.SelectedPath;

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sıfırlansınmı?", "Sayacı Sıfırla!", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // sıfırlama işlemi...


                mf.Enabled = true;
                
                
            
            }
        }
    }
}
