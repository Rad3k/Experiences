namespace Predfakturace
{
    partial class menu
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
            this.pojNext = new System.Windows.Forms.Button();
            this.spoNext = new System.Windows.Forms.Button();
            this.csobNext = new System.Windows.Forms.Button();
            this.pojistovny = new System.Windows.Forms.Label();
            this.sporitelny = new System.Windows.Forms.Label();
            this.csob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pojNext
            // 
            this.pojNext.Location = new System.Drawing.Point(174, 38);
            this.pojNext.Name = "pojNext";
            this.pojNext.Size = new System.Drawing.Size(141, 32);
            this.pojNext.TabIndex = 0;
            this.pojNext.Text = "Pokračovat";
            this.pojNext.UseVisualStyleBackColor = true;
            this.pojNext.Click += new System.EventHandler(this.pojNext_Click);
            // 
            // spoNext
            // 
            this.spoNext.Location = new System.Drawing.Point(174, 87);
            this.spoNext.Name = "spoNext";
            this.spoNext.Size = new System.Drawing.Size(141, 32);
            this.spoNext.TabIndex = 1;
            this.spoNext.Text = "Pokračovat";
            this.spoNext.UseVisualStyleBackColor = true;
            this.spoNext.Click += new System.EventHandler(this.spoNext_Click);
            // 
            // csobNext
            // 
            this.csobNext.Location = new System.Drawing.Point(174, 135);
            this.csobNext.Name = "csobNext";
            this.csobNext.Size = new System.Drawing.Size(141, 32);
            this.csobNext.TabIndex = 2;
            this.csobNext.Text = "Pokračovat";
            this.csobNext.UseVisualStyleBackColor = true;
            this.csobNext.Click += new System.EventHandler(this.csobNext_Click);
            // 
            // pojistovny
            // 
            this.pojistovny.AutoSize = true;
            this.pojistovny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pojistovny.Location = new System.Drawing.Point(35, 40);
            this.pojistovny.Name = "pojistovny";
            this.pojistovny.Size = new System.Drawing.Size(113, 24);
            this.pojistovny.TabIndex = 3;
            this.pojistovny.Text = "Pojišťovny:";
            // 
            // sporitelny
            // 
            this.sporitelny.AutoSize = true;
            this.sporitelny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sporitelny.Location = new System.Drawing.Point(35, 89);
            this.sporitelny.Name = "sporitelny";
            this.sporitelny.Size = new System.Drawing.Size(110, 24);
            this.sporitelny.TabIndex = 4;
            this.sporitelny.Text = "Spořitelny:";
            // 
            // csob
            // 
            this.csob.AutoSize = true;
            this.csob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.csob.Location = new System.Drawing.Point(35, 137);
            this.csob.Name = "csob";
            this.csob.Size = new System.Drawing.Size(72, 24);
            this.csob.TabIndex = 5;
            this.csob.Text = "ČSOB:";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 198);
            this.Controls.Add(this.csob);
            this.Controls.Add(this.sporitelny);
            this.Controls.Add(this.pojistovny);
            this.Controls.Add(this.csobNext);
            this.Controls.Add(this.spoNext);
            this.Controls.Add(this.pojNext);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hlavní menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pojNext;
        private System.Windows.Forms.Button spoNext;
        private System.Windows.Forms.Button csobNext;
        private System.Windows.Forms.Label pojistovny;
        private System.Windows.Forms.Label sporitelny;
        private System.Windows.Forms.Label csob;
    }
}

