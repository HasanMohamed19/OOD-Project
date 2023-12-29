namespace OOD_Project.TeacherGroup
{
    partial class TeacherViewCoursesForm
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
            this.viewCoursesMainPanel = new System.Windows.Forms.Panel();
            this.courseDetailedPanel = new System.Windows.Forms.Panel();
            this.detailContainer = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.courseBtn = new System.Windows.Forms.Button();
            this.contentBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.coursesListView = new System.Windows.Forms.ListView();
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseTutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewCoursesMainPanel.SuspendLayout();
            this.courseDetailedPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewCoursesMainPanel
            // 
            this.viewCoursesMainPanel.Controls.Add(this.courseDetailedPanel);
            this.viewCoursesMainPanel.Controls.Add(this.coursesListView);
            this.viewCoursesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCoursesMainPanel.Location = new System.Drawing.Point(0, 0);
            this.viewCoursesMainPanel.Name = "viewCoursesMainPanel";
            this.viewCoursesMainPanel.Size = new System.Drawing.Size(1008, 529);
            this.viewCoursesMainPanel.TabIndex = 8;
            // 
            // courseDetailedPanel
            // 
            this.courseDetailedPanel.Controls.Add(this.detailContainer);
            this.courseDetailedPanel.Controls.Add(this.buttonPanel);
            this.courseDetailedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDetailedPanel.Location = new System.Drawing.Point(235, 0);
            this.courseDetailedPanel.Name = "courseDetailedPanel";
            this.courseDetailedPanel.Size = new System.Drawing.Size(773, 529);
            this.courseDetailedPanel.TabIndex = 7;
            // 
            // detailContainer
            // 
            this.detailContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailContainer.Location = new System.Drawing.Point(0, 69);
            this.detailContainer.Name = "detailContainer";
            this.detailContainer.Size = new System.Drawing.Size(773, 460);
            this.detailContainer.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.courseBtn);
            this.buttonPanel.Controls.Add(this.contentBtn);
            this.buttonPanel.Controls.Add(this.studentsBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(773, 69);
            this.buttonPanel.TabIndex = 0;
            // 
            // courseBtn
            // 
            this.courseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.courseBtn.FlatAppearance.BorderSize = 0;
            this.courseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.courseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtn.ForeColor = System.Drawing.Color.White;
            this.courseBtn.Location = new System.Drawing.Point(3, 9);
            this.courseBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(150, 50);
            this.courseBtn.TabIndex = 0;
            this.courseBtn.Text = "Course";
            this.courseBtn.UseVisualStyleBackColor = false;
            this.courseBtn.Click += new System.EventHandler(this.courseBtn_Click);
            // 
            // contentBtn
            // 
            this.contentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.contentBtn.FlatAppearance.BorderSize = 0;
            this.contentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.contentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentBtn.ForeColor = System.Drawing.Color.White;
            this.contentBtn.Location = new System.Drawing.Point(159, 9);
            this.contentBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.contentBtn.Name = "contentBtn";
            this.contentBtn.Size = new System.Drawing.Size(150, 50);
            this.contentBtn.TabIndex = 2;
            this.contentBtn.Text = "Content";
            this.contentBtn.UseVisualStyleBackColor = false;
            this.contentBtn.Click += new System.EventHandler(this.contentBtn_Click);
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.studentsBtn.FlatAppearance.BorderSize = 0;
            this.studentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.ForeColor = System.Drawing.Color.White;
            this.studentsBtn.Location = new System.Drawing.Point(315, 9);
            this.studentsBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(150, 50);
            this.studentsBtn.TabIndex = 1;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.UseVisualStyleBackColor = false;
            this.studentsBtn.Click += new System.EventHandler(this.studentsBtn_Click);
            // 
            // coursesListView
            // 
            this.coursesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.coursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseName,
            this.courseTutor});
            this.coursesListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.coursesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesListView.FullRowSelect = true;
            this.coursesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.coursesListView.HideSelection = false;
            this.coursesListView.Location = new System.Drawing.Point(0, 0);
            this.coursesListView.Margin = new System.Windows.Forms.Padding(2);
            this.coursesListView.MultiSelect = false;
            this.coursesListView.Name = "coursesListView";
            this.coursesListView.Size = new System.Drawing.Size(235, 529);
            this.coursesListView.TabIndex = 6;
            this.coursesListView.TileSize = new System.Drawing.Size(215, 90);
            this.coursesListView.UseCompatibleStateImageBehavior = false;
            this.coursesListView.View = System.Windows.Forms.View.Tile;
            this.coursesListView.SelectedIndexChanged += new System.EventHandler(this.coursesListView_SelectedIndexChanged);
            // 
            // courseName
            // 
            this.courseName.DisplayIndex = 1;
            this.courseName.Width = 70;
            // 
            // courseTutor
            // 
            this.courseTutor.DisplayIndex = 0;
            this.courseTutor.Width = 70;
            // 
            // TeacherViewCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.viewCoursesMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherViewCoursesForm";
            this.Text = "TeacherViewCoursesForm";
            this.viewCoursesMainPanel.ResumeLayout(false);
            this.courseDetailedPanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewCoursesMainPanel;
        private System.Windows.Forms.Panel courseDetailedPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button contentBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.ListView coursesListView;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader courseTutor;
        private System.Windows.Forms.Panel detailContainer;
    }
}