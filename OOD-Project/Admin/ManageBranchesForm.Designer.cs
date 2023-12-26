﻿namespace OOD_Project
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
            this.branchNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.branchArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.usersListControls.Margin = new System.Windows.Forms.Padding(4);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(1045, 41);
            this.usersListControls.TabIndex = 4;
            // 
            // addBranchBtn
            // 
            this.addBranchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addBranchBtn.FlatAppearance.BorderSize = 0;
            this.addBranchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBranchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addBranchBtn.Location = new System.Drawing.Point(4, 4);
            this.addBranchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBranchBtn.Name = "addBranchBtn";
            this.addBranchBtn.Size = new System.Drawing.Size(100, 33);
            this.addBranchBtn.TabIndex = 2;
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
            this.editBranchBtn.Location = new System.Drawing.Point(112, 4);
            this.editBranchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBranchBtn.Name = "editBranchBtn";
            this.editBranchBtn.Size = new System.Drawing.Size(100, 33);
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
            this.deleteBranchBtn.Location = new System.Drawing.Point(220, 4);
            this.deleteBranchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBranchBtn.Name = "deleteBranchBtn";
            this.deleteBranchBtn.Size = new System.Drawing.Size(100, 33);
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
            this.branchNameCol,
            this.branchArea,
            this.cityColumn,
            this.phoneNumberCol});
            this.branchesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.branchesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchesListView.FullRowSelect = true;
            this.branchesListView.GridLines = true;
            this.branchesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.branchesListView.HideSelection = false;
            this.branchesListView.HoverSelection = true;
            this.branchesListView.Location = new System.Drawing.Point(0, 41);
            this.branchesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.branchesListView.MultiSelect = false;
            this.branchesListView.Name = "branchesListView";
            this.branchesListView.Size = new System.Drawing.Size(1045, 561);
            this.branchesListView.TabIndex = 5;
            this.branchesListView.UseCompatibleStateImageBehavior = false;
            this.branchesListView.View = System.Windows.Forms.View.Details;
            // 
            // branchID
            // 
            this.branchID.Text = "Branch ID";
            this.branchID.Width = 150;
            // 
            // branchNameCol
            // 
            this.branchNameCol.Text = "Branch Name";
            this.branchNameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.branchNameCol.Width = 166;
            // 
            // branchArea
            // 
            this.branchArea.Text = "Area";
            this.branchArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.branchArea.Width = 100;
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            this.cityColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cityColumn.Width = 100;
            // 
            // phoneNumberCol
            // 
            this.phoneNumberCol.Text = "Phone Number";
            this.phoneNumberCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumberCol.Width = 250;
            // 
            // ManageBranchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 602);
            this.Controls.Add(this.branchesListView);
            this.Controls.Add(this.usersListControls);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageBranchesForm";
            this.Text = "ManageBranchesForm";
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button editBranchBtn;
        private System.Windows.Forms.Button deleteBranchBtn;
        private System.Windows.Forms.ListView branchesListView;
        private System.Windows.Forms.ColumnHeader branchID;
        private System.Windows.Forms.ColumnHeader branchArea;
        private System.Windows.Forms.ColumnHeader cityColumn;
        private System.Windows.Forms.ColumnHeader phoneNumberCol;
        private System.Windows.Forms.Button addBranchBtn;
        private System.Windows.Forms.ColumnHeader branchNameCol;
    }
}