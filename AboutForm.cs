using System;
using System.Windows.Forms;

namespace TimeTrackerBeta
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        private void GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GitHub.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/DEScott8");
        }
        private void DanielsProjects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DanielsProjects.LinkVisited = true;
            System.Diagnostics.Process.Start("http://danielsprojects.net/myprojects.html");
        }

        private void LinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkedIn.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/daniel-scott-b65484b8/");
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
