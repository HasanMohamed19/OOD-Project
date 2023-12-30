namespace OOD_Project.Admin
{
    partial class ViewFeedbackForm
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
            this.courseListView = new System.Windows.Forms.ListView();
            this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentListView = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.feedbackTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.lblA5 = new System.Windows.Forms.Label();
            this.lblQ5 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.feedbackTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseListView
            // 
            this.courseListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseName});
            this.courseListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.courseListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListView.FullRowSelect = true;
            this.courseListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.courseListView.HideSelection = false;
            this.courseListView.Location = new System.Drawing.Point(0, 0);
            this.courseListView.Margin = new System.Windows.Forms.Padding(2);
            this.courseListView.MultiSelect = false;
            this.courseListView.Name = "courseListView";
            this.courseListView.Size = new System.Drawing.Size(200, 529);
            this.courseListView.TabIndex = 7;
            this.courseListView.TileSize = new System.Drawing.Size(175, 90);
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Tile;
            this.courseListView.SelectedIndexChanged += new System.EventHandler(this.courseListView_SelectedIndexChanged);
            // 
            // courseName
            // 
            this.courseName.Width = 70;
            // 
            // studentListView
            // 
            this.studentListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.studentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName});
            this.studentListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListView.FullRowSelect = true;
            this.studentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.studentListView.HideSelection = false;
            this.studentListView.Location = new System.Drawing.Point(200, 0);
            this.studentListView.Margin = new System.Windows.Forms.Padding(2);
            this.studentListView.MultiSelect = false;
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(200, 529);
            this.studentListView.TabIndex = 8;
            this.studentListView.TileSize = new System.Drawing.Size(180, 90);
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.Tile;
            this.studentListView.SelectedIndexChanged += new System.EventHandler(this.studentListView_SelectedIndexChanged);
            // 
            // studentName
            // 
            this.studentName.Width = 70;
            // 
            // feedbackTable
            // 
            this.feedbackTable.ColumnCount = 2;
            this.feedbackTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedbackTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.feedbackTable.Controls.Add(this.lblSuggestions, 0, 7);
            this.feedbackTable.Controls.Add(this.lblA5, 1, 6);
            this.feedbackTable.Controls.Add(this.lblQ5, 0, 6);
            this.feedbackTable.Controls.Add(this.lblA4, 1, 5);
            this.feedbackTable.Controls.Add(this.lblQ4, 0, 5);
            this.feedbackTable.Controls.Add(this.lblA3, 1, 4);
            this.feedbackTable.Controls.Add(this.lblQ3, 0, 4);
            this.feedbackTable.Controls.Add(this.lblA2, 1, 3);
            this.feedbackTable.Controls.Add(this.lblQ2, 0, 3);
            this.feedbackTable.Controls.Add(this.lblQ1, 0, 2);
            this.feedbackTable.Controls.Add(this.lblA1, 1, 2);
            this.feedbackTable.Controls.Add(this.lblCourse, 1, 1);
            this.feedbackTable.Controls.Add(this.lblTitle, 0, 0);
            this.feedbackTable.Controls.Add(this.lblStudent, 0, 1);
            this.feedbackTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackTable.Location = new System.Drawing.Point(400, 0);
            this.feedbackTable.Name = "feedbackTable";
            this.feedbackTable.RowCount = 8;
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.56975F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8558F));
            this.feedbackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.29546F));
            this.feedbackTable.Size = new System.Drawing.Size(608, 529);
            this.feedbackTable.TabIndex = 9;
            // 
            // lblSuggestions
            // 
            this.feedbackTable.SetColumnSpan(this.lblSuggestions, 2);
            this.lblSuggestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSuggestions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestions.Location = new System.Drawing.Point(3, 413);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(602, 116);
            this.lblSuggestions.TabIndex = 14;
            this.lblSuggestions.Text = "Suggestion: \r\nGreat stuff!";
            // 
            // lblA5
            // 
            this.lblA5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA5.Location = new System.Drawing.Point(307, 356);
            this.lblA5.Name = "lblA5";
            this.lblA5.Size = new System.Drawing.Size(298, 57);
            this.lblA5.TabIndex = 13;
            this.lblA5.Text = "Answer:\r\nStrongly Satisfied";
            this.lblA5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ5
            // 
            this.lblQ5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQ5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ5.Location = new System.Drawing.Point(3, 356);
            this.lblQ5.Name = "lblQ5";
            this.lblQ5.Size = new System.Drawing.Size(298, 57);
            this.lblQ5.TabIndex = 12;
            this.lblQ5.Text = "Question 5: \r\nOverall, how satisfied are you with the course?";
            this.lblQ5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblA4
            // 
            this.lblA4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA4.Location = new System.Drawing.Point(307, 299);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(298, 57);
            this.lblA4.TabIndex = 11;
            this.lblA4.Text = "Answer:\r\nStrongly Satisfied";
            this.lblA4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ4
            // 
            this.lblQ4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQ4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ4.Location = new System.Drawing.Point(3, 299);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(298, 57);
            this.lblQ4.TabIndex = 10;
            this.lblQ4.Text = "Question 4: \r\nWas the course well-organized and easy to follow?";
            this.lblQ4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblA3
            // 
            this.lblA3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA3.Location = new System.Drawing.Point(307, 242);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(298, 57);
            this.lblA3.TabIndex = 9;
            this.lblA3.Text = "Answer:\r\nStrongly Satisfied";
            this.lblA3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ3
            // 
            this.lblQ3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQ3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3.Location = new System.Drawing.Point(3, 242);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(298, 57);
            this.lblQ3.TabIndex = 8;
            this.lblQ3.Text = "Question 3: \r\nWas the level of difficulty appropriate for your understanding?";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblA2
            // 
            this.lblA2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA2.Location = new System.Drawing.Point(307, 185);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(298, 57);
            this.lblA2.TabIndex = 7;
            this.lblA2.Text = "Answer:\r\nStrongly Satisfied";
            this.lblA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQ2
            // 
            this.lblQ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQ2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ2.Location = new System.Drawing.Point(3, 185);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(298, 57);
            this.lblQ2.TabIndex = 6;
            this.lblQ2.Text = "Question 2: \r\nWere the course materials (textbooks, handouts, online resources) h" +
    "elpful?";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQ1
            // 
            this.lblQ1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQ1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ1.Location = new System.Drawing.Point(3, 128);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(298, 57);
            this.lblQ1.TabIndex = 5;
            this.lblQ1.Text = "Question 1: \r\nWere the assessments reflective of the course content and learning " +
    "objectives?";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblA1
            // 
            this.lblA1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblA1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA1.Location = new System.Drawing.Point(307, 128);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(298, 57);
            this.lblA1.TabIndex = 4;
            this.lblA1.Text = "Answer:\r\nStrongly Satisfied";
            this.lblA1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCourse
            // 
            this.lblCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(307, 71);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(298, 57);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course: N/A";
            this.lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.feedbackTable.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(602, 71);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Feedback";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudent
            // 
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(3, 71);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(298, 57);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "Student: N/A";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.feedbackTable);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.courseListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFeedbackForm";
            this.Text = "ViewFeedbackForm";
            this.feedbackTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader courseName;
        private System.Windows.Forms.ListView studentListView;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.TableLayoutPanel feedbackTable;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblA5;
        private System.Windows.Forms.Label lblQ5;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Label lblSuggestions;
    }
}