namespace OOD_Project.TeacherGroup.ViewCourses
{
    partial class ViewStudentsForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "lesson1.pptx",
            "C:\\Users\\Jameelo\\Documents",
            "213 KB"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "lesson2.mp4",
            "content\\14_11",
            "94 MB"}, -1);
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.gradeBtn = new System.Windows.Forms.Button();
            this.emailBtn = new System.Windows.Forms.Button();
            this.classesListView = new System.Windows.Forms.ListView();
            this.columnStudentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.gradeBtn);
            this.usersListControls.Controls.Add(this.emailBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(773, 33);
            this.usersListControls.TabIndex = 7;
            // 
            // gradeBtn
            // 
            this.gradeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.gradeBtn.FlatAppearance.BorderSize = 0;
            this.gradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.gradeBtn.Location = new System.Drawing.Point(3, 3);
            this.gradeBtn.Name = "gradeBtn";
            this.gradeBtn.Size = new System.Drawing.Size(95, 27);
            this.gradeBtn.TabIndex = 0;
            this.gradeBtn.TabStop = false;
            this.gradeBtn.Text = "Grade";
            this.gradeBtn.UseVisualStyleBackColor = false;
            // 
            // emailBtn
            // 
            this.emailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.emailBtn.FlatAppearance.BorderSize = 0;
            this.emailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.emailBtn.Location = new System.Drawing.Point(104, 3);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(95, 27);
            this.emailBtn.TabIndex = 3;
            this.emailBtn.TabStop = false;
            this.emailBtn.Text = "Email";
            this.emailBtn.UseVisualStyleBackColor = false;
            // 
            // classesListView
            // 
            this.classesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStudentId,
            this.columnStudentName,
            this.columnGrade});
            this.classesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListView.FullRowSelect = true;
            this.classesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.classesListView.HideSelection = false;
            this.classesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.classesListView.Location = new System.Drawing.Point(0, 33);
            this.classesListView.MultiSelect = false;
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(773, 427);
            this.classesListView.TabIndex = 8;
            this.classesListView.UseCompatibleStateImageBehavior = false;
            this.classesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnStudentId
            // 
            this.columnStudentId.Text = "Student ID";
            this.columnStudentId.Width = 140;
            // 
            // columnStudentName
            // 
            this.columnStudentName.Text = "Name";
            this.columnStudentName.Width = 170;
            // 
            // columnGrade
            // 
            this.columnGrade.Width = 200;
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(773, 460);
            this.Controls.Add(this.classesListView);
            this.Controls.Add(this.usersListControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudentsForm";
            this.Text = "GradeStudentsForm";
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button gradeBtn;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader columnStudentId;
        private System.Windows.Forms.ColumnHeader columnStudentName;
        private System.Windows.Forms.ColumnHeader columnGrade;
    }
}