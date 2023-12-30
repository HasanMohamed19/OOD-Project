namespace OOD_Project
{
    partial class TeacherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanel));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.viewCoursesBtn = new System.Windows.Forms.Button();
            this.viewEmailsBtn = new System.Windows.Forms.Button();
            this.announcementsBtn = new System.Windows.Forms.Button();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPnl = new System.Windows.Forms.Panel();
            this.profileBar = new OOD_Project.ProfileBar();
            this.teacherMainContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.notificationPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.flowLayoutPanel1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.notificationPnl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1007, 72);
            this.panelHeader.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.viewCoursesBtn);
            this.flowLayoutPanel1.Controls.Add(this.viewEmailsBtn);
            this.flowLayoutPanel1.Controls.Add(this.announcementsBtn);
            this.flowLayoutPanel1.Controls.Add(this.sendEmailBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 12, 8, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 72);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // viewCoursesBtn
            // 
            this.viewCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewCoursesBtn.FlatAppearance.BorderSize = 0;
            this.viewCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCoursesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewCoursesBtn.Location = new System.Drawing.Point(3, 15);
            this.viewCoursesBtn.Name = "viewCoursesBtn";
            this.viewCoursesBtn.Size = new System.Drawing.Size(108, 42);
            this.viewCoursesBtn.TabIndex = 6;
            this.viewCoursesBtn.Text = "View Courses";
            this.viewCoursesBtn.UseVisualStyleBackColor = false;
            this.viewCoursesBtn.Click += new System.EventHandler(this.viewCoursesBtn_Click);
            // 
            // viewEmailsBtn
            // 
            this.viewEmailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewEmailsBtn.FlatAppearance.BorderSize = 0;
            this.viewEmailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmailsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewEmailsBtn.Location = new System.Drawing.Point(117, 15);
            this.viewEmailsBtn.Name = "viewEmailsBtn";
            this.viewEmailsBtn.Size = new System.Drawing.Size(108, 42);
            this.viewEmailsBtn.TabIndex = 5;
            this.viewEmailsBtn.Text = "View Emails";
            this.viewEmailsBtn.UseVisualStyleBackColor = false;
            this.viewEmailsBtn.Click += new System.EventHandler(this.viewEmailsBtn_Click);
            // 
            // announcementsBtn
            // 
            this.announcementsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.announcementsBtn.FlatAppearance.BorderSize = 0;
            this.announcementsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.announcementsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.announcementsBtn.Location = new System.Drawing.Point(231, 15);
            this.announcementsBtn.Name = "announcementsBtn";
            this.announcementsBtn.Size = new System.Drawing.Size(108, 42);
            this.announcementsBtn.TabIndex = 4;
            this.announcementsBtn.Text = "Announcements";
            this.announcementsBtn.UseVisualStyleBackColor = false;
            this.announcementsBtn.Click += new System.EventHandler(this.announcementsBtn_Click);
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.sendEmailBtn.FlatAppearance.BorderSize = 0;
            this.sendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendEmailBtn.Location = new System.Drawing.Point(345, 15);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(108, 42);
            this.sendEmailBtn.TabIndex = 7;
            this.sendEmailBtn.Text = "Send Email";
            this.sendEmailBtn.UseVisualStyleBackColor = false;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "eLMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notificationPnl
            // 
            this.notificationPnl.Controls.Add(this.profileBar);
            this.notificationPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.notificationPnl.Location = new System.Drawing.Point(807, 0);
            this.notificationPnl.Margin = new System.Windows.Forms.Padding(2);
            this.notificationPnl.Name = "notificationPnl";
            this.notificationPnl.Padding = new System.Windows.Forms.Padding(3);
            this.notificationPnl.Size = new System.Drawing.Size(200, 72);
            this.notificationPnl.TabIndex = 8;
            // 
            // profileBar
            // 
            this.profileBar.BackColor = System.Drawing.Color.Transparent;
            this.profileBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBar.Location = new System.Drawing.Point(3, 3);
            this.profileBar.LoggedInUser = null;
            this.profileBar.Margin = new System.Windows.Forms.Padding(4);
            this.profileBar.Name = "profileBar";
            this.profileBar.NotificationList = null;
            this.profileBar.ParentContainer = null;
            this.profileBar.Size = new System.Drawing.Size(194, 66);
            this.profileBar.TabIndex = 0;
            // 
            // teacherMainContent
            // 
            this.teacherMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.teacherMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherMainContent.Location = new System.Drawing.Point(0, 72);
            this.teacherMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.teacherMainContent.Name = "teacherMainContent";
            this.teacherMainContent.Size = new System.Drawing.Size(1007, 528);
            this.teacherMainContent.TabIndex = 4;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 600);
            this.Controls.Add(this.teacherMainContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1023, 639);
            this.MinimumSize = new System.Drawing.Size(1023, 639);
            this.Name = "TeacherPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Panel";
            this.panelHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.notificationPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button viewCoursesBtn;
        private System.Windows.Forms.Button viewEmailsBtn;
        private System.Windows.Forms.Button announcementsBtn;
        private System.Windows.Forms.Button sendEmailBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel teacherMainContent;
        private System.Windows.Forms.Panel notificationPnl;
        private ProfileBar profileBar;
    }
}