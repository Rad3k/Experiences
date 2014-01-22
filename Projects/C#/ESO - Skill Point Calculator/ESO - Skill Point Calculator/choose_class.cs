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
    public partial class choose_class : Form
    {
        Collection collection = new Collection();

        public choose_class()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void dragonknightButton_Click(object sender, EventArgs e)
        {
            buildEditor skill = new buildEditor();
            skill.Show();
        }

        private void dragonknightButton_MouseEnter(object sender, EventArgs e)
        {
            dragonknightButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_revealed));
        }

        private void dragonknightButton_MouseLeave(object sender, EventArgs e)
        {
            this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_hidden));
            dragonknightButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void nightBlade_Click(object sender, EventArgs e)
        {
            buildEditor skill = new buildEditor();
            skill.Show();
        }

        private void nightBlade_MouseEnter(object sender, EventArgs e)
        {
            nightBlade.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_revealed));
        }

        private void nightBlade_MouseLeave(object sender, EventArgs e)
        {
            this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_hidden));
            nightBlade.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void sorcererButton_Click(object sender, EventArgs e)
        {
            buildEditor skill = new buildEditor();
            skill.Show();
        }

        private void sorcererButton_MouseEnter(object sender, EventArgs e)
        {
            sorcererButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_revealed));
        }

        private void sorcererButton_MouseLeave(object sender, EventArgs e)
        {
            this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_hidden));
            sorcererButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void templarButton_Click(object sender, EventArgs e)
        {
            buildEditor skill = new buildEditor();
            skill.Show();
        }

        private void templarButton_MouseEnter(object sender, EventArgs e)
        {
            templarButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_revealed));
        }

        private void templarButton_MouseLeave(object sender, EventArgs e)
        {
            this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_hidden));
            templarButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
            closeButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void helpButtons_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void helpButtons_MouseEnter(object sender, EventArgs e)
        {
            helpButtons.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
        }

        private void helpButtons_MouseLeave(object sender, EventArgs e)
        {
            this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
            helpButtons.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minButton_MouseEnter(object sender, EventArgs e)
        {
            minButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
        }

        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
            minButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }
    }
}
