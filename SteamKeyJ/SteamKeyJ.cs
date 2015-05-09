using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SteamKeyJ.Properties;
using System.Diagnostics;

namespace SteamKeyJ
{
    public partial class SteamKeyJ : Form
    {
        private Dictionary<string, int> dictAssigned = new Dictionary<string, int>();
        private Dictionary<string, Action> dictAction = new Dictionary<string, Action>();
        private ContextMenu cMenu = new ContextMenu();
        private bool isHooked = true;

        public SteamKeyJ()
        {
            InitializeComponent();
            AssignDictionary();
            var kri = KeyRecogniser.Instance;
            KeyRecogniser.RequestedKeysPressed += new EventHandler(KeyRecogniser_RequestedKeysPressed);

            MenuItem miExit = new MenuItem("Exit", (s,e) => { this.Close(); });
            MenuItem miShow = new MenuItem("Open SteamKeyJ", (s, e) => { this.Show(); this.Visible = true; this.WindowState = FormWindowState.Normal; });
            MenuItem miToggleEnable = new MenuItem((isHooked) ? "Disable" : "Enable", (s, e) => { checkBox1.Checked = !checkBox1.Checked; ((MenuItem)s).Text = (isHooked) ? "Disable" : "Enable"; });
            MenuItem miShowMusicPlayer = new MenuItem("Show Music Player", (s, e) => { Process.Start("steam://open/musicplayer"); });

            cMenu.MenuItems.Add(miToggleEnable);
            cMenu.MenuItems.Add(miShowMusicPlayer);
            cMenu.MenuItems.Add(miShow);
            cMenu.MenuItems.Add(miExit);            
            
            notifyIcon1.ContextMenu = cMenu;
            notifyIcon1.Text = "SteamKeyJ";
            notifyIcon1.Icon = new Icon("SKDJ.ico");
            notifyIcon1.DoubleClick += (s, e) => { this.Show(); this.Visible = true; this.WindowState = FormWindowState.Normal; };


            this.Closing += (s, e) =>
            {
                KeyRecogniser.Unhook();
            };

            //check if 'hidden' was passed in, start minimized
            if(Environment.GetCommandLineArgs().Contains("hidden", StringComparer.OrdinalIgnoreCase))
                this.WindowState = FormWindowState.Minimized;
        }

        void AssignDictionary()
        {
            dictAssigned.AddOrUpdate("playpause", Settings.Default.playpause); 
            dictAssigned.AddOrUpdate("next", Settings.Default.next);
            dictAssigned.AddOrUpdate("previous", Settings.Default.previous);
            dictAssigned.AddOrUpdate("volumeup", Settings.Default.volumeup);
            dictAssigned.AddOrUpdate("volumedown", Settings.Default.volumedown);
            dictAssigned.AddOrUpdate("mute", Settings.Default.mute);
            dictAssigned.AddOrUpdate("shuffle", Settings.Default.shuffle);
            dictAssigned.AddOrUpdate("repeat", Settings.Default.repeat);

            //Action
            dictAction.AddOrUpdate("playpause", () => Process.Start("steam://musicplayer/toggleplaypause")); 
            dictAction.AddOrUpdate("next", () => Process.Start("steam://musicplayer/playnext"));
            dictAction.AddOrUpdate("previous", () => Process.Start("steam://musicplayer/playprevious"));
            dictAction.AddOrUpdate("volumeup", () => Process.Start("steam://musicplayer/increasevolume"));
            dictAction.AddOrUpdate("volumedown", () => Process.Start("steam://musicplayer/decreasevolume"));
            dictAction.AddOrUpdate("mute", () => Process.Start("steam://musicplayer/togglemute"));
            dictAction.AddOrUpdate("repeat", () => Process.Start("steam://musicplayer/toggleplayingrepeatstatus"));
            dictAction.AddOrUpdate("shuffle", () => Process.Start("steam://musicplayer/toggleplayingshuffled"));
        }



        void KeyRecogniser_RequestedKeysPressed(object sender, EventArgs e)
        {
            if (!IsFormOpen<SteamKeyConfig>())
            {
                var value = dictAssigned.FirstOrDefault(x => x.Value == (int)sender).Key;
                if (value != null) dictAction[value]();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                KeyRecogniser.SetHook();
                isHooked = true;

            }
            else
            {
                KeyRecogniser.Unhook();
                isHooked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SteamKeyConfig skc = new SteamKeyConfig())
            {
                skc.ShowDialog();
                AssignDictionary();
            }
        }


        private void SteamKeyJ_Resize(object sender, EventArgs e)
        {
            MinimizeWindow();            
        }

        private void MinimizeWindow()
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;

                notifyIcon1.ShowBalloonTip(100, "SteamKeyJ Minimised", "SteamKeyJ is running in the background", ToolTipIcon.Info);
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("steam://open/musicplayer"); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.keyboardp.me");
        }

        private bool IsFormOpen<T>()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is T)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
