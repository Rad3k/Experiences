using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predfakturace
{
    public partial class ControlFile : Form
    {
        public int calculate = 0;
        public int y = 28;
        public string name;

        public ControlFile()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nextStep_Click(object sender, EventArgs e)
        {
        }

        private void OpenFileDialogButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (calculate == 0)
                {
                    string souborFilename = openFileDialog1.FileName;
                    filePathText.Text = souborFilename;
                }
                else
                {
                    Button btn = sender as Button;
                    string souborFilename = openFileDialog1.FileName;
                    this.Controls.Find((string)btn.Tag, true)[0].Text = souborFilename;
                }
            }
        }

        private void nextDialog_Click(object sender, EventArgs e)
        {
            if (calculate <= 7)
            {
                TextBox text = new TextBox();
                text.Location = new Point(filePathText.Location.X, filePathText.Location.Y + y);
                text.Size = new Size(194, 20);
                text.ReadOnly = true;
                text.Name = "filePathText" + calculate.ToString();
                //text.Tag = text.Name;
                this.Controls.Add(text);

                Button button = new Button();
                button.Location = new Point(OpenFileDialogButton.Location.X, OpenFileDialogButton.Location.Y + y);
                button.Size = new Size(33, 24);
                button.Text = "...";
                button.Tag = text.Name;
                button.Click += new EventHandler(OpenFileDialogButton_Click);
                this.Controls.Add(button);

                this.nextDialog.Location = new Point(22, 49 + y);
            }
            else
            {
                this.nextDialog.Controls.Remove(nextDialog);
                this.nextDialog.Dispose();
                MessageBox.Show("Bylo dosaženo maximální počtu přidaných souborů, nelze přidat více!");
            }

            y = y + 28;
            calculate++;
        }
    }
}
