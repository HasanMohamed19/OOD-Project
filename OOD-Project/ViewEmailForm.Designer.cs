namespace OOD_Project
{
    partial class ViewEmailForm
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
            this.emailContainer = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inboxBtn = new System.Windows.Forms.Button();
            this.outboxBtn = new System.Windows.Forms.Button();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailContainer
            // 
            this.emailContainer.BackColor = System.Drawing.Color.Transparent;
            this.emailContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailContainer.Location = new System.Drawing.Point(0, 69);
            this.emailContainer.Margin = new System.Windows.Forms.Padding(2);
            this.emailContainer.Name = "emailContainer";
            this.emailContainer.Size = new System.Drawing.Size(1007, 459);
            this.emailContainer.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.inboxBtn);
            this.buttonPanel.Controls.Add(this.outboxBtn);
            this.buttonPanel.Controls.Add(this.sendEmailBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1007, 69);
            this.buttonPanel.TabIndex = 1;
            // 
            // inboxBtn
            // 
            this.inboxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.inboxBtn.FlatAppearance.BorderSize = 0;
            this.inboxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.inboxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inboxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxBtn.ForeColor = System.Drawing.Color.White;
            this.inboxBtn.Location = new System.Drawing.Point(3, 9);
            this.inboxBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.inboxBtn.Name = "inboxBtn";
            this.inboxBtn.Size = new System.Drawing.Size(150, 50);
            this.inboxBtn.TabIndex = 0;
            this.inboxBtn.Text = "Inbox";
            this.inboxBtn.UseVisualStyleBackColor = false;
            this.inboxBtn.Click += new System.EventHandler(this.inboxBtn_Click);
            // 
            // outboxBtn
            // 
            this.outboxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.outboxBtn.FlatAppearance.BorderSize = 0;
            this.outboxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.outboxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outboxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboxBtn.ForeColor = System.Drawing.Color.White;
            this.outboxBtn.Location = new System.Drawing.Point(159, 9);
            this.outboxBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.outboxBtn.Name = "outboxBtn";
            this.outboxBtn.Size = new System.Drawing.Size(150, 50);
            this.outboxBtn.TabIndex = 2;
            this.outboxBtn.Text = "Outbox";
            this.outboxBtn.UseVisualStyleBackColor = false;
            this.outboxBtn.Click += new System.EventHandler(this.outboxBtn_Click);
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.sendEmailBtn.FlatAppearance.BorderSize = 0;
            this.sendEmailBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(247)))));
            this.sendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailBtn.ForeColor = System.Drawing.Color.White;
            this.sendEmailBtn.Location = new System.Drawing.Point(315, 9);
            this.sendEmailBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(150, 50);
            this.sendEmailBtn.TabIndex = 1;
            this.sendEmailBtn.Text = "Send Email";
            this.sendEmailBtn.UseVisualStyleBackColor = false;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // ViewEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1007, 528);
            this.Controls.Add(this.emailContainer);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewEmailForm";
            this.Text = "ViewEmailForm";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel emailContainer;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button inboxBtn;
        private System.Windows.Forms.Button outboxBtn;
        private System.Windows.Forms.Button sendEmailBtn;
    }
}