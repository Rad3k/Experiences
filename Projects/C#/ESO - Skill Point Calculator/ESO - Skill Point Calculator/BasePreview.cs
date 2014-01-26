using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using WMPLib;

namespace ESO___Skill_Point_Calculator
{
    public partial class BasePreview : Form
    {
        Collection collection = new Collection();
        Controller control = new Controller();

        public BasePreview()
        {
            InitializeComponent();
            this.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));
            collection.BackroundPlayerStart(new WindowsMediaPlayer());
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                uploadFileText.Text = souborFilename;

                if (control.ControllFile(uploadFileText.Text))
                    imageCorrectly.Visible = true;
                else
                    fileBad.Visible = true;

                imageFile.Visible = true;
                uploadFileText.Visible = true;
            }
        }

        private void CheckAllButtons_MouseEnter(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor_hand));

            switch (name)
            {
                case "createButton":
                    this.createButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.create_on));
                    break;
                case "uploadButton":
                    this.uploadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upload_on));
                    break;
                case "myWebsiteButton":
                    this.myWebsiteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rad3k_logo_on));
                    break;
                case "cancelButton":
                    this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel_on1));
                    break;
                case "InterestButton":
                    this.InterestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.teso_cz_logo_on));
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
            }
        }

        private void CheckAllButtons_MouseLeave(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            var name = currentButton.Name;
            currentButton.Cursor = NativeMethods.LoadCustomCursor(Path.Combine(collection.source, collection.cursor));

            switch (name)
            {
                case "createButton":
                    this.createButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.create));
                    break;
                case "uploadButton":
                    this.uploadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upload));
                    break;
                case "myWebsiteButton":
                    this.myWebsiteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rad3k_logo));
                    break;
                case "cancelButton":
                    this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel1));
                    break;
                case "InterestButton":
                    this.InterestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.teso_cz_logo));
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
            }
        }

        private void InterestButton_Click(object sender, EventArgs e)
        {
            Links link = new Links();
            link.interestWebSite();
        }

        private void myWebsiteButton_Click(object sender, EventArgs e)
        {
            Links link = new Links();
            link.myWebSite();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximizedButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void minimalizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            switch (collection.value)
            {
                case 0:
                    collection.BackroundPlayerClose(new WindowsMediaPlayer());
                    collection.value++;
                    break;
                case 1:
                    collection.BackroundPlayerStart(new WindowsMediaPlayer());
                    collection.value = 0;
                    break;
            }
        }
    }
}
