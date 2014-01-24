using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESO___Skill_Point_Calculator
{
    class GraphicClassStructure : GraphicPosition
    {
        public Button menu = new Button();
        public Button classBackround = new Button();
        public Button resetTree = new Button();

        public void CreateClassButtons()
        {
            switch (UniqueValue.character)
            {
                case "sorcerer":
                    this.menu.Name = "sorcererText";
                    this.menu.BackgroundImage = BuildResource.sorcerer;
                    this.classBackround.BackgroundImage = BuildResource.sorcerer_skill_tree;
                    break;
                case "dragonknight":
                    this.menu.Name = "dragonKnightText";
                    this.menu.BackgroundImage = BuildResource.dragonknight;
                    this.classBackround.BackgroundImage = BuildResource.dragonknight_skill_tree;
                    break;
                case "templar":
                    this.menu.Name = "templarText";
                    this.menu.BackgroundImage = BuildResource.templar;
                    this.classBackround.BackgroundImage = BuildResource.templar_skill_tree;
                    break;
                case "nightblade":
                    this.menu.Name = "nightbladeText";
                    this.menu.BackgroundImage = BuildResource.nightblade;
                    this.classBackround.BackgroundImage = BuildResource.nightblade_skill_tree;
                    break;
            }

            // Menu
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Location = new System.Drawing.Point(Location[0][0][0], Location[0][1][0]);
            this.menu.Size = new System.Drawing.Size(Size[0][0][0], Size[0][1][0]);
            this.menu.TabIndex = 3;
            this.menu.UseVisualStyleBackColor = false;

            // Class Backround
            this.classBackround.BackColor = System.Drawing.Color.Transparent;
            this.classBackround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classBackround.FlatAppearance.BorderSize = 0;
            this.classBackround.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.classBackround.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.classBackround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classBackround.Location = new System.Drawing.Point(Location[0][0][1], Location[0][1][1]);
            this.classBackround.Name = "classBackround";
            this.classBackround.Size = new System.Drawing.Size(Size[0][0][1], Size[0][1][1]);
            this.classBackround.TabIndex = 17;
            this.classBackround.UseVisualStyleBackColor = false;

            // Reset tree
            this.resetTree.BackColor = System.Drawing.Color.Transparent;
            this.resetTree.BackgroundImage = BuildResource.reset;
            this.resetTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetTree.FlatAppearance.BorderSize = 0;
            this.resetTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resetTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTree.Name = "resetTree";
            this.resetTree.Size = new System.Drawing.Size(Size[0][0][2], Size[0][1][2]);
            //this.resetTree.TabIndex = 18;
            this.resetTree.UseVisualStyleBackColor = false;
        }

        public void RemoveAllButtons()
        {
            this.menu.Controls.Remove(menu);
            this.classBackround.Controls.Remove(classBackround);
            this.resetTree.Controls.Remove(resetTree);

            this.menu.Dispose();
            this.classBackround.Dispose();
            this.resetTree.Dispose();
        }
    }
}
