namespace OOD_Project.TeacherGroup.ViewCourses
{
    partial class ContentView
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
            this.classesListView = new System.Windows.Forms.ListView();
            this.columnFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.uploadContentBtn = new System.Windows.Forms.Button();
            this.downloadContentBtn = new System.Windows.Forms.Button();
            this.deleteContentBtn = new System.Windows.Forms.Button();
            this.usersListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // classesListView
            // 
            this.classesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFilename,
            this.columnSize});
            this.classesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListView.FullRowSelect = true;
            this.classesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.classesListView.HideSelection = false;
            this.classesListView.Location = new System.Drawing.Point(0, 33);
            this.classesListView.MultiSelect = false;
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(773, 427);
            this.classesListView.TabIndex = 3;
            this.classesListView.UseCompatibleStateImageBehavior = false;
            this.classesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnFilename
            // 
            this.columnFilename.Text = "File";
            this.columnFilename.Width = 620;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.Width = 133;
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.uploadContentBtn);
            this.usersListControls.Controls.Add(this.downloadContentBtn);
            this.usersListControls.Controls.Add(this.deleteContentBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(773, 33);
            this.usersListControls.TabIndex = 6;
            // 
            // uploadContentBtn
            // 
            this.uploadContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.uploadContentBtn.FlatAppearance.BorderSize = 0;
            this.uploadContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.uploadContentBtn.Location = new System.Drawing.Point(3, 3);
            this.uploadContentBtn.Name = "uploadContentBtn";
            this.uploadContentBtn.Size = new System.Drawing.Size(95, 27);
            this.uploadContentBtn.TabIndex = 0;
            this.uploadContentBtn.TabStop = false;
            this.uploadContentBtn.Text = "Upload";
            this.uploadContentBtn.UseVisualStyleBackColor = false;
            this.uploadContentBtn.Click += new System.EventHandler(this.uploadContentBtn_Click);
            // 
            // downloadContentBtn
            // 
            this.downloadContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.downloadContentBtn.FlatAppearance.BorderSize = 0;
            this.downloadContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.downloadContentBtn.Location = new System.Drawing.Point(104, 3);
            this.downloadContentBtn.Name = "downloadContentBtn";
            this.downloadContentBtn.Size = new System.Drawing.Size(95, 27);
            this.downloadContentBtn.TabIndex = 3;
            this.downloadContentBtn.TabStop = false;
            this.downloadContentBtn.Text = "Download";
            this.downloadContentBtn.UseVisualStyleBackColor = false;
            this.downloadContentBtn.Click += new System.EventHandler(this.downloadContentBtn_Click);
            // 
            // deleteContentBtn
            // 
            this.deleteContentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteContentBtn.FlatAppearance.BorderSize = 0;
            this.deleteContentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteContentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteContentBtn.Location = new System.Drawing.Point(205, 3);
            this.deleteContentBtn.Name = "deleteContentBtn";
            this.deleteContentBtn.Size = new System.Drawing.Size(95, 27);
            this.deleteContentBtn.TabIndex = 2;
            this.deleteContentBtn.Text = "Delete";
            this.deleteContentBtn.UseVisualStyleBackColor = false;
            // 
            // ContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(773, 460);
            this.Controls.Add(this.classesListView);
            this.Controls.Add(this.usersListControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentView";
            this.Text = "ClassesView";
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader columnFilename;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button uploadContentBtn;
        private System.Windows.Forms.Button deleteContentBtn;
        private System.Windows.Forms.Button downloadContentBtn;
    }
}