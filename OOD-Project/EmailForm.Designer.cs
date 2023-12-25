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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentLbl = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel2.Controls.Add(this.ContentLbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtContent, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.toLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.subjectLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSubject, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(46, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(913, 356);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // ContentLbl
            // 
            this.ContentLbl.AutoSize = true;
            this.ContentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLbl.Location = new System.Drawing.Point(7, 68);
            this.ContentLbl.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ContentLbl.Name = "ContentLbl";
            this.ContentLbl.Size = new System.Drawing.Size(87, 25);
            this.ContentLbl.TabIndex = 2;
            this.ContentLbl.Text = "Content:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(118, 66);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(791, 286);
            this.txtContent.TabIndex = 4;
            // 
            // toLbl
            // 
            this.toLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLbl.AutoSize = true;
            this.toLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLbl.Location = new System.Drawing.Point(4, 3);
            this.toLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(42, 25);
            this.toLbl.TabIndex = 5;
            this.toLbl.Text = "To:";
            // 
            // subjectLbl
            // 
            this.subjectLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLbl.Location = new System.Drawing.Point(4, 34);
            this.subjectLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(84, 25);
            this.subjectLbl.TabIndex = 1;
            this.subjectLbl.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(118, 35);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(791, 22);
            this.txtSubject.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(118, 4);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(791, 22);
            this.txtTo.TabIndex = 6;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmail.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendEmail.Location = new System.Drawing.Point(263, 383);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(511, 66);
            this.btnSendEmail.TabIndex = 46;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ContentLbl;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSendEmail;
    }
}