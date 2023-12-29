namespace OOD_Project
{
    partial class AdminPanel
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
            this.manageBranchesBtn = new System.Windows.Forms.Button();
            this.manageInformationBtn = new System.Windows.Forms.Button();
            this.manageUsersBtn = new System.Windows.Forms.Button();
            this.manageCoursesBtn = new System.Windows.Forms.Button();
            this.btnAddAnouncement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationPnl = new System.Windows.Forms.Panel();
            this.adminMainContent = new System.Windows.Forms.Panel();
            this.viewEmailsBtn = new System.Windows.Forms.Button();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.profileBar = new OOD_Project.ProfileBar();
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
            this.panelHeader.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.manageBranchesBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageInformationBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageUsersBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageCoursesBtn);
            this.flowLayoutPanel1.Controls.Add(this.btnAddAnouncement);
            this.flowLayoutPanel1.Controls.Add(this.viewEmailsBtn);
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
            // manageBranchesBtn
            // 
            this.manageBranchesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.manageBranchesBtn.FlatAppearance.BorderSize = 0;
            this.manageBranchesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBranchesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBranchesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageBranchesBtn.Location = new System.Drawing.Point(4, 19);
            this.manageBranchesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manageBranchesBtn.Name = "manageBranchesBtn";
            this.manageBranchesBtn.Size = new System.Drawing.Size(108, 42);
            this.manageBranchesBtn.TabIndex = 6;
            this.manageBranchesBtn.Text = "Manage Branches";
            this.manageBranchesBtn.UseVisualStyleBackColor = false;
            this.manageBranchesBtn.Click += new System.EventHandler(this.manageBranchesBtn_Click);
            // 
            // manageInformationBtn
            // 
            this.manageInformationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.manageInformationBtn.FlatAppearance.BorderSize = 0;
            this.manageInformationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageInformationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageInformationBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageInformationBtn.Location = new System.Drawing.Point(156, 19);
            this.manageInformationBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manageInformationBtn.Name = "manageInformationBtn";
            this.manageInformationBtn.Size = new System.Drawing.Size(108, 42);
            this.manageInformationBtn.TabIndex = 5;
            this.manageInformationBtn.Text = "Upload Information";
            this.manageInformationBtn.UseVisualStyleBackColor = false;
            this.manageInformationBtn.Click += new System.EventHandler(this.manageInformationBtn_Click);
            // 
            // manageUsersBtn
            // 
            this.manageUsersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.manageUsersBtn.FlatAppearance.BorderSize = 0;
            this.manageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageUsersBtn.Location = new System.Drawing.Point(308, 19);
            this.manageUsersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manageUsersBtn.Name = "manageUsersBtn";
            this.manageUsersBtn.Size = new System.Drawing.Size(108, 42);
            this.manageUsersBtn.TabIndex = 4;
            this.manageUsersBtn.Text = "Manage Users";
            this.manageUsersBtn.UseVisualStyleBackColor = false;
            this.manageUsersBtn.Click += new System.EventHandler(this.manageUsersBtn_Click);
            // 
            // manageCoursesBtn
            // 
            this.manageCoursesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.manageCoursesBtn.FlatAppearance.BorderSize = 0;
            this.manageCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCoursesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageCoursesBtn.Location = new System.Drawing.Point(460, 19);
            this.manageCoursesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.manageCoursesBtn.Name = "manageCoursesBtn";
            this.manageCoursesBtn.Size = new System.Drawing.Size(108, 42);
            this.manageCoursesBtn.TabIndex = 7;
            this.manageCoursesBtn.Text = "Manage Courses";
            this.manageCoursesBtn.UseVisualStyleBackColor = false;
            this.manageCoursesBtn.Click += new System.EventHandler(this.manageCoursesBtn_Click_1);
            // 
            // btnAddAnouncement
            // 
            this.btnAddAnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnAddAnouncement.FlatAppearance.BorderSize = 0;
            this.btnAddAnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnouncement.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAnouncement.Location = new System.Drawing.Point(612, 19);
            this.btnAddAnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnouncement.Name = "btnAddAnouncement";
            this.btnAddAnouncement.Size = new System.Drawing.Size(144, 52);
            this.btnAddAnouncement.TabIndex = 8;
            this.btnAddAnouncement.Text = "Manage Announcement";
            this.btnAddAnouncement.UseVisualStyleBackColor = false;
            this.btnAddAnouncement.Click += new System.EventHandler(this.btnAddAnouncement_Click);
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
            this.notificationPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationPnl.Name = "notificationPnl";
            this.notificationPnl.Padding = new System.Windows.Forms.Padding(4);
            this.notificationPnl.Size = new System.Drawing.Size(83, 89);
            this.notificationPnl.TabIndex = 8;
            // 
            // adminMainContent
            // 
            this.adminMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.adminMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminMainContent.Location = new System.Drawing.Point(0, 89);
            this.adminMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.adminMainContent.Name = "adminMainContent";
            this.adminMainContent.Size = new System.Drawing.Size(1007, 528);
            this.adminMainContent.TabIndex = 3;
            // 
            // viewEmailsBtn
            // 
            this.viewEmailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewEmailsBtn.FlatAppearance.BorderSize = 0;
            this.viewEmailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmailsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.viewEmailsBtn.Location = new System.Drawing.Point(764, 19);
            this.viewEmailsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewEmailsBtn.Name = "viewEmailsBtn";
            this.viewEmailsBtn.Size = new System.Drawing.Size(144, 52);
            this.viewEmailsBtn.TabIndex = 9;
            this.viewEmailsBtn.Text = "View Emails";
            this.viewEmailsBtn.UseVisualStyleBackColor = false;
            this.viewEmailsBtn.Click += new System.EventHandler(this.email_Click);
            // 
            // sendEmailBtn
            // profileBar
            // 
            this.sendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.sendEmailBtn.FlatAppearance.BorderSize = 0;
            this.sendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sendEmailBtn.Location = new System.Drawing.Point(916, 19);
            this.sendEmailBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(144, 52);
            this.sendEmailBtn.TabIndex = 10;
            this.sendEmailBtn.Text = "Send Emails";
            this.sendEmailBtn.UseVisualStyleBackColor = false;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            this.profileBar.BackColor = System.Drawing.Color.Transparent;
            this.profileBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBar.Location = new System.Drawing.Point(3, 3);
            this.profileBar.LoggedInUser = null;
            this.profileBar.Name = "profileBar";
            this.profileBar.NotificationList = null;
            this.profileBar.ParentContainer = null;
            this.profileBar.Size = new System.Drawing.Size(194, 66);
            this.profileBar.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 600);
            this.Controls.Add(this.adminMainContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1023, 639);
            this.MinimumSize = new System.Drawing.Size(1023, 639);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panelHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.notificationPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button manageBranchesBtn;
        private System.Windows.Forms.Button manageInformationBtn;
        private System.Windows.Forms.Button manageUsersBtn;
        private System.Windows.Forms.Panel adminMainContent;
        private System.Windows.Forms.Button manageCoursesBtn;
        private System.Windows.Forms.Panel notificationPnl;
        private System.Windows.Forms.Button btnAddAnouncement;
        private System.Windows.Forms.Button viewEmailsBtn;
        private System.Windows.Forms.Button sendEmailBtn;
        private ProfileBar profileBar;
    }
}