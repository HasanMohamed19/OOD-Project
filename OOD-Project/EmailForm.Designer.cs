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
            this.deleteMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipientTxt
            // 
            this.recipientTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientTxt.Location = new System.Drawing.Point(39, 26);
            this.recipientTxt.Name = "recipientTxt";
            this.recipientTxt.Size = new System.Drawing.Size(613, 27);
            this.recipientTxt.TabIndex = 0;
            this.recipientTxt.Text = "To";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTxt.Location = new System.Drawing.Point(39, 66);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(613, 27);
            this.subjectTxt.TabIndex = 1;
            this.subjectTxt.Text = "Subject";
            // 
            // bodyText
            // 
            this.bodyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyText.Location = new System.Drawing.Point(39, 106);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(613, 399);
            this.bodyText.TabIndex = 2;
            this.bodyText.Text = "";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.White;
            this.btnSendEmail.Location = new System.Drawing.Point(39, 618);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(141, 45);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(186, 618);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(127, 45);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // attachmentsListView
            // 
            this.attachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName});
            this.attachmentsListView.HideSelection = false;
            this.attachmentsListView.Location = new System.Drawing.Point(39, 511);
            this.attachmentsListView.Name = "attachmentsListView";
            this.attachmentsListView.Size = new System.Drawing.Size(613, 91);
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
            this.deleteMenuStrip.Size = new System.Drawing.Size(211, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 683);
            this.Controls.Add(this.attachmentsListView);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.recipientTxt);
            this.Controls.Add(this.subjectTxt);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.deleteMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}