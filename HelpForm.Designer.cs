namespace TimeTrackerBeta
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.INeedInstructions = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INeedInstructions
            // 
            this.INeedInstructions.Location = new System.Drawing.Point(13, 13);
            this.INeedInstructions.Name = "INeedInstructions";
            this.INeedInstructions.Size = new System.Drawing.Size(302, 94);
            this.INeedInstructions.TabIndex = 0;
            this.INeedInstructions.Text = resources.GetString("INeedInstructions.Text");
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(92, 91);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 40);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "I\'M GONNA WRECK IT!";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 145);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.INeedInstructions);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label INeedInstructions;
        private System.Windows.Forms.Button CloseButton;
    }
}