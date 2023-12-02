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
            this.label1 = new System.Windows.Forms.Label();
            this.adminMainContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.panelHeader.Controls.Add(this.flowLayoutPanel1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 72);
            this.panelHeader.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.flowLayoutPanel1.Controls.Add(this.manageBranchesBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageInformationBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageUsersBtn);
            this.flowLayoutPanel1.Controls.Add(this.manageCoursesBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(274, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 16, 8, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(510, 72);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // manageBranchesBtn
            // 
            this.manageBranchesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBranchesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageBranchesBtn.Location = new System.Drawing.Point(3, 19);
            this.manageBranchesBtn.Name = "manageBranchesBtn";
            this.manageBranchesBtn.Size = new System.Drawing.Size(116, 34);
            this.manageBranchesBtn.TabIndex = 6;
            this.manageBranchesBtn.Text = "Manage Branches";
            this.manageBranchesBtn.UseVisualStyleBackColor = true;
            this.manageBranchesBtn.Click += new System.EventHandler(this.manageBranchesBtn_Click);
            // 
            // manageInformationBtn
            // 
            this.manageInformationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageInformationBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageInformationBtn.Location = new System.Drawing.Point(125, 19);
            this.manageInformationBtn.Name = "manageInformationBtn";
            this.manageInformationBtn.Size = new System.Drawing.Size(116, 34);
            this.manageInformationBtn.TabIndex = 5;
            this.manageInformationBtn.Text = "Upload Information";
            this.manageInformationBtn.UseVisualStyleBackColor = true;
            this.manageInformationBtn.Click += new System.EventHandler(this.manageInformationBtn_Click);
            // 
            // manageUsersBtn
            // 
            this.manageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUsersBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageUsersBtn.Location = new System.Drawing.Point(247, 19);
            this.manageUsersBtn.Name = "manageUsersBtn";
            this.manageUsersBtn.Size = new System.Drawing.Size(116, 34);
            this.manageUsersBtn.TabIndex = 4;
            this.manageUsersBtn.Text = "Manage Users";
            this.manageUsersBtn.UseVisualStyleBackColor = true;
            this.manageUsersBtn.Click += new System.EventHandler(this.manageUsersBtn_Click);
            // 
            // manageCoursesBtn
            // 
            this.manageCoursesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCoursesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.manageCoursesBtn.Location = new System.Drawing.Point(369, 19);
            this.manageCoursesBtn.Name = "manageCoursesBtn";
            this.manageCoursesBtn.Size = new System.Drawing.Size(116, 34);
            this.manageCoursesBtn.TabIndex = 7;
            this.manageCoursesBtn.Text = "Manage Courses";
            this.manageCoursesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "eLMS System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adminMainContent
            // 
            this.adminMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminMainContent.Location = new System.Drawing.Point(0, 72);
            this.adminMainContent.Name = "adminMainContent";
            this.adminMainContent.Size = new System.Drawing.Size(784, 489);
            this.adminMainContent.TabIndex = 3;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.adminMainContent);
            this.Controls.Add(this.panelHeader);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panelHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
    }
}