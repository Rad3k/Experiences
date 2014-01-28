using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using WMPLib;

namespace ESO___Skill_Point_Calculator
{
    class GraphicClassStructure : GraphicPosition
    {
        public List<ButtonControl> buttonControl = new List<ButtonControl>();

        // Global
        public Button resetTree;
        public Button menu = new Button();
        public PictureBox classBackround = new PictureBox();
        // Button
        Button plus;
        Button minus;
        // Spells
        Button spells;
        // ButtonInformation:
        Button ultimateInfo = new Button();
        Button activeInfo = new Button();
        Button passiveInfo = new Button();
        // Label
        Label points;

        Collection collection = new Collection();

        public GraphicClassStructure()
        {
            collection.ListClassValueLabel();
        }

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
            classBackround.Location = Location[0][1];
            classBackround.Name = "classBackround";
            classBackround.Size = Size[0][4];
            classBackround.Controls.Add(ultimateInfo);
            classBackround.Controls.Add(activeInfo);
            classBackround.Controls.Add(passiveInfo);

            // Button information
            ultimateInfo.BackColor = Color.Transparent;
            ultimateInfo.BackgroundImage = BuildResource.ultimate;
            ultimateInfo.BackgroundImageLayout = ImageLayout.Stretch;
            ultimateInfo.FlatAppearance.BorderSize = 0;
            ultimateInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ultimateInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ultimateInfo.FlatStyle = FlatStyle.Flat;
            ultimateInfo.Location = Location[0][2];
            ultimateInfo.Name = "ultimateInfo";
            ultimateInfo.Size = Size[0][6];
            ultimateInfo.UseVisualStyleBackColor = false;

            activeInfo.BackColor = Color.Transparent;
            activeInfo.BackgroundImage = BuildResource.active;
            activeInfo.BackgroundImageLayout = ImageLayout.Stretch;
            activeInfo.FlatAppearance.BorderSize = 0;
            activeInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            activeInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            activeInfo.FlatStyle = FlatStyle.Flat;
            activeInfo.Location = Location[0][3];
            activeInfo.Name = "activeInfo";
            activeInfo.Size = Size[0][7];
            activeInfo.UseVisualStyleBackColor = false;

            passiveInfo.BackColor = Color.Transparent;
            passiveInfo.BackgroundImage = BuildResource.passive;
            passiveInfo.BackgroundImageLayout = ImageLayout.Stretch;
            passiveInfo.FlatAppearance.BorderSize = 0;
            passiveInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            passiveInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            passiveInfo.FlatStyle = FlatStyle.Flat;
            passiveInfo.Location = Location[0][4];
            passiveInfo.Name = "passiveInfo";
            passiveInfo.Size = Size[0][7];
            passiveInfo.UseVisualStyleBackColor = false;
        }

