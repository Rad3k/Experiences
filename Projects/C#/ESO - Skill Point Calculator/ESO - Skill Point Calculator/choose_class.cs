using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESO___Skill_Point_Calculator
{
    public partial class choose_class : Form
    {
        public choose_class()
        {
            InitializeComponent();
        }

        private void dragonknightButton_Click(object sender, EventArgs e)
        {
            SkillTree skill = new SkillTree();
            skill.Show();
        }

        private void dragonknightButton_MouseEnter(object sender, EventArgs e)
        {
            this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_revealed));
        }

        private void dragonknightButton_MouseLeave(object sender, EventArgs e)
        {
            this.dragonknightButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Dragonknight_hidden));
        }

        private void nightBlade_Click(object sender, EventArgs e)
        {
            SkillTree skill = new SkillTree();
            skill.Show();
        }

        private void nightBlade_MouseEnter(object sender, EventArgs e)
        {
            this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_revealed));
        }

        private void nightBlade_MouseLeave(object sender, EventArgs e)
        {
            this.nightBlade.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Nightblade_hidden));
        }

        private void sorcererButton_Click(object sender, EventArgs e)
        {
            SkillTree skill = new SkillTree();
            skill.Show();
        }

        private void sorcererButton_MouseEnter(object sender, EventArgs e)
        {
            this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_revealed));
        }

        private void sorcererButton_MouseLeave(object sender, EventArgs e)
        {
            this.sorcererButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Sorcerer_hidden));
        }

        private void templarButton_Click(object sender, EventArgs e)
        {
            SkillTree skill = new SkillTree();
            skill.Show();
        }

        private void templarButton_MouseEnter(object sender, EventArgs e)
        {
            this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_revealed));
        }

        private void templarButton_MouseLeave(object sender, EventArgs e)
        {
            this.templarButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Templar_hidden));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
        }

        private void helpButtons_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void helpButtons_MouseEnter(object sender, EventArgs e)
        {
            this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
        }

        private void helpButtons_MouseLeave(object sender, EventArgs e)
        {
            this.helpButtons.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minButton_MouseEnter(object sender, EventArgs e)
        {
            this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
        }

        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            this.minButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
        }
    }
}
