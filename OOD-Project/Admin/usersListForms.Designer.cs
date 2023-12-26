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
            this.currentUsersDG = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.pendingUsersTab = new System.Windows.Forms.TabPage();
            this.pendingUsersListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.currentUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentUsersDG)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(784, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // currentUsersTab
            // 
            this.currentUsersTab.Controls.Add(this.currentUsersDG);
            this.currentUsersTab.Controls.Add(this.panel1);
            this.currentUsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsersTab.Location = new System.Drawing.Point(4, 22);
            this.currentUsersTab.Name = "currentUsersTab";
            this.currentUsersTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.currentUsersTab.Size = new System.Drawing.Size(776, 463);
            this.currentUsersTab.TabIndex = 0;
            this.currentUsersTab.Text = "Current Users";
            this.currentUsersTab.UseVisualStyleBackColor = true;
            // 
            // currentUsersDG
            // 
            this.currentUsersDG.AllowUserToAddRows = false;
            this.currentUsersDG.AllowUserToDeleteRows = false;
            this.currentUsersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentUsersDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUsersDG.Location = new System.Drawing.Point(3, 36);
            this.currentUsersDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentUsersDG.Name = "currentUsersDG";
            this.currentUsersDG.ReadOnly = true;
            this.currentUsersDG.RowHeadersWidth = 51;
            this.currentUsersDG.RowTemplate.Height = 24;
            this.currentUsersDG.Size = new System.Drawing.Size(770, 424);
            this.currentUsersDG.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.usersListControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 33);
            this.panel1.TabIndex = 5;
            // 
            // usersListControls
            // 
            this.usersListControls.BackColor = System.Drawing.Color.Transparent;
            this.usersListControls.Controls.Add(this.addUserBtn);
            this.usersListControls.Controls.Add(this.editUserBtn);
            this.usersListControls.Controls.Add(this.deleteUserBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(770, 33);
            this.usersListControls.TabIndex = 3;
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editUserBtn.FlatAppearance.BorderSize = 0;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editUserBtn.Location = new System.Drawing.Point(84, 3);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(75, 27);
            this.editUserBtn.TabIndex = 0;
            this.editUserBtn.TabStop = false;
            this.editUserBtn.Text = "Edit";
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteUserBtn.FlatAppearance.BorderSize = 0;
            this.deleteUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteUserBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteUserBtn.TabIndex = 1;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // pendingUsersTab
            // 
            this.pendingUsersTab.Controls.Add(this.pendingUsersListBox);
            this.pendingUsersTab.Controls.Add(this.flowLayoutPanel1);
            this.pendingUsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingUsersTab.Location = new System.Drawing.Point(4, 22);
            this.pendingUsersTab.Name = "pendingUsersTab";
            this.pendingUsersTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pendingUsersTab.Size = new System.Drawing.Size(776, 463);
            this.pendingUsersTab.TabIndex = 1;
            this.pendingUsersTab.Text = "Pending Users";
            this.pendingUsersTab.UseVisualStyleBackColor = true;
            // 
            // pendingUsersListBox
            // 
            this.pendingUsersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingUsersListBox.FormattingEnabled = true;
            this.pendingUsersListBox.ItemHeight = 22;
            this.pendingUsersListBox.Location = new System.Drawing.Point(3, 36);
            this.pendingUsersListBox.Name = "pendingUsersListBox";
            this.pendingUsersListBox.Size = new System.Drawing.Size(770, 424);
            this.pendingUsersListBox.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAccept);
            this.flowLayoutPanel1.Controls.Add(this.btnReject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 27);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.btnReject.Location = new System.Drawing.Point(84, 3);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 27);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addUserBtn.Location = new System.Drawing.Point(3, 3);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 27);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.TabStop = false;
            this.addUserBtn.Text = "Add";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // usersListForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(784, 489);
            this.Controls.Add(this.tabControl1);
            this.Name = "usersListForms";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.currentUsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentUsersDG)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.ListBox pendingUsersListBox;
        private System.Windows.Forms.DataGridView currentUsersDG;
        private System.Windows.Forms.Button addUserBtn;
    }
}