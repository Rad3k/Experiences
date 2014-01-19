using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ESO___Skill_Point_Calculator
{
    public partial class BasePreview : Form
    {
        public string heslo;

        public BasePreview()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string souborFilename = openFileDialog1.FileName;
                uploadFileText.Text = souborFilename;
            }

            imageCorrectly.Visible = true;
            imageFile.Visible = true;
            uploadFileText.Visible = true;
        }

        private void uploadButton_MouseEnter(object sender, EventArgs e)
        {
            this.uploadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upload_on));
        }

        private void uploadButton_MouseLeave(object sender, EventArgs e)
        {
            this.uploadButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.upload));
        }

        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            this.createButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.create_on));
        }

        private void createButton_MouseLeave(object sender, EventArgs e)
        {
            this.createButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.create));
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel_on1));
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cancel1));
        }

        private void InterestButton_Click(object sender, EventArgs e)
        {
            Links link = new Links();
            link.interestWebSite();
        }

        private void InterestButton_MouseEnter(object sender, EventArgs e)
        {
            this.InterestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.teso_cz_logo_on));
        }

        private void InterestButton_MouseLeave(object sender, EventArgs e)
        {
            this.InterestButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.teso_cz_logo));
        }

        private void myWebsiteButton_Click(object sender, EventArgs e)
        {
            Links link = new Links();
            link.myWebSite();
        }

        private void myWebsiteButton_MouseEnter(object sender, EventArgs e)
        {
            this.myWebsiteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rad3k_logo_on));
        }

        private void myWebsiteButton_MouseLeave(object sender, EventArgs e)
        {
            this.myWebsiteButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rad3k_logo));
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent_on));
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_transparent));
        }

        private void maximizedButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void maximizedButton_MouseEnter(object sender, EventArgs e)
        {
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent_on));
        }

        private void maximizedButton_MouseLeave(object sender, EventArgs e)
        {
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.about_transparent));
        }

        private void minimalizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimalizedButton_MouseEnter(object sender, EventArgs e)
        {
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent_on));
        }

        private void minimalizedButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_transparent));
        }
    }
}
