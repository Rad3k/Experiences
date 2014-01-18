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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Links link = new Links();
            link.forgetPassword();
        }

        private void forgetUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
        }
        
        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Login_on));
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Login));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Links link = new Links();
            link.Register();
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Register_on));
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Register));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cancel_on));
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Cancel));
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

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close_on));
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void maximizedButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void maximizedButton_MouseEnter(object sender, EventArgs e)
        {
            this.maximizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.max_on));
        }

        private void maximizedButton_MouseLeave(object sender, EventArgs e)
        {
            this.maximizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.max));
        }

        private void minimalizedButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimalizedButton_MouseEnter(object sender, EventArgs e)
        {
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min_on));
        }

        private void minimalizedButton_MouseLeave(object sender, EventArgs e)
        {
            this.minimalizedButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.min));
        }
    }
}
