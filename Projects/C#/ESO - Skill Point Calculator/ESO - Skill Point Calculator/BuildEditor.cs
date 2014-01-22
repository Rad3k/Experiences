using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    public partial class buildEditor : Form
    {
        Collection collection = new Collection();

        public buildEditor()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            maxSkillPoint.Text = collection.maxSkill.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_MouseEnter(object sender, EventArgs e)
        {
            helpButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            helpButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
        }

        private void minimalizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimalizedButton_MouseEnter(object sender, EventArgs e)
        {
            minimalizedButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
        }

        private void minimalizedButton_MouseLeave(object sender, EventArgs e)
        {
            minimalizedButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
        }

        private void dragonKnightText_Click(object sender, EventArgs e)
        {

        }

        private void weaponSlot1_Click(object sender, EventArgs e)
        {

        }

        private void armorType_Click(object sender, EventArgs e)
        {

        }

        private void weaponSlot2_Click(object sender, EventArgs e)
        {

        }
    }
}
