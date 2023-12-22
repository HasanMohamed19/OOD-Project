
namespace OOD_Project.Admin
{
    partial class AddCourseForm
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
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.courseIDLbl = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.creditsLbl = new System.Windows.Forms.Label();
            this.programmeLbl = new System.Windows.Forms.Label();
            this.sectionCountLbl = new System.Windows.Forms.Label();
            this.txtProgramme = new System.Windows.Forms.TextBox();
            this.txtSectionCount = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCourse.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCourse.Location = new System.Drawing.Point(260, 541);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(511, 66);
            this.btnAddCourse.TabIndex = 37;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1045, 145);
            this.panelHeader.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1045, 78);
            this.label3.TabIndex = 38;
            this.label3.Text = "eLMS System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1045, 69);
            this.label2.TabIndex = 37;
            this.label2.Text = "Course Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.courseIDLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCourseID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.creditsLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.programmeLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sectionCountLbl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProgramme, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSectionCount, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLbl, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.courseNameLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCourseName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCredits, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 173);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 241);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // courseIDLbl
            // 
            this.courseIDLbl.AutoSize = true;
            this.courseIDLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDLbl.Location = new System.Drawing.Point(17, 12);
            this.courseIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseIDLbl.Name = "courseIDLbl";
            this.courseIDLbl.Size = new System.Drawing.Size(151, 45);
            this.courseIDLbl.TabIndex = 13;
            this.courseIDLbl.Text = "Course ID:";
            this.courseIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseID.Location = new System.Drawing.Point(176, 16);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(245, 37);
            this.txtCourseID.TabIndex = 9;
            // 
            // creditsLbl
            // 
            this.creditsLbl.AutoSize = true;
            this.creditsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLbl.Location = new System.Drawing.Point(17, 141);
            this.creditsLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(151, 88);
            this.creditsLbl.TabIndex = 16;
            this.creditsLbl.Text = "Credits:";
            this.creditsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // programmeLbl
            // 
            this.programmeLbl.AutoSize = true;
            this.programmeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programmeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeLbl.Location = new System.Drawing.Point(429, 12);
            this.programmeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programmeLbl.Name = "programmeLbl";
            this.programmeLbl.Size = new System.Drawing.Size(156, 45);
            this.programmeLbl.TabIndex = 18;
            this.programmeLbl.Text = "Programme:";
            this.programmeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionCountLbl
            // 
            this.sectionCountLbl.AutoSize = true;
            this.sectionCountLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionCountLbl.Location = new System.Drawing.Point(429, 82);
            this.sectionCountLbl.Margin = new System.Windows.Forms.Padding(4, 25, 4, 25);
            this.sectionCountLbl.Name = "sectionCountLbl";
            this.sectionCountLbl.Size = new System.Drawing.Size(156, 25);
            this.sectionCountLbl.TabIndex = 20;
            this.sectionCountLbl.Text = "Section Count:";
            this.sectionCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProgramme
            // 
            this.txtProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgramme.Location = new System.Drawing.Point(612, 16);
            this.txtProgramme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProgramme.Name = "txtProgramme";
            this.txtProgramme.Size = new System.Drawing.Size(245, 37);
            this.txtProgramme.TabIndex = 17;
            // 
            // txtSectionCount
            // 
            this.txtSectionCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSectionCount.Location = new System.Drawing.Point(612, 76);
            this.txtSectionCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSectionCount.Name = "txtSectionCount";
            this.txtSectionCount.Size = new System.Drawing.Size(245, 37);
            this.txtSectionCount.TabIndex = 19;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(429, 141);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(156, 88);
            this.descriptionLbl.TabIndex = 29;
            this.descriptionLbl.Text = "Description:";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.txtDescription);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(608, 139);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 83);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(4, 4);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 75);
            this.txtDescription.TabIndex = 32;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.Location = new System.Drawing.Point(17, 57);
            this.courseNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(151, 75);
            this.courseNameLbl.TabIndex = 14;
            this.courseNameLbl.Text = "Course Name:";
            this.courseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(176, 76);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(245, 37);
            this.txtCourseName.TabIndex = 10;
            // 
            // txtCredits
            // 
            this.txtCredits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(176, 136);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(245, 37);
            this.txtCredits.TabIndex = 15;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(97, 411);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(147, 25);
            this.lblCode.TabIndex = 43;
            this.lblCode.Text = "Course Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(252, 403);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(245, 37);
            this.txtCode.TabIndex = 42;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1045, 640);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnAddCourse);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Form";
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label courseIDLbl;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Label programmeLbl;
        private System.Windows.Forms.Label sectionCountLbl;
        private System.Windows.Forms.TextBox txtProgramme;
        private System.Windows.Forms.TextBox txtSectionCount;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}