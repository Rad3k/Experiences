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
    class Collection
    {
        // Global
        public string cursor;
        public string cursor_hand;
        public string sound;
        public string source;
        public int value;

        // Class tree
        public List<int> ultimateSpells = new List<int>();
        public List<int> activeSpells = new List<int>();
        public List<int> passiveSpells = new List<int>();

        public Collection()
        {
            cursor = "img/Cursor.cur";
            cursor_hand = "img/Cursor_hand.cur";
            sound = "sound/The_Call_-_The_Elder_Scrolls_Online.mp3";
            source = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        }

        public void ListClassValueLabel()
        {
            for (int i = 0; i < ultimateSpells.Count(); i++)
                ultimateSpells.RemoveAt(i);
            for (int i = 0; i < activeSpells.Count(); i++)
                activeSpells.RemoveAt(i);
            for (int i = 0; i < passiveSpells.Count(); i++)
                passiveSpells.RemoveAt(i);

            for (int i = 0; i < 3; i++)
                ultimateSpells.Add(0);
            for (int i = 0; i < 15; i++)
                activeSpells.Add(0);
            for (int i = 0; i < 12; i++)
                passiveSpells.Add(0);
        }
    }
}
