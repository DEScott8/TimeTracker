namespace TimeTrackerBeta
{
    partial class AboutForm
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
            this.VersionInfo = new System.Windows.Forms.Label();
            this.DeveloperInfo = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.LinkLabel();
            this.DanielsProjects = new System.Windows.Forms.LinkLabel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LinkedIn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // VersionInfo
            // 
            this.VersionInfo.AutoSize = true;
            this.VersionInfo.Location = new System.Drawing.Point(13, 16);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(48, 13);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.Text = "Build 1.1";
            // 
            // DeveloperInfo
            // 
            this.DeveloperInfo.AutoSize = true;
            this.DeveloperInfo.Location = new System.Drawing.Point(13, 40);
            this.DeveloperInfo.Name = "DeveloperInfo";
            this.DeveloperInfo.Size = new System.Drawing.Size(251, 13);
            this.DeveloperInfo.TabIndex = 1;
            this.DeveloperInfo.Text = "Developed by Daniel Scott on December 1st, 2024.";
            // 
            // GitHub
            // 
            this.GitHub.AutoSize = true;
            this.GitHub.Location = new System.Drawing.Point(13, 62);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(110, 13);
            this.GitHub.TabIndex = 2;
            this.GitHub.TabStop = true;
            this.GitHub.Text = "github.com/DEScott8";
            this.GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LinkClicked);
            // 
            // DanielsProjects
            // 
            this.DanielsProjects.AutoSize = true;
            this.DanielsProjects.Location = new System.Drawing.Point(13, 86);
            this.DanielsProjects.Name = "DanielsProjects";
            this.DanielsProjects.Size = new System.Drawing.Size(122, 13);
            this.DanielsProjects.TabIndex = 3;
            this.DanielsProjects.TabStop = true;
            this.DanielsProjects.Text = "www.danielsprojects.net";
            this.DanielsProjects.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DanielsProjects_LinkClicked);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(73, 140);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(110, 38);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Okay, enough of this shameless plug.";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LinkedIn
            // 
            this.LinkedIn.AutoSize = true;
            this.LinkedIn.Location = new System.Drawing.Point(16, 114);
            this.LinkedIn.Name = "LinkedIn";
            this.LinkedIn.Size = new System.Drawing.Size(257, 13);
            this.LinkedIn.TabIndex = 5;
            this.LinkedIn.TabStop = true;
            this.LinkedIn.Text = "https://www.linkedin.com/in/daniel-scott-b65484b8/";
            this.LinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkedIn_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 199);
            this.Controls.Add(this.LinkedIn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DanielsProjects);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.DeveloperInfo);
            this.Controls.Add(this.VersionInfo);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionInfo;
        private System.Windows.Forms.Label DeveloperInfo;
        private System.Windows.Forms.LinkLabel GitHub;
        private System.Windows.Forms.LinkLabel DanielsProjects;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.LinkLabel LinkedIn;
    }
}