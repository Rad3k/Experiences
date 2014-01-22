﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ESO___Skill_Point_Calculator
{
    class Collection
    {
        public string cursor;
        public string cursor_hand;
        public string sound;
        public string source;
        public int value;

        public Collection()
        {
            cursor = "img/Cursor.cur";
            cursor_hand = "img/Cursor_hand.cur";
            sound = "sound/The_Call_-_The_Elder_Scrolls_Online.wav";
            source = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        }

        public void BackroundPlayerStart()
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(Path.Combine(source, sound));
                sndplayr.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }

        public void BackroundPlayerClose()
        {
            try
            {
                SoundPlayer sndplayr = new SoundPlayer(Path.Combine(source, sound));
                sndplayr.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace.ToString(), "Error");
            }
        }
    }
}
