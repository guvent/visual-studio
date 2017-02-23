using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;


namespace syslock
{
    class Program 
    {
        static void Main(string[] args)
        {

            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            start.CreateNoWindow = true; start.UseShellExecute = false; start.WindowStyle = ProcessWindowStyle.Hidden;
            
            string pth = Application.ExecutablePath.Replace("syslock.EXE", "");
            pth = Application.ExecutablePath.Replace("syslock.exe", "");
            start.FileName = pth + "syslock.exe"; 
            
            Process[] prlist = Process.GetProcesses();
            
            bool found = false; bool work = false; bool restart = false; int pcount = 0;

            string[] liste = {"explorer","iexplore","browser","chrome","safari","firefox"};
            pcount = 0; 
            foreach (Process proc in prlist)
                {  
                    try { proc.Refresh();
                        
                        foreach (string ls in liste)
                          { if (ls == proc.ProcessName) { found = true; } }
                            
                        switch (proc.ProcessName)
                          {
                              case "working": work = true; break;

                              case "syslock":
                                  
                                  proc.PriorityBoostEnabled = true;
                                  proc.PriorityClass = ProcessPriorityClass.High;

                                  if (proc.PrivateMemorySize >= 99999999 && restart == false)
                                  { restart = true; Process.Start(start); Application.ExitThread(); }
                                  else
                                  { pcount++; }
                                break;
                              
                          }
                       
                    }
                    catch (Exception er) {  Console.WriteLine("[" + DateTime.Now + "]: " + er.Message); }
                }
         //   Console.Write(pcount);
            if (pcount <= 1) { pcount = 3;  Process.Start(start); }
            /* */
            if (pcount >= 4) { Application.ExitThread(); }  /**/
            
            try
                {
                    StreamWriter wrlist = new StreamWriter(pth + "exitexplorer.bat", false);
                    wrlist.Flush();
                    wrlist.WriteLine("@echo off"); wrlist.WriteLine(" ");
                    foreach (string ls in liste)
                    {

                        wrlist.WriteLine("taskkill.exe /f /im " + ls + ".exe");
                        wrlist.WriteLine(" ");

                    }
                    wrlist.WriteLine(" "); wrlist.WriteLine("@echo");
                    wrlist.Close();
                }
                catch (Exception er) { } //Console.WriteLine("[" + DateTime.Now + "]: " + er.Message); }
                    
                    // start.FileName = pth + @"syslock.exe";
                try {
                    if (reg.ayarlar.syslock.ToLower() != "false")
                    {
                   /* */  switch (found)
                        { case true: start.FileName = pth + "exitexplorer.bat"; Process.Start(start); break; }/**/
                    }
                /* */     switch (work)
                    { case false: start.FileName = pth + "exitlogin.bat"; Process.Start(start); break; }/**/
                }
                catch (Exception er) { Console.WriteLine("[" + DateTime.Now + "]: " + er.Message); }
                    System.Threading.Thread.Sleep(200);
            
           /* */ if(!restart && reg.ayarlar.applook.ToLower() != "false" && work) {Main(null);}
           // */ Main(null);
        }
        

    }
}
