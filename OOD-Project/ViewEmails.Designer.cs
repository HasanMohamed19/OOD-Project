namespace OOD_Project
{
    partial class ViewEmails
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
            this.emailsListView = new System.Windows.Forms.ListView();
            this.emailSender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nothingLbl = new System.Windows.Forms.Label();
            this.viewEmailPanel = new System.Windows.Forms.Panel();
            this.emailSubjetLbl = new System.Windows.Forms.Label();
            this.attachmentsListView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailBodyTxt = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.senderLbl = new System.Windows.Forms.Label();
            this.recipientLbl = new System.Windows.Forms.Label();
            this.downloadMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTableView = new System.Windows.Forms.TableLayoutPanel();
            this.viewEmailPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.downloadMenuStrip.SuspendLayout();
            this.emailTableView.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailsListView
            // 
            this.emailsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.emailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emailSender,
            this.emailSubject});
            this.emailsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.emailsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailsListView.FullRowSelect = true;
            this.emailsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.emailsListView.HideSelection = false;
            this.emailsListView.Location = new System.Drawing.Point(0, 0);
            this.emailsListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailsListView.MultiSelect = false;
            this.emailsListView.Name = "emailsListView";
            this.emailsListView.Size = new System.Drawing.Size(194, 498);
            this.emailsListView.TabIndex = 7;
            this.emailsListView.TileSize = new System.Drawing.Size(200, 90);
            this.emailsListView.UseCompatibleStateImageBehavior = false;
            this.emailsListView.View = System.Windows.Forms.View.Tile;
            this.emailsListView.SelectedIndexChanged += new System.EventHandler(this.emailsListView_SelectedIndexChanged);
            // 
            // emailSender
            // 
            this.emailSender.DisplayIndex = 1;
            // 
            // emailSubject
            // 
            this.emailSubject.DisplayIndex = 0;
            // 
            // nothingLbl
            // 
            this.nothingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothingLbl.Location = new System.Drawing.Point(4, 9);
            this.nothingLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nothingLbl.Name = "nothingLbl";
            this.nothingLbl.Size = new System.Drawing.Size(485, 33);
            this.nothingLbl.TabIndex = 8;
            this.nothingLbl.Text = "Select an item to read. Nothing is selected";
            this.nothingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewEmailPanel
            // 
            this.viewEmailPanel.Controls.Add(this.emailTableView);
            this.viewEmailPanel.Controls.Add(this.nothingLbl);
            this.viewEmailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEmailPanel.Location = new System.Drawing.Point(194, 0);
            this.viewEmailPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewEmailPanel.Name = "viewEmailPanel";
            this.viewEmailPanel.Size = new System.Drawing.Size(801, 498);
            this.viewEmailPanel.TabIndex = 9;
            // 
            // emailSubjetLbl
            // 
            this.emailSubjetLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailSubjetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSubjetLbl.Location = new System.Drawing.Point(2, 0);
            this.emailSubjetLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailSubjetLbl.Name = "emailSubjetLbl";
            this.emailSubjetLbl.Size = new System.Drawing.Size(797, 49);
            this.emailSubjetLbl.TabIndex = 12;
            this.emailSubjetLbl.Text = "Title";
            this.emailSubjetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attachmentsListView
            // 
            this.attachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName});
            this.attachmentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachmentsListView.HideSelection = false;
            this.attachmentsListView.Location = new System.Drawing.Point(2, 398);
            this.attachmentsListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attachmentsListView.Name = "attachmentsListView";
            this.attachmentsListView.Size = new System.Drawing.Size(797, 98);
            this.attachmentsListView.TabIndex = 11;
            this.attachmentsListView.UseCompatibleStateImageBehavior = false;
            this.attachmentsListView.View = System.Windows.Forms.View.SmallIcon;
            this.attachmentsListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.attachmentsListView_ItemMouseHover);
            this.attachmentsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attachmentsListView_MouseClick);
            // 
            // emailBodyTxt
            // 
            this.emailBodyTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.emailBodyTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBodyTxt.Location = new System.Drawing.Point(2, 110);
            this.emailBodyTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailBodyTxt.Name = "emailBodyTxt";
            this.emailBodyTxt.ReadOnly = true;
            this.emailBodyTxt.Size = new System.Drawing.Size(797, 284);
            this.emailBodyTxt.TabIndex = 10;
            this.emailBodyTxt.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.senderLbl);
            this.flowLayoutPanel1.Controls.Add(this.recipientLbl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 51);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(797, 55);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // senderLbl
            // 
            this.senderLbl.AutoSize = true;
            this.senderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderLbl.Location = new System.Drawing.Point(2, 0);
            this.senderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.senderLbl.Name = "senderLbl";
            this.senderLbl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 6);
            this.senderLbl.Size = new System.Drawing.Size(50, 29);
            this.senderLbl.TabIndex = 0;
            this.senderLbl.Text = "From:";
            // 
            // recipientLbl
            // 
            this.recipientLbl.AutoSize = true;
            this.recipientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLbl.Location = new System.Drawing.Point(2, 29);
            this.recipientLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recipientLbl.Name = "recipientLbl";
            this.recipientLbl.Size = new System.Drawing.Size(31, 20);
            this.recipientLbl.TabIndex = 1;
            this.recipientLbl.Text = "To:";
            // 
            // downloadMenuStrip
            // 
            this.downloadMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downloadMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.downloadMenuStrip.Name = "downloadMenuStrip";
            this.downloadMenuStrip.Size = new System.Drawing.Size(129, 26);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // emailTableView
            // 
            this.emailTableView.ColumnCount = 1;
            this.emailTableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.emailTableView.Controls.Add(this.emailSubjetLbl, 0, 0);
            this.emailTableView.Controls.Add(this.attachmentsListView, 0, 3);
            this.emailTableView.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.emailTableView.Controls.Add(this.emailBodyTxt, 0, 2);
            this.emailTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTableView.Location = new System.Drawing.Point(0, 0);
            this.emailTableView.Name = "emailTableView";
            this.emailTableView.RowCount = 4;
            this.emailTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.emailTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.emailTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.emailTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.emailTableView.Size = new System.Drawing.Size(801, 498);
            this.emailTableView.TabIndex = 13;
            // 
            // ViewEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(995, 498);
            this.Controls.Add(this.viewEmailPanel);
            this.Controls.Add(this.emailsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewEmails";
            this.Text = "ViewEmails";
            this.viewEmailPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.downloadMenuStrip.ResumeLayout(false);
            this.emailTableView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView emailsListView;
        private System.Windows.Forms.ColumnHeader emailSender;
        private System.Windows.Forms.ColumnHeader emailSubject;
        private System.Windows.Forms.Label nothingLbl;
        private System.Windows.Forms.Panel viewEmailPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox emailBodyTxt;
        private System.Windows.Forms.Label senderLbl;
        private System.Windows.Forms.Label recipientLbl;
        private System.Windows.Forms.ListView attachmentsListView;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ContextMenuStrip downloadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.Label emailSubjetLbl;
        private System.Windows.Forms.TableLayoutPanel emailTableView;
    }
}