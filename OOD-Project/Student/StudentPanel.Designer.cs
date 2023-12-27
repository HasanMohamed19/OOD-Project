namespace OOD_Project
{
    partial class StudentPanel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.viewCoursesBtn = new System.Windows.Forms.Button();
            this.viewEmailBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotificationBell = new System.Windows.Forms.Button();
            this.studentMainContent = new System.Windows.Forms.Panel();
            this.viewAnnouncementBtn = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.notificationPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.flowLayoutPanel1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.notificationPnl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1341, 89);
            this.panelHeader.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.viewCoursesBtn);
            this.flowLayoutPanel1.Controls.Add(this.viewEmailBtn);
            this.flowLayoutPanel1.Controls.Add(this.viewAnnouncementBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(171, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 8, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1087, 89);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // viewCoursesBtn
            // 
            this.viewCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewCoursesBtn.FlatAppearance.BorderSize = 0;
            this.viewCoursesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.viewCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoursesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewCoursesBtn.Location = new System.Drawing.Point(4, 19);
            this.viewCoursesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewCoursesBtn.Name = "viewCoursesBtn";
            this.viewCoursesBtn.Size = new System.Drawing.Size(144, 52);
            this.viewCoursesBtn.TabIndex = 6;
            this.viewCoursesBtn.Text = "View Courses";
            this.viewCoursesBtn.UseVisualStyleBackColor = false;
            this.viewCoursesBtn.Click += new System.EventHandler(this.viewCoursesBtn_Click);
            // 
            // viewEmailBtn
            // 
            this.viewEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewEmailBtn.FlatAppearance.BorderSize = 0;
            this.viewEmailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.viewEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmailBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewEmailBtn.Location = new System.Drawing.Point(156, 19);
            this.viewEmailBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewEmailBtn.Name = "viewEmailBtn";
            this.viewEmailBtn.Size = new System.Drawing.Size(155, 52);
            this.viewEmailBtn.TabIndex = 7;
            this.viewEmailBtn.Text = "View Emails";
            this.viewEmailBtn.UseVisualStyleBackColor = false;
            this.viewEmailBtn.Click += new System.EventHandler(this.viewEmailBtn_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "eLMS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notificationPnl
            // 
            this.notificationPnl.Controls.Add(this.button1);
            this.notificationPnl.Controls.Add(this.btnNotificationBell);
            this.notificationPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.notificationPnl.Location = new System.Drawing.Point(1258, 0);
            this.notificationPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notificationPnl.Name = "notificationPnl";
            this.notificationPnl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notificationPnl.Size = new System.Drawing.Size(83, 89);
            this.notificationPnl.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::OOD_Project.Properties.Resources.userIcon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNotificationBell
            // 
            this.btnNotificationBell.BackgroundImage = global::OOD_Project.Properties.Resources.bell_icon;
            this.btnNotificationBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotificationBell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotificationBell.FlatAppearance.BorderSize = 0;
            this.btnNotificationBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationBell.Location = new System.Drawing.Point(4, 4);
            this.btnNotificationBell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNotificationBell.Name = "btnNotificationBell";
            this.btnNotificationBell.Size = new System.Drawing.Size(75, 37);
            this.btnNotificationBell.TabIndex = 0;
            this.btnNotificationBell.UseVisualStyleBackColor = true;
            this.btnNotificationBell.Click += new System.EventHandler(this.btnNotificationBell_Click);
            // 
            // studentMainContent
            // 
            this.studentMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.studentMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentMainContent.Location = new System.Drawing.Point(0, 89);
            this.studentMainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentMainContent.Name = "studentMainContent";
            this.studentMainContent.Size = new System.Drawing.Size(1341, 641);
            this.studentMainContent.TabIndex = 3;
            // 
            // viewAnnouncementBtn
            // 
            this.viewAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.viewAnnouncementBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.viewAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAnnouncementBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewAnnouncementBtn.Location = new System.Drawing.Point(319, 19);
            this.viewAnnouncementBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewAnnouncementBtn.Name = "viewAnnouncementBtn";
            this.viewAnnouncementBtn.Size = new System.Drawing.Size(155, 52);
            this.viewAnnouncementBtn.TabIndex = 8;
            this.viewAnnouncementBtn.Text = "View Announcement";
            this.viewAnnouncementBtn.UseVisualStyleBackColor = false;
            this.viewAnnouncementBtn.Click += new System.EventHandler(this.viewAnnouncementBtn_Click);
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 730);
            this.Controls.Add(this.studentMainContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1359, 777);
            this.MinimumSize = new System.Drawing.Size(1359, 777);
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.panelHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.notificationPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel studentMainContent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button viewCoursesBtn;
        private System.Windows.Forms.Panel notificationPnl;
        private System.Windows.Forms.Button btnNotificationBell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewEmailBtn;
        private System.Windows.Forms.Button viewAnnouncementBtn;
    }
}