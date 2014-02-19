using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    class GraphicWeaponsStructure : GraphicPosition
    {
        buildEditor spentSkill;
        Collection collection = new Collection();

        public PictureBox weaponBackround = new PictureBox();
        // ButtonInformation:
        Button activeInfo = new Button();
        Button passiveInfo = new Button();
        // Button
        Button plus;
        Button minus;
        // Spells
        Button spells;
        // Label
        Label points;

        public GraphicWeaponsStructure(buildEditor spentSkill)
        {
            this.spentSkill = spentSkill;
            collection.ListClassValueLabel();
        }

        public void CreateArmorButtons()
        {
            // Class Backround
            weaponBackround.BackColor = Color.Transparent;
            weaponBackround.BackgroundImageLayout = ImageLayout.Stretch;
            weaponBackround.Location = Location[0][0][1];
            weaponBackround.Name = "weaponBackround";
            weaponBackround.Size = Size[0][4];
            weaponBackround.Controls.Add(activeInfo);
            weaponBackround.Controls.Add(passiveInfo);

            activeInfo.BackColor = Color.Transparent;
            activeInfo.BackgroundImage = BuildResource.active;
            activeInfo.BackgroundImageLayout = ImageLayout.Stretch;
            activeInfo.FlatAppearance.BorderSize = 0;
            activeInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            activeInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            activeInfo.FlatStyle = FlatStyle.Flat;
            activeInfo.Location = Location[0][0][2];
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
            passiveInfo.Location = Location[0][0][3];
            passiveInfo.Location = new Point(passiveInfo.Location.X, passiveInfo.Location.Y + 135);
            passiveInfo.Name = "passiveInfo";
            passiveInfo.Size = Size[0][7];
            passiveInfo.UseVisualStyleBackColor = false;

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
                            spells.Location = Location[2][0][i];
                            plus.Location = Location[2][1][i];
                            minus.Location = Location[2][2][i];
                            points.Location = Location[2][0][i];
                            points.Location = new Point(points.Location.X + 8, points.Location.Y + 45);
                            break;
                        case 1:
                            spells.Location = Location[2][0][i];
                            spells.Location = new Point(spells.Location.X + 205, spells.Location.Y);
                            plus.Location = Location[2][1][i];
                            plus.Location = new Point(plus.Location.X + 205, plus.Location.Y);
                            minus.Location = Location[2][2][i];
                            minus.Location = new Point(minus.Location.X + 205, minus.Location.Y);
                            points.Location = Location[2][0][i];
                            points.Location = new Point(points.Location.X + 213, points.Location.Y + 45);
                            break;
                        case 2:
                            spells.Location = Location[2][0][i];
                            spells.Location = new Point(spells.Location.X + 410, spells.Location.Y);
                            plus.Location = Location[2][1][i];
                            plus.Location = new Point(plus.Location.X + 410, plus.Location.Y);
                            minus.Location = Location[2][2][i];
                            minus.Location = new Point(minus.Location.X + 410, minus.Location.Y);
                            points.Location = Location[2][0][i];
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

                    // Labels for point
                    points.BackColor = Color.Transparent;
                    points.ForeColor = Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
                    points.BackgroundImageLayout = ImageLayout.Stretch;
                    points.FlatStyle = FlatStyle.Flat;
                    points.Name = "points";
                    points.Name = spells.Name + i.ToString() + "_" + j.ToString();
                    if (i >= 5)
                        points.Text = "0 / 2";
                    else
                        points.Text = "0 / 1";

                    // Plus
                    plus.BackColor = Color.Transparent;
                    plus.BackgroundImage = BuildResource.plus1;
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
                    plus.MouseEnter += new EventHandler(classButton_MouseEnter);
                    plus.MouseLeave += new EventHandler(classButton_MouseLeave);
                    plus.Tag = points;

                    // Minus
                    minus.BackColor = Color.Transparent;
                    minus.BackgroundImage = BuildResource.minus1;
                    minus.BackgroundImageLayout = ImageLayout.Stretch;
                    minus.FlatAppearance.BorderSize = 0;
                    minus.FlatAppearance.MouseDownBackColor = Color.Transparent;
                    minus.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    minus.FlatStyle = FlatStyle.Flat;
                    minus.Name = "minus";
                    minus.Size = Size[0][9];
                    minus.UseVisualStyleBackColor = false;
                    minus.Name = minus.Name + i.ToString() + "_" + j.ToString();
                    minus.Click += new EventHandler(minusButton_click);
                    minus.MouseEnter += new EventHandler(classButton_MouseEnter);
                    minus.MouseLeave += new EventHandler(classButton_MouseLeave);
                    minus.Tag = points;

                    weaponBackround.Controls.Add(spells);
                    weaponBackround.Controls.Add(plus);
                    weaponBackround.Controls.Add(minus);
                    weaponBackround.Controls.Add(points);
                }
            }
        }

        private void classButton_MouseEnter(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));

            if (name.Contains("plus"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.plus_on));
            else if (name.Contains("minus"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.minus_on));
        }

        private void classButton_MouseLeave(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            if (name.Contains("plus"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.plus1));
            else if (name.Contains("minus"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.minus1));
        }

        private void plusButton_click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;

            switch (name)
            {
                // Active Tree (1)
                case "plus0_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[0] = 1;
                    break;
                case "plus1_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[1] = 1;
                    break;
                case "plus2_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[2] = 1;
                    break;
                case "plus3_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[3] = 1;
                    break;
                case "plus4_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[4] = 1;
                    break;
                // Active Tree (1)
                case "plus0_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[5] = 1;
                    break;
                case "plus1_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[6] = 1;
                    break;
                case "plus2_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[7] = 1;
                    break;
                case "plus3_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[8] = 1;
                    break;
                case "plus4_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[9] = 1;
                    break;
                // Active Tree (1)
                case "plus0_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[10] = 1;
                    break;
                case "plus1_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[11] = 1;
                    break;
                case "plus2_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[12] = 1;
                    break;
                case "plus3_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[13] = 1;
                    break;
                case "plus4_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[14] = 1;
                    break;
                // Passive Tree (1)
                case "plus5_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[0] = 2;
                    }
                    break;
                case "plus6_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[1] = 2;
                    }
                    break;
                case "plus7_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[2] = 2;
                    }
                    break;
                case "plus8_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[3] = 2;
                    }
                    break;
                case "plus9_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[4] = 2;
                    }
                    break;
                // Passive Tree (2)
                case "plus5_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[5] = 2;
                    }
                    break;
                case "plus6_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[6] = 2;
                    }
                    break;
                case "plus7_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[7] = 2;
                    }
                    break;
                case "plus8_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[8] = 2;
                    }
                    break;
                case "plus9_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[9] = 2;
                    }
                    break;
                // Passive Tree (3)
                case "plus5_2":
                   if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[10] = 2;
                    }
                    break;
                case "plus6_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[11] = 2;
                    }
                    break;
                case "plus7_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[12] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[12] = 2;
                    }
                    break;
                case "plus8_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[13] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[13] = 2;
                    }
                    break;
                case "plus9_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[14] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[14] = 2;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.classUltimateSpells.Sum() + collection.classActiveSpells.Sum()
                + collection.classPassiveSpells.Sum() + collection.armorActiveSpells.Sum() + collection.armorPassiveSpells.Sum() +
                collection.WeaponsActiveSpells.Sum() + collection.WeaponsPassiveSpells.Sum();
            spentSkill.maxSkillPoint_TextChanged(spentSkill, "maxSkillPoint");
        }

        private void minusButton_click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;

            switch (name)
            {
                // Active Tree (1)
                case "minus0_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[0] = 1;
                    break;
                case "minus1_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[1] = 1;
                    break;
                case "minus2_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[2] = 1;
                    break;
                case "minus3_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[3] = 1;
                    break;
                case "minus4_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[4] = 1;
                    break;
                // Active Tree (1)
                case "minus0_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[5] = 1;
                    break;
                case "minus1_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[6] = 1;
                    break;
                case "minus2_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[7] = 1;
                    break;
                case "minus3_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[8] = 1;
                    break;
                case "minus4_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[9] = 1;
                    break;
                // Active Tree (1)
                case "minus0_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[10] = 1;
                    break;
                case "minus1_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[11] = 1;
                    break;
                case "minus2_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[12] = 1;
                    break;
                case "minus3_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[13] = 1;
                    break;
                case "minus4_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.WeaponsActiveSpells[14] = 1;
                    break;
                // Passive Tree (1)
                case "minus5_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[0] = 2;
                    }
                    break;
                case "minus6_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[1] = 2;
                    }
                    break;
                case "minus7_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[2] = 2;
                    }
                    break;
                case "minus8_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[3] = 2;
                    }
                    break;
                case "minus9_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[4] = 2;
                    }
                    break;
                // Passive Tree (2)
                case "minus5_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[5] = 2;
                    }
                    break;
                case "minus6_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[6] = 2;
                    }
                    break;
                case "minus7_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[7] = 2;
                    }
                    break;
                case "minus8_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[8] = 2;
                    }
                    break;
                case "minus9_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[9] = 2;
                    }
                    break;
                // Passive Tree (3)
                case "minus5_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[10] = 2;
                    }
                    break;
                case "minus6_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[11] = 2;
                    }
                    break;
                case "minus7_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[12] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[12] = 2;
                    }
                    break;
                case "minus8_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[13] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[13] = 2;
                    }
                    break;
                case "minus9_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.WeaponsPassiveSpells[14] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.WeaponsPassiveSpells[14] = 2;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.classUltimateSpells.Sum() + collection.classActiveSpells.Sum()
                + collection.classPassiveSpells.Sum() + collection.armorActiveSpells.Sum() + collection.armorPassiveSpells.Sum() +
                collection.WeaponsActiveSpells.Sum() + collection.WeaponsPassiveSpells.Sum();
            spentSkill.maxSkillPoint_TextChanged(spentSkill, "maxSkillPoint");
        }

        public void WeaponsAllButtonsVisible()
        {
            weaponBackround.Visible = true;
            activeInfo.Visible = true;
            passiveInfo.Visible = true;
        }

        public void WeaponsAllButtonsInVisible()
        {
            weaponBackround.Visible = false;
            activeInfo.Visible = false;
            passiveInfo.Visible = false;
        }

        public void RemoveAllButtons()
        {
            weaponBackround.Controls.Remove(weaponBackround);
            activeInfo.Controls.Remove(activeInfo);
            passiveInfo.Controls.Remove(passiveInfo);

            weaponBackround.Dispose();
            activeInfo.Dispose();
            passiveInfo.Dispose();
        }
    }
}
