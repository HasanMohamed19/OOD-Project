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
            this.emailTabs = new System.Windows.Forms.TabControl();
            this.inboxTab = new System.Windows.Forms.TabPage();
            this.inboxPanel = new System.Windows.Forms.Panel();
            this.sentTab = new System.Windows.Forms.TabPage();
            this.sentPanel = new System.Windows.Forms.Panel();
            this.emailTabs.SuspendLayout();
            this.inboxTab.SuspendLayout();
            this.sentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailTabs
            // 
            this.emailTabs.Controls.Add(this.inboxTab);
            this.emailTabs.Controls.Add(this.sentTab);
            this.emailTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTabs.Location = new System.Drawing.Point(0, 0);
            this.emailTabs.Name = "emailTabs";
            this.emailTabs.SelectedIndex = 0;
            this.emailTabs.Size = new System.Drawing.Size(1178, 789);
            this.emailTabs.TabIndex = 0;
            this.emailTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.emailTabs_Selecting);
            // 
            // inboxTab
            // 
            this.inboxTab.Controls.Add(this.inboxPanel);
            this.inboxTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxTab.Location = new System.Drawing.Point(4, 25);
            this.inboxTab.Name = "inboxTab";
            this.inboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.inboxTab.Size = new System.Drawing.Size(1154, 677);
            this.inboxTab.TabIndex = 0;
            this.inboxTab.Text = "Inbox";
            this.inboxTab.UseVisualStyleBackColor = true;
            // 
            // inboxPanel
            // 
            this.inboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inboxPanel.Location = new System.Drawing.Point(3, 3);
            this.inboxPanel.Name = "inboxPanel";
            this.inboxPanel.Size = new System.Drawing.Size(1148, 671);
            this.inboxPanel.TabIndex = 0;
            // 
            // sentTab
            // 
            this.sentTab.Controls.Add(this.sentPanel);
            this.sentTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentTab.Location = new System.Drawing.Point(4, 25);
            this.sentTab.Name = "sentTab";
            this.sentTab.Padding = new System.Windows.Forms.Padding(3);
            this.sentTab.Size = new System.Drawing.Size(1170, 760);
            this.sentTab.TabIndex = 1;
            this.sentTab.Text = "Sent";
            this.sentTab.UseVisualStyleBackColor = true;
            // 
            // sentPanel
            // 
            this.sentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sentPanel.Location = new System.Drawing.Point(3, 3);
            this.sentPanel.Name = "sentPanel";
            this.sentPanel.Size = new System.Drawing.Size(1164, 754);
            this.sentPanel.TabIndex = 0;
            // 
            // ViewEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 789);
            this.Controls.Add(this.emailTabs);
            this.Name = "ViewEmailForm";
            this.Text = "ViewEmailForm";
            this.emailTabs.ResumeLayout(false);
            this.inboxTab.ResumeLayout(false);
            this.sentTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl emailTabs;
        private System.Windows.Forms.TabPage inboxTab;
        private System.Windows.Forms.TabPage sentTab;
        private System.Windows.Forms.Panel inboxPanel;
        private System.Windows.Forms.Panel sentPanel;
    }
}