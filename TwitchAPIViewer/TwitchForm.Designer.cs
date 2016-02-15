namespace TwitchAPIViewer
{
    partial class TwitchForm
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
            this.lblViewers = new System.Windows.Forms.Label();
            this.lblFollowers = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblViewers
            // 
            this.lblViewers.AutoSize = true;
            this.lblViewers.Location = new System.Drawing.Point(12, 9);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(68, 13);
            this.lblViewers.TabIndex = 0;
            this.lblViewers.Text = "Viewers: 000";
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.Location = new System.Drawing.Point(95, 9);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(75, 13);
            this.lblFollowers.TabIndex = 1;
            this.lblFollowers.Text = "Followers: 000";
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Location = new System.Drawing.Point(185, 9);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(59, 13);
            this.lblViews.TabIndex = 2;
            this.lblViews.Text = "Views: 000";
            // 
            // TwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 32);
            this.Controls.Add(this.lblViews);
            this.Controls.Add(this.lblFollowers);
            this.Controls.Add(this.lblViewers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TwitchForm";
            this.Opacity = 0.8D;
            this.Text = "TwitchViewer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwitchForm_FormClosing);
            this.Load += new System.EventHandler(this.TwitchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.Label lblFollowers;
        private System.Windows.Forms.Label lblViews;
    }
}

