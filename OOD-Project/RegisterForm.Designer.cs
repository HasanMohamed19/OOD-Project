namespace OOD_Project
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegisterAsTeacher = new System.Windows.Forms.Button();
            this.btnRegisterAsStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.RegisterContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.tableLayoutPanel1);
            this.panelHeader.Controls.Add(this.Title);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 113);
            this.panelHeader.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterAsTeacher, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterAsStudent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 50);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnRegisterAsTeacher
            // 
            this.btnRegisterAsTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnRegisterAsTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterAsTeacher.FlatAppearance.BorderSize = 0;
            this.btnRegisterAsTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAsTeacher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAsTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterAsTeacher.Location = new System.Drawing.Point(542, 4);
            this.btnRegisterAsTeacher.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnRegisterAsTeacher.Name = "btnRegisterAsTeacher";
            this.btnRegisterAsTeacher.Size = new System.Drawing.Size(222, 42);
            this.btnRegisterAsTeacher.TabIndex = 2;
            this.btnRegisterAsTeacher.Text = "Register as Teacher";
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
            this.btnRegisterAsStudent.Location = new System.Drawing.Point(281, 4);
            this.btnRegisterAsStudent.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnRegisterAsStudent.Name = "btnRegisterAsStudent";
            this.btnRegisterAsStudent.Size = new System.Drawing.Size(221, 42);
            this.btnRegisterAsStudent.TabIndex = 1;
            this.btnRegisterAsStudent.Text = "Register as Student";
            this.btnRegisterAsStudent.UseVisualStyleBackColor = false;
            this.btnRegisterAsStudent.Click += new System.EventHandler(this.btnRegisterAsStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(20, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(221, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back to Login";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(784, 63);
            this.Title.TabIndex = 0;
            this.Title.Text = "eLMS System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterContainer
            // 
            this.RegisterContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.RegisterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterContainer.Location = new System.Drawing.Point(0, 113);
            this.RegisterContainer.Name = "RegisterContainer";
            this.RegisterContainer.Size = new System.Drawing.Size(784, 348);
            this.RegisterContainer.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.RegisterContainer);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel RegisterContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegisterAsTeacher;
        private System.Windows.Forms.Button btnRegisterAsStudent;
    }
}