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
        GraphicClassStructure classStructure = new GraphicClassStructure();

        int clickClass = 0;

        public buildEditor()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            maxSkillPoint.Text = UniqueValue.spentSkillPoints.ToString();
            classStructure.CreateClassButtons();
            classStructure.menu.Click += new System.EventHandler(classMenu_Click);
            classStructure.menu.MouseEnter += new System.EventHandler(CheckAllButtons_MouseEnter);
            classStructure.menu.MouseLeave += new System.EventHandler(CheckAllButtons_MouseLeave);
            this.Controls.Add(classStructure.menu);
        }

        private void CheckAllButtons_MouseEnter(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));

            switch (name)
            {
                // Class buttons
                case "dragonknight":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight_on));
                    break;
                case "sorcerer":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.sorcerer_on));
                    break;
                case "nightblade":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.nightblade_on));
                    break;
                case "templar":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.templar_on));
                    break;
                case "minimalizedButton":
                    this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
                    break;
                case "helpButton":
                    this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
                    break;
                case "exitButton":
                    this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
                    break;
                case "weaponSlot1":
                    this.weaponSlot1.BackgroundImage = ((System.Drawing.Image)(BuildResource.one_two_handed_dual_on));
                    break;
                case "weaponSlot2":
                    this.weaponSlot2.BackgroundImage = ((System.Drawing.Image)(BuildResource.bow_staff_on));
                    break;
                case "armorType":
                    this.armorType.BackgroundImage = ((System.Drawing.Image)(BuildResource.light_medium_heavy_on));
                    break;
                case "racialDaggerfall":
                    this.racialDaggerfall.BackgroundImage = ((System.Drawing.Image)(BuildResource.breton_redguard_orc_on));
                    break;
                case "racialAldmeri":
                    this.racialAldmeri.BackgroundImage = ((System.Drawing.Image)(BuildResource.altmer_bosmer_khajiit_on));
                    break;
                case "racialEbonheart":
                    this.racialEbonheart.BackgroundImage = ((System.Drawing.Image)(BuildResource.nord_dunmer_argonian_on));
                    break;
                case "pvpType":
                    this.pvpType.BackgroundImage = ((System.Drawing.Image)(BuildResource.assault_support_emperor_on));
                    break;
                case "guildsType":
                    this.guildsType.BackgroundImage = ((System.Drawing.Image)(BuildResource.guilds_on));
                    break;
                case "craftingType":
                    this.craftingType.BackgroundImage = ((System.Drawing.Image)(BuildResource.crafting_on));
                    break;
                case "soulMagicType":
                    this.soulMagicType.BackgroundImage = ((System.Drawing.Image)(BuildResource.soul_magic_on));
                    break;
                case "vampirismType":
                    this.vampirismType.BackgroundImage = ((System.Drawing.Image)(BuildResource.vampirism_on));
                    break;
                case "lycanthropyType":
                    this.lycanthropyType.BackgroundImage = ((System.Drawing.Image)(BuildResource.lycanthropy_on));
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
                // Class buttons
                case "dragonknight":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight));
                    break;
                case "sorcerer":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.sorcerer));
                    break;
                case "nightblade":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.nightblade));
                    break;
                case "templar":
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.templar));
                    break;
                case "minimalizedButton":
                    this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
                    break;
                case "helpButton":
                    this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
                    break;
                case "exitButton":
                    this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
                    break;
                case "weaponSlot1":
                    this.weaponSlot1.BackgroundImage = ((System.Drawing.Image)(BuildResource.one_two_handed_dual));
                    break;
                case "weaponSlot2":
                    this.weaponSlot2.BackgroundImage = ((System.Drawing.Image)(BuildResource.bow_staff));
                    break;
                case "armorType":
                    this.armorType.BackgroundImage = ((System.Drawing.Image)(BuildResource.light_medium_heavy));
                    break;
                case "racialDaggerfall":
                    this.racialDaggerfall.BackgroundImage = ((System.Drawing.Image)(BuildResource.breton_redguard_orc));
                    break;
                case "racialAldmeri":
                    this.racialAldmeri.BackgroundImage = ((System.Drawing.Image)(BuildResource.altmer_bosmer_khajiit));
                    break;
                case "racialEbonheart":
                    this.racialEbonheart.BackgroundImage = ((System.Drawing.Image)(BuildResource.nord_dunmer_argonian));
                    break;
                case "pvpType":
                    this.pvpType.BackgroundImage = ((System.Drawing.Image)(BuildResource.assault_support_emperor));
                    break;
                case "guildsType":
                    this.guildsType.BackgroundImage = ((System.Drawing.Image)(BuildResource.guilds));
                    break;
                case "craftingType":
                    this.craftingType.BackgroundImage = ((System.Drawing.Image)(BuildResource.crafting));
                    break;
                case "soulMagicType":
                    this.soulMagicType.BackgroundImage = ((System.Drawing.Image)(BuildResource.soul_magic));
                    break;
                case "vampirismType":
                    this.vampirismType.BackgroundImage = ((System.Drawing.Image)(BuildResource.vampirism));
                    break;
                case "lycanthropyType":
                    this.lycanthropyType.BackgroundImage = ((System.Drawing.Image)(BuildResource.lycanthropy));
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            classStructure.RemoveAllButtons();
            Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void minimalizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void classMenu_Click(object sender, EventArgs e)
        {
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
            classStructure.ClassAllButtonsVisible();
            if (clickClass < 1)
            {
                classStructure.CreateClassButtons();
                classStructure.CreateSpellsButton();
                this.Controls.Add(classStructure.classBackround);
            }
            for (int i = 0; i < 3; i++)
            {
                classStructure.resetTree = new Button();
                classStructure.resetTreeButton((Button)sender, e);
                classStructure.resetTree.Location = classStructure.Location[4][i];
                classStructure.resetTree.Name = classStructure.resetTree.Name + i.ToString();
                this.Controls.Add(classStructure.resetTree);
            }
            clickClass++;
        }

        private void weaponSlot1_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void armorType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void weaponSlot2_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void racialDaggerfall_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void racialAldmeri_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void racialEbonheart_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void pvpType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void guildsType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void craftingType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void soulMagicType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void lycanthropyType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }

        private void vampirismType_Click(object sender, EventArgs e)
        {
            classStructure.ClassAllButtonsInVisible();
            classStructure.classUniqueButtons_VisibleChanged((Button)sender, e);
        }
    }
}
