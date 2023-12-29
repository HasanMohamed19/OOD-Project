namespace OOD_Project
{
    partial class ViewCoursesForm
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
            this.coursesListView = new System.Windows.Forms.ListView();
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseTutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewCoursesMainPanel = new System.Windows.Forms.Panel();
            this.courseDetailedPanel = new System.Windows.Forms.Panel();
            this.classDetailsPanel = new System.Windows.Forms.Panel();
            this.classesListView = new System.Windows.Forms.ListView();
            this.columnDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.contentClassBtn = new System.Windows.Forms.Button();
            this.emailBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.contentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewCoursesMainPanel.SuspendLayout();
            this.courseDetailedPanel.SuspendLayout();
            this.classDetailsPanel.SuspendLayout();
            this.courseDetailedTablePanel.SuspendLayout();
            this.CourseDetailsPanelTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.coursesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // viewCoursesMainPanel
            // 
            this.viewCoursesMainPanel.Controls.Add(this.tableLayoutPanel1);
            this.viewCoursesMainPanel.Controls.Add(this.courseDetailedPanel);
            this.viewCoursesMainPanel.Controls.Add(this.coursesListView);
            this.viewCoursesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCoursesMainPanel.Location = new System.Drawing.Point(0, 0);
            this.viewCoursesMainPanel.Name = "viewCoursesMainPanel";
            this.viewCoursesMainPanel.Size = new System.Drawing.Size(1008, 529);
            this.viewCoursesMainPanel.TabIndex = 7;
            // 
            // courseDetailedPanel
            // 
            this.courseDetailedPanel.Controls.Add(this.classDetailsPanel);
            this.courseDetailedPanel.Controls.Add(this.courseDetailedTablePanel);
            this.courseDetailedPanel.Controls.Add(this.buttonPanel);
            this.courseDetailedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDetailedPanel.Location = new System.Drawing.Point(235, 0);
            this.courseDetailedPanel.Name = "courseDetailedPanel";
            this.courseDetailedPanel.Size = new System.Drawing.Size(773, 529);
            this.courseDetailedPanel.TabIndex = 7;
            // 
            // classDetailsPanel
            // 
            this.classDetailsPanel.Controls.Add(this.contentListView);
            this.classDetailsPanel.Controls.Add(this.classesListView);
            this.classDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classDetailsPanel.Location = new System.Drawing.Point(0, 238);
            this.classDetailsPanel.Name = "classDetailsPanel";
            this.classDetailsPanel.Size = new System.Drawing.Size(773, 222);
            this.classDetailsPanel.TabIndex = 2;
            // 
            // classesListView
            // 
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDay,
            this.columnTime,
            this.columnLocation});
            this.classesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListView.FullRowSelect = true;
            this.classesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.classesListView.HideSelection = false;
            this.classesListView.Location = new System.Drawing.Point(0, 0);
            this.classesListView.MultiSelect = false;
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(773, 222);
            this.classesListView.TabIndex = 0;
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
            // courseDetailedTablePanel
            // 
            this.courseDetailedTablePanel.Controls.Add(this.CourseDetailsPanelTable);
            this.courseDetailedTablePanel.Controls.Add(this.courseTitleLabel);
            this.courseDetailedTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseDetailedTablePanel.Location = new System.Drawing.Point(0, 0);
            this.courseDetailedTablePanel.Name = "courseDetailedTablePanel";
            this.courseDetailedTablePanel.Size = new System.Drawing.Size(773, 238);
            this.courseDetailedTablePanel.TabIndex = 0;
            // 
            // CourseDetailsPanelTable
            // 
            this.CourseDetailsPanelTable.ColumnCount = 3;
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.CourseDetailsPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
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
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CourseDetailsPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.CourseDetailsPanelTable.Size = new System.Drawing.Size(773, 177);
            this.CourseDetailsPanelTable.TabIndex = 5;
            // 
            // courseDescription
            // 
            this.courseDescription.AutoSize = true;
            this.CourseDetailsPanelTable.SetColumnSpan(this.courseDescription, 3);
            this.courseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDescription.Location = new System.Drawing.Point(6, 90);
            this.courseDescription.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(149, 20);
            this.courseDescription.TabIndex = 0;
            this.courseDescription.Text = "No course selected.";
            this.courseDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseProgrammeLabel
            // 
            this.courseProgrammeLabel.AutoSize = true;
            this.courseProgrammeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseProgrammeLabel.Location = new System.Drawing.Point(486, 52);
            this.courseProgrammeLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseProgrammeLabel.Name = "courseProgrammeLabel";
            this.courseProgrammeLabel.Size = new System.Drawing.Size(125, 20);
            this.courseProgrammeLabel.TabIndex = 2;
            this.courseProgrammeLabel.Text = "Programme: N/A";
            this.courseProgrammeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCreditsLabel.Location = new System.Drawing.Point(301, 52);
            this.courseCreditsLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(93, 20);
            this.courseCreditsLabel.TabIndex = 1;
            this.courseCreditsLabel.Text = "Credits: N/A";
            this.courseCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseTutorLabel
            // 
            this.courseTutorLabel.AutoSize = true;
            this.courseTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTutorLabel.Location = new System.Drawing.Point(6, 50);
            this.courseTutorLabel.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseTutorLabel.Name = "courseTutorLabel";
            this.courseTutorLabel.Size = new System.Drawing.Size(80, 20);
            this.courseTutorLabel.TabIndex = 0;
            this.courseTutorLabel.Text = "Tutor: N/A";
            this.courseTutorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCRNLabel
            // 
            this.courseCRNLabel.AutoSize = true;
            this.courseCRNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCRNLabel.Location = new System.Drawing.Point(486, 12);
            this.courseCRNLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseCRNLabel.Name = "courseCRNLabel";
            this.courseCRNLabel.Size = new System.Drawing.Size(77, 20);
            this.courseCRNLabel.TabIndex = 2;
            this.courseCRNLabel.Text = "CRN: N/A";
            this.courseCRNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseSectionLabel
            // 
            this.courseSectionLabel.AutoSize = true;
            this.courseSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSectionLabel.Location = new System.Drawing.Point(301, 12);
            this.courseSectionLabel.Margin = new System.Windows.Forms.Padding(8, 12, 0, 0);
            this.courseSectionLabel.Name = "courseSectionLabel";
            this.courseSectionLabel.Size = new System.Drawing.Size(92, 20);
            this.courseSectionLabel.TabIndex = 1;
            this.courseSectionLabel.Text = "Grade:  N/A";
            this.courseSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLabel.Location = new System.Drawing.Point(6, 10);
            this.courseCodeLabel.Margin = new System.Windows.Forms.Padding(6, 10, 0, 0);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(81, 20);
            this.courseCodeLabel.TabIndex = 0;
            this.courseCodeLabel.Text = "Code: N/A";
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
            this.courseTitleLabel.Text = "No Course";
            this.courseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 460);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(773, 69);
            this.buttonPanel.TabIndex = 0;
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.feedbackBtn.Enabled = false;
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(11, 6);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(170, 56);
            this.feedbackBtn.TabIndex = 0;
            this.feedbackBtn.Text = "Send Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // contentClassBtn
            // 
            this.contentClassBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentClassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.contentClassBtn.Enabled = false;
            this.contentClassBtn.FlatAppearance.BorderSize = 0;
            this.contentClassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.contentClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contentClassBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentClassBtn.ForeColor = System.Drawing.Color.White;
            this.contentClassBtn.Location = new System.Drawing.Point(397, 6);
            this.contentClassBtn.Name = "contentClassBtn";
            this.contentClassBtn.Size = new System.Drawing.Size(170, 56);
            this.contentClassBtn.TabIndex = 2;
            this.contentClassBtn.Text = "View Content";
            this.contentClassBtn.UseVisualStyleBackColor = false;
            this.contentClassBtn.Click += new System.EventHandler(this.contentClassBtn_Click);
            // 
            // emailBtn
            // 
            this.emailBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.emailBtn.Enabled = false;
            this.emailBtn.FlatAppearance.BorderSize = 0;
            this.emailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.emailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBtn.ForeColor = System.Drawing.Color.White;
            this.emailBtn.Location = new System.Drawing.Point(204, 6);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(170, 56);
            this.emailBtn.TabIndex = 1;
            this.emailBtn.Text = "Email Tutor";
            this.emailBtn.UseVisualStyleBackColor = false;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.downloadBtn.FlatAppearance.BorderSize = 0;
            this.downloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.ForeColor = System.Drawing.Color.White;
            this.downloadBtn.Location = new System.Drawing.Point(591, 6);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(170, 56);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.Text = "Download File";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // contentListView
            // 
            this.contentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.contentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentListView.FullRowSelect = true;
            this.contentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contentListView.HideSelection = false;
            this.contentListView.Location = new System.Drawing.Point(0, 0);
            this.contentListView.MultiSelect = false;
            this.contentListView.Name = "contentListView";
            this.contentListView.Size = new System.Drawing.Size(773, 222);
            this.contentListView.TabIndex = 1;
            this.contentListView.UseCompatibleStateImageBehavior = false;
            this.contentListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File";
            this.columnHeader2.Width = 640;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.downloadBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentClassBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.feedbackBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 460);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 69);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ViewCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.viewCoursesMainPanel);
            this.Name = "ViewCoursesForm";
            this.Text = "ViewCoursesForm";
            this.viewCoursesMainPanel.ResumeLayout(false);
            this.courseDetailedPanel.ResumeLayout(false);
            this.classDetailsPanel.ResumeLayout(false);
            this.courseDetailedTablePanel.ResumeLayout(false);
            this.CourseDetailsPanelTable.ResumeLayout(false);
            this.CourseDetailsPanelTable.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView coursesListView;
        private System.Windows.Forms.Panel viewCoursesMainPanel;
        private System.Windows.Forms.Panel courseDetailedPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Panel classDetailsPanel;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label courseCRNLabel;
        private System.Windows.Forms.Label courseTutorLabel;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.Label courseProgrammeLabel;
        private System.Windows.Forms.Label courseDescription;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader courseTutor;
        private System.Windows.Forms.TableLayoutPanel CourseDetailsPanelTable;
        private System.Windows.Forms.Panel courseDetailedTablePanel;
        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader columnDay;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button contentClassBtn;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.Label courseSectionLabel;
        private System.Windows.Forms.ListView contentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}