using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    class Collection
    {
        // Global
        public string cursor;
        public string cursor_hand;
        public string sound;
        public string source;

        // Class tree
        public List<int> classUltimateSpells = new List<int>();
        public List<int> classActiveSpells = new List<int>();
        public List<int> classPassiveSpells = new List<int>();
        // Armor tree
        public List<int> armorActiveSpells = new List<int>();
        public List<int> armorPassiveSpells = new List<int>();
        // Weapon tree
        public List<int> WeaponsActiveSpells = new List<int>();
        public List<int> WeaponsPassiveSpells = new List<int>();

        public Collection()
        {
            cursor = "img/Cursor.cur";
            cursor_hand = "img/Cursor_hand.cur";
            sound = "sound/The_Call_-_The_Elder_Scrolls_Online.mp3";
            source = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
        }

        public void ListClassValueLabel()
        {
            for (int i = 0; i < classUltimateSpells.Count(); i++)
            {
                classUltimateSpells.RemoveAt(i);
                armorActiveSpells.RemoveAt(i);
            }
            for (int i = 0; i < classActiveSpells.Count(); i++)
            {
                classActiveSpells.RemoveAt(i);
                armorPassiveSpells.RemoveAt(i);
                WeaponsActiveSpells.RemoveAt(i);
                WeaponsPassiveSpells.RemoveAt(i);
            }
            for (int i = 0; i < classPassiveSpells.Count(); i++)
                classPassiveSpells.RemoveAt(i);

            for (int i = 0; i < 3; i++)
            {
                classUltimateSpells.Add(0);
                armorActiveSpells.Add(0);
            }
            for (int i = 0; i < 15; i++)
            {
                classActiveSpells.Add(0);
                armorPassiveSpells.Add(0);
                WeaponsActiveSpells.Add(0);
                WeaponsPassiveSpells.Add(0);
            }
            for (int i = 0; i < 12; i++)
                classPassiveSpells.Add(0);
        }
    }
}
