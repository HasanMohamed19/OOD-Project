namespace OOD_Project.Admin
{
    partial class EditCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourseForm));
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.pagesContainer = new System.Windows.Forms.TableLayoutPanel();
            this.studentsPage = new System.Windows.Forms.TableLayoutPanel();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coursePage = new System.Windows.Forms.TableLayoutPanel();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.comboTeacher = new System.Windows.Forms.ComboBox();
            this.txtCRN = new System.Windows.Forms.TextBox();
            this.crnLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.capacityLbl = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.comboProgramme = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.creditsLbl = new System.Windows.Forms.Label();
            this.programmeLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bottomPnl.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.pagesContainer.SuspendLayout();
            this.studentsPage.SuspendLayout();
            this.coursePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPnl
            // 
            this.bottomPnl.Controls.Add(this.btnLeft);
            this.bottomPnl.Controls.Add(this.btnRight);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(0, 399);
            this.bottomPnl.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(972, 97);
            this.bottomPnl.TabIndex = 43;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeft.Location = new System.Drawing.Point(16, 16);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(336, 66);
            this.btnLeft.TabIndex = 38;
            this.btnLeft.Text = "Back";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRight.Location = new System.Drawing.Point(620, 16);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(336, 66);
            this.btnRight.TabIndex = 37;
            this.btnRight.Text = "Next";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.headerLbl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(972, 71);
            this.panelHeader.TabIndex = 44;
            // 
            // headerLbl
            // 
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(972, 71);
            this.headerLbl.TabIndex = 37;
            this.headerLbl.Text = "Course Form";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagesContainer
            // 
            this.pagesContainer.ColumnCount = 3;
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.Controls.Add(this.studentsPage, 1, 0);
            this.pagesContainer.Controls.Add(this.coursePage, 0, 0);
            this.pagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesContainer.Location = new System.Drawing.Point(0, 71);
            this.pagesContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pagesContainer.Name = "pagesContainer";
            this.pagesContainer.RowCount = 1;
            this.pagesContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.Size = new System.Drawing.Size(972, 328);
            this.pagesContainer.TabIndex = 45;
            // 
            // studentsPage
            // 
            this.studentsPage.ColumnCount = 2;
            this.studentsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentsPage.Controls.Add(this.studentsListView, 0, 0);
            this.studentsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsPage.Location = new System.Drawing.Point(972, 0);
            this.studentsPage.Margin = new System.Windows.Forms.Padding(0);
            this.studentsPage.MinimumSize = new System.Drawing.Size(972, 0);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.RowCount = 1;
            this.studentsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsPage.Size = new System.Drawing.Size(972, 328);
            this.studentsPage.TabIndex = 39;
            // 
            // studentsListView
            // 
            this.studentsListView.CheckBoxes = true;
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.studentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.HideSelection = false;
            this.studentsListView.Location = new System.Drawing.Point(4, 4);
            this.studentsListView.Margin = new System.Windows.Forms.Padding(4);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(963, 320);
            this.studentsListView.TabIndex = 58;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPR";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Major";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Programme";
            this.columnHeader5.Width = 180;
            // 
            // coursePage
            // 
            this.coursePage.ColumnCount = 4;
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.coursePage.Controls.Add(this.txtCredits, 3, 1);
            this.coursePage.Controls.Add(this.comboTeacher, 3, 3);
            this.coursePage.Controls.Add(this.txtCRN, 1, 3);
            this.coursePage.Controls.Add(this.crnLbl, 0, 3);
            this.coursePage.Controls.Add(this.teacherLbl, 2, 3);
            this.coursePage.Controls.Add(this.capacityLbl, 0, 4);
            this.coursePage.Controls.Add(this.txtCapacity, 1, 4);
            this.coursePage.Controls.Add(this.comboProgramme, 3, 0);
            this.coursePage.Controls.Add(this.txtCode, 1, 0);
            this.coursePage.Controls.Add(this.lblCode, 0, 0);
            this.coursePage.Controls.Add(this.creditsLbl, 2, 1);
            this.coursePage.Controls.Add(this.programmeLbl, 2, 0);
            this.coursePage.Controls.Add(this.descriptionLbl, 0, 2);
            this.coursePage.Controls.Add(this.courseNameLbl, 0, 1);
            this.coursePage.Controls.Add(this.txtCourseName, 1, 1);
            this.coursePage.Controls.Add(this.txtDescription, 1, 2);
            this.coursePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursePage.Location = new System.Drawing.Point(0, 0);
            this.coursePage.Margin = new System.Windows.Forms.Padding(0);
            this.coursePage.MaximumSize = new System.Drawing.Size(972, 0);
            this.coursePage.MinimumSize = new System.Drawing.Size(972, 0);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.coursePage.RowCount = 5;
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.Size = new System.Drawing.Size(972, 328);
            this.coursePage.TabIndex = 41;
            // 
            // txtCredits
            // 
            this.txtCredits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(694, 69);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(245, 37);
            this.txtCredits.TabIndex = 51;
            // 
            // comboTeacher
            // 
            this.comboTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(694, 238);
            this.comboTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(245, 37);
            this.comboTeacher.TabIndex = 50;
            // 
            // txtCRN
            // 
            this.txtCRN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRN.Location = new System.Drawing.Point(221, 234);
            this.txtCRN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(245, 37);
            this.txtCRN.TabIndex = 48;
            // 
            // crnLbl
            // 
            this.crnLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crnLbl.Location = new System.Drawing.Point(17, 239);
            this.crnLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.crnLbl.Name = "crnLbl";
            this.crnLbl.Size = new System.Drawing.Size(181, 44);
            this.crnLbl.TabIndex = 49;
            this.crnLbl.Text = "CRN:";
            this.crnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLbl.Location = new System.Drawing.Point(489, 230);
            this.teacherLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(181, 53);
            this.teacherLbl.TabIndex = 47;
            this.teacherLbl.Text = "Teacher:";
            this.teacherLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLbl.Location = new System.Drawing.Point(17, 283);
            this.capacityLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(181, 45);
            this.capacityLbl.TabIndex = 46;
            this.capacityLbl.Text = "Capacity:";
            this.capacityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(221, 287);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(245, 37);
            this.txtCapacity.TabIndex = 45;
            // 
            // comboProgramme
            // 
            this.comboProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Location = new System.Drawing.Point(694, 20);
            this.comboProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(245, 37);
            this.comboProgramme.TabIndex = 44;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(221, 16);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(245, 37);
            this.txtCode.TabIndex = 42;
            // 
            // lblCode
            // 
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(17, 21);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(181, 44);
            this.lblCode.TabIndex = 43;
            this.lblCode.Text = "Course Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsLbl
            // 
            this.creditsLbl.AutoSize = true;
            this.creditsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLbl.Location = new System.Drawing.Point(489, 74);
            this.creditsLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(181, 36);
            this.creditsLbl.TabIndex = 16;
            this.creditsLbl.Text = "Credits:";
            this.creditsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // programmeLbl
            // 
            this.programmeLbl.AutoSize = true;
            this.programmeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programmeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeLbl.Location = new System.Drawing.Point(489, 12);
            this.programmeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programmeLbl.Name = "programmeLbl";
            this.programmeLbl.Size = new System.Drawing.Size(181, 53);
            this.programmeLbl.TabIndex = 18;
            this.programmeLbl.Text = "Programme:";
            this.programmeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(17, 119);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(181, 111);
            this.descriptionLbl.TabIndex = 29;
            this.descriptionLbl.Text = "Description:";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.Location = new System.Drawing.Point(17, 65);
            this.courseNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(181, 45);
            this.courseNameLbl.TabIndex = 14;
            this.courseNameLbl.Text = "Course Name:";
            this.courseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(221, 69);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(245, 37);
            this.txtCourseName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.coursePage.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(219, 115);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(17, 5, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(719, 111);
            this.txtDescription.TabIndex = 32;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 496);
            this.Controls.Add(this.pagesContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.bottomPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCourseForm_FormClosing);
            this.bottomPnl.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.pagesContainer.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.coursePage.ResumeLayout(false);
            this.coursePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.TableLayoutPanel pagesContainer;
        private System.Windows.Forms.TableLayoutPanel studentsPage;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TableLayoutPanel coursePage;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.TextBox txtCRN;
        private System.Windows.Forms.Label crnLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Label programmeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}