
namespace OOD_Project
{
    partial class AnnouncementsList
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
            this.addAnnouncementBtn = new System.Windows.Forms.Button();
            this.editAnnouncementBtn = new System.Windows.Forms.Button();
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteAnnouncementBtn = new System.Windows.Forms.Button();
            this.viewContentBtn = new System.Windows.Forms.Button();
            this.announcementListView = new System.Windows.Forms.ListView();
            this.idCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementSentByCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementDateSentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeSentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAnnouncementBtn
            // 
            this.addAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.addAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnnouncementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addAnnouncementBtn.Location = new System.Drawing.Point(4, 4);
            this.addAnnouncementBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addAnnouncementBtn.Name = "addAnnouncementBtn";
            this.addAnnouncementBtn.Size = new System.Drawing.Size(100, 33);
            this.addAnnouncementBtn.TabIndex = 0;
            this.addAnnouncementBtn.TabStop = false;
            this.addAnnouncementBtn.Text = "Add";
            this.addAnnouncementBtn.UseVisualStyleBackColor = false;
            this.addAnnouncementBtn.Click += new System.EventHandler(this.addAnnouncementBtn_Click);
            // 
            // editAnnouncementBtn
            // 
            this.editAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.editAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAnnouncementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editAnnouncementBtn.Location = new System.Drawing.Point(112, 4);
            this.editAnnouncementBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editAnnouncementBtn.Name = "editAnnouncementBtn";
            this.editAnnouncementBtn.Size = new System.Drawing.Size(100, 33);
            this.editAnnouncementBtn.TabIndex = 1;
            this.editAnnouncementBtn.Text = "Edit";
            this.editAnnouncementBtn.UseVisualStyleBackColor = false;
            this.editAnnouncementBtn.Click += new System.EventHandler(this.editAnnouncementBtn_Click);
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.addAnnouncementBtn);
            this.usersListControls.Controls.Add(this.editAnnouncementBtn);
            this.usersListControls.Controls.Add(this.deleteAnnouncementBtn);
            this.usersListControls.Controls.Add(this.viewContentBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Margin = new System.Windows.Forms.Padding(4);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(1067, 41);
            this.usersListControls.TabIndex = 7;
            // 
            // deleteAnnouncementBtn
            // 
            this.deleteAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.deleteAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAnnouncementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteAnnouncementBtn.Location = new System.Drawing.Point(220, 4);
            this.deleteAnnouncementBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAnnouncementBtn.Name = "deleteAnnouncementBtn";
            this.deleteAnnouncementBtn.Size = new System.Drawing.Size(100, 33);
            this.deleteAnnouncementBtn.TabIndex = 2;
            this.deleteAnnouncementBtn.Text = "Delete";
            this.deleteAnnouncementBtn.UseVisualStyleBackColor = false;
            this.deleteAnnouncementBtn.Click += new System.EventHandler(this.deleteAnnouncementBtn_Click);
            // 
            // viewContentBtn
            // 
            this.viewContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewContentBtn.FlatAppearance.BorderSize = 0;
            this.viewContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.viewContentBtn.Location = new System.Drawing.Point(328, 4);
            this.viewContentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewContentBtn.Name = "viewContentBtn";
            this.viewContentBtn.Size = new System.Drawing.Size(167, 33);
            this.viewContentBtn.TabIndex = 3;
            this.viewContentBtn.Text = "View Content";
            this.viewContentBtn.UseVisualStyleBackColor = false;
            // 
            // announcementListView
            // 
            this.announcementListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.announcementListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCol,
            this.AnnouncementNameCol,
            this.AnnouncementSentByCol,
            this.AnnouncementDateSentCol,
            this.timeSentCol});
            this.announcementListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementListView.FullRowSelect = true;
            this.announcementListView.GridLines = true;
            this.announcementListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.announcementListView.HideSelection = false;
            this.announcementListView.HoverSelection = true;
            this.announcementListView.Location = new System.Drawing.Point(0, 43);
            this.announcementListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.announcementListView.MultiSelect = false;
            this.announcementListView.Name = "announcementListView";
            this.announcementListView.Size = new System.Drawing.Size(1067, 558);
            this.announcementListView.TabIndex = 8;
            this.announcementListView.UseCompatibleStateImageBehavior = false;
            this.announcementListView.View = System.Windows.Forms.View.Details;
            // 
            // idCol
            // 
            this.idCol.Text = "Announcement ID";
            this.idCol.Width = 216;
            // 
            // AnnouncementNameCol
            // 
            this.AnnouncementNameCol.Text = "Title";
            this.AnnouncementNameCol.Width = 285;
            // 
            // AnnouncementSentByCol
            // 
            this.AnnouncementSentByCol.Text = "Sent By";
            this.AnnouncementSentByCol.Width = 114;
            // 
            // AnnouncementDateSentCol
            // 
            this.AnnouncementDateSentCol.Text = "Date Sent";
            this.AnnouncementDateSentCol.Width = 127;
            // 
            // timeSentCol
            // 
            this.timeSentCol.Text = "Time Sent";
            this.timeSentCol.Width = 139;
            // 
            // AnnouncementsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 598);
            this.Controls.Add(this.usersListControls);
            this.Controls.Add(this.announcementListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnnouncementsList";
            this.Text = "AnnouncementsList";
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAnnouncementBtn;
        private System.Windows.Forms.Button editAnnouncementBtn;
        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button deleteAnnouncementBtn;
        private System.Windows.Forms.ListView announcementListView;
        private System.Windows.Forms.ColumnHeader AnnouncementNameCol;
        private System.Windows.Forms.ColumnHeader AnnouncementSentByCol;
        private System.Windows.Forms.ColumnHeader AnnouncementDateSentCol;
        private System.Windows.Forms.Button viewContentBtn;
        private System.Windows.Forms.ColumnHeader timeSentCol;
        private System.Windows.Forms.ColumnHeader idCol;
    }
}