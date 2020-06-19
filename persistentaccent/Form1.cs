using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace persistent_accent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the SystemEvents class to receive event notification when a user 
            // preference changes, the palette changes, or when display settings change.
            SystemEvents.UserPreferenceChanged += x;

            // For demonstration purposes, this application sits idle waiting for events.
            Console.WriteLine("This application is waiting for system events.");
            Console.WriteLine("Press <Enter> to terminate this application.");
            Console.ReadLine();
        }

        readonly static UserPreferenceChangedEventHandler x = new UserPreferenceChangedEventHandler(Thingy);

        /* 
         * called when a user preference changes
         */
        static void Thingy(object sender, UserPreferenceChangedEventArgs e)
        {
            Console.WriteLine("The user preference is changing. Category={0}", e.Category);

            System.Threading.Thread.Sleep(1000);

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\DWM", true);

            key.SetValue("AccentColor", unchecked((int)0xff000000), RegistryValueKind.DWord);

            key.Close();
        }

        /*
         * Hide program in tray
         * http://smartsnipp.ecomparefiles.com/code/c_sharp_windows_application/windows_form_hide_and_show_in_system_tray.aspx
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            nicoHide.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            nicoHide.BalloonTipTitle = "Hide Form";
            nicoHide.BalloonTipText = "Form Minimized to System Tray.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                nicoHide.Visible = true;
                nicoHide.ShowBalloonTip(4);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                nicoHide.Visible = false;
            }
        }

        private void nicoHide_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        /*
         * i think this is what you do
         * when you want to unhook a thingy
         */
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
