namespace OOD_Project.Admin
{
    partial class AddAnouncementForm
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
            this.contentLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.btnPublishAnouncement = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.contentLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBody, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 359);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // contentLbl
            // 
            this.contentLbl.AutoSize = true;
            this.contentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLbl.Location = new System.Drawing.Point(17, 71);
            this.contentLbl.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(131, 276);
            this.contentLbl.TabIndex = 48;
            this.contentLbl.Text = "Content:";
            this.contentLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(17, 12);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(131, 50);
            this.titleLbl.TabIndex = 13;
            this.titleLbl.Text = "Title:";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(174, 18);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(748, 37);
            this.txtTitle.TabIndex = 47;
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(172, 68);
            this.txtBody.Margin = new System.Windows.Forms.Padding(20, 6, 20, 18);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(749, 259);
            this.txtBody.TabIndex = 46;
            this.txtBody.Text = "";
            // 
            // btnPublishAnouncement
            // 
            this.btnPublishAnouncement.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPublishAnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnPublishAnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublishAnouncement.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishAnouncement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPublishAnouncement.Location = new System.Drawing.Point(228, 374);
            this.btnPublishAnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.btnPublishAnouncement.Name = "btnPublishAnouncement";
            this.btnPublishAnouncement.Size = new System.Drawing.Size(511, 66);
            this.btnPublishAnouncement.TabIndex = 47;
            this.btnPublishAnouncement.Text = "Publish";
            this.btnPublishAnouncement.UseVisualStyleBackColor = false;
            this.btnPublishAnouncement.Click += new System.EventHandler(this.btnPublishAnouncement_Click);
            // 
            // AddAnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnPublishAnouncement);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddAnouncementForm";
            this.Text = "AddAnouncementForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label contentLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnPublishAnouncement;
    }
}