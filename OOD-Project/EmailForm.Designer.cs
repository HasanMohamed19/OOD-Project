namespace OOD_Project
{
    partial class EmailForm
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
            this.components = new System.ComponentModel.Container();
            this.recipientTxt = new System.Windows.Forms.TextBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.bodyText = new System.Windows.Forms.RichTextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.attachmentsListView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.deleteMenuStrip.SuspendLayout();
            this.emailTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipientTxt
            // 
            this.emailTableLayout.SetColumnSpan(this.recipientTxt, 2);
            this.recipientTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipientTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientTxt.Location = new System.Drawing.Point(18, 18);
            this.recipientTxt.Margin = new System.Windows.Forms.Padding(2);
            this.recipientTxt.Name = "recipientTxt";
            this.recipientTxt.Size = new System.Drawing.Size(462, 23);
            this.recipientTxt.TabIndex = 0;
            this.recipientTxt.Text = "To";
            this.recipientTxt.TextChanged += new System.EventHandler(this.recipientTxt_TextChanged);
            // 
            // subjectTxt
            // 
            this.emailTableLayout.SetColumnSpan(this.subjectTxt, 2);
            this.subjectTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTxt.Location = new System.Drawing.Point(18, 48);
            this.subjectTxt.Margin = new System.Windows.Forms.Padding(2);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(462, 23);
            this.subjectTxt.TabIndex = 1;
            this.subjectTxt.Text = "Subject";
            // 
            // bodyText
            // 
            this.emailTableLayout.SetColumnSpan(this.bodyText, 2);
            this.bodyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyText.Location = new System.Drawing.Point(18, 78);
            this.bodyText.Margin = new System.Windows.Forms.Padding(2);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(462, 326);
            this.bodyText.TabIndex = 2;
            this.bodyText.Text = "";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(57, 493);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(150, 40);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttach.Location = new System.Drawing.Point(290, 493);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(150, 40);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // attachmentsListView
            // 
            this.attachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName});
            this.emailTableLayout.SetColumnSpan(this.attachmentsListView, 2);
            this.attachmentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachmentsListView.HideSelection = false;
            this.attachmentsListView.Location = new System.Drawing.Point(18, 408);
            this.attachmentsListView.Margin = new System.Windows.Forms.Padding(2);
            this.attachmentsListView.Name = "attachmentsListView";
            this.attachmentsListView.Size = new System.Drawing.Size(462, 78);
            this.attachmentsListView.TabIndex = 12;
            this.attachmentsListView.UseCompatibleStateImageBehavior = false;
            this.attachmentsListView.View = System.Windows.Forms.View.SmallIcon;
            this.attachmentsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attachmentsListView_MouseClick);
            // 
            // deleteMenuStrip
            // 
            this.deleteMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deleteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.deleteMenuStrip.Name = "deleteMenuStrip";
            this.deleteMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // emailTableLayout
            // 
            this.emailTableLayout.ColumnCount = 2;
            this.emailTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emailTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.emailTableLayout.Controls.Add(this.recipientTxt, 0, 0);
            this.emailTableLayout.Controls.Add(this.subjectTxt, 0, 1);
            this.emailTableLayout.Controls.Add(this.btnAttach, 1, 4);
            this.emailTableLayout.Controls.Add(this.attachmentsListView, 0, 3);
            this.emailTableLayout.Controls.Add(this.btnSendEmail, 0, 4);
            this.emailTableLayout.Controls.Add(this.bodyText, 0, 2);
            this.emailTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTableLayout.Location = new System.Drawing.Point(0, 0);
            this.emailTableLayout.Name = "emailTableLayout";
            this.emailTableLayout.Padding = new System.Windows.Forms.Padding(16);
            this.emailTableLayout.RowCount = 5;
            this.emailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.emailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.emailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.emailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.emailTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.emailTableLayout.Size = new System.Drawing.Size(498, 555);
            this.emailTableLayout.TabIndex = 13;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(498, 555);
            this.Controls.Add(this.emailTableLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            this.deleteMenuStrip.ResumeLayout(false);
            this.emailTableLayout.ResumeLayout(false);
            this.emailTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox recipientTxt;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.RichTextBox bodyText;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListView attachmentsListView;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ContextMenuStrip deleteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel emailTableLayout;
    }
}