using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    class GraphicArmorStructure : GraphicPosition
    {
        buildEditor spentSkill;
        Collection collection = new Collection();

        public PictureBox armorBackround = new PictureBox();
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

        public GraphicArmorStructure(buildEditor spentSkill)
        {
            this.spentSkill = spentSkill;
            collection.ListClassValueLabel();
        }

        public void CreateArmorButtons()
        {
            // Class Backround
            armorBackround.BackColor = Color.Transparent;
            armorBackround.BackgroundImage = BuildResource.armor_skill_tree;
            armorBackround.BackgroundImageLayout = ImageLayout.Stretch;
            armorBackround.Location = Location[0][0][1];
            armorBackround.Name = "armorBackround";
            armorBackround.Size = Size[0][4];
            armorBackround.Controls.Add(activeInfo);
            armorBackround.Controls.Add(passiveInfo);

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
            passiveInfo.Name = "passiveInfo";
            passiveInfo.Size = Size[0][7];
            passiveInfo.UseVisualStyleBackColor = false;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    spells = new Button();
                    plus = new Button();
                    minus = new Button();
                    points = new Label();

                    switch (j)
                    {
                        case 0:
                            spells.Location = Location[1][0][i];
                            points.Location = Location[1][0][i];
                            points.Location = new Point(points.Location.X + 8, points.Location.Y + 45);
                            plus.Location = Location[1][1][i];
                            minus.Location = Location[1][2][i];
                            break;
                        case 1:
                            spells.Location = Location[1][0][i];
                            spells.Location = new Point(spells.Location.X + 205, spells.Location.Y);
                            plus.Location = Location[1][1][i];
                            plus.Location = new Point(plus.Location.X + 205, plus.Location.Y);
                            minus.Location = Location[1][2][i];
                            minus.Location = new Point(minus.Location.X + 205, minus.Location.Y);
                            points.Location = Location[1][0][i];
                            points.Location = new Point(points.Location.X + 213, points.Location.Y + 45);
                            break;
                        case 2:
                            spells.Location = Location[1][0][i];
                            spells.Location = new Point(spells.Location.X + 410, spells.Location.Y);
                            plus.Location = Location[1][1][i];
                            plus.Location = new Point(plus.Location.X + 410, plus.Location.Y);
                            minus.Location = Location[1][2][i];
                            minus.Location = new Point(minus.Location.X + 410, minus.Location.Y);
                            points.Location = Location[1][0][i];
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
                    if (i >= 1)
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

                    armorBackround.Controls.Add(spells);
                    armorBackround.Controls.Add(plus);
                    armorBackround.Controls.Add(minus);
                    armorBackround.Controls.Add(points);
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
                // Active
                case "plus0_0":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.armorActiveSpells[0] = 1;
                    break;
                case "plus0_1":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.armorActiveSpells[1] = 1;
                    break;
                case "plus0_2":
                    (currentButton.Tag as Label).Text = "1 / 1";
                    collection.armorActiveSpells[2] = 1;
                    break;
                // Passive Tree (1)
                case "plus1_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[0] = 2;
                    }
                    break;
                case "plus2_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[1] = 2;
                    }
                    break;
                case "plus3_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[2] = 2;
                    }
                    break;
                case "plus4_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[3] = 2;
                    }
                    break;
                case "plus5_0":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[4] = 2;
                    }
                    break;
                // Passive Tree (2)
                case "plus1_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[5] = 2;
                    }
                    break;
                case "plus2_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[6] = 2;
                    }
                    break;
                case "plus3_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[7] = 2;
                    }
                    break;
                case "plus4_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[8] = 2;
                    }
                    break;
                case "plus5_1":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[9] = 2;
                    }
                    break;
                // Passive Tree (3)
                case "plus1_2":
                   if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[10] = 2;
                    }
                    break;
                case "plus2_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[11] = 2;
                    }
                    break;
                case "plus3_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[12] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[12] = 2;
                    }
                    break;
                case "plus4_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[13] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[13] = 2;
                    }
                    break;
                case "plus5_2":
                    if ((currentButton.Tag as Label).Text.Contains("0 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[14] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "2 / 2";
                        collection.armorPassiveSpells[14] = 2;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.classUltimateSpells.Sum() + collection.classActiveSpells.Sum()
                + collection.classPassiveSpells.Sum() + collection.armorActiveSpells.Sum() + collection.armorPassiveSpells.Sum();
            spentSkill.maxSkillPoint_TextChanged(spentSkill, "maxSkillPoint");
        }

        private void minusButton_click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;

            switch (name)
            {
                // Active
                case "minus0_0":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.armorActiveSpells[0] = 0;
                    break;
                case "minus0_1":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.armorActiveSpells[1] = 0;
                    break;
                case "minus0_2":
                    (currentButton.Tag as Label).Text = "0 / 1";
                    collection.armorActiveSpells[2] = 0;
                    break;
                // Passive Tree (1)
                case "minus1_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[0] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[0] = 0;
                    }
                    break;
                case "minus2_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[1] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[1] = 0;
                    }
                    break;
                case "minus3_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[2] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[2] = 0;
                    }
                    break;
                case "minus4_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[3] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[3] = 0;
                    }
                    break;
                case "minus5_0":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[4] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[4] = 0;
                    }
                    break;
                // Passive Tree (2)
                case "minus1_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[5] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[5] = 0;
                    }
                    break;
                case "minus2_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[6] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[6] = 0;
                    }
                    break;
                case "minus3_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[7] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[7] = 0;
                    }
                    break;
                case "minus4_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[8] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[8] = 0;
                    }
                    break;
                case "minus5_1":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[9] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[9] = 0;
                    }
                    break;
                // Passive Tree (3)
                case "minus1_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[10] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[10] = 0;
                    }
                    break;
                case "minus2_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[11] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[11] = 0;
                    }
                    break;
                case "minus3_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[12] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[12] = 0;
                    }
                    break;
                case "minus4_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[13] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[13] = 0;
                    }
                    break;
                case "minus5_2":
                    if ((currentButton.Tag as Label).Text.Contains("2 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "1 / 2";
                        collection.armorPassiveSpells[14] = 1;
                    }
                    else if ((currentButton.Tag as Label).Text.Contains("1 / 2"))
                    {
                        (currentButton.Tag as Label).Text = "0 / 2";
                        collection.armorPassiveSpells[14] = 0;
                    }
                    break;
            }
            UniqueValue.spentSkillPoints = collection.classUltimateSpells.Sum() + collection.classActiveSpells.Sum() 
                + collection.classPassiveSpells.Sum() + collection.armorActiveSpells.Sum() + collection.armorPassiveSpells.Sum();
            spentSkill.maxSkillPoint_TextChanged(spentSkill, "maxSkillPoint");
        }

        public void ArmorAllButtonsVisible()
        {
            armorBackround.Visible = true;
            activeInfo.Visible = true;
            passiveInfo.Visible = true;
        }

        public void ArmorAllButtonsInVisible()
        {
            armorBackround.Visible = false;
            activeInfo.Visible = false;
            passiveInfo.Visible = false;
        }

        public void RemoveAllButtons()
        {
            armorBackround.Controls.Remove(armorBackround);
            activeInfo.Controls.Remove(activeInfo);
            passiveInfo.Controls.Remove(passiveInfo);

            armorBackround.Dispose();
            activeInfo.Dispose();
            passiveInfo.Dispose();
        }
    }
}
