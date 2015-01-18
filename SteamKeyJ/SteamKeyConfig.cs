using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using SteamKeyJ.Properties;

namespace SteamKeyJ
{
    public partial class SteamKeyConfig : Form
    {

        private Dictionary<int, Action> dictAction = new Dictionary<int, Action>();
        //string = action name, int = key (can be converted to friendly name at runtime)
        private Dictionary<string, int> dictAssigned = new Dictionary<string, int>();
        private bool isSetting = false;
        private TextBox tbSelected = null;
        

        public SteamKeyConfig()
        {
            InitializeComponent();
            this.Focus();
            

            AssignExistingValues();     

            KeyRecogniser.RequestedKeysPressed += new EventHandler(KeyRecogniser_RequestedKeysPressed);

        }

        void AssignExistingValues()
        {
            if (Settings.Default.playpause != -1)
            {
                tbPlayPause.Text = ((Keys)Settings.Default.playpause).ToString();
                dictAssigned.Add("playpause", Settings.Default.playpause);
            }
            else
                dictAssigned.Add("playpause", -1);

          

            if (Settings.Default.next != -1)
            {
                tbNext.Text = ((Keys)Settings.Default.next).ToString();
                dictAssigned.Add("next", Settings.Default.next);
            }
            else
                dictAssigned.Add("next", -1);
            

            if (Settings.Default.previous != -1)
            {
                tbPrevious.Text = ((Keys)Settings.Default.previous).ToString();
                dictAssigned.Add("previous", Settings.Default.previous);
            }
            else
                dictAssigned.Add("previous", -1);

            if (Settings.Default.volumeup != -1)
            {
                tbVolumeUp.Text = ((Keys)Settings.Default.volumeup).ToString();
                dictAssigned.Add("volumeup", Settings.Default.volumeup);
            }
            else
                dictAssigned.Add("volumeup", -1);


            if (Settings.Default.volumedown != -1)
            {
                tbVolumeDown.Text = ((Keys)Settings.Default.volumedown).ToString();
                dictAssigned.Add("volumedown", Settings.Default.volumedown);
            }
            else
                dictAssigned.Add("volumedown", -1);

            if (Settings.Default.mute != -1)
            {
                tbMute.Text = ((Keys)Settings.Default.mute).ToString();
                dictAssigned.Add("mute", Settings.Default.mute);
            }
            else
                dictAssigned.Add("mute", -1);

            if (Settings.Default.repeat != -1)
            {
                tbRepeat.Text = ((Keys)Settings.Default.repeat).ToString();
                dictAssigned.Add("repeat", Settings.Default.repeat);
            }
            else
                dictAssigned.Add("repeat", -1);

            if (Settings.Default.shuffle != -1)
            {
                tbShuffle.Text = ((Keys)Settings.Default.shuffle).ToString();
                dictAssigned.Add("shuffle", Settings.Default.shuffle);
            }
            else
                dictAssigned.Add("shuffle", -1);
        }


        void KeyRecogniser_RequestedKeysPressed(object sender, EventArgs e)
        {
            if (isSetting && tbSelected != null)
            {
                string keyName = ((Keys)sender).ToString();
                tbSelected.Text = keyName; 
              
                switch(tbSelected.Tag.ToString())
                {
                    case "playpause":
                        dictAssigned["playpause"] = (int)sender;                       
                        break;
                   
                    case "next":
                        dictAssigned["next"] = (int)sender;
                        break;
                    case "previous":
                        dictAssigned["previous"] = (int)sender;
                        break;
                    case "volumeup":
                        dictAssigned["volumeup"] = (int)sender;
                        break;
                    case "volumedown":
                        dictAssigned["volumedown"] = (int)sender;
                        break;
                    case "mute":
                        dictAssigned["mute"] = (int)sender;
                        break;
                    case "repeat":
                        dictAssigned["repeat"] = (int)sender;
                        break;
                    case "shuffle":
                        dictAssigned["shuffle"] = (int)sender;
                        break;
                }
            }
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
             
        }


        private void textBox_Leave(object sender, EventArgs e)
        {
            isSetting = false;
            tbSelected = null;
        }

        private void textBox_Focus(object sender, EventArgs e)
        {
            lblExplanation.Text = "Please press the key to assign";
            
            isSetting = true;
            tbSelected = sender as TextBox;
            tbSelected.Select(0, tbSelected.Text.Length);
            tbSelected.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Settings.Default.playpause = dictAssigned["playpause"]; 
            Settings.Default.next = dictAssigned["next"];
            Settings.Default.previous = dictAssigned["previous"];
            Settings.Default.volumeup = dictAssigned["volumeup"];
            Settings.Default.volumedown = dictAssigned["volumedown"];
            Settings.Default.mute = dictAssigned["mute"];
            Settings.Default.shuffle = dictAssigned["shuffle"];
            Settings.Default.repeat = dictAssigned["repeat"];
            
            Settings.Default.Save();
            this.Close();
      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Button selectedDeleteButton = sender as Button;
            switch(selectedDeleteButton.Tag.ToString())
            {
                case "delplaypause":
                    tbPlayPause.Clear();
                    dictAssigned["playpause"] = -1;
                    break;
               
                case "delnext":
                    tbNext.Clear();
                    dictAssigned["next"] = -1;
                    break;
                case "delprevious":
                    tbPrevious.Clear();
                    dictAssigned["previous"] = -1;
                    break;
                case "delvolumeup":
                    tbVolumeUp.Clear();
                    dictAssigned["volumeup"] = -1;
                    break;
                case "delvolumedown":
                    tbVolumeDown.Clear();
                    dictAssigned["volumedown"] = -1;
                    break;
                case "delmute":
                    tbMute.Clear();
                    dictAssigned["mute"] = -1;
                    break;
                case "shuffle":
                    tbMute.Clear();
                    dictAssigned["shuffle"] = -1;
                    break;
                case "repeat":
                    tbMute.Clear();
                    dictAssigned["repeat"] = -1;
                    break;
                                        
            }
        }
    }
}