        public void resetTreeButton(object sender, EventArgs e)
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
            resetTree.Click += new EventHandler(resetTreeOneEvent_Click);
            resetTree.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);
            resetTree.MouseEnter += new EventHandler(classButton_MouseEnter);
            resetTree.MouseLeave += new EventHandler(classButton_MouseLeave);

            buttonControl.Add(new ButtonControl() { btn = menu, obj = (object)resetTree });
        }

        public void CreateSpellsButton()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    spells = new Button();
                    plus = new Button();
                    minus = new Button();
                    points = new Label();

                    switch (j)
                    {
                        case 0:
                            spells.Location = Location[1][i];
                            points.Location = Location[1][i];
                            points.Location = new Point(points.Location.X + 8, points.Location.Y + 45);
                            plus.Location = Location[2][i];
                            minus.Location = Location[3][i];
                            break;
                        case 1:
                            spells.Location = Location[1][i];
                            spells.Location = new Point(spells.Location.X + 205, spells.Location.Y);
                            plus.Location = Location[2][i];
                            plus.Location = new Point(plus.Location.X + 205, plus.Location.Y);
                            minus.Location = Location[3][i];
                            minus.Location = new Point(minus.Location.X + 205, minus.Location.Y);
                            points.Location = Location[1][i];
                            points.Location = new Point(points.Location.X + 213, points.Location.Y + 45);
                            break;
                        case 2:
                            spells.Location = Location[1][i];
                            spells.Location = new Point(spells.Location.X + 410, spells.Location.Y);
                            plus.Location = Location[2][i];
                            plus.Location = new Point(plus.Location.X + 410, plus.Location.Y);
                            minus.Location = Location[3][i];
                            minus.Location = new Point(minus.Location.X + 410, minus.Location.Y);
                            points.Location = Location[1][i];
                            points.Location = new Point(points.Location.X + 418, points.Location.Y + 45);
                            break;
                    }

                    // Spells
                    spells.BackColor = Color.Transparent;
                    spells.BackgroundImage = BuildResource.skill_temp;
                    spells.BackgroundImageLayout = ImageLayout.Stretch;
                    spells.FlatAppearance.BorderSize = 0;
                    spells.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    spells.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    spells.FlatStyle = FlatStyle.Flat;
                    spells.Name = "Spells";
                    spells.Size = Size[0][8];
                    spells.UseVisualStyleBackColor = false;
                    spells.Name = spells.Name + i.ToString() + "_" + j.ToString();
                    spells.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);

                    // Labels for point
                    points.BackColor = Color.Transparent;
                    points.ForeColor = Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
                    points.BackgroundImageLayout = ImageLayout.Stretch;
                    points.FlatStyle = FlatStyle.Flat;
                    points.Name = "points";
                    points.Name = spells.Name + i.ToString() + "_" + j.ToString();
                    if (i >= 6)
                        points.Text = "0 / 2";
                    else
                        points.Text = "0 / 1";
                    points.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);

                    // Plus
                    plus.BackColor = Color.Transparent;
                    plus.BackgroundImage = BuildResource.plus;
                    plus.BackgroundImageLayout = ImageLayout.Stretch;
                    plus.FlatAppearance.BorderSize = 0;
                    plus.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    plus.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    plus.FlatStyle = FlatStyle.Flat;
                    plus.Name = "plus";
                    plus.Size = Size[0][9];
                    plus.UseVisualStyleBackColor = false;
                    plus.Name = plus.Name + i.ToString() + "_" + j.ToString();
                    plus.Click += new EventHandler(plusButton_click);
                    plus.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);
                    plus.MouseEnter += new EventHandler(classButton_MouseEnter);
                    plus.MouseLeave += new EventHandler(classButton_MouseLeave);
                    plus.Tag = points;

                    // Minus
                    minus.BackColor = Color.Transparent;
                    minus.BackgroundImage = BuildResource.minus;
                    minus.BackgroundImageLayout = ImageLayout.Stretch;
                    minus.FlatAppearance.BorderSize = 0;
                    minus.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    minus.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    minus.FlatStyle = FlatStyle.Flat;
                    minus.Name = "minus";
                    minus.Size = Size[0][10];
                    minus.UseVisualStyleBackColor = false;
                    minus.Name = minus.Name + i.ToString() + "_" + j.ToString();
                    minus.Click += new EventHandler(minusButton_click);
                    minus.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);
                    minus.MouseEnter += new EventHandler(classButton_MouseEnter);
                    minus.MouseLeave += new EventHandler(classButton_MouseLeave);
                    minus.Tag = points;

                    classBackround.Controls.Add(spells);
                    classBackround.Controls.Add(plus);
                    classBackround.Controls.Add(minus);
                    classBackround.Controls.Add(points);
                }
            }
        }

        public void classUniqueButtons_VisibleChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (ButtonControl btnCntrl in buttonControl)
            {
                if (btnCntrl.btn != button)
                {
                    if (btnCntrl.obj.GetType() == typeof(Button))
                    {
                        Button objBtn = (Button)btnCntrl.obj;
                        objBtn.Visible = UniqueValue.visibleType;
                    }
                }
            }
        }

        private void classButton_MouseEnter(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));

            switch (name)
            {
                // Unique buttons
                case "resetTree0":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset_on));
                    break;
                case "resetTree1":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset_on));
                    break;
                case "resetTree2":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset_on));
                    break;
            }
        }

        private void classButton_MouseLeave(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            switch (name)
            {
                // Unique buttons
                case "resetTree0":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset));
                    break;
                case "resetTree1":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset));
                    break;
                case "resetTree2":
                    currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset));
                    break;
            }
        }

        private void plusButton_click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;

            switch (name)
            {
                // Ultimate
                case "plus0_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.ultimateSpells[0] = 1;
                    break;
                case "plus0_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.ultimateSpells[1] = 1;
                    break;
                case "plus0_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.ultimateSpells[2] = 1;
                    break;
                // Active Tree (1)
                case "plus1_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[0] = 1;
                    break;
                case "plus2_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[1] = 1;
                    break;
                case "plus3_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[2] = 1;
                    break;
                case "plus4_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[3] = 1;
                    break;
                case "plus5_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[4] = 1;
                    break;
                // Active Tree (2)
                case "plus1_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[5] = 1;
                    break;
                case "plus2_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[6] = 1;
                    break;
                case "plus3_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[7] = 1;
                    break;
                case "plus4_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[8] = 1;
                    break;
                case "plus5_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[9] = 1;
                    break;
                // Active Tree (3)
                case "plus1_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[10] = 1;
                    break;
                case "plus2_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[11] = 1;
                    break;
                case "plus3_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[12] = 1;
                    break;
                case "plus4_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[13] = 1;
                    break;
                case "plus5_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.activeSpells[14] = 1;
                    break;
                // Passive Tree (1)
                case "plus6_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[0] = 2;
                    }
                    break;
                case "plus7_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[1] = 2;
                    }
                    break;
                case "plus8_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[2] = 2;
                    }
                    break;
                case "plus9_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[3] = 2;
                    }
                    break;
                // Passive Tree (2)
                case "plus6_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[4] = 2;
                    }
                    break;
                case "plus7_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[5] = 2;
                    }
                    break;
                case "plus8_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[6] = 2;
                    }
                    break;
                case "plus9_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[7] = 2;
                    }
                    break;
                // Passive Tree (3)
                case "plus6_2":
                   if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[8] = 2;
                    }
                    break;
                case "plus7_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[9] = 2;
                    }
                    break;
                case "plus8_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[10] = 2;
                    }
                    break;
                case "plus9_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.passiveSpells[11] = 2;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.ultimateSpells.Sum() + collection.activeSpells.Sum() + collection.passiveSpells.Sum();
            // Get reference to the label
            var buildEditor = new buildEditor();
            buildEditor.maxSkillPoint_TextChanged(buildEditor, "maxSkillPoint");
        }

        private void minusButton_click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;

            switch (name)
            {
                // Ultimate
                case "minus0_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.ultimateSpells[0] = 0;
                    break;
                case "minus0_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.ultimateSpells[1] = 0;
                    break;
                case "minus0_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.ultimateSpells[2] = 0;
                    break;
                // Active Tree (1)
                case "minus1_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[0] = 0;
                    break;
                case "minus2_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[1] = 0;
                    break;
                case "minus3_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[2] = 0;
                    break;
                case "minus4_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[3] = 0;
                    break;
                case "minus5_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[4] = 0;
                    break;
                // Active Tree (2)
                case "minus1_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[5] = 0;
                    break;
                case "minus2_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[6] = 0;
                    break;
                case "minus3_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[7] = 0;
                    break;
                case "minus4_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[8] = 0;
                    break;
                case "minus5_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[9] = 0;
                    break;
                // Active Tree (3)
                case "minus1_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[10] = 0;
                    break;
                case "minus2_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[11] = 0;
                    break;
                case "minus3_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[12] = 0;
                    break;
                case "minus4_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[13] = 0;
                    break;
                case "minus5_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.activeSpells[14] = 0;
                    break;
                // Passive Tree (1)
                case "minus6_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[0] = 0;
                    }
                    break;
                case "minus7_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[1] = 0;
                    }
                    break;
                case "minus8_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[2] = 0;
                    }
                    break;
                case "minus9_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[3] = 0;
                    }
                    break;
                // Passive Tree (2)
                case "minus6_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[4] = 0;
                    }
                    break;
                case "minus7_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[5] = 0;
                    }
                    break;
                case "minus8_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[6] = 0;
                    }
                    break;
                case "minus9_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[7] = 0;
                    }
                    break;
                // Passive Tree (3)
                case "minus6_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[8] = 0;
                    }
                    break;
                case "minus7_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[9] = 0;
                    }
                    break;
                case "minus8_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[10] = 0;
                    }
                    break;
                case "minus9_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.passiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.passiveSpells[11] = 0;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.ultimateSpells.Sum() + collection.activeSpells.Sum() + collection.passiveSpells.Sum();
        }

        private void resetTreeOneEvent_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var name = button.Name;
            if (button != null)
            {
                switch (name)
                {
                    case "resetTree0":
                        MessageBox.Show("1");
                        break;
                    case "resetTree1":
                        MessageBox.Show("2");
                        break;
                    case "resetTree2":
                        MessageBox.Show("3");
                        break;
                }
            }
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
