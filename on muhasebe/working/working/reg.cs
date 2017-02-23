using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace working
{
    class reg
    {
        public struct ayarlar
        {

            static public string server = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "server").ToString();
            static public string sruser = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "user").ToString();
            static public string srpass = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "pass").ToString();
            static public string bkpdir = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "backupdir").ToString();
            static public string bktime = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "bktime").ToString();
            static public string bkarch = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\database", "bkarch").ToString();

            static public string logdir = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "logdir").ToString();
            static public string syslock = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "syslock").ToString();
            static public string applook = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "syslook").ToString();
            static public string systray = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "systray").ToString();
            static public string topmost = reg.getkey(reg.HKEY.HKCU, @"SOFTWARE\smart-gt.com\working\application", "topmost").ToString();


        }
        
       public struct HKEY 
        {
          static public string HKCR = "HKCR";
          static public string HKLM = "HKLM";
          static public string HKCU = "HKCU";
        } 

        
        static public bool setkey(string hkey, string key, string name, string val) 
        {
            bool sonuc = true;
            RegistryKey gkey = open_HKCU(key);

            switch(hkey)
            {
                case "HKCR":
            gkey = open_HKCR(key);
            break;
                case "HKLM":
            gkey = open_HKLM(key);
            break;
                case "HKCU":
            gkey = open_HKCU(key);
            break;
            
            }
            try
            {
                gkey.SetValue(name, val);
            }
            catch (Exception er) { sonuc = false; Program.izle("Kayıt Yazma Hatası: "+ er.Message); }
            return sonuc;
        }

        static public bool newkey(string hkey, string inkey, string key, string name, string val)
        {
            bool sonuc = true;
            RegistryKey gkey = open_HKCU(inkey);

            switch (hkey)
            {
                case "HKCR":
                    gkey = open_HKCR(inkey);
                    break;
                case "HKLM":
                    gkey = open_HKLM(inkey);
                    break;
                case "HKCU":
                    gkey = open_HKCU(inkey);
                    break;

            }
            try
            {
                RegistryKey gkey2 = gkey.CreateSubKey(key);
                gkey2.SetValue(name, val);
            }
            catch (Exception er) { sonuc = false; Program.izle("Kayıt Yapma Hatası: " + er.Message); }
            return sonuc;
        }

        static public void newky(string hkey,string inkey,string key)
        {
             
            RegistryKey gkey = open_HKCU(inkey);

            switch (hkey)
            {
                case "HKCR":
                    gkey = open_HKCR(inkey);
                    break;
                case "HKLM":
                    gkey = open_HKLM(inkey);
                    break;
                case "HKCU":
                    gkey = open_HKCU(inkey);
                    break;

            }

            gkey.CreateSubKey(key);

        }

        static public object getkey(string hkey, string key, string name)
        {

            RegistryKey gkey = open_HKCU(key); object ret = (string)"" ;

            switch (hkey)
            {
                case "HKCR":
                    gkey = open_HKCR(key);
                    break;
                case "HKLM":
                    gkey = open_HKLM(key);
                    break;
                case "HKCU":
                    gkey = open_HKCU(key);
                    break;

            }
            try
            {
                ret = gkey.GetValue(name);
            }
            catch (Exception er) { Program.izle("Kayıt Defteri Hatası: " + er.Message); }

            return ret;
        }

        public void d() {
            
            
        
        }

        static public RegistryKey open_HKCR(string ky)
        {
            return Registry.ClassesRoot.OpenSubKey(ky,true);
        }
        static public RegistryKey open_HKCU(string ky)
        {
            return Registry.CurrentUser.OpenSubKey(ky,true);
        }
        static public RegistryKey open_HKLM(string ky)
        {
            return Registry.LocalMachine.OpenSubKey(ky,true);
        }
    }
}
