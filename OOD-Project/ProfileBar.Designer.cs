namespace OOD_Project
{
    partial class ProfileBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProfile = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.btnNotificationBell = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::OOD_Project.Properties.Resources.userIcon;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(42, 15);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(2);
            this.btnProfile.Size = new System.Drawing.Size(36, 36);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(0, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(113, 66);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Student\r\nLong User Name";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNotificationBell
            // 
            this.btnNotificationBell.BackgroundImage = global::OOD_Project.Properties.Resources.bell_icon;
            this.btnNotificationBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotificationBell.FlatAppearance.BorderSize = 0;
            this.btnNotificationBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificationBell.Location = new System.Drawing.Point(2, 15);
            this.btnNotificationBell.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotificationBell.Name = "btnNotificationBell";
            this.btnNotificationBell.Size = new System.Drawing.Size(36, 36);
            this.btnNotificationBell.TabIndex = 4;
            this.btnNotificationBell.UseVisualStyleBackColor = true;
            this.btnNotificationBell.Click += new System.EventHandler(this.btnNotificationBell_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNotificationBell);
            this.flowLayoutPanel1.Controls.Add(this.btnProfile);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(113, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 66);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ProfileBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProfileBar";
            this.Size = new System.Drawing.Size(193, 66);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button btnNotificationBell;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
