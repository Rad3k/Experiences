using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    public partial class ChooseClass : Form
    {
        Collection collection = new Collection();

        public ChooseClass()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
        }

        private void dragonknightButton_Click(object sender, EventArgs e)
        {
            UniqueValue.character = "dragonknight";
            buildEditor skill = new buildEditor();
            skill.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void nightBlade_Click(object sender, EventArgs e)
        {
            UniqueValue.character = "nightblade";
            buildEditor skill = new buildEditor();
            skill.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void sorcererButton_Click(object sender, EventArgs e)
        {
            UniqueValue.character = "sorcerer";
            buildEditor skill = new buildEditor();
            skill.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void templarButton_Click(object sender, EventArgs e)
        {
            UniqueValue.character = "templar";
            buildEditor skill = new buildEditor();
            skill.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButtons_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CheckAllButtons_MouseEnter(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));

            switch (name)
            {
                case "dragonknightButton":
                    this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_revealed1));
                    break;
                case "nightBladeButton":
                    this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_revealed1));
                    break;
                case "sorcererButton":
                    this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_revealed2));
                    break;
                case "templarButton":
                    this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_revealed2));
                    break;
                case "minButton":
                    this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
                    break;
                case "helpButtons":
                    this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
                    break;
                case "closeButton":
                    this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
                    break;
            }
        }

        private void CheckAllButtons_MouseLeave(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            switch (name)
            {
                case "dragonknightButton":
                    this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_hidden1));
                    break;
                case "nightBladeButton":
                    this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_hidden1));
                    break;
                case "sorcererButton":
                    this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_hidden2));
                    break;
                case "templarButton":
                    this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_hidden2));
                    break;
                case "minButton":
                    this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
                    break;
                case "helpButtons":
                    this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
                    break;
                case "closeButton":
                    this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
                    break;
            }
        }
    }
}
