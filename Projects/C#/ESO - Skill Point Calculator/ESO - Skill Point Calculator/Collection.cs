using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ESO___Skill_Point_Calculator
{
    class Collection : GraphicPosition
    {
        public Button menu = new Button();

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

        public void CreateClassButtons()
        {
            switch (UniqueValue.character)
            {
                case "sorcerer":
                    menu.Name = "sorcererText";
                    menu.BackgroundImage = global::ESO___Skill_Point_Calculator.BuildResource.sorcerer;
                    break;
                case "dragonknight":
                    menu.Name = "dragonKnightText";
                    menu.BackgroundImage = global::ESO___Skill_Point_Calculator.BuildResource.dragonknight;
                    break;
                case "templar":
                    menu.Name = "templarText";
                    menu.BackgroundImage = global::ESO___Skill_Point_Calculator.BuildResource.templar;
                    break;
                case "nightblade":
                    menu.Name = "nightbladeText";
                    menu.BackgroundImage = global::ESO___Skill_Point_Calculator.BuildResource.nightblade;
                    break;
            }

            // Menu
            menu.BackColor = System.Drawing.Color.Transparent;
            menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            menu.Location = new System.Drawing.Point(Location[0][0,0]);
            menu.Size = new System.Drawing.Size(Size[0][0,0], 0);
            menu.TabIndex = 3;
            menu.UseVisualStyleBackColor = false;
        }

        public void RemoveAllButtons()
        {
            menu.Controls.Remove(menu);
            menu.Dispose();
        }
    }
}
