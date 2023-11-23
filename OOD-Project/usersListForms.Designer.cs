namespace OOD_Project
{
    partial class usersListForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.currentUsersTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.currentUsersListBox = new System.Windows.Forms.ListBox();
            this.pendingUsersTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.pendingUsersListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.currentUsersTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.usersListControls.SuspendLayout();
            this.pendingUsersTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.currentUsersTab);
            this.tabControl1.Controls.Add(this.pendingUsersTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // currentUsersTab
            // 
            this.currentUsersTab.Controls.Add(this.panel1);
            this.currentUsersTab.Controls.Add(this.currentUsersListBox);
            this.currentUsersTab.Location = new System.Drawing.Point(4, 22);
            this.currentUsersTab.Name = "currentUsersTab";
            this.currentUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentUsersTab.Size = new System.Drawing.Size(776, 313);
            this.currentUsersTab.TabIndex = 0;
            this.currentUsersTab.Text = "Current Users";
            this.currentUsersTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usersListControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 33);
            this.panel1.TabIndex = 5;
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.editUserBtn);
            this.usersListControls.Controls.Add(this.deleteUserBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(770, 32);
            this.usersListControls.TabIndex = 3;
            // 
            // editUserBtn
            // 
            this.editUserBtn.Location = new System.Drawing.Point(3, 3);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(75, 23);
            this.editUserBtn.TabIndex = 0;
            this.editUserBtn.Text = "Edit";
            this.editUserBtn.UseVisualStyleBackColor = true;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.Location = new System.Drawing.Point(84, 3);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteUserBtn.TabIndex = 1;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = true;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // currentUsersListBox
            // 
            this.currentUsersListBox.FormattingEnabled = true;
            this.currentUsersListBox.Location = new System.Drawing.Point(3, 48);
            this.currentUsersListBox.Name = "currentUsersListBox";
            this.currentUsersListBox.Size = new System.Drawing.Size(770, 264);
            this.currentUsersListBox.TabIndex = 5;
            // 
            // pendingUsersTab
            // 
            this.pendingUsersTab.Controls.Add(this.flowLayoutPanel1);
            this.pendingUsersTab.Controls.Add(this.pendingUsersListBox);
            this.pendingUsersTab.Location = new System.Drawing.Point(4, 22);
            this.pendingUsersTab.Name = "pendingUsersTab";
            this.pendingUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendingUsersTab.Size = new System.Drawing.Size(776, 313);
            this.pendingUsersTab.TabIndex = 1;
            this.pendingUsersTab.Text = "Pending Users";
            this.pendingUsersTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAccept);
            this.flowLayoutPanel1.Controls.Add(this.btnReject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 32);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(84, 3);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // pendingUsersListBox
            // 
            this.pendingUsersListBox.FormattingEnabled = true;
            this.pendingUsersListBox.Location = new System.Drawing.Point(3, 47);
            this.pendingUsersListBox.Name = "pendingUsersListBox";
            this.pendingUsersListBox.Size = new System.Drawing.Size(770, 264);
            this.pendingUsersListBox.TabIndex = 7;
            // 
            // usersListForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 339);
            this.Controls.Add(this.tabControl1);
            this.Name = "usersListForms";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.currentUsersTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.usersListControls.ResumeLayout(false);
            this.pendingUsersTab.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage currentUsersTab;
        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.TabPage pendingUsersTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox currentUsersListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.ListBox pendingUsersListBox;
    }
}