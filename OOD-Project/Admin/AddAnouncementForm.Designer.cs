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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnouncementForm));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 87);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 292);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // contentLbl
            // 
            this.contentLbl.AutoSize = true;
            this.contentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLbl.Location = new System.Drawing.Point(13, 57);
            this.contentLbl.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.contentLbl.Name = "contentLbl";
            this.contentLbl.Size = new System.Drawing.Size(98, 225);
            this.contentLbl.TabIndex = 48;
            this.contentLbl.Text = "Content:";
            this.contentLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(13, 10);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(98, 40);
            this.titleLbl.TabIndex = 13;
            this.titleLbl.Text = "Title:";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(130, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(562, 31);
            this.txtTitle.TabIndex = 47;
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(129, 55);
            this.txtBody.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(563, 211);
            this.txtBody.TabIndex = 46;
            this.txtBody.Text = "";
            // 
            // btnPublishAnouncement
            // 
            this.btnPublishAnouncement.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPublishAnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.btnPublishAnouncement.FlatAppearance.BorderSize = 0;
            this.btnPublishAnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublishAnouncement.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishAnouncement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPublishAnouncement.Location = new System.Drawing.Point(307, 465);
            this.btnPublishAnouncement.Name = "btnPublishAnouncement";
            this.btnPublishAnouncement.Size = new System.Drawing.Size(383, 54);
            this.btnPublishAnouncement.TabIndex = 47;
            this.btnPublishAnouncement.Text = "Publish";
            this.btnPublishAnouncement.UseVisualStyleBackColor = false;
            this.btnPublishAnouncement.Click += new System.EventHandler(this.btnPublishAnouncement_Click);
            // 
            // AddAnouncementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.btnPublishAnouncement);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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