
namespace OOD_Project
{
    partial class EmailTutor
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
            this.EmailTutorLabel = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.toLbl = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.ContentLbl = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailTutorLabel
            // 
            this.EmailTutorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailTutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTutorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.EmailTutorLabel.Location = new System.Drawing.Point(0, 0);
            this.EmailTutorLabel.Name = "EmailTutorLabel";
            this.EmailTutorLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.EmailTutorLabel.Size = new System.Drawing.Size(800, 61);
            this.EmailTutorLabel.TabIndex = 2;
            this.EmailTutorLabel.Text = "Email Tutor";
            this.EmailTutorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmail.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendEmail.Location = new System.Drawing.Point(198, 374);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(383, 54);
            this.btnSendEmail.TabIndex = 43;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(52, 64);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 289);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(88, 3);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(594, 20);
            this.txtTo.TabIndex = 6;
            // 
            // toLbl
            // 
            this.toLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toLbl.AutoSize = true;
            this.toLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLbl.Location = new System.Drawing.Point(3, 2);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(31, 20);
            this.toLbl.TabIndex = 5;
            this.toLbl.Text = "To:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(88, 28);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(594, 20);
            this.txtSubject.TabIndex = 3;
            // 
            // ContentLbl
            // 
            this.ContentLbl.AutoSize = true;
            this.ContentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLbl.Location = new System.Drawing.Point(5, 55);
            this.ContentLbl.Margin = new System.Windows.Forms.Padding(5);
            this.ContentLbl.Name = "ContentLbl";
            this.ContentLbl.Size = new System.Drawing.Size(70, 20);
            this.ContentLbl.TabIndex = 2;
            this.ContentLbl.Text = "Content:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(88, 53);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(594, 233);
            this.txtContent.TabIndex = 4;
            // 
            // subjectLbl
            // 
            this.subjectLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLbl.Location = new System.Drawing.Point(3, 27);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(67, 20);
            this.subjectLbl.TabIndex = 1;
            this.subjectLbl.Text = "Subject:";
            // 
            // EmailTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.EmailTutorLabel);
            this.Name = "EmailTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmailTutorLabel;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label ContentLbl;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label toLbl;
    }
}