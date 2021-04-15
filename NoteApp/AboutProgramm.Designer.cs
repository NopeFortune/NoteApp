
namespace NoteApp
{
    partial class AboutProgramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramm));
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbGit = new System.Windows.Forms.Label();
            this.lbGitLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAbout.Location = new System.Drawing.Point(12, 9);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(508, 17);
            this.lbAbout.TabIndex = 0;
            this.lbAbout.Text = "Программа была написана в качестве практики пользователем с ником \"NopeFortune\"";
            // 
            // lbGit
            // 
            this.lbGit.AutoSize = true;
            this.lbGit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGit.Location = new System.Drawing.Point(12, 70);
            this.lbGit.Name = "lbGit";
            this.lbGit.Size = new System.Drawing.Size(171, 17);
            this.lbGit.TabIndex = 1;
            this.lbGit.Text = "Ссылка на Git (кликабельно):";
            // 
            // lbGitLink
            // 
            this.lbGitLink.AutoSize = true;
            this.lbGitLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGitLink.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGitLink.ForeColor = System.Drawing.Color.Blue;
            this.lbGitLink.Location = new System.Drawing.Point(233, 70);
            this.lbGitLink.Name = "lbGitLink";
            this.lbGitLink.Size = new System.Drawing.Size(289, 17);
            this.lbGitLink.TabIndex = 2;
            this.lbGitLink.Text = "https://github.com/NopeFortune?tab=repositories";
            this.lbGitLink.Click += new System.EventHandler(this.lbGitLink_Click);
            // 
            // AboutProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 128);
            this.Controls.Add(this.lbGitLink);
            this.Controls.Add(this.lbGit);
            this.Controls.Add(this.lbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AboutProgramm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutProgramm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbGit;
        private System.Windows.Forms.Label lbGitLink;
    }
}