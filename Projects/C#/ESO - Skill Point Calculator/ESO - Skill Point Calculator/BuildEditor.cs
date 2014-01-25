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

        public buildEditor()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            maxSkillPoint.Text = collection.maxSkill.ToString();
            classStructure.CreateClassButtons();

            switch (UniqueValue.character)
            {
                case "sorcerer":
                    classStructure.menu.MouseEnter += new System.EventHandler(sorcerer_MouseEnter);
                    classStructure.menu.MouseLeave += new System.EventHandler(sorcerer_MouseLeave);
                    break;
                case "dragonknight":
                    classStructure.menu.MouseEnter += new System.EventHandler(dragonKnightText_MouseEnter);
                    classStructure.menu.MouseLeave += new System.EventHandler(dragonKnightText_MouseLeave);
                    break;
                case "templar":
                    classStructure.menu.MouseEnter += new System.EventHandler(templar_MouseEnter);
                    classStructure.menu.MouseLeave += new System.EventHandler(templar_MouseLeave);
                    break;
                case "nightblade":
                    classStructure.menu.MouseEnter += new System.EventHandler(nightblade_MouseEnter);
                    classStructure.menu.MouseLeave += new System.EventHandler(nightblade_MouseLeave);
                    break;
            }
            classStructure.menu.Click += new System.EventHandler(classMenu_Click);
            this.Controls.Add(classStructure.menu);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            classStructure.RemoveAllButtons();
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

        private void dragonKnightText_MouseEnter(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight_on));
        }

        private void dragonKnightText_MouseLeave(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight));
        }

        private void classMenu_Click(object sender, EventArgs e)
        {
            classStructure.CreateClassButtons();
            this.Controls.Add(classStructure.classBackround);

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        classStructure.resetTree.Location = classStructure.Location[0][2];
                        break;
                    case 1:
                        classStructure.resetTree.Location = classStructure.Location[0][3];
                        break;
                    case 2:
                        classStructure.resetTree.Location = classStructure.Location[0][4];
                        break;
                }
                classStructure.resetTree.Click += new EventHandler(resetTreeOneEvent_Click);
                classStructure.resetTree.MouseEnter += new EventHandler(resetTree_MouseEnter);
                classStructure.resetTree.MouseLeave += new EventHandler(resetTree_MouseLeave);
                classStructure.resetTree.Tag = i;
                this.Controls.Add(classStructure.resetTree);
            }
        }

        private void resetTree_MouseEnter(object sender, EventArgs e)
        {
            classStructure.resetTree.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.resetTree.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset_on));
        }

        private void resetTree_MouseLeave(object sender, EventArgs e)
        {
            classStructure.resetTree.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.resetTree.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset));
        }

        private void sorcerer_MouseEnter(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.sorcerer_on));
        }

        private void sorcerer_MouseLeave(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.sorcerer));
        }

        private void templar_MouseEnter(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.templar_on));
        }

        private void templar_MouseLeave(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.templar));
        }

        private void nightblade_MouseEnter(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.nightblade_on));
        }

        private void nightblade_MouseLeave(object sender, EventArgs e)
        {
            classStructure.menu.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.nightblade));
        }

        private void weaponSlot1_Click(object sender, EventArgs e)
        {
            classStructure.RemoveAllButtons();
        }

        private void weaponSlot1_MouseEnter(object sender, EventArgs e)
        {
            weaponSlot1.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.weaponSlot1.BackgroundImage = ((System.Drawing.Image)(BuildResource.one_two_handed_dual_on));
        }

        private void weaponSlot1_MouseLeave(object sender, EventArgs e)
        {
            weaponSlot1.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.weaponSlot1.BackgroundImage = ((System.Drawing.Image)(BuildResource.one_two_handed_dual));
        }

        private void armorType_Click(object sender, EventArgs e)
        {

        }

        private void armorType_MouseEnter(object sender, EventArgs e)
        {
            armorType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.armorType.BackgroundImage = ((System.Drawing.Image)(BuildResource.light_medium_heavy_on));
        }

        private void armorType_MouseLeave(object sender, EventArgs e)
        {
            armorType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.armorType.BackgroundImage = ((System.Drawing.Image)(BuildResource.light_medium_heavy));
        }

        private void weaponSlot2_Click(object sender, EventArgs e)
        {

        }

        private void weaponSlot2_MouseEnter(object sender, EventArgs e)
        {
            weaponSlot2.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.weaponSlot2.BackgroundImage = ((System.Drawing.Image)(BuildResource.bow_staff_on));
        }

        private void weaponSlot2_MouseLeave(object sender, EventArgs e)
        {
            weaponSlot2.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.weaponSlot2.BackgroundImage = ((System.Drawing.Image)(BuildResource.bow_staff));
        }

        private void racialDaggerfall_MouseEnter(object sender, EventArgs e)
        {
            racialDaggerfall.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.racialDaggerfall.BackgroundImage = ((System.Drawing.Image)(BuildResource.breton_redguard_orc_on));
        }

        private void racialDaggerfall_MouseLeave(object sender, EventArgs e)
        {
            racialDaggerfall.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.racialDaggerfall.BackgroundImage = ((System.Drawing.Image)(BuildResource.breton_redguard_orc));
        }

        private void racialAldmeri_MouseEnter(object sender, EventArgs e)
        {
            racialAldmeri.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.racialAldmeri.BackgroundImage = ((System.Drawing.Image)(BuildResource.altmer_bosmer_khajiit_on));
        }

        private void racialAldmeri_MouseLeave(object sender, EventArgs e)
        {
            racialAldmeri.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.racialAldmeri.BackgroundImage = ((System.Drawing.Image)(BuildResource.altmer_bosmer_khajiit));
        }

        private void racialEbonheart_MouseEnter(object sender, EventArgs e)
        {
            racialEbonheart.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.racialEbonheart.BackgroundImage = ((System.Drawing.Image)(BuildResource.nord_dunmer_argonian_on));
        }

        private void racialEbonheart_MouseLeave(object sender, EventArgs e)
        {
            racialEbonheart.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.racialEbonheart.BackgroundImage = ((System.Drawing.Image)(BuildResource.nord_dunmer_argonian));
        }

        private void pvpType_MouseEnter(object sender, EventArgs e)
        {
            pvpType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.pvpType.BackgroundImage = ((System.Drawing.Image)(BuildResource.assault_support_emperor_on));
        }

        private void pvpType_MouseLeave(object sender, EventArgs e)
        {
            pvpType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.pvpType.BackgroundImage = ((System.Drawing.Image)(BuildResource.assault_support_emperor));
        }

        private void guildsType_MouseEnter(object sender, EventArgs e)
        {
            guildsType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.guildsType.BackgroundImage = ((System.Drawing.Image)(BuildResource.guilds_on));
        }

        private void guildsType_MouseLeave(object sender, EventArgs e)
        {
            guildsType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.guildsType.BackgroundImage = ((System.Drawing.Image)(BuildResource.guilds));
        }

        private void craftingType_MouseEnter(object sender, EventArgs e)
        {
            craftingType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.craftingType.BackgroundImage = ((System.Drawing.Image)(BuildResource.crafting_on));
        }

        private void craftingType_MouseLeave(object sender, EventArgs e)
        {
            craftingType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.craftingType.BackgroundImage = ((System.Drawing.Image)(BuildResource.crafting));
        }

        private void soulMagicType_MouseEnter(object sender, EventArgs e)
        {
            soulMagicType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.soulMagicType.BackgroundImage = ((System.Drawing.Image)(BuildResource.soul_magic_on));
        }

        private void soulMagicType_MouseLeave(object sender, EventArgs e)
        {
            soulMagicType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.soulMagicType.BackgroundImage = ((System.Drawing.Image)(BuildResource.soul_magic));
        }

        private void vampirismType_MouseEnter(object sender, EventArgs e)
        {
            vampirismType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.vampirismType.BackgroundImage = ((System.Drawing.Image)(BuildResource.vampirism_on));
        }

        private void vampirismType_MouseLeave(object sender, EventArgs e)
        {
            vampirismType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.vampirismType.BackgroundImage = ((System.Drawing.Image)(BuildResource.vampirism));
        }

        private void lycanthropyType_MouseEnter(object sender, EventArgs e)
        {
            lycanthropyType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));
            this.lycanthropyType.BackgroundImage = ((System.Drawing.Image)(BuildResource.lycanthropy_on));
        }

        private void lycanthropyType_MouseLeave(object sender, EventArgs e)
        {
            lycanthropyType.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            this.lycanthropyType.BackgroundImage = ((System.Drawing.Image)(BuildResource.lycanthropy));
        }

        private void resetTreeOneEvent_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // now you know the button that was clicked
                switch ((int)button.Tag)
                {
                    case 0:
                        // First Button Clicked
                        break;
                    case 1:
                        // Second Button Clicked
                        break;
                    case 2:
                        // Third Button Clicked
                        break;
                }
            }
        }
    }
}
