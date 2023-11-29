
namespace OOD_Project.Admin
{
    partial class ManageCourseForm
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
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.courseListView = new System.Windows.Forms.ListView();
            this.courseIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.programmeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sectionCountCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addCourseBtn.FlatAppearance.BorderSize = 0;
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addCourseBtn.Location = new System.Drawing.Point(3, 3);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(75, 27);
            this.addCourseBtn.TabIndex = 0;
            this.addCourseBtn.TabStop = false;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editCourseBtn.FlatAppearance.BorderSize = 0;
            this.editCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editCourseBtn.Location = new System.Drawing.Point(84, 3);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(75, 27);
            this.editCourseBtn.TabIndex = 1;
            this.editCourseBtn.Text = "Edit";
            this.editCourseBtn.UseVisualStyleBackColor = false;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.addCourseBtn);
            this.usersListControls.Controls.Add(this.editCourseBtn);
            this.usersListControls.Controls.Add(this.deleteCourseBtn);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(600, 33);
            this.usersListControls.TabIndex = 5;
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteCourseBtn.FlatAppearance.BorderSize = 0;
            this.deleteCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteCourseBtn.Location = new System.Drawing.Point(165, 3);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(75, 27);
            this.deleteCourseBtn.TabIndex = 2;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = false;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // courseListView
            // 
            this.courseListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.courseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseIDCol,
            this.courseNameCol,
            this.creditsColumn,
            this.programmeColumn,
            this.sectionCountCol,
            this.descriptionColumn});
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
            this.courseListView.Size = new System.Drawing.Size(600, 333);
            this.courseListView.TabIndex = 6;
            this.courseListView.UseCompatibleStateImageBehavior = false;
            this.courseListView.View = System.Windows.Forms.View.Details;
            // 
            // courseIDCol
            // 
            this.courseIDCol.Text = "Course ID";
            this.courseIDCol.Width = 113;
            // 
            // courseNameCol
            // 
            this.courseNameCol.Text = "Course Name";
            this.courseNameCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseNameCol.Width = 133;
            // 
            // creditsColumn
            // 
            this.creditsColumn.Text = "Credits";
            this.creditsColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.creditsColumn.Width = 86;
            // 
            // programmeColumn
            // 
            this.programmeColumn.Text = "Programme";
            this.programmeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.programmeColumn.Width = 130;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionColumn.Width = 200;
            // 
            // sectionCountCol
            // 
            this.sectionCountCol.Text = "Section Count";
            this.sectionCountCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sectionCountCol.Width = 132;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.courseListView);
            this.Controls.Add(this.usersListControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageCourseForm";
            this.Text = "Manage Courses";
            this.Load += new System.EventHandler(this.ManageCourse_Load);
            this.usersListControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.ListView courseListView;
        private System.Windows.Forms.ColumnHeader courseIDCol;
        private System.Windows.Forms.ColumnHeader courseNameCol;
        private System.Windows.Forms.ColumnHeader creditsColumn;
        private System.Windows.Forms.ColumnHeader programmeColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.ColumnHeader sectionCountCol;
    }
}