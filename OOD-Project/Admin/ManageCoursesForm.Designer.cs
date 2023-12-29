
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.courseControls = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCourses = new System.Windows.Forms.Label();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.classDG = new System.Windows.Forms.DataGridView();
            this.classControls = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClass = new System.Windows.Forms.Label();
            this.addClass = new System.Windows.Forms.Button();
            this.editClass = new System.Windows.Forms.Button();
            this.deleteClass = new System.Windows.Forms.Button();
            this.courseDG = new System.Windows.Forms.DataGridView();
            this.btnPublishReport = new System.Windows.Forms.Button();
            this.courseControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDG)).BeginInit();
            this.classControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDG)).BeginInit();
            this.SuspendLayout();
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addCourseBtn.FlatAppearance.BorderSize = 0;
            this.addCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addCourseBtn.Location = new System.Drawing.Point(145, 4);
            this.addCourseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(100, 33);
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
            this.editCourseBtn.Location = new System.Drawing.Point(253, 4);
            this.editCourseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(100, 33);
            this.editCourseBtn.TabIndex = 1;
            this.editCourseBtn.Text = "Edit";
            this.editCourseBtn.UseVisualStyleBackColor = false;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // courseControls
            // 
            this.courseControls.Controls.Add(this.lblCourses);
            this.courseControls.Controls.Add(this.addCourseBtn);
            this.courseControls.Controls.Add(this.editCourseBtn);
            this.courseControls.Controls.Add(this.deleteCourseBtn);
            this.courseControls.Controls.Add(this.feedbackBtn);
            this.courseControls.Controls.Add(this.reportBtn);
            this.courseControls.Controls.Add(this.btnPublishReport);
            this.courseControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControls.Location = new System.Drawing.Point(4, 4);
            this.courseControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseControls.Name = "courseControls";
            this.courseControls.Size = new System.Drawing.Size(1336, 41);
            this.courseControls.TabIndex = 5;
            // 
            // lblCourses
            // 
            this.lblCourses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(4, 0);
            this.lblCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(133, 37);
            this.lblCourses.TabIndex = 4;
            this.lblCourses.Text = "Courses:";
            this.lblCourses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteCourseBtn.FlatAppearance.BorderSize = 0;
            this.deleteCourseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteCourseBtn.Location = new System.Drawing.Point(361, 4);
            this.deleteCourseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(100, 33);
            this.deleteCourseBtn.TabIndex = 2;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = false;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.feedbackBtn.Location = new System.Drawing.Point(469, 4);
            this.feedbackBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(177, 33);
            this.feedbackBtn.TabIndex = 5;
            this.feedbackBtn.Text = "View Feedback";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.reportBtn.Location = new System.Drawing.Point(654, 4);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(199, 33);
            this.reportBtn.TabIndex = 6;
            this.reportBtn.Text = "Download Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.classDG, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.classControls, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.courseDG, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseControls, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1344, 651);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // classDG
            // 
            this.classDG.AllowUserToAddRows = false;
            this.classDG.AllowUserToDeleteRows = false;
            this.classDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.classDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classDG.Location = new System.Drawing.Point(3, 431);
            this.classDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classDG.MultiSelect = false;
            this.classDG.Name = "classDG";
            this.classDG.ReadOnly = true;
            this.classDG.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDG.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.classDG.RowTemplate.Height = 24;
            this.classDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classDG.Size = new System.Drawing.Size(1338, 218);
            this.classDG.TabIndex = 11;
            // 
            // classControls
            // 
            this.classControls.Controls.Add(this.lblClass);
            this.classControls.Controls.Add(this.addClass);
            this.classControls.Controls.Add(this.editClass);
            this.classControls.Controls.Add(this.deleteClass);
            this.classControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.classControls.Location = new System.Drawing.Point(4, 384);
            this.classControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classControls.Name = "classControls";
            this.classControls.Size = new System.Drawing.Size(1336, 41);
            this.classControls.TabIndex = 10;
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(4, 0);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(133, 37);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Classes:";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addClass
            // 
            this.addClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addClass.FlatAppearance.BorderSize = 0;
            this.addClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addClass.Location = new System.Drawing.Point(145, 4);
            this.addClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(100, 33);
            this.addClass.TabIndex = 0;
            this.addClass.TabStop = false;
            this.addClass.Text = "Add";
            this.addClass.UseVisualStyleBackColor = false;
            this.addClass.Click += new System.EventHandler(this.addClass_Click);
            // 
            // editClass
            // 
            this.editClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editClass.FlatAppearance.BorderSize = 0;
            this.editClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editClass.Location = new System.Drawing.Point(253, 4);
            this.editClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editClass.Name = "editClass";
            this.editClass.Size = new System.Drawing.Size(100, 33);
            this.editClass.TabIndex = 1;
            this.editClass.Text = "Edit";
            this.editClass.UseVisualStyleBackColor = false;
            this.editClass.Click += new System.EventHandler(this.editClass_Click);
            // 
            // deleteClass
            // 
            this.deleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteClass.FlatAppearance.BorderSize = 0;
            this.deleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteClass.Location = new System.Drawing.Point(361, 4);
            this.deleteClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteClass.Name = "deleteClass";
            this.deleteClass.Size = new System.Drawing.Size(100, 33);
            this.deleteClass.TabIndex = 2;
            this.deleteClass.Text = "Delete";
            this.deleteClass.UseVisualStyleBackColor = false;
            this.deleteClass.Click += new System.EventHandler(this.deleteClass_Click);
            // 
            // courseDG
            // 
            this.courseDG.AllowUserToAddRows = false;
            this.courseDG.AllowUserToDeleteRows = false;
            this.courseDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.courseDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDG.Location = new System.Drawing.Point(3, 51);
            this.courseDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseDG.MultiSelect = false;
            this.courseDG.Name = "courseDG";
            this.courseDG.ReadOnly = true;
            this.courseDG.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDG.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.courseDG.RowTemplate.Height = 24;
            this.courseDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDG.Size = new System.Drawing.Size(1338, 327);
            this.courseDG.TabIndex = 9;
            this.courseDG.SelectionChanged += new System.EventHandler(this.courseDG_SelectionChanged);
            // 
            // btnPublishReport
            // 
            this.btnPublishReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnPublishReport.FlatAppearance.BorderSize = 0;
            this.btnPublishReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.btnPublishReport.Location = new System.Drawing.Point(861, 4);
            this.btnPublishReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublishReport.Name = "btnPublishReport";
            this.btnPublishReport.Size = new System.Drawing.Size(199, 33);
            this.btnPublishReport.TabIndex = 7;
            this.btnPublishReport.Text = "Publish Report";
            this.btnPublishReport.UseVisualStyleBackColor = false;
            this.btnPublishReport.Click += new System.EventHandler(this.btnPublishReport_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1344, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageCourseForm";
            this.Text = "Manage Courses";
            this.courseControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classDG)).EndInit();
            this.classControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.FlowLayoutPanel courseControls;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView courseDG;
        private System.Windows.Forms.FlowLayoutPanel classControls;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.Button editClass;
        private System.Windows.Forms.Button deleteClass;
        private System.Windows.Forms.DataGridView classDG;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button btnPublishReport;
    }
}