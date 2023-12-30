namespace OOD_Project.TeacherGroup.ViewCourses
{
    partial class ViewStudentsForm
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
            this.usersListControls = new System.Windows.Forms.FlowLayoutPanel();
            this.emailBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.publishBtn = new System.Windows.Forms.Button();
            this.studentsDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.usersListControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDG)).BeginInit();
            this.SuspendLayout();
            // 
            // usersListControls
            // 
            this.usersListControls.Controls.Add(this.emailBtn);
            this.usersListControls.Controls.Add(this.generateBtn);
            this.usersListControls.Controls.Add(this.publishBtn);
            this.usersListControls.Controls.Add(this.label1);
            this.usersListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersListControls.Location = new System.Drawing.Point(0, 0);
            this.usersListControls.Name = "usersListControls";
            this.usersListControls.Size = new System.Drawing.Size(773, 33);
            this.usersListControls.TabIndex = 7;
            // 
            // emailBtn
            // 
            this.emailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.emailBtn.FlatAppearance.BorderSize = 0;
            this.emailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.emailBtn.Location = new System.Drawing.Point(3, 3);
            this.emailBtn.Name = "emailBtn";
            this.emailBtn.Size = new System.Drawing.Size(156, 27);
            this.emailBtn.TabIndex = 3;
            this.emailBtn.TabStop = false;
            this.emailBtn.Text = "Email Student";
            this.emailBtn.UseVisualStyleBackColor = false;
            this.emailBtn.Click += new System.EventHandler(this.emailBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.generateBtn.Location = new System.Drawing.Point(165, 3);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(156, 27);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.TabStop = false;
            this.generateBtn.Text = "Generate Report";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // publishBtn
            // 
            this.publishBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.publishBtn.FlatAppearance.BorderSize = 0;
            this.publishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.publishBtn.Location = new System.Drawing.Point(327, 3);
            this.publishBtn.Name = "publishBtn";
            this.publishBtn.Size = new System.Drawing.Size(156, 27);
            this.publishBtn.TabIndex = 4;
            this.publishBtn.TabStop = false;
            this.publishBtn.Text = "Publish Report";
            this.publishBtn.UseVisualStyleBackColor = false;
            this.publishBtn.Click += new System.EventHandler(this.publishBtn_Click);
            // 
            // studentsDG
            // 
            this.studentsDG.AllowUserToAddRows = false;
            this.studentsDG.AllowUserToDeleteRows = false;
            this.studentsDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.studentsDG.Location = new System.Drawing.Point(0, 33);
            this.studentsDG.Margin = new System.Windows.Forms.Padding(2);
            this.studentsDG.MultiSelect = false;
            this.studentsDG.Name = "studentsDG";
            this.studentsDG.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsDG.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.studentsDG.RowTemplate.Height = 24;
            this.studentsDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.studentsDG.Size = new System.Drawing.Size(773, 427);
            this.studentsDG.TabIndex = 8;
            this.studentsDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDG_CellClick);
            this.studentsDG.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDG_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on a Grade cell to edit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(773, 460);
            this.Controls.Add(this.studentsDG);
            this.Controls.Add(this.usersListControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudentsForm";
            this.Text = "GradeStudentsForm";
            this.usersListControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel usersListControls;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button emailBtn;
        private System.Windows.Forms.DataGridView studentsDG;
        private System.Windows.Forms.Button publishBtn;
        private System.Windows.Forms.Label label1;
    }
}