
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
            this.btnRight = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
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
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pagesContainer = new System.Windows.Forms.TableLayoutPanel();
            this.studentsPage = new System.Windows.Forms.TableLayoutPanel();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classPage = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.classesListView = new System.Windows.Forms.ListView();
            this.class0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.class5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHeader.SuspendLayout();
            this.coursePage.SuspendLayout();
            this.bottomPnl.SuspendLayout();
            this.pagesContainer.SuspendLayout();
            this.studentsPage.SuspendLayout();
            this.classPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRight.Location = new System.Drawing.Point(465, 13);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(252, 54);
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
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(729, 58);
            this.panelHeader.TabIndex = 40;
            // 
            // headerLbl
            // 
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(729, 58);
            this.headerLbl.TabIndex = 37;
            this.headerLbl.Text = "Course Form";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.coursePage.MaximumSize = new System.Drawing.Size(729, 0);
            this.coursePage.MinimumSize = new System.Drawing.Size(729, 0);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(10);
            this.coursePage.RowCount = 5;
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.Size = new System.Drawing.Size(729, 266);
            this.coursePage.TabIndex = 41;
            // 
            // txtCredits
            // 
            this.txtCredits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(519, 51);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(185, 31);
            this.txtCredits.TabIndex = 51;
            // 
            // comboTeacher
            // 
            this.comboTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(519, 186);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(185, 32);
            this.comboTeacher.TabIndex = 50;
            // 
            // txtCRN
            // 
            this.txtCRN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCRN.Location = new System.Drawing.Point(164, 186);
            this.txtCRN.Name = "txtCRN";
            this.txtCRN.Size = new System.Drawing.Size(185, 31);
            this.txtCRN.TabIndex = 48;
            // 
            // crnLbl
            // 
            this.crnLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crnLbl.Location = new System.Drawing.Point(13, 190);
            this.crnLbl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.crnLbl.Name = "crnLbl";
            this.crnLbl.Size = new System.Drawing.Size(135, 31);
            this.crnLbl.TabIndex = 49;
            this.crnLbl.Text = "CRN:";
            this.crnLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLbl.Location = new System.Drawing.Point(366, 183);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(135, 38);
            this.teacherLbl.TabIndex = 47;
            this.teacherLbl.Text = "Teacher:";
            this.teacherLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacityLbl
            // 
            this.capacityLbl.AutoSize = true;
            this.capacityLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLbl.Location = new System.Drawing.Point(13, 221);
            this.capacityLbl.Name = "capacityLbl";
            this.capacityLbl.Size = new System.Drawing.Size(135, 37);
            this.capacityLbl.TabIndex = 46;
            this.capacityLbl.Text = "Capacity:";
            this.capacityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(164, 224);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(185, 31);
            this.txtCapacity.TabIndex = 45;
            // 
            // comboProgramme
            // 
            this.comboProgramme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Location = new System.Drawing.Point(519, 13);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(185, 32);
            this.comboProgramme.TabIndex = 44;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(164, 13);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 31);
            this.txtCode.TabIndex = 42;
            // 
            // lblCode
            // 
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(13, 17);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(135, 31);
            this.lblCode.TabIndex = 43;
            this.lblCode.Text = "Course Code:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsLbl
            // 
            this.creditsLbl.AutoSize = true;
            this.creditsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLbl.Location = new System.Drawing.Point(366, 55);
            this.creditsLbl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(135, 30);
            this.creditsLbl.TabIndex = 16;
            this.creditsLbl.Text = "Credits:";
            this.creditsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // programmeLbl
            // 
            this.programmeLbl.AutoSize = true;
            this.programmeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programmeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmeLbl.Location = new System.Drawing.Point(366, 10);
            this.programmeLbl.Name = "programmeLbl";
            this.programmeLbl.Size = new System.Drawing.Size(135, 38);
            this.programmeLbl.TabIndex = 18;
            this.programmeLbl.Text = "Programme:";
            this.programmeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLbl.Location = new System.Drawing.Point(13, 92);
            this.descriptionLbl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(135, 91);
            this.descriptionLbl.TabIndex = 29;
            this.descriptionLbl.Text = "Description:";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.Location = new System.Drawing.Point(13, 48);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(135, 37);
            this.courseNameLbl.TabIndex = 14;
            this.courseNameLbl.Text = "Course Name:";
            this.courseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(164, 51);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(185, 31);
            this.txtCourseName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.coursePage.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(164, 89);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(13, 4, 3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(540, 91);
            this.txtDescription.TabIndex = 32;
            // 
            // bottomPnl
            // 
            this.bottomPnl.Controls.Add(this.btnLeft);
            this.bottomPnl.Controls.Add(this.btnRight);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(0, 324);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(729, 79);
            this.bottomPnl.TabIndex = 42;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLeft.Location = new System.Drawing.Point(12, 13);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(252, 54);
            this.btnLeft.TabIndex = 38;
            this.btnLeft.Text = "Back";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // pagesContainer
            // 
            this.pagesContainer.ColumnCount = 3;
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.Controls.Add(this.studentsPage, 2, 0);
            this.pagesContainer.Controls.Add(this.classPage, 1, 0);
            this.pagesContainer.Controls.Add(this.coursePage, 0, 0);
            this.pagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesContainer.Location = new System.Drawing.Point(0, 58);
            this.pagesContainer.Name = "pagesContainer";
            this.pagesContainer.RowCount = 1;
            this.pagesContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.Size = new System.Drawing.Size(729, 266);
            this.pagesContainer.TabIndex = 39;
            // 
            // studentsPage
            // 
            this.studentsPage.ColumnCount = 2;
            this.studentsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentsPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentsPage.Controls.Add(this.studentsListView, 0, 0);
            this.studentsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsPage.Location = new System.Drawing.Point(729, 0);
            this.studentsPage.Margin = new System.Windows.Forms.Padding(0);
            this.studentsPage.MinimumSize = new System.Drawing.Size(729, 0);
            this.studentsPage.Name = "studentsPage";
            this.studentsPage.RowCount = 1;
            this.studentsPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsPage.Size = new System.Drawing.Size(729, 266);
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
            this.studentsListView.Location = new System.Drawing.Point(3, 3);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(723, 260);
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
            // classPage
            // 
            this.classPage.ColumnCount = 4;
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.classPage.Controls.Add(this.btnDeleteClass, 3, 2);
            this.classPage.Controls.Add(this.btnAddClass, 2, 2);
            this.classPage.Controls.Add(this.timeEnd, 1, 1);
            this.classPage.Controls.Add(this.comboDay, 1, 2);
            this.classPage.Controls.Add(this.txtRoom, 3, 1);
            this.classPage.Controls.Add(this.label5, 0, 2);
            this.classPage.Controls.Add(this.label1, 0, 1);
            this.classPage.Controls.Add(this.label3, 2, 1);
            this.classPage.Controls.Add(this.label4, 2, 0);
            this.classPage.Controls.Add(this.txtBuilding, 3, 0);
            this.classPage.Controls.Add(this.label7, 0, 0);
            this.classPage.Controls.Add(this.timeStart, 1, 0);
            this.classPage.Controls.Add(this.classesListView, 0, 4);
            this.classPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classPage.Location = new System.Drawing.Point(729, 0);
            this.classPage.Margin = new System.Windows.Forms.Padding(0);
            this.classPage.MaximumSize = new System.Drawing.Size(729, 0);
            this.classPage.MinimumSize = new System.Drawing.Size(729, 0);
            this.classPage.Name = "classPage";
            this.classPage.Padding = new System.Windows.Forms.Padding(10);
            this.classPage.RowCount = 5;
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.classPage.Size = new System.Drawing.Size(729, 266);
            this.classPage.TabIndex = 43;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnDeleteClass.FlatAppearance.BorderSize = 0;
            this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteClass.Location = new System.Drawing.Point(543, 88);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(173, 31);
            this.btnDeleteClass.TabIndex = 56;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddClass.Location = new System.Drawing.Point(366, 88);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(171, 31);
            this.btnAddClass.TabIndex = 55;
            this.btnAddClass.Text = "Add";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeEnd.CustomFormat = "hh:mm tt";
            this.timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(164, 53);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(185, 24);
            this.timeEnd.TabIndex = 53;
            this.timeEnd.Value = new System.DateTime(2023, 12, 29, 8, 0, 0, 0);
            // 
            // comboDay
            // 
            this.comboDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(164, 87);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(185, 32);
            this.comboDay.TabIndex = 51;
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(543, 50);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(173, 31);
            this.txtRoom.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "Day:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "End Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Room Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Building Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.Location = new System.Drawing.Point(543, 13);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(173, 31);
            this.txtBuilding.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Start Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeStart
            // 
            this.timeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStart.CustomFormat = "hh:mm tt";
            this.timeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(164, 16);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(185, 24);
            this.timeStart.TabIndex = 52;
            this.timeStart.Value = new System.DateTime(2023, 12, 29, 8, 0, 0, 0);
            // 
            // classesListView
            // 
            this.classesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.class0,
            this.class1,
            this.class2,
            this.class3,
            this.class4,
            this.class5});
            this.classPage.SetColumnSpan(this.classesListView, 4);
            this.classesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesListView.FullRowSelect = true;
            this.classesListView.HideSelection = false;
            this.classesListView.Location = new System.Drawing.Point(13, 125);
            this.classesListView.MultiSelect = false;
            this.classesListView.Name = "classesListView";
            this.classesListView.Size = new System.Drawing.Size(703, 128);
            this.classesListView.TabIndex = 57;
            this.classesListView.UseCompatibleStateImageBehavior = false;
            this.classesListView.View = System.Windows.Forms.View.Details;
            // 
            // class0
            // 
            this.class0.Text = "ID";
            this.class0.Width = 50;
            // 
            // class1
            // 
            this.class1.Text = "Start Time";
            this.class1.Width = 120;
            // 
            // class2
            // 
            this.class2.Text = "End Time";
            this.class2.Width = 120;
            // 
            // class3
            // 
            this.class3.Text = "Day";
            this.class3.Width = 120;
            // 
            // class4
            // 
            this.class4.Text = "Building";
            this.class4.Width = 75;
            // 
            // class5
            // 
            this.class5.Text = "Room";
            this.class5.Width = 80;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(729, 403);
            this.Controls.Add(this.pagesContainer);
            this.Controls.Add(this.bottomPnl);
            this.Controls.Add(this.panelHeader);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCourseForm_FormClosing);
            this.panelHeader.ResumeLayout(false);
            this.coursePage.ResumeLayout(false);
            this.coursePage.PerformLayout();
            this.bottomPnl.ResumeLayout(false);
            this.pagesContainer.ResumeLayout(false);
            this.studentsPage.ResumeLayout(false);
            this.classPage.ResumeLayout(false);
            this.classPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.TableLayoutPanel coursePage;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Label programmeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.TableLayoutPanel pagesContainer;
        private System.Windows.Forms.TableLayoutPanel classPage;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.TextBox txtCRN;
        private System.Windows.Forms.Label crnLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label capacityLbl;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.ListView classesListView;
        private System.Windows.Forms.ColumnHeader class1;
        private System.Windows.Forms.ColumnHeader class2;
        private System.Windows.Forms.ColumnHeader class3;
        private System.Windows.Forms.ColumnHeader class4;
        private System.Windows.Forms.ColumnHeader class5;
        private System.Windows.Forms.ColumnHeader class0;
        private System.Windows.Forms.TableLayoutPanel studentsPage;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}