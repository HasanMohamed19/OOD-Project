
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
            this.label2 = new System.Windows.Forms.Label();
            this.coursePage = new System.Windows.Forms.TableLayoutPanel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.creditsLbl = new System.Windows.Forms.Label();
            this.programmeLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMajor = new System.Windows.Forms.ComboBox();
            this.pagesContainer = new System.Windows.Forms.TableLayoutPanel();
            this.sectionPage = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.classPage = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.coursePage.SuspendLayout();
            this.bottomPnl.SuspendLayout();
            this.pagesContainer.SuspendLayout();
            this.sectionPage.SuspendLayout();
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
            this.btnRight.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(729, 58);
            this.panelHeader.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 58);
            this.label2.TabIndex = 37;
            this.label2.Text = "Course Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coursePage
            // 
            this.coursePage.AutoSize = true;
            this.coursePage.ColumnCount = 4;
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.coursePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.coursePage.Controls.Add(this.comboMajor, 3, 0);
            this.coursePage.Controls.Add(this.txtCode, 1, 0);
            this.coursePage.Controls.Add(this.lblCode, 0, 0);
            this.coursePage.Controls.Add(this.creditsLbl, 2, 1);
            this.coursePage.Controls.Add(this.programmeLbl, 2, 0);
            this.coursePage.Controls.Add(this.descriptionLbl, 0, 2);
            this.coursePage.Controls.Add(this.courseNameLbl, 0, 1);
            this.coursePage.Controls.Add(this.txtCourseName, 1, 1);
            this.coursePage.Controls.Add(this.txtCredits, 3, 1);
            this.coursePage.Controls.Add(this.txtDescription, 1, 2);
            this.coursePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coursePage.Location = new System.Drawing.Point(0, 0);
            this.coursePage.Margin = new System.Windows.Forms.Padding(0);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(10);
            this.coursePage.RowCount = 3;
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.coursePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.coursePage.Size = new System.Drawing.Size(729, 199);
            this.coursePage.TabIndex = 41;
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
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(13, 17);
            this.lblCode.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(118, 20);
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
            this.descriptionLbl.Size = new System.Drawing.Size(135, 97);
            this.descriptionLbl.TabIndex = 29;
            this.descriptionLbl.Text = "Description:";
            this.descriptionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // txtCredits
            // 
            this.txtCredits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(519, 51);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(185, 31);
            this.txtCredits.TabIndex = 15;
            // 
            // bottomPnl
            // 
            this.bottomPnl.Controls.Add(this.button1);
            this.bottomPnl.Controls.Add(this.btnRight);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(0, 257);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(729, 79);
            this.bottomPnl.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 54);
            this.button1.TabIndex = 38;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboMajor
            // 
            this.comboMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMajor.FormattingEnabled = true;
            this.comboMajor.Location = new System.Drawing.Point(519, 13);
            this.comboMajor.Name = "comboMajor";
            this.comboMajor.Size = new System.Drawing.Size(185, 32);
            this.comboMajor.TabIndex = 44;
            // 
            // pagesContainer
            // 
            this.pagesContainer.ColumnCount = 3;
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.pagesContainer.Controls.Add(this.classPage, 2, 0);
            this.pagesContainer.Controls.Add(this.sectionPage, 1, 0);
            this.pagesContainer.Controls.Add(this.coursePage, 0, 0);
            this.pagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagesContainer.Location = new System.Drawing.Point(0, 58);
            this.pagesContainer.Name = "pagesContainer";
            this.pagesContainer.RowCount = 1;
            this.pagesContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagesContainer.Size = new System.Drawing.Size(729, 199);
            this.pagesContainer.TabIndex = 39;
            // 
            // sectionPage
            // 
            this.sectionPage.AutoSize = true;
            this.sectionPage.ColumnCount = 4;
            this.sectionPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sectionPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.sectionPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.sectionPage.Controls.Add(this.comboBox1, 3, 0);
            this.sectionPage.Controls.Add(this.textBox1, 1, 0);
            this.sectionPage.Controls.Add(this.label1, 0, 0);
            this.sectionPage.Controls.Add(this.label3, 2, 1);
            this.sectionPage.Controls.Add(this.label4, 2, 0);
            this.sectionPage.Controls.Add(this.label5, 0, 2);
            this.sectionPage.Controls.Add(this.label6, 0, 1);
            this.sectionPage.Controls.Add(this.textBox2, 1, 1);
            this.sectionPage.Controls.Add(this.textBox3, 3, 1);
            this.sectionPage.Controls.Add(this.textBox4, 1, 2);
            this.sectionPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionPage.Location = new System.Drawing.Point(729, 0);
            this.sectionPage.Margin = new System.Windows.Forms.Padding(0);
            this.sectionPage.Name = "sectionPage";
            this.sectionPage.Padding = new System.Windows.Forms.Padding(10);
            this.sectionPage.RowCount = 3;
            this.sectionPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sectionPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sectionPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sectionPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sectionPage.Size = new System.Drawing.Size(1, 199);
            this.sectionPage.TabIndex = 42;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1, 32);
            this.comboBox1.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 31);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Course Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Credits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 38);
            this.label4.TabIndex = 18;
            this.label4.Text = "Programme:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 97);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Course Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1, 31);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 31);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.sectionPage.SetColumnSpan(this.textBox4, 3);
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(23, 89);
            this.textBox4.Margin = new System.Windows.Forms.Padding(13, 4, 3, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1, 91);
            this.textBox4.TabIndex = 32;
            // 
            // classPage
            // 
            this.classPage.AutoSize = true;
            this.classPage.ColumnCount = 4;
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.classPage.Controls.Add(this.comboBox2, 3, 0);
            this.classPage.Controls.Add(this.textBox5, 1, 0);
            this.classPage.Controls.Add(this.label7, 0, 0);
            this.classPage.Controls.Add(this.label8, 2, 1);
            this.classPage.Controls.Add(this.label9, 2, 0);
            this.classPage.Controls.Add(this.label10, 0, 2);
            this.classPage.Controls.Add(this.label11, 0, 1);
            this.classPage.Controls.Add(this.textBox6, 1, 1);
            this.classPage.Controls.Add(this.textBox7, 3, 1);
            this.classPage.Controls.Add(this.textBox8, 1, 2);
            this.classPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classPage.Location = new System.Drawing.Point(729, 0);
            this.classPage.Margin = new System.Windows.Forms.Padding(0);
            this.classPage.Name = "classPage";
            this.classPage.Padding = new System.Windows.Forms.Padding(10);
            this.classPage.RowCount = 3;
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.classPage.Size = new System.Drawing.Size(1, 199);
            this.classPage.TabIndex = 43;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1, 32);
            this.comboBox2.TabIndex = 44;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(13, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1, 31);
            this.textBox5.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Course Code:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Credits:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 38);
            this.label9.TabIndex = 18;
            this.label9.Text = "Programme:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1, 97);
            this.label10.TabIndex = 29;
            this.label10.Text = "Description:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 37);
            this.label11.TabIndex = 14;
            this.label11.Text = "Course Name:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(13, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(1, 31);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(13, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1, 31);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.classPage.SetColumnSpan(this.textBox8, 3);
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(23, 89);
            this.textBox8.Margin = new System.Windows.Forms.Padding(13, 4, 3, 3);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1, 91);
            this.textBox8.TabIndex = 32;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(729, 336);
            this.Controls.Add(this.pagesContainer);
            this.Controls.Add(this.bottomPnl);
            this.Controls.Add(this.panelHeader);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.panelHeader.ResumeLayout(false);
            this.coursePage.ResumeLayout(false);
            this.coursePage.PerformLayout();
            this.bottomPnl.ResumeLayout(false);
            this.pagesContainer.ResumeLayout(false);
            this.pagesContainer.PerformLayout();
            this.sectionPage.ResumeLayout(false);
            this.sectionPage.PerformLayout();
            this.classPage.ResumeLayout(false);
            this.classPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel coursePage;
        private System.Windows.Forms.Label creditsLbl;
        private System.Windows.Forms.Label programmeLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboMajor;
        private System.Windows.Forms.TableLayoutPanel pagesContainer;
        private System.Windows.Forms.TableLayoutPanel classPage;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TableLayoutPanel sectionPage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}