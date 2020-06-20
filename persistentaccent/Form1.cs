using Microsoft.Win32;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persistent_accent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the SystemEvents class to receive event notification when a user 
            // preference changes, the palette changes, or when display settings change.
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;

            Icon = trayIcon.Icon = Resources.bruv;
        }

        private const string RegKey = @"SOFTWARE\Microsoft\Windows\DWM";
        private const string RegName = "AccentColor";
        private const int RegValue = unchecked((int)0xff000000);

        private void SetAccent()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey, true))
            {
                key.SetValue(RegName, RegValue, RegistryValueKind.DWord);
            }
            Log($"Changed {RegKey}\\{RegName} to 0x{RegValue:X}");
        }

        private void Log(string text) => logBox.AppendText(text + Environment.NewLine);

        // called when a user preference changes
        private async void UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            Log($"User preference changing. Category: {e.Category}");
            if (e.Category == UserPreferenceCategory.Desktop)
            {
                await Task.Delay(1000);
                SetAccent();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(3);
                Hide();
            }
            else
            {
                trayIcon.Visible = false;
            }
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
