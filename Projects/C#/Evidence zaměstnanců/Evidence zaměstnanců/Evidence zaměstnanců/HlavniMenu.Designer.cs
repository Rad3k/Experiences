namespace Evidence_zaměstnanců
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.zamMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addZam = new System.Windows.Forms.ToolStripMenuItem();
            this.zamSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.delZam = new System.Windows.Forms.ToolStripMenuItem();
            this.zamSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.controlZam = new System.Windows.Forms.ToolStripMenuItem();
            this.zamSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.smlouvyZam = new System.Windows.Forms.ToolStripMenuItem();
            this.zamSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.problemZam = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenceCVs = new System.Windows.Forms.ToolStripMenuItem();
            this.addCVs = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorCVs1 = new System.Windows.Forms.ToolStripSeparator();
            this.editCVs = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorCVs2 = new System.Windows.Forms.ToolStripSeparator();
            this.delCVs = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.programPanel = new System.Windows.Forms.MenuStrip();
            this.navigačníPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.napovedaProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.repozitaryLink = new System.Windows.Forms.ToolStripMenuItem();
            this.technickSupportLink = new System.Windows.Forms.ToolStripMenuItem();
            this.infoProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDB = new System.Windows.Forms.ToolStripComboBox();
            this.MainMenu.SuspendLayout();
            this.programPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamMenu,
            this.evidenceCVs,
            this.statisticsMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 29);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(126, 413);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "HlavniMenu";
            // 
            // zamMenu
            // 
            this.zamMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addZam,
            this.zamSeparator1,
            this.delZam,
            this.zamSeparator2,
            this.controlZam,
            this.zamSeparator3,
            this.smlouvyZam,
            this.zamSeparator4,
            this.problemZam});
            this.zamMenu.Name = "zamMenu";
            this.zamMenu.Size = new System.Drawing.Size(119, 19);
            this.zamMenu.Text = "Zaměstnanci";
            this.zamMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zamMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // addZam
            // 
            this.addZam.Name = "addZam";
            this.addZam.Size = new System.Drawing.Size(207, 22);
            this.addZam.Text = "Založení zaměstnance";
            this.addZam.Click += new System.EventHandler(this.addZam_Click);
            // 
            // zamSeparator1
            // 
            this.zamSeparator1.Name = "zamSeparator1";
            this.zamSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // delZam
            // 
            this.delZam.Name = "delZam";
            this.delZam.Size = new System.Drawing.Size(207, 22);
            this.delZam.Text = "Odstranění zaměstnance";
            this.delZam.Click += new System.EventHandler(this.delZam_Click);
            // 
            // zamSeparator2
            // 
            this.zamSeparator2.Name = "zamSeparator2";
            this.zamSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // controlZam
            // 
            this.controlZam.Name = "controlZam";
            this.controlZam.Size = new System.Drawing.Size(207, 22);
            this.controlZam.Text = "Controla zaměstnanců";
            this.controlZam.Click += new System.EventHandler(this.controlZam_Click);
            // 
            // zamSeparator3
            // 
            this.zamSeparator3.Name = "zamSeparator3";
            this.zamSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // smlouvyZam
            // 
            this.smlouvyZam.Name = "smlouvyZam";
            this.smlouvyZam.Size = new System.Drawing.Size(207, 22);
            this.smlouvyZam.Text = "Ukončené smlouvy";
            this.smlouvyZam.Click += new System.EventHandler(this.smlouvyZam_Click);
            // 
            // zamSeparator4
            // 
            this.zamSeparator4.Name = "zamSeparator4";
            this.zamSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // problemZam
            // 
            this.problemZam.Name = "problemZam";
            this.problemZam.Size = new System.Drawing.Size(207, 22);
            this.problemZam.Text = "Problémový zaměstnanci";
            this.problemZam.Click += new System.EventHandler(this.problemZam_Click);
            // 
            // evidenceCVs
            // 
            this.evidenceCVs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCVs,
            this.separatorCVs1,
            this.editCVs,
            this.separatorCVs2,
            this.delCVs});
            this.evidenceCVs.Name = "evidenceCVs";
            this.evidenceCVs.Size = new System.Drawing.Size(119, 19);
            this.evidenceCVs.Text = "Evidence životopisů";
            // 
            // addCVs
            // 
            this.addCVs.Name = "addCVs";
            this.addCVs.Size = new System.Drawing.Size(173, 22);
            this.addCVs.Text = "Přidat životopis";
            this.addCVs.Click += new System.EventHandler(this.addCVs_Click);
            // 
            // separatorCVs1
            // 
            this.separatorCVs1.Name = "separatorCVs1";
            this.separatorCVs1.Size = new System.Drawing.Size(170, 6);
            // 
            // editCVs
            // 
            this.editCVs.Name = "editCVs";
            this.editCVs.Size = new System.Drawing.Size(173, 22);
            this.editCVs.Text = "Upravit životopis";
            this.editCVs.Click += new System.EventHandler(this.editCVs_Click);
            // 
            // separatorCVs2
            // 
            this.separatorCVs2.Name = "separatorCVs2";
            this.separatorCVs2.Size = new System.Drawing.Size(170, 6);
            // 
            // delCVs
            // 
            this.delCVs.Name = "delCVs";
            this.delCVs.Size = new System.Drawing.Size(173, 22);
            this.delCVs.Text = "Odstranit životopis";
            this.delCVs.Click += new System.EventHandler(this.delCVs_Click);
            // 
            // statisticsMenu
            // 
            this.statisticsMenu.Name = "statisticsMenu";
            this.statisticsMenu.Size = new System.Drawing.Size(119, 19);
            this.statisticsMenu.Text = "Statistika";
            this.statisticsMenu.Click += new System.EventHandler(this.statisticsMenu_Click);
            // 
            // programPanel
            // 
            this.programPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.programPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigačníPanelToolStripMenuItem,
            this.websiteItem,
            this.napovedaProgram,
            this.infoProgram,
            this.selectDB});
            this.programPanel.Location = new System.Drawing.Point(0, 0);
            this.programPanel.Name = "programPanel";
            this.programPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.programPanel.Size = new System.Drawing.Size(704, 29);
            this.programPanel.TabIndex = 1;
            this.programPanel.Text = "programPanel";
            // 
            // navigačníPanelToolStripMenuItem
            // 
            this.navigačníPanelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.navigačníPanelToolStripMenuItem.Name = "navigačníPanelToolStripMenuItem";
            this.navigačníPanelToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.navigačníPanelToolStripMenuItem.Text = "Navigační Panel";
            // 
            // websiteItem
            // 
            this.websiteItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.websiteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.websiteItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.websiteItem.Name = "websiteItem";
            this.websiteItem.Size = new System.Drawing.Size(119, 25);
            this.websiteItem.Text = "Webové stránky";
            this.websiteItem.Click += new System.EventHandler(this.websiteItem_Click);
            // 
            // napovedaProgram
            // 
            this.napovedaProgram.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.napovedaProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repozitaryLink,
            this.technickSupportLink});
            this.napovedaProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napovedaProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.napovedaProgram.Name = "napovedaProgram";
            this.napovedaProgram.Size = new System.Drawing.Size(82, 25);
            this.napovedaProgram.Text = "Nápověda";
            // 
            // repozitaryLink
            // 
            this.repozitaryLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repozitaryLink.Name = "repozitaryLink";
            this.repozitaryLink.Size = new System.Drawing.Size(177, 22);
            this.repozitaryLink.Text = "Repozitář";
            this.repozitaryLink.Click += new System.EventHandler(this.repozitaryLink_Click);
            // 
            // technickSupportLink
            // 
            this.technickSupportLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.technickSupportLink.Name = "technickSupportLink";
            this.technickSupportLink.Size = new System.Drawing.Size(177, 22);
            this.technickSupportLink.Text = "Technická podpora";
            this.technickSupportLink.Click += new System.EventHandler(this.technickSupportLink_Click);
            // 
            // infoProgram
            // 
            this.infoProgram.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoProgram.Name = "infoProgram";
            this.infoProgram.Size = new System.Drawing.Size(159, 25);
            this.infoProgram.Text = "Informace o programu";
            this.infoProgram.Click += new System.EventHandler(this.infoProgram_Click);
            // 
            // selectDB
            // 
            this.selectDB.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.selectDB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectDB.BackColor = System.Drawing.SystemColors.InfoText;
            this.selectDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectDB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selectDB.Name = "selectDB";
            this.selectDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectDB.Size = new System.Drawing.Size(121, 25);
            this.selectDB.Click += new System.EventHandler(this.selectDB_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.programPanel);
            this.Name = "Main";
            this.Text = "Hlavní menu";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.programPanel.ResumeLayout(false);
            this.programPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.MenuStrip programPanel;
        private System.Windows.Forms.ToolStripMenuItem navigačníPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoProgram;
        private System.Windows.Forms.ToolStripMenuItem napovedaProgram;
        private System.Windows.Forms.ToolStripMenuItem zamMenu;
        private System.Windows.Forms.ToolStripMenuItem addZam;
        private System.Windows.Forms.ToolStripSeparator zamSeparator1;
        private System.Windows.Forms.ToolStripMenuItem delZam;
        private System.Windows.Forms.ToolStripSeparator zamSeparator2;
        private System.Windows.Forms.ToolStripMenuItem controlZam;
        private System.Windows.Forms.ToolStripSeparator zamSeparator3;
        private System.Windows.Forms.ToolStripMenuItem smlouvyZam;
        private System.Windows.Forms.ToolStripSeparator zamSeparator4;
        private System.Windows.Forms.ToolStripMenuItem problemZam;
        private System.Windows.Forms.ToolStripMenuItem websiteItem;
        private System.Windows.Forms.ToolStripComboBox selectDB;
        private System.Windows.Forms.ToolStripMenuItem evidenceCVs;
        private System.Windows.Forms.ToolStripMenuItem addCVs;
        private System.Windows.Forms.ToolStripMenuItem editCVs;
        private System.Windows.Forms.ToolStripMenuItem delCVs;
        private System.Windows.Forms.ToolStripMenuItem repozitaryLink;
        private System.Windows.Forms.ToolStripMenuItem technickSupportLink;
        private System.Windows.Forms.ToolStripSeparator separatorCVs1;
        private System.Windows.Forms.ToolStripSeparator separatorCVs2;
        private System.Windows.Forms.ToolStripMenuItem statisticsMenu;
    }
}

