namespace OOD_Project
{
    partial class ManageUsersForm
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
            this.addUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.pendingUsersTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inactiveDGV = new System.Windows.Forms.DataGridView();
            this.pendingDGV = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addInactive = new System.Windows.Forms.Button();
            this.editInactive = new System.Windows.Forms.Button();
            this.deleteInactive = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.currentUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentUsersDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.usersListControls.SuspendLayout();
            this.pendingUsersTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDGV)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1008, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // currentUsersTab
            // 
            this.currentUsersTab.Controls.Add(this.currentUsersDG);
            this.currentUsersTab.Controls.Add(this.panel1);
            this.currentUsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUsersTab.Location = new System.Drawing.Point(4, 22);
            this.currentUsersTab.Name = "currentUsersTab";
            this.currentUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentUsersTab.Size = new System.Drawing.Size(1000, 503);
            this.currentUsersTab.TabIndex = 0;
            this.currentUsersTab.Text = "Current Users";
            this.currentUsersTab.UseVisualStyleBackColor = true;
            // 
            // currentUsersDG
            // 
            this.currentUsersDG.AllowUserToAddRows = false;
            this.currentUsersDG.AllowUserToDeleteRows = false;
            this.currentUsersDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentUsersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentUsersDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentUsersDG.Location = new System.Drawing.Point(3, 36);
            this.currentUsersDG.Margin = new System.Windows.Forms.Padding(2);
            this.currentUsersDG.MultiSelect = false;
            this.currentUsersDG.Name = "currentUsersDG";
            this.currentUsersDG.ReadOnly = true;
            this.currentUsersDG.RowHeadersVisible = false;
            this.currentUsersDG.RowHeadersWidth = 51;
            this.currentUsersDG.RowTemplate.Height = 24;
            this.currentUsersDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentUsersDG.Size = new System.Drawing.Size(994, 464);
            this.currentUsersDG.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.usersListControls);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 33);
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
            this.usersListControls.Size = new System.Drawing.Size(994, 33);
            this.usersListControls.TabIndex = 3;
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
            this.pendingUsersTab.Controls.Add(this.tableLayoutPanel1);
            this.pendingUsersTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingUsersTab.Location = new System.Drawing.Point(4, 22);
            this.pendingUsersTab.Name = "pendingUsersTab";
            this.pendingUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.pendingUsersTab.Size = new System.Drawing.Size(1000, 503);
            this.pendingUsersTab.TabIndex = 1;
            this.pendingUsersTab.Text = "Pending Users";
            this.pendingUsersTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inactiveDGV, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pendingDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 497);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // inactiveDGV
            // 
            this.inactiveDGV.AllowUserToAddRows = false;
            this.inactiveDGV.AllowUserToDeleteRows = false;
            this.inactiveDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inactiveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inactiveDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inactiveDGV.Location = new System.Drawing.Point(2, 289);
            this.inactiveDGV.Margin = new System.Windows.Forms.Padding(2);
            this.inactiveDGV.MultiSelect = false;
            this.inactiveDGV.Name = "inactiveDGV";
            this.inactiveDGV.ReadOnly = true;
            this.inactiveDGV.RowHeadersVisible = false;
            this.inactiveDGV.RowHeadersWidth = 51;
            this.inactiveDGV.RowTemplate.Height = 24;
            this.inactiveDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inactiveDGV.Size = new System.Drawing.Size(990, 206);
            this.inactiveDGV.TabIndex = 10;
            // 
            // pendingDGV
            // 
            this.pendingDGV.AllowUserToAddRows = false;
            this.pendingDGV.AllowUserToDeleteRows = false;
            this.pendingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pendingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingDGV.Location = new System.Drawing.Point(2, 41);
            this.pendingDGV.Margin = new System.Windows.Forms.Padding(2);
            this.pendingDGV.MultiSelect = false;
            this.pendingDGV.Name = "pendingDGV";
            this.pendingDGV.ReadOnly = true;
            this.pendingDGV.RowHeadersVisible = false;
            this.pendingDGV.RowHeadersWidth = 51;
            this.pendingDGV.RowTemplate.Height = 24;
            this.pendingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pendingDGV.Size = new System.Drawing.Size(990, 205);
            this.pendingDGV.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.addInactive);
            this.flowLayoutPanel2.Controls.Add(this.editInactive);
            this.flowLayoutPanel2.Controls.Add(this.deleteInactive);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 251);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(988, 33);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inactive Users:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addInactive
            // 
            this.addInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addInactive.FlatAppearance.BorderSize = 0;
            this.addInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addInactive.Location = new System.Drawing.Point(157, 3);
            this.addInactive.Name = "addInactive";
            this.addInactive.Size = new System.Drawing.Size(75, 27);
            this.addInactive.TabIndex = 0;
            this.addInactive.Text = "Add";
            this.addInactive.UseVisualStyleBackColor = false;
            this.addInactive.Click += new System.EventHandler(this.addInactive_Click);
            // 
            // editInactive
            // 
            this.editInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editInactive.FlatAppearance.BorderSize = 0;
            this.editInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editInactive.Location = new System.Drawing.Point(238, 3);
            this.editInactive.Name = "editInactive";
            this.editInactive.Size = new System.Drawing.Size(75, 27);
            this.editInactive.TabIndex = 2;
            this.editInactive.Text = "Edit";
            this.editInactive.UseVisualStyleBackColor = false;
            this.editInactive.Click += new System.EventHandler(this.editInactive_Click);
            // 
            // deleteInactive
            // 
            this.deleteInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteInactive.FlatAppearance.BorderSize = 0;
            this.deleteInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteInactive.Location = new System.Drawing.Point(319, 3);
            this.deleteInactive.Name = "deleteInactive";
            this.deleteInactive.Size = new System.Drawing.Size(75, 27);
            this.deleteInactive.TabIndex = 1;
            this.deleteInactive.Text = "Delete";
            this.deleteInactive.UseVisualStyleBackColor = false;
            this.deleteInactive.Click += new System.EventHandler(this.deleteInactive_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.btnAccept);
            this.flowLayoutPanel1.Controls.Add(this.btnReject);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 33);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pending Users:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.btnAccept.Location = new System.Drawing.Point(157, 3);
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
            this.btnReject.Location = new System.Drawing.Point(238, 3);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 27);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsersForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.currentUsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentUsersDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.usersListControls.ResumeLayout(false);
            this.pendingUsersTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inactiveDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDGV)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView currentUsersDG;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addInactive;
        private System.Windows.Forms.Button deleteInactive;
        private System.Windows.Forms.DataGridView inactiveDGV;
        private System.Windows.Forms.DataGridView pendingDGV;
        private System.Windows.Forms.Button editInactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}