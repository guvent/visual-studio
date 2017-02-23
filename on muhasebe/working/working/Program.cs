using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace working
{
    
       
    static class Program
    {
        
        #region declare..

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static string[,] loglar = new string[10,1000000];
        private static int logno = 0;

        public static NotifyIcon nf = new NotifyIcon();
        private static Form1 frm = new Form1(ref nf);


        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            

            AllocConsole();
            izle("initializing...");

            #region look..
            string pth = Application.StartupPath;

            if (reg.ayarlar.applook.ToLower() != "false")
            {
                System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
                start.FileName = pth + "\\syslock.exe"; //"runas";
                start.CreateNoWindow = true; start.UseShellExecute = false; start.WindowStyle = ProcessWindowStyle.Hidden;
                //start.Arguments = "/trustlevel:0x40000 " + pth + "\\syslock.exe";
                Process.Start(start);
                Process.Start(start);
                izle("Look bots is activated..");
            
            }
            else
            {
                izle("Look bots disable not working..!");
            } //Process.Start("explorer.exe"); }
            /**/

            #endregion

            #region sleep
            izle("Thread is sleeping 2 second, wait....");
            System.Threading.Thread.Sleep(2000);
            #endregion

            #region instance chk
            string procName = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcessesByName(procName).Length != 1)
            {

                izle("Already running!! now exit...");
                System.Threading.Thread.Sleep(1000);
                //    Application.ExitThread();
                //    Application.Exit();

            }

            #endregion

            #region start app

            else
            {
                loadsettings();
                
                izle("Testing Server Connection! wait...");
                if (sqldene())
                {

                    izle("SQL Connection Success...");
                    
                    _hookID = SetHook(_proc);
                    Application.EnableVisualStyles();
                    //   Application.SetCompatibleTextRenderingDefault(false);
                    //    Application.Run(new Form1());

                    izle("main window is open...");
                    
                        Application.Run(frm);
                    
                }
                else
                {
                    Timer tm = null;
                    settingd st = new settingd(ref tm);
                    Application.Run(st);

                }
            }
            nf.Dispose(); 

            UnhookWindowsHookEx(_hookID);
            FreeConsole();
        }

            #endregion


        #region load set

        public static bool loadsettings()
        {
            /**/
            
            
            Properties.Settings.Default.cagbilConnectionString = "Data Source= " + reg.ayarlar.server + ";User Id=" + reg.ayarlar.sruser + ";Password=" + reg.ayarlar.srpass;

           // izle("Data Source=" + reg.ayarlar.server + ";User Id=" + reg.ayarlar.sruser + ";Password=" + reg.ayarlar.srpass);

            return true;
        }

#endregion

        #region test sql
        public static bool sqldene()
        {
            bool sonuc = true;
            SqlConnection sqtest = new SqlConnection();
            sqtest.ConnectionString = Properties.Settings.Default.cagbilConnectionString;
            try
            {
                sqtest.Open();
                sqtest.Close();
            }
            catch (Exception sqerr)
            {
                izle("HATA! : " + sqerr.Message.ToString());
                System.Threading.Thread.Sleep(3000);
                sonuc = false;
            }
            return sonuc;
        }
        #endregion

        #region izle for log
        public static void izle(string log)
        {
            Console.WriteLine("[" + DateTime.Now.ToString() + "] - " + log);

            

            logno++;
      //*
          loglar[1,logno] = DateTime.Now.ToString();
            loglar[2,logno] = log;
            /* */
           
        }
        #endregion

        #region seizure kb spec. key

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if ((Keys)vkCode == Keys.F12)
                {

                    frm.sistemizle("");

                  //  frm.Show();
                  //  frm.WindowState = FormWindowState.Maximized;

                  //  Application.Exit();
                   // _applicationForm.checkBox1.Checked = true;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);

        #endregion

    }
}
