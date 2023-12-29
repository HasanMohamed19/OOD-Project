namespace OOD_Project
{
    partial class ViewAnnouncementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAnnouncementsForm));
            this.announcementsListView = new System.Windows.Forms.ListView();
            this.announcementTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.announcementType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.announcementTitleLbl = new System.Windows.Forms.Label();
            this.announcementBodyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // announcementsListView
            // 
            this.announcementsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.announcementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.announcementTitle,
            this.announcementType});
            this.announcementsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.announcementsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementsListView.FullRowSelect = true;
            this.announcementsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.announcementsListView.HideSelection = false;
            this.announcementsListView.Location = new System.Drawing.Point(0, 0);
            this.announcementsListView.Margin = new System.Windows.Forms.Padding(2);
            this.announcementsListView.MaximumSize = new System.Drawing.Size(220, 529);
            this.announcementsListView.MultiSelect = false;
            this.announcementsListView.Name = "announcementsListView";
            this.announcementsListView.Size = new System.Drawing.Size(220, 529);
            this.announcementsListView.TabIndex = 7;
            this.announcementsListView.TileSize = new System.Drawing.Size(198, 90);
            this.announcementsListView.UseCompatibleStateImageBehavior = false;
            this.announcementsListView.View = System.Windows.Forms.View.Tile;
            this.announcementsListView.SelectedIndexChanged += new System.EventHandler(this.announcementsListView_SelectedIndexChanged);
            // 
            // announcementTitle
            // 
            this.announcementTitle.Width = 70;
            // 
            // announcementTitleLbl
            // 
            this.announcementTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.announcementTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.announcementTitleLbl.Location = new System.Drawing.Point(220, 0);
            this.announcementTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.announcementTitleLbl.Name = "announcementTitleLbl";
            this.announcementTitleLbl.Size = new System.Drawing.Size(788, 65);
            this.announcementTitleLbl.TabIndex = 50;
            this.announcementTitleLbl.Text = "Announcement";
            this.announcementTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // announcementBodyLbl
            // 
            this.announcementBodyLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.announcementBodyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announcementBodyLbl.Location = new System.Drawing.Point(220, 65);
            this.announcementBodyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.announcementBodyLbl.Name = "announcementBodyLbl";
            this.announcementBodyLbl.Padding = new System.Windows.Forms.Padding(10);
            this.announcementBodyLbl.Size = new System.Drawing.Size(788, 464);
            this.announcementBodyLbl.TabIndex = 51;
            this.announcementBodyLbl.Text = resources.GetString("announcementBodyLbl.Text");
            // 
            // ViewAnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1008, 529);
            this.Controls.Add(this.announcementBodyLbl);
            this.Controls.Add(this.announcementTitleLbl);
            this.Controls.Add(this.announcementsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewAnnouncementsForm";
            this.Text = "ViewAnnouncementsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView announcementsListView;
        private System.Windows.Forms.ColumnHeader announcementTitle;
        private System.Windows.Forms.Label announcementTitleLbl;
        private System.Windows.Forms.Label announcementBodyLbl;
        private System.Windows.Forms.ColumnHeader announcementType;
    }
}