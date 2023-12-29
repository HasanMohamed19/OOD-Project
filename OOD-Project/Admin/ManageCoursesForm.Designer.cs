
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.courseControls = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.classDG = new System.Windows.Forms.DataGridView();
            this.classControls = new System.Windows.Forms.FlowLayoutPanel();
            this.addClass = new System.Windows.Forms.Button();
            this.editClass = new System.Windows.Forms.Button();
            this.deleteClass = new System.Windows.Forms.Button();
            this.courseDG = new System.Windows.Forms.DataGridView();
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
            // courseControls
            // 
            this.courseControls.Controls.Add(this.addCourseBtn);
            this.courseControls.Controls.Add(this.editCourseBtn);
            this.courseControls.Controls.Add(this.deleteCourseBtn);
            this.courseControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControls.Location = new System.Drawing.Point(3, 3);
            this.courseControls.Name = "courseControls";
            this.courseControls.Size = new System.Drawing.Size(1002, 33);
            this.courseControls.TabIndex = 5;
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 529);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // classDG
            // 
            this.classDG.AllowUserToAddRows = false;
            this.classDG.AllowUserToDeleteRows = false;
            this.classDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.classDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classDG.Location = new System.Drawing.Point(2, 350);
            this.classDG.Margin = new System.Windows.Forms.Padding(2);
            this.classDG.MultiSelect = false;
            this.classDG.Name = "classDG";
            this.classDG.ReadOnly = true;
            this.classDG.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDG.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.classDG.RowTemplate.Height = 24;
            this.classDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classDG.Size = new System.Drawing.Size(1004, 177);
            this.classDG.TabIndex = 11;
            // 
            // classControls
            // 
            this.classControls.Controls.Add(this.addClass);
            this.classControls.Controls.Add(this.editClass);
            this.classControls.Controls.Add(this.deleteClass);
            this.classControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.classControls.Location = new System.Drawing.Point(3, 312);
            this.classControls.Name = "classControls";
            this.classControls.Size = new System.Drawing.Size(1002, 33);
            this.classControls.TabIndex = 10;
            // 
            // addClass
            // 
            this.addClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.addClass.FlatAppearance.BorderSize = 0;
            this.addClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.addClass.Location = new System.Drawing.Point(3, 3);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(75, 27);
            this.addClass.TabIndex = 0;
            this.addClass.TabStop = false;
            this.addClass.Text = "Add";
            this.addClass.UseVisualStyleBackColor = false;
            // 
            // editClass
            // 
            this.editClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.editClass.FlatAppearance.BorderSize = 0;
            this.editClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.editClass.Location = new System.Drawing.Point(84, 3);
            this.editClass.Name = "editClass";
            this.editClass.Size = new System.Drawing.Size(75, 27);
            this.editClass.TabIndex = 1;
            this.editClass.Text = "Edit";
            this.editClass.UseVisualStyleBackColor = false;
            // 
            // deleteClass
            // 
            this.deleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.deleteClass.FlatAppearance.BorderSize = 0;
            this.deleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.deleteClass.Location = new System.Drawing.Point(165, 3);
            this.deleteClass.Name = "deleteClass";
            this.deleteClass.Size = new System.Drawing.Size(75, 27);
            this.deleteClass.TabIndex = 2;
            this.deleteClass.Text = "Delete";
            this.deleteClass.UseVisualStyleBackColor = false;
            // 
            // courseDG
            // 
            this.courseDG.AllowUserToAddRows = false;
            this.courseDG.AllowUserToDeleteRows = false;
            this.courseDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.courseDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDG.Location = new System.Drawing.Point(2, 41);
            this.courseDG.Margin = new System.Windows.Forms.Padding(2);
            this.courseDG.MultiSelect = false;
            this.courseDG.Name = "courseDG";
            this.courseDG.ReadOnly = true;
            this.courseDG.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDG.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.courseDG.RowTemplate.Height = 24;
            this.courseDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDG.Size = new System.Drawing.Size(1004, 266);
            this.courseDG.TabIndex = 9;
            this.courseDG.SelectionChanged += new System.EventHandler(this.courseDG_SelectionChanged);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}