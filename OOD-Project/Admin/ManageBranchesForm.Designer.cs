namespace OOD_Project
{
    partial class ManageBranchesForm
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
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.addBranchBtn = new System.Windows.Forms.Button();
            this.editBranchBtn = new System.Windows.Forms.Button();
            this.deleteBranchBtn = new System.Windows.Forms.Button();
            this.branchesListView = new System.Windows.Forms.ListView();
            this.branchID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersListControls
            // 
            this.usersListControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.usersListControls.Controls.Add(this.addBranchBtn);
            this.usersListControls.Controls.Add(this.editBranchBtn);
            this.usersListControls.Controls.Add(this.deleteBranchBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(1008, 33);
            this.usersListControls.TabIndex = 4;
            // 
            // addBranchBtn
            // 
            this.addBranchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addBranchBtn.FlatAppearance.BorderSize = 0;
            this.addBranchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBranchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addBranchBtn.Location = new System.Drawing.Point(3, 3);
            this.addBranchBtn.Name = "addBranchBtn";
            this.addBranchBtn.Size = new System.Drawing.Size(75, 27);
            this.addBranchBtn.TabIndex = 2;
            this.addBranchBtn.TabStop = false;
            this.addBranchBtn.Text = "Add";
            this.addBranchBtn.UseVisualStyleBackColor = false;
            this.addBranchBtn.Click += new System.EventHandler(this.addBranchBtn_Click);
            // 
            // editBranchBtn
            // 
            this.editBranchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editBranchBtn.FlatAppearance.BorderSize = 0;
            this.editBranchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBranchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editBranchBtn.Location = new System.Drawing.Point(84, 3);
            this.editBranchBtn.Name = "editBranchBtn";
            this.editBranchBtn.Size = new System.Drawing.Size(75, 27);
            this.editBranchBtn.TabIndex = 0;
            this.editBranchBtn.TabStop = false;
            this.editBranchBtn.Text = "Edit";
            this.editBranchBtn.UseVisualStyleBackColor = false;
            this.editBranchBtn.Click += new System.EventHandler(this.editBranchBtn_Click);
            // 
            // deleteBranchBtn
            // 
            this.deleteBranchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteBranchBtn.FlatAppearance.BorderSize = 0;
            this.deleteBranchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBranchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteBranchBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteBranchBtn.Name = "deleteBranchBtn";
            this.deleteBranchBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteBranchBtn.TabIndex = 1;
            this.deleteBranchBtn.Text = "Delete";
            this.deleteBranchBtn.UseVisualStyleBackColor = false;
            this.deleteBranchBtn.Click += new System.EventHandler(this.deleteBranchBtn_Click);
            // 
            // branchesListView
            // 
            this.branchesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.branchesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.branchID,
            this.branchName,
            this.phoneNumberCol});
            this.branchesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchesListView.FullRowSelect = true;
            this.branchesListView.GridLines = true;
            this.branchesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.branchesListView.HideSelection = false;
            this.branchesListView.Location = new System.Drawing.Point(0, 33);
            this.branchesListView.Margin = new System.Windows.Forms.Padding(2);
            this.branchesListView.MultiSelect = false;
            this.branchesListView.Name = "branchesListView";
            this.branchesListView.Size = new System.Drawing.Size(1008, 496);
            this.branchesListView.TabIndex = 5;
            this.branchesListView.UseCompatibleStateImageBehavior = false;
            this.branchesListView.View = System.Windows.Forms.View.Details;
            // 
            // branchID
            // 
            this.branchID.Text = "Branch ID";
            this.branchID.Width = 0;
            // 
            // branchName
            // 
            this.branchName.Text = "Name";
            this.branchName.Width = 700;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.Text = "Phone Number";
            this.phoneNumberCol.Width = 300;
            // 
            // ManageBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.branchesListView);
            this.Controls.Add(this.usersListControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageBranchesForm";
            this.Text = "ManageBranchesForm";
            this.Load += new System.EventHandler(this.ManageBranchesForm_Load);
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button editBranchBtn;
        private System.Windows.Forms.Button deleteBranchBtn;
        private System.Windows.Forms.ListView branchesListView;
        private System.Windows.Forms.ColumnHeader branchID;
        private System.Windows.Forms.ColumnHeader branchName;
        private System.Windows.Forms.ColumnHeader phoneNumberCol;
        private System.Windows.Forms.Button addBranchBtn;
    }
}