namespace OOD_Project.TeacherGroup.ViewCourses
{
    partial class ViewCourseForm
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
            "Wednesday",
            "10:00 AM - 11:50 AM",
            "36.203"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Thursday",
            "8:00 AM - 9:50 AM",
            "36.206"}, -1);
            this.courseDetailedTablePanel = new System.Windows.Forms.Panel();
            this.CourseDetailsPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.courseDescription = new System.Windows.Forms.Label();
            this.courseProgrammeLabel = new System.Windows.Forms.Label();
            this.courseCreditsLabel = new System.Windows.Forms.Label();
            this.courseTutorLabel = new System.Windows.Forms.Label();
            this.courseCRNLabel = new System.Windows.Forms.Label();
            this.courseSectionLabel = new System.Windows.Forms.Label();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.courseTitleLabel = new System.Windows.Forms.Label();
            this.classesListView = new System.Windows.Forms.ListView();
            this.columnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseDetailedTablePanel.SuspendLayout();
            this.CourseDetailsPanelTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseDetailedTablePanel
            // 
            this.courseDetailedTablePanel.Controls.Add(this.CourseDetailsPanelTable);
            this.courseDetailedTablePanel.Controls.Add(this.courseTitleLabel);
            this.courseDetailedTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDetailedTablePanel.Location = new System.Drawing.Point(0, 0);
            this.courseDetailedTablePanel.Name = "courseDetailedTablePanel";
            this.courseDetailedTablePanel.Size = new System.Drawing.Size(773, 330);
            this.courseDetailedTablePanel.TabIndex = 1;
            // 
            // CourseDetailsPanelTable
            // 
            this.CourseDetailsPanelTable.ColumnCount = 3;
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.CourseDetailsPanelTable.Controls.Add(this.courseDescription, 0, 2);
            this.CourseDetailsPanelTable.Controls.Add(this.courseProgrammeLabel, 2, 1);
            this.CourseDetailsPanelTable.Controls.Add(this.courseCreditsLabel, 1, 1);
            this.CourseDetailsPanelTable.Controls.Add(this.courseTutorLabel, 0, 1);
            this.CourseDetailsPanelTable.Controls.Add(this.courseCRNLabel, 2, 0);
            this.CourseDetailsPanelTable.Controls.Add(this.courseSectionLabel, 1, 0);
            this.CourseDetailsPanelTable.Controls.Add(this.courseCodeLabel, 0, 0);
            this.CourseDetailsPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CourseDetailsPanelTable.Location = new System.Drawing.Point(0, 61);
            this.CourseDetailsPanelTable.Name = "CourseDetailsPanelTable";
            this.CourseDetailsPanelTable.RowCount = 3;
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.CourseDetailsPanelTable.Size = new System.Drawing.Size(773, 269);
            this.CourseDetailsPanelTable.TabIndex = 5;
            // 
            // courseDescription
            // 
            this.courseDescription.AutoSize = true;
            this.CourseDetailsPanelTable.SetColumnSpan(this.courseDescription, 3);
            this.courseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDescription.Location = new System.Drawing.Point(6, 170);
            this.courseDescription.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(767, 40);
            this.courseDescription.TabIndex = 0;
            this.courseDescription.Text = "Description: This couse is a course that teaches stuff about itself as the course" +
    " of a course does. It also has a long description unlike other courses of course" +
    "s, weird.\r\n";
            this.courseDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseProgrammeLabel
            // 
            this.courseProgrammeLabel.AutoSize = true;
            this.courseProgrammeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseProgrammeLabel.Location = new System.Drawing.Point(532, 92);
            this.courseProgrammeLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseProgrammeLabel.Name = "courseProgrammeLabel";
            this.courseProgrammeLabel.Size = new System.Drawing.Size(176, 20);
            this.courseProgrammeLabel.TabIndex = 2;
            this.courseProgrammeLabel.Text = "Programme: Samboosa";
            this.courseProgrammeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCreditsLabel.Location = new System.Drawing.Point(284, 92);
            this.courseCreditsLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(85, 20);
            this.courseCreditsLabel.TabIndex = 1;
            this.courseCreditsLabel.Text = "Credits: 15";
            this.courseCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTutorLabel
            // 
            this.courseTutorLabel.AutoSize = true;
            this.courseTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTutorLabel.Location = new System.Drawing.Point(6, 90);
            this.courseTutorLabel.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseTutorLabel.Name = "courseTutorLabel";
            this.courseTutorLabel.Size = new System.Drawing.Size(116, 20);
            this.courseTutorLabel.TabIndex = 0;
            this.courseTutorLabel.Text = "Tutor: Yousifito";
            this.courseTutorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCRNLabel
            // 
            this.courseCRNLabel.AutoSize = true;
            this.courseCRNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCRNLabel.Location = new System.Drawing.Point(532, 12);
            this.courseCRNLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseCRNLabel.Name = "courseCRNLabel";
            this.courseCRNLabel.Size = new System.Drawing.Size(96, 20);
            this.courseCRNLabel.TabIndex = 2;
            this.courseCRNLabel.Text = "CRN: 43789";
            this.courseCRNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseSectionLabel
            // 
            this.courseSectionLabel.AutoSize = true;
            this.courseSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSectionLabel.Location = new System.Drawing.Point(284, 12);
            this.courseSectionLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseSectionLabel.Name = "courseSectionLabel";
            this.courseSectionLabel.Size = new System.Drawing.Size(96, 20);
            this.courseSectionLabel.TabIndex = 1;
            this.courseSectionLabel.Text = "Capacity: 25";
            this.courseSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLabel.Location = new System.Drawing.Point(6, 10);
            this.courseCodeLabel.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(105, 20);
            this.courseCodeLabel.TabIndex = 0;
            this.courseCodeLabel.Text = "Code: IT0000";
            this.courseCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.courseTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.courseTitleLabel.Size = new System.Drawing.Size(773, 61);
            this.courseTitleLabel.TabIndex = 1;
            this.courseTitleLabel.Text = "CourseTitle";
            this.courseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classesListView
            // 
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDay,
            this.columnTime,
            this.columnLocation});
            this.classesListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.classesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListView.FullRowSelect = true;
            this.classesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.classesListView.HideSelection = false;
            this.classesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.classesListView.Location = new System.Drawing.Point(0, 330);
            this.classesListView.MultiSelect = false;
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(773, 130);
            this.classesListView.TabIndex = 2;
            this.classesListView.UseCompatibleStateImageBehavior = false;
            this.classesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnDay
            // 
            this.columnDay.Text = "Day";
            this.columnDay.Width = 133;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 217;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.Width = 150;
            // 
            // ViewCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(773, 460);
            this.Controls.Add(this.courseDetailedTablePanel);
            this.Controls.Add(this.classesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCourseForm";
            this.Text = "ViewCourseForm";
            this.courseDetailedTablePanel.ResumeLayout(false);
            this.CourseDetailsPanelTable.ResumeLayout(false);
            this.CourseDetailsPanelTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel courseDetailedTablePanel;
        private System.Windows.Forms.TableLayoutPanel CourseDetailsPanelTable;
        private System.Windows.Forms.Label courseDescription;
        private System.Windows.Forms.Label courseProgrammeLabel;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.Label courseTutorLabel;
        private System.Windows.Forms.Label courseCRNLabel;
        private System.Windows.Forms.Label courseSectionLabel;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader columnDay;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnLocation;
    }
}