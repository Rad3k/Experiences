namespace Predfakturace
{
    partial class ControlFile
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
            this.filePathText = new System.Windows.Forms.TextBox();
            this.OpenFileDialogButton = new System.Windows.Forms.Button();
            this.nextDialog = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.nextStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePathText
            // 
            this.filePathText.Location = new System.Drawing.Point(22, 23);
            this.filePathText.Name = "filePathText";
            this.filePathText.ReadOnly = true;
            this.filePathText.Size = new System.Drawing.Size(194, 20);
            this.filePathText.TabIndex = 0;
            // 
            // OpenFileDialogButton
            // 
            this.OpenFileDialogButton.Location = new System.Drawing.Point(222, 20);
            this.OpenFileDialogButton.Name = "OpenFileDialogButton";
            this.OpenFileDialogButton.Size = new System.Drawing.Size(33, 24);
            this.OpenFileDialogButton.TabIndex = 1;
            this.OpenFileDialogButton.Text = "...";
            this.OpenFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenFileDialogButton.Click += new System.EventHandler(this.OpenFileDialogButton_Click);
            // 
            // nextDialog
            // 
            this.nextDialog.Location = new System.Drawing.Point(22, 49);
            this.nextDialog.Name = "nextDialog";
            this.nextDialog.Size = new System.Drawing.Size(75, 23);
            this.nextDialog.TabIndex = 2;
            this.nextDialog.Text = "Přidat";
            this.nextDialog.UseVisualStyleBackColor = true;
            this.nextDialog.Click += new System.EventHandler(this.nextDialog_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(22, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // nextStep
            // 
            this.nextStep.Location = new System.Drawing.Point(180, 323);
            this.nextStep.Name = "nextStep";
            this.nextStep.Size = new System.Drawing.Size(75, 23);
            this.nextStep.TabIndex = 4;
            this.nextStep.Text = "Pokračovat";
            this.nextStep.UseVisualStyleBackColor = true;
            this.nextStep.Click += new System.EventHandler(this.nextStep_Click);
            // 
            // ControlFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 358);
            this.Controls.Add(this.nextStep);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.nextDialog);
            this.Controls.Add(this.OpenFileDialogButton);
            this.Controls.Add(this.filePathText);
            this.Name = "ControlFile";
            this.Text = "Vkládání předfakturací";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathText;
        private System.Windows.Forms.Button OpenFileDialogButton;
        private System.Windows.Forms.Button nextDialog;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button nextStep;
    }
}