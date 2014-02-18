using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ESO___Skill_Point_Calculator
{
    class GlobalStructure : GraphicPosition
    {
        Collection collection = new Collection();
        public List<ButtonControl> buttonControl = new List<ButtonControl>();
        public Button resetTree;
        public Label maxSkillPoint;
        public bool accesToCreate = true;

        public void globalStructureInfo()
        {
            if (accesToCreate)
            {
                // Maxskill Point
                maxSkillPoint.AutoSize = true;
                maxSkillPoint.BackColor = System.Drawing.Color.Transparent;
                maxSkillPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                maxSkillPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(181)))));
                maxSkillPoint.Location = new System.Drawing.Point(528, 687);
                maxSkillPoint.Name = "maxSkillPoint";
                maxSkillPoint.Text = UniqueValue.spentSkillPoints.ToString();
                maxSkillPoint.Size = new System.Drawing.Size(0, 20);
                accesToCreate = false;
            }

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
            resetTree.Visible = false;
            resetTree.Click += new EventHandler(resetTreeOneEvent_Click);
            resetTree.VisibleChanged += new EventHandler(classUniqueButtons_VisibleChanged);
            resetTree.MouseEnter += new EventHandler(classButton_MouseEnter);
            resetTree.MouseLeave += new EventHandler(classButton_MouseLeave);
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

            if (name.Contains("resetTree"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset_on));
        }

        private void classButton_MouseLeave(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            if (name.Contains("resetTree"))
                currentButton.BackgroundImage = ((System.Drawing.Image)(BuildResource.reset));
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
    }

    class ButtonControl
    {
        public Button btn;
        public object obj;
    }
}
