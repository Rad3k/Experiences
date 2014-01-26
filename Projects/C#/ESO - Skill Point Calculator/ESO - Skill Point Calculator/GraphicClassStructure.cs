using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    class GraphicClassStructure : GraphicPosition
    {
        public List<ButtonControl> buttonControl = new List<ButtonControl>();

        public Button resetTree;
        public Button menu = new Button();
        public Button classBackround = new Button();
        Collection collection = new Collection();

        public void CreateClassButtons()
        {
            switch (UniqueValue.character)
            {
                case "sorcerer":
                    menu.Name = "sorcererText";
                    menu.BackgroundImage = BuildResource.sorcerer;
                    menu.Size = Size[0][1];
                    classBackround.BackgroundImage = BuildResource.sorcerer_skill_tree;
                    break;
                case "dragonknight":
                    menu.Name = "dragonKnightText";
                    menu.BackgroundImage = BuildResource.dragonknight;
                    menu.Size = Size[0][0];
                    classBackround.BackgroundImage = BuildResource.dragonknight_skill_tree;
                    break;
                case "templar":
                    menu.Name = "templarText";
                    menu.BackgroundImage = BuildResource.templar;
                    menu.Size = Size[0][3];
                    classBackround.BackgroundImage = BuildResource.templar_skill_tree;
                    break;
                case "nightblade":
                    menu.Name = "nightbladeText";
                    menu.BackgroundImage = BuildResource.nightblade;
                    menu.Size = Size[0][2];
                    classBackround.BackgroundImage = BuildResource.nightblade_skill_tree;
                    break;
            }
            // Menu
            menu.BackColor = Color.Transparent;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatAppearance.MouseDownBackColor = Color.Transparent;
            menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Location = Location[0][0];
            menu.TabIndex = 3;
            menu.Name = UniqueValue.character;
            menu.UseVisualStyleBackColor = false;

            // Class Backround
            classBackround.BackColor = Color.Transparent;
            classBackround.BackgroundImageLayout = ImageLayout.Stretch;
            classBackround.FlatAppearance.BorderSize = 0;
            classBackround.FlatAppearance.MouseDownBackColor = Color.Transparent;
            classBackround.FlatAppearance.MouseOverBackColor = Color.Transparent;
            classBackround.FlatStyle = FlatStyle.Flat;
            classBackround.Location = Location[0][1];
            classBackround.Name = "classBackround";
            classBackround.Size = Size[0][4];
            classBackround.TabIndex = 17;
            classBackround.UseVisualStyleBackColor = false;
        }

        public void CreateUniqueClass(object sender, EventArgs e)
        {
            // Reset tree
            resetTree.BackColor = Color.Transparent;
            resetTree.BackgroundImage = BuildResource.reset;
            resetTree.BackgroundImageLayout = ImageLayout.Stretch;
            resetTree.FlatAppearance.BorderSize = 0;
            resetTree.FlatAppearance.MouseDownBackColor = Color.Transparent;
            resetTree.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resetTree.FlatStyle = FlatStyle.Flat;
            resetTree.Name = "resetTree";
            resetTree.Size = Size[0][5];
            resetTree.UseVisualStyleBackColor = false;
        }
        
        public void ClassAllButtonsVisible(object sender, EventArgs e)
        {
            classBackround.Visible = true;
            UniqueValue.visibleType = true;
        }

        public void ClassAllButtonsInVisible(object sender, EventArgs e)
        {
            classBackround.Visible = false;
            UniqueValue.visibleType = false;
        }

        public void RemoveAllButtons(object sender, EventArgs e)
        {
            classBackround.Controls.Remove(classBackround);
            classBackround.Dispose();
        }
    }
    
    class ButtonControl 
    {
        public Button btn;
        public object obj;
    }
}
