using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WMPLib;

namespace ESO___Skill_Point_Calculator
{
    class Collection
    {
        public string cursor;
        public string cursor_hand;
        public string sound;
        public string source;
        public int value;
        
        // Build editor
        // Base value
        public int maxSkill = 60;

        public Collection()
        {
            cursor = "img/Cursor.cur";
            cursor_hand = "img/Cursor_hand.cur";
            sound = "sound/The_Call_-_The_Elder_Scrolls_Online.mp3";
            source = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        }

        public void BackroundPlayerStart(WindowsMediaPlayer wplayer)
        {
            try
            {
                wplayer.URL = Path.Combine(source, sound);
                wplayer.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        public void BackroundPlayerClose(WindowsMediaPlayer wplayer)
        {
            try
            {
                wplayer.URL = Path.Combine(source, sound);
                wplayer.controls.stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }
    }
}
