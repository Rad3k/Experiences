using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    public partial class buildEditor : Form
    {
        Collection collection = new Collection();
        GlobalStructure global;
        GraphicClassStructure classStructure;
        GraphicArmorStructure armorStructure;
        GraphicWeaponsStructure weaponStructure;

        int clickClass = 0;
        int clickArmor = 0;
        int clickWeapons = 0;

        public buildEditor()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            global = new GlobalStructure();
            classStructure = new GraphicClassStructure(this);
            armorStructure = new GraphicArmorStructure(this);
            weaponStructure = new GraphicWeaponsStructure(this);
            

            // Menu information for class
            classStructure.CreateClassButtons();
            classStructure.menu.Click += new System.EventHandler(classMenu_Click);
            classStructure.menu.MouseEnter += new System.EventHandler(CheckAllButtons_MouseEnter);
            classStructure.menu.MouseLeave += new System.EventHandler(CheckAllButtons_MouseLeave);
            this.Controls.Add(classStructure.menu);

            // Global structure
            for (int i = 0; i < 3; i++)
            {
                global.resetTree = new Button();
                if (global.accesToCreate)
                    global.maxSkillPoint = new Label();
                global.globalStructureInfo();
                global.resetTree.Location = classStructure.Location[0][4][i];
                global.resetTree.Name = global.resetTree.Name + i.ToString();
                this.Controls.Add(global.resetTree);
                this.Controls.Add(global.maxSkillPoint);

                global.buttonControl.Add(new ButtonControl() { btn = classStructure.menu, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = weaponSlot1, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = weaponSlot2, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = armorType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = racialDaggerfall, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = racialAldmeri, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = racialEbonheart, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = pvpType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = guildsType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = craftingType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = soulMagicType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = lycanthropyType, obj = (object)global.resetTree });
                global.buttonControl.Add(new ButtonControl() { btn = vampirismType, obj = (object)global.resetTree });
            }
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
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight_on1));
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
                    this.classStructure.menu.BackgroundImage = ((System.Drawing.Image)(BuildResource.dragonknight1));
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
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            classStructure.ClassAllButtonsVisible();
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();

            if (clickClass < 1)
            {
                classStructure.CreateClassButtons();
                classStructure.CreateSpellsButton();
                this.Controls.Add(classStructure.classBackround);
            }
            clickClass++;
            UniqueValue.visibleType = true;
        }

        private void weaponSlot1_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            UniqueValue.weapons = "melee";
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsVisible();

            if (clickWeapons < 1 || UniqueValue.weapons == "melee")
            {
                weaponStructure.weaponBackround.BackgroundImage = BuildResource.weapon_1_skill_tree1;
                weaponStructure.CreateArmorButtons();
                this.Controls.Add(weaponStructure.weaponBackround);
            }
            clickWeapons++;
        }

        private void armorType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsVisible();
            weaponStructure.WeaponsAllButtonsInVisible();

            if (clickArmor < 1)
            {
                armorStructure.CreateArmorButtons();
                this.Controls.Add(armorStructure.armorBackround);
            }
            clickArmor++;
        }

        private void weaponSlot2_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            UniqueValue.weapons = "ranged";
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsVisible();

            if (clickWeapons < 1 || UniqueValue.weapons == "ranged")
            {
                weaponStructure.weaponBackround.BackgroundImage = BuildResource.weapon_2_skill_tree1;
                weaponStructure.CreateArmorButtons();
                this.Controls.Add(weaponStructure.weaponBackround);
            }
            clickWeapons++;
        }

        private void racialDaggerfall_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void racialAldmeri_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void racialEbonheart_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void pvpType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void guildsType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void craftingType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void soulMagicType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void lycanthropyType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        private void vampirismType_Click(object sender, EventArgs e)
        {
            UniqueValue.visibleType = true;
            classStructure.ClassAllButtonsInVisible();
            global.classUniqueButtons_VisibleChanged((Button)sender, e);
            armorStructure.ArmorAllButtonsInVisible();
            weaponStructure.WeaponsAllButtonsInVisible();
        }

        public void maxSkillPoint_TextChanged(Form formInstance, string labelName)
        {
            // Get reference to the label
            var label = formInstance.Controls.Find(labelName, true).FirstOrDefault();
            if (null != label && label is Label)
            {
                (label as Label).Text = UniqueValue.spentSkillPoints.ToString();
            }
        }
    }
}
