namespace OOD_Project.Admin
{
    partial class AddUserForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegisterAsTeacher = new System.Windows.Forms.Button();
            this.btnRegisterAsStudent = new System.Windows.Forms.Button();
            this.addUserContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterAsTeacher, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterAsStudent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(75, 0, 75, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnRegisterAsTeacher
            // 
            this.btnRegisterAsTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnRegisterAsTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterAsTeacher.FlatAppearance.BorderSize = 0;
            this.btnRegisterAsTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAsTeacher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAsTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterAsTeacher.Location = new System.Drawing.Point(362, 4);
            this.btnRegisterAsTeacher.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnRegisterAsTeacher.Name = "btnRegisterAsTeacher";
            this.btnRegisterAsTeacher.Size = new System.Drawing.Size(227, 38);
            this.btnRegisterAsTeacher.TabIndex = 2;
            this.btnRegisterAsTeacher.Text = "Teacher";
            this.btnRegisterAsTeacher.UseVisualStyleBackColor = false;
            this.btnRegisterAsTeacher.Click += new System.EventHandler(this.btnRegisterAsTeacher_Click);
            // 
            // btnRegisterAsStudent
            // 
            this.btnRegisterAsStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnRegisterAsStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterAsStudent.FlatAppearance.BorderSize = 0;
            this.btnRegisterAsStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAsStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAsStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterAsStudent.Location = new System.Drawing.Point(95, 4);
            this.btnRegisterAsStudent.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnRegisterAsStudent.Name = "btnRegisterAsStudent";
            this.btnRegisterAsStudent.Size = new System.Drawing.Size(227, 38);
            this.btnRegisterAsStudent.TabIndex = 1;
            this.btnRegisterAsStudent.Text = "Student";
            this.btnRegisterAsStudent.UseVisualStyleBackColor = false;
            this.btnRegisterAsStudent.Click += new System.EventHandler(this.btnRegisterAsStudent_Click);
            // 
            // addUserContainer
            // 
            this.addUserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserContainer.Location = new System.Drawing.Point(0, 46);
            this.addUserContainer.Name = "addUserContainer";
            this.addUserContainer.Size = new System.Drawing.Size(684, 315);
            this.addUserContainer.TabIndex = 4;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.addUserContainer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRegisterAsTeacher;
        private System.Windows.Forms.Button btnRegisterAsStudent;
        private System.Windows.Forms.Panel addUserContainer;
    }
}