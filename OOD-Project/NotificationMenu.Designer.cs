namespace OOD_Project
{
    partial class NotificationMenu
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUnread = new System.Windows.Forms.Label();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.panelNotifications = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.lblUnread);
            this.panelHeader.Controls.Add(this.lblNotifications);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(224, 35);
            this.panelHeader.TabIndex = 0;
            // 
            // lblUnread
            // 
            this.lblUnread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnread.AutoSize = true;
            this.lblUnread.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnread.Location = new System.Drawing.Point(151, 9);
            this.lblUnread.Name = "lblUnread";
            this.lblUnread.Size = new System.Drawing.Size(61, 17);
            this.lblUnread.TabIndex = 1;
            this.lblUnread.Text = "2 Unread";
            this.lblUnread.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.Location = new System.Drawing.Point(12, 9);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(88, 16);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications";
            // 
            // panelNotifications
            // 
            this.panelNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotifications.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelNotifications.Location = new System.Drawing.Point(0, 35);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Size = new System.Drawing.Size(224, 365);
            this.panelNotifications.TabIndex = 1;
            // 
            // NotificationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(224, 400);
            this.Controls.Add(this.panelNotifications);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationMenu";
            this.Deactivate += new System.EventHandler(this.NotificationMenu_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotificationMenu_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FlowLayoutPanel panelNotifications;
        private System.Windows.Forms.Label lblUnread;
        private System.Windows.Forms.Label lblNotifications;
    }
}