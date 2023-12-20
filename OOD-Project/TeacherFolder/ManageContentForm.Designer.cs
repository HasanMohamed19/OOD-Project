namespace OOD_Project.TeacherFolder
{
    partial class ManageContentForm
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
            this.contentListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.addContentBtn = new System.Windows.Forms.Button();
            this.editContentBtn = new System.Windows.Forms.Button();
            this.deleteContentBtn = new System.Windows.Forms.Button();
            this.courseListView = new System.Windows.Forms.ListView();
            this.contentIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentSizeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentFolderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contentListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentListControls
            // 
            this.contentListControls.Controls.Add(this.addContentBtn);
            this.contentListControls.Controls.Add(this.editContentBtn);
            this.contentListControls.Controls.Add(this.deleteContentBtn);
            this.contentListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentListControls.Location = new System.Drawing.Point(0, 0);
            this.contentListControls.Name = "contentListControls";
            this.contentListControls.Size = new System.Drawing.Size(784, 33);
            this.contentListControls.TabIndex = 6;
            // 
            // addContentBtn
            // 
            this.addContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addContentBtn.FlatAppearance.BorderSize = 0;
            this.addContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addContentBtn.Location = new System.Drawing.Point(3, 3);
            this.addContentBtn.Name = "addContentBtn";
            this.addContentBtn.Size = new System.Drawing.Size(75, 27);
            this.addContentBtn.TabIndex = 0;
            this.addContentBtn.TabStop = false;
            this.addContentBtn.Text = "Add";
            this.addContentBtn.UseVisualStyleBackColor = false;
            // 
            // editContentBtn
            // 
            this.editContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editContentBtn.FlatAppearance.BorderSize = 0;
            this.editContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editContentBtn.Location = new System.Drawing.Point(84, 3);
            this.editContentBtn.Name = "editContentBtn";
            this.editContentBtn.Size = new System.Drawing.Size(75, 27);
            this.editContentBtn.TabIndex = 1;
            this.editContentBtn.Text = "Edit";
            this.editContentBtn.UseVisualStyleBackColor = false;
            // 
            // deleteContentBtn
            // 
            this.deleteContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteContentBtn.FlatAppearance.BorderSize = 0;
            this.deleteContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteContentBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteContentBtn.Name = "deleteContentBtn";
            this.deleteContentBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteContentBtn.TabIndex = 2;
            this.deleteContentBtn.Text = "Delete";
            this.deleteContentBtn.UseVisualStyleBackColor = false;
            // 
            // courseListView
            // 
            this.courseListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentIDCol,
            this.contentNameCol,
            this.contentSizeCol,
            this.contentFolderCol});
            this.courseListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListView.FullRowSelect = true;
            this.courseListView.GridLines = true;
            this.courseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.courseListView.HideSelection = false;
            this.courseListView.HoverSelection = true;
            this.courseListView.Location = new System.Drawing.Point(0, 33);
            this.courseListView.Margin = new System.Windows.Forms.Padding(2);
            this.courseListView.MultiSelect = false;
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(784, 456);
            this.courseListView.TabIndex = 7;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            // 
            // contentIDCol
            // 
            this.contentIDCol.Text = "Content ID";
            this.contentIDCol.Width = 101;
            // 
            // contentNameCol
            // 
            this.contentNameCol.Text = "Filename";
            this.contentNameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contentNameCol.Width = 150;
            // 
            // contentSizeCol
            // 
            this.contentSizeCol.Text = "Size";
            this.contentSizeCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contentSizeCol.Width = 86;
            // 
            // contentFolderCol
            // 
            this.contentFolderCol.Text = "Folder Location";
            this.contentFolderCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contentFolderCol.Width = 443;
            // 
            // ManageContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 489);
            this.Controls.Add(this.courseListView);
            this.Controls.Add(this.contentListControls);
            this.Name = "ManageContentForm";
            this.Text = "ManageContentForm";
            this.contentListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contentListControls;
        private System.Windows.Forms.Button addContentBtn;
        private System.Windows.Forms.Button editContentBtn;
        private System.Windows.Forms.Button deleteContentBtn;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader contentIDCol;
        private System.Windows.Forms.ColumnHeader contentNameCol;
        private System.Windows.Forms.ColumnHeader contentSizeCol;
        private System.Windows.Forms.ColumnHeader contentFolderCol;
    }
}