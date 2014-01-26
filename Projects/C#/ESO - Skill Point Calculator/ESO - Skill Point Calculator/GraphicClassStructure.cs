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

        // Button
        public Button plus;
        public Button minus;
        public Button resetTree;
        public Button menu = new Button();
        public Button classBackround = new Button();
        // Spells
        public Button ultimateSpell = new Button();
        public Button activeSpell1 = new Button();
        public Button activeSpell2 = new Button();
        public Button activeSpell3 = new Button();
        public Button activeSpell4 = new Button();
        public Button activeSpell5 = new Button();
        public Button passiveSpell1 = new Button();
        public Button passiveSpell2 = new Button();
        public Button passiveSpell3 = new Button();
        public Button passiveSpell4 = new Button();
        // ButtonInformation:
        public Button ultimateInfo = new Button();
        public Button activeInfo = new Button();
        public Button passiveInfo = new Button();
        // Label
        public Label points;

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
            classBackround.UseVisualStyleBackColor = false;

            // Button information
            ultimateInfo.BackColor = Color.Transparent;
            ultimateInfo.BackgroundImage = BuildResource.ultimate;
            ultimateInfo.BackgroundImageLayout = ImageLayout.Stretch;
            ultimateInfo.FlatAppearance.BorderSize = 0;
            ultimateInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ultimateInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ultimateInfo.FlatStyle = FlatStyle.Flat;
            ultimateInfo.Location = Location[0][5];
            ultimateInfo.Name = "ultimateInfo";
            ultimateInfo.Size = Size[0][5];
            ultimateInfo.UseVisualStyleBackColor = false;

            activeInfo.BackColor = Color.Transparent;
            activeInfo.BackgroundImage = BuildResource.active;
            activeInfo.BackgroundImageLayout = ImageLayout.Stretch;
            activeInfo.FlatAppearance.BorderSize = 0;
            activeInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            activeInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            activeInfo.FlatStyle = FlatStyle.Flat;
            activeInfo.Location = Location[0][6];
            activeInfo.Name = "activeInfo";
            activeInfo.Size = Size[0][6];
            activeInfo.UseVisualStyleBackColor = false;

            passiveInfo.BackColor = Color.Transparent;
            passiveInfo.BackgroundImage = BuildResource.passive;
            passiveInfo.BackgroundImageLayout = ImageLayout.Stretch;
            passiveInfo.FlatAppearance.BorderSize = 0;
            passiveInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            passiveInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            passiveInfo.FlatStyle = FlatStyle.Flat;
            passiveInfo.Location = Location[0][7];
            passiveInfo.Name = "passiveInfo";
            passiveInfo.Size = Size[0][7];
            passiveInfo.UseVisualStyleBackColor = false;
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
        
        public void ClassAllButtonsVisible()
        {
            classBackround.Visible = true;
            UniqueValue.visibleType = true;
            ultimateInfo.Visible = true;
            activeInfo.Visible = true;
            passiveInfo.Visible = true;
        }

        public void ClassAllButtonsInVisible()
        {
            classBackround.Visible = false;
            UniqueValue.visibleType = false;
            ultimateInfo.Visible = false;
            activeInfo.Visible = false;
            passiveInfo.Visible = false;
        }

        public void RemoveAllButtons()
        {
            classBackround.Controls.Remove(classBackround);
            ultimateInfo.Controls.Remove(ultimateInfo);
            activeInfo.Controls.Remove(activeInfo);
            passiveInfo.Controls.Remove(passiveInfo);

            classBackround.Dispose();
            ultimateInfo.Dispose();
            activeInfo.Dispose();
            passiveInfo.Dispose();
        }
    }
    
    class ButtonControl 
    {
        public Button btn;
        public object obj;
    }
}
