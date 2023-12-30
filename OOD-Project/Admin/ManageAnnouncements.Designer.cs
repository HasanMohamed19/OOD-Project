namespace OOD_Project.Admin
{
    partial class ManageAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAnnouncements));
            this.manageAnnouncementsTab = new System.Windows.Forms.TabControl();
            this.ViewAnnouncementTab = new System.Windows.Forms.TabPage();
            this.sendAnnouncementTab = new System.Windows.Forms.TabPage();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.manageAnnouncementsTab.SuspendLayout();
            this.ViewAnnouncementTab.SuspendLayout();
            this.sendAnnouncementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // manageAnnouncementsTab
            // 
            this.manageAnnouncementsTab.Controls.Add(this.ViewAnnouncementTab);
            this.manageAnnouncementsTab.Controls.Add(this.sendAnnouncementTab);
            this.manageAnnouncementsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageAnnouncementsTab.Location = new System.Drawing.Point(0, 0);
            this.manageAnnouncementsTab.Name = "manageAnnouncementsTab";
            this.manageAnnouncementsTab.SelectedIndex = 0;
            this.manageAnnouncementsTab.Size = new System.Drawing.Size(910, 550);
            this.manageAnnouncementsTab.TabIndex = 0;
            this.manageAnnouncementsTab.SelectedIndexChanged += new System.EventHandler(this.manageAnnouncementsTab_SelectedIndexChanged);
            // 
            // ViewAnnouncementTab
            // 
            this.ViewAnnouncementTab.Controls.Add(this.viewPanel);
            this.ViewAnnouncementTab.Location = new System.Drawing.Point(4, 25);
            this.ViewAnnouncementTab.Name = "ViewAnnouncementTab";
            this.ViewAnnouncementTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewAnnouncementTab.Size = new System.Drawing.Size(902, 521);
            this.ViewAnnouncementTab.TabIndex = 0;
            this.ViewAnnouncementTab.Text = "View Announcements";
            this.ViewAnnouncementTab.UseVisualStyleBackColor = true;
            // 
            // sendAnnouncementTab
            // 
            this.sendAnnouncementTab.Controls.Add(this.sendPanel);
            this.sendAnnouncementTab.Location = new System.Drawing.Point(4, 25);
            this.sendAnnouncementTab.Name = "sendAnnouncementTab";
            this.sendAnnouncementTab.Padding = new System.Windows.Forms.Padding(3);
            this.sendAnnouncementTab.Size = new System.Drawing.Size(902, 521);
            this.sendAnnouncementTab.TabIndex = 1;
            this.sendAnnouncementTab.Text = "Send Announcements";
            this.sendAnnouncementTab.UseVisualStyleBackColor = true;
            // 
            // viewPanel
            // 
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(3, 3);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(896, 515);
            this.viewPanel.TabIndex = 0;
            // 
            // sendPanel
            // 
            this.sendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendPanel.Location = new System.Drawing.Point(3, 3);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(896, 515);
            this.sendPanel.TabIndex = 0;
            // 
            // ManageAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 550);
            this.Controls.Add(this.manageAnnouncementsTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAnnouncements";
            this.Text = "ManageAnnouncements";
            this.manageAnnouncementsTab.ResumeLayout(false);
            this.ViewAnnouncementTab.ResumeLayout(false);
            this.sendAnnouncementTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl manageAnnouncementsTab;
        private System.Windows.Forms.TabPage ViewAnnouncementTab;
        private System.Windows.Forms.TabPage sendAnnouncementTab;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Panel sendPanel;
    }
}