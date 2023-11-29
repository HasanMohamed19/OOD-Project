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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Code | Course",
            "Tutor Name"}, -1);
            this.coursesListView = new System.Windows.Forms.ListView();
            this.viewCoursesMainPanel = new System.Windows.Forms.Panel();
            this.courseDetailedPanel = new System.Windows.Forms.Panel();
            this.courseTitleDetailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.courseTitleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.courseCodeLabel = new System.Windows.Forms.Label();
            this.courseSectionLabel = new System.Windows.Forms.Label();
            this.courseCRNLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.courseTutorLabel = new System.Windows.Forms.Label();
            this.courseCreditsLabel = new System.Windows.Forms.Label();
            this.courseProgrammeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classDetailsPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.courseTutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewCoursesMainPanel.SuspendLayout();
            this.courseDetailedPanel.SuspendLayout();
            this.courseTitleDetailsPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.coursesListView.HoverSelection = true;
            this.coursesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.coursesListView.Location = new System.Drawing.Point(0, 0);
            this.coursesListView.Margin = new System.Windows.Forms.Padding(2);
            this.coursesListView.MultiSelect = false;
            this.coursesListView.Name = "coursesListView";
            this.coursesListView.Size = new System.Drawing.Size(184, 448);
            this.coursesListView.TabIndex = 6;
            this.coursesListView.TileSize = new System.Drawing.Size(180, 60);
            this.coursesListView.UseCompatibleStateImageBehavior = false;
            this.coursesListView.View = System.Windows.Forms.View.Tile;
            // 
            // viewCoursesMainPanel
            // 
            this.viewCoursesMainPanel.Controls.Add(this.courseDetailedPanel);
            this.viewCoursesMainPanel.Controls.Add(this.coursesListView);
            this.viewCoursesMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCoursesMainPanel.Location = new System.Drawing.Point(0, 0);
            this.viewCoursesMainPanel.Name = "viewCoursesMainPanel";
            this.viewCoursesMainPanel.Size = new System.Drawing.Size(689, 448);
            this.viewCoursesMainPanel.TabIndex = 7;
            // 
            // courseDetailedPanel
            // 
            this.courseDetailedPanel.Controls.Add(this.courseTitleDetailsPanel);
            this.courseDetailedPanel.Controls.Add(this.classDetailsPanel);
            this.courseDetailedPanel.Controls.Add(this.buttonPanel);
            this.courseDetailedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDetailedPanel.Location = new System.Drawing.Point(184, 0);
            this.courseDetailedPanel.Name = "courseDetailedPanel";
            this.courseDetailedPanel.Size = new System.Drawing.Size(505, 448);
            this.courseDetailedPanel.TabIndex = 7;
            // 
            // courseTitleDetailsPanel
            // 
            this.courseTitleDetailsPanel.Controls.Add(this.courseTitleLabel);
            this.courseTitleDetailsPanel.Controls.Add(this.flowLayoutPanel1);
            this.courseTitleDetailsPanel.Controls.Add(this.flowLayoutPanel2);
            this.courseTitleDetailsPanel.Controls.Add(this.flowLayoutPanel3);
            this.courseTitleDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseTitleDetailsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.courseTitleDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.courseTitleDetailsPanel.Name = "courseTitleDetailsPanel";
            this.courseTitleDetailsPanel.Size = new System.Drawing.Size(505, 234);
            this.courseTitleDetailsPanel.TabIndex = 0;
            // 
            // courseTitleLabel
            // 
            this.courseTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.courseTitleLabel.Name = "courseTitleLabel";
            this.courseTitleLabel.Size = new System.Drawing.Size(499, 35);
            this.courseTitleLabel.TabIndex = 1;
            this.courseTitleLabel.Text = "CourseTitle";
            this.courseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.courseCodeLabel);
            this.flowLayoutPanel1.Controls.Add(this.courseSectionLabel);
            this.flowLayoutPanel1.Controls.Add(this.courseCRNLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 36);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // courseCodeLabel
            // 
            this.courseCodeLabel.AutoSize = true;
            this.courseCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCodeLabel.Location = new System.Drawing.Point(35, 7);
            this.courseCodeLabel.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.courseCodeLabel.Name = "courseCodeLabel";
            this.courseCodeLabel.Size = new System.Drawing.Size(105, 20);
            this.courseCodeLabel.TabIndex = 0;
            this.courseCodeLabel.Text = "Code: IT0000";
            this.courseCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseSectionLabel
            // 
            this.courseSectionLabel.AutoSize = true;
            this.courseSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSectionLabel.Location = new System.Drawing.Point(205, 7);
            this.courseSectionLabel.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.courseSectionLabel.Name = "courseSectionLabel";
            this.courseSectionLabel.Size = new System.Drawing.Size(80, 20);
            this.courseSectionLabel.TabIndex = 1;
            this.courseSectionLabel.Text = "Section: 0";
            this.courseSectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCRNLabel
            // 
            this.courseCRNLabel.AutoSize = true;
            this.courseCRNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCRNLabel.Location = new System.Drawing.Point(350, 7);
            this.courseCRNLabel.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.courseCRNLabel.Name = "courseCRNLabel";
            this.courseCRNLabel.Size = new System.Drawing.Size(96, 20);
            this.courseCRNLabel.TabIndex = 2;
            this.courseCRNLabel.Text = "CRN: 43789";
            this.courseCRNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.courseTutorLabel);
            this.flowLayoutPanel2.Controls.Add(this.courseCreditsLabel);
            this.flowLayoutPanel2.Controls.Add(this.courseProgrammeLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 80);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(499, 36);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // courseTutorLabel
            // 
            this.courseTutorLabel.AutoSize = true;
            this.courseTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTutorLabel.Location = new System.Drawing.Point(35, 7);
            this.courseTutorLabel.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.courseTutorLabel.Name = "courseTutorLabel";
            this.courseTutorLabel.Size = new System.Drawing.Size(116, 20);
            this.courseTutorLabel.TabIndex = 0;
            this.courseTutorLabel.Text = "Tutor: Yousifito";
            this.courseTutorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCreditsLabel.Location = new System.Drawing.Point(186, 7);
            this.courseCreditsLabel.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(85, 20);
            this.courseCreditsLabel.TabIndex = 1;
            this.courseCreditsLabel.Text = "Credits: 15";
            this.courseCreditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // courseProgrammeLabel
            // 
            this.courseProgrammeLabel.AutoSize = true;
            this.courseProgrammeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseProgrammeLabel.Location = new System.Drawing.Point(306, 7);
            this.courseProgrammeLabel.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.courseProgrammeLabel.Name = "courseProgrammeLabel";
            this.courseProgrammeLabel.Size = new System.Drawing.Size(176, 20);
            this.courseProgrammeLabel.TabIndex = 2;
            this.courseProgrammeLabel.Text = "Programme: Samboosa";
            this.courseProgrammeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 122);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(499, 36);
            this.flowLayoutPanel3.TabIndex = 4;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code: IT0000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Section: 0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CRN: 43789";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // classDetailsPanel
            // 
            this.classDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.classDetailsPanel.Name = "classDetailsPanel";
            this.classDetailsPanel.Size = new System.Drawing.Size(505, 380);
            this.classDetailsPanel.TabIndex = 2;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 380);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(505, 68);
            this.buttonPanel.TabIndex = 0;
            // 
            // courseTutor
            // 
            this.courseTutor.DisplayIndex = 0;
            // 
            // courseName
            // 
            this.courseName.DisplayIndex = 1;
            // 
            // ViewCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 448);
            this.Controls.Add(this.viewCoursesMainPanel);
            this.Name = "ViewCoursesForm";
            this.Text = "ViewCoursesForm";
            this.viewCoursesMainPanel.ResumeLayout(false);
            this.courseDetailedPanel.ResumeLayout(false);
            this.courseTitleDetailsPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView coursesListView;
        private System.Windows.Forms.Panel viewCoursesMainPanel;
        private System.Windows.Forms.Panel courseDetailedPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Panel classDetailsPanel;
        private System.Windows.Forms.FlowLayoutPanel courseTitleDetailsPanel;
        private System.Windows.Forms.Label courseTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label courseCodeLabel;
        private System.Windows.Forms.Label courseSectionLabel;
        private System.Windows.Forms.Label courseCRNLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label courseTutorLabel;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.Label courseProgrammeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ColumnHeader courseTutor;
    }
}