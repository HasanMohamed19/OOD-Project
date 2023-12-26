
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
            this.courseListView = new System.Windows.Forms.ListView();
            this.AnnouncementIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementSentByCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnouncementDateSentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewContentBtn = new System.Windows.Forms.Button();
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
            this.addAnnouncementBtn.Location = new System.Drawing.Point(3, 3);
            this.addAnnouncementBtn.Name = "addAnnouncementBtn";
            this.addAnnouncementBtn.Size = new System.Drawing.Size(75, 27);
            this.addAnnouncementBtn.TabIndex = 0;
            this.addAnnouncementBtn.TabStop = false;
            this.addAnnouncementBtn.Text = "Add";
            this.addAnnouncementBtn.UseVisualStyleBackColor = false;
            // 
            // editAnnouncementBtn
            // 
            this.editAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.editAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAnnouncementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editAnnouncementBtn.Location = new System.Drawing.Point(84, 3);
            this.editAnnouncementBtn.Name = "editAnnouncementBtn";
            this.editAnnouncementBtn.Size = new System.Drawing.Size(75, 27);
            this.editAnnouncementBtn.TabIndex = 1;
            this.editAnnouncementBtn.Text = "Edit";
            this.editAnnouncementBtn.UseVisualStyleBackColor = false;
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.addAnnouncementBtn);
            this.usersListControls.Controls.Add(this.editAnnouncementBtn);
            this.usersListControls.Controls.Add(this.deleteAnnouncementBtn);
            this.usersListControls.Controls.Add(this.viewContentBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(800, 33);
            this.usersListControls.TabIndex = 7;
            // 
            // deleteAnnouncementBtn
            // 
            this.deleteAnnouncementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteAnnouncementBtn.FlatAppearance.BorderSize = 0;
            this.deleteAnnouncementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAnnouncementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAnnouncementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteAnnouncementBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteAnnouncementBtn.Name = "deleteAnnouncementBtn";
            this.deleteAnnouncementBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteAnnouncementBtn.TabIndex = 2;
            this.deleteAnnouncementBtn.Text = "Delete";
            this.deleteAnnouncementBtn.UseVisualStyleBackColor = false;
            // 
            // courseListView
            // 
            this.courseListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AnnouncementIDCol,
            this.AnnouncementNameCol,
            this.AnnouncementSentByCol,
            this.AnnouncementDateSentCol});
            this.courseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListView.FullRowSelect = true;
            this.courseListView.GridLines = true;
            this.courseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.courseListView.HideSelection = false;
            this.courseListView.HoverSelection = true;
            this.courseListView.Location = new System.Drawing.Point(0, 35);
            this.courseListView.Margin = new System.Windows.Forms.Padding(2);
            this.courseListView.MultiSelect = false;
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(800, 454);
            this.courseListView.TabIndex = 8;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            // 
            // AnnouncementIDCol
            // 
            this.AnnouncementIDCol.Text = "ID";
            // 
            // AnnouncementNameCol
            // 
            this.AnnouncementNameCol.Text = "Title";
            this.AnnouncementNameCol.Width = 296;
            // 
            // AnnouncementSentByCol
            // 
            this.AnnouncementSentByCol.Text = "Sent By";
            this.AnnouncementSentByCol.Width = 89;
            // 
            // AnnouncementDateSentCol
            // 
            this.AnnouncementDateSentCol.Text = "Date Sent";
            this.AnnouncementDateSentCol.Width = 103;
            // 
            // viewContentBtn
            // 
            this.viewContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.viewContentBtn.FlatAppearance.BorderSize = 0;
            this.viewContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.viewContentBtn.Location = new System.Drawing.Point(246, 3);
            this.viewContentBtn.Name = "viewContentBtn";
            this.viewContentBtn.Size = new System.Drawing.Size(125, 27);
            this.viewContentBtn.TabIndex = 3;
            this.viewContentBtn.Text = "View Content";
            this.viewContentBtn.UseVisualStyleBackColor = false;
            // 
            // AnnouncementsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.usersListControls);
            this.Controls.Add(this.courseListView);
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
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader AnnouncementIDCol;
        private System.Windows.Forms.ColumnHeader AnnouncementNameCol;
        private System.Windows.Forms.ColumnHeader AnnouncementSentByCol;
        private System.Windows.Forms.ColumnHeader AnnouncementDateSentCol;
        private System.Windows.Forms.Button viewContentBtn;
    }
}