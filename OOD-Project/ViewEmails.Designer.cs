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
            this.label1 = new System.Windows.Forms.Label();
            this.viewEmailPanel = new System.Windows.Forms.Panel();
            this.attachmentsListView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailBodyTxt = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.senderLbl = new System.Windows.Forms.Label();
            this.recipientLbl = new System.Windows.Forms.Label();
            this.downloadMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmailPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.downloadMenuStrip.SuspendLayout();
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
            this.emailsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailsListView.MultiSelect = false;
            this.emailsListView.Name = "emailsListView";
            this.emailsListView.Size = new System.Drawing.Size(297, 555);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select an item to read. Nothing is selected";
            // 
            // viewEmailPanel
            // 
            this.viewEmailPanel.Controls.Add(this.attachmentsListView);
            this.viewEmailPanel.Controls.Add(this.emailBodyTxt);
            this.viewEmailPanel.Controls.Add(this.flowLayoutPanel1);
            this.viewEmailPanel.Controls.Add(this.label1);
            this.viewEmailPanel.Location = new System.Drawing.Point(303, 0);
            this.viewEmailPanel.Name = "viewEmailPanel";
            this.viewEmailPanel.Size = new System.Drawing.Size(616, 555);
            this.viewEmailPanel.TabIndex = 9;
            // 
            // attachmentsListView
            // 
            this.attachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName});
            this.attachmentsListView.HideSelection = false;
            this.attachmentsListView.Location = new System.Drawing.Point(3, 452);
            this.attachmentsListView.Name = "attachmentsListView";
            this.attachmentsListView.Size = new System.Drawing.Size(608, 91);
            this.attachmentsListView.TabIndex = 11;
            this.attachmentsListView.UseCompatibleStateImageBehavior = false;
            this.attachmentsListView.View = System.Windows.Forms.View.SmallIcon;
            this.attachmentsListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.attachmentsListView_ItemMouseHover);
            this.attachmentsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attachmentsListView_MouseClick);
            // 
            // emailBodyTxt
            // 
            this.emailBodyTxt.Location = new System.Drawing.Point(3, 91);
            this.emailBodyTxt.Name = "emailBodyTxt";
            this.emailBodyTxt.ReadOnly = true;
            this.emailBodyTxt.Size = new System.Drawing.Size(608, 343);
            this.emailBodyTxt.TabIndex = 10;
            this.emailBodyTxt.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.senderLbl);
            this.flowLayoutPanel1.Controls.Add(this.recipientLbl);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 73);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // senderLbl
            // 
            this.senderLbl.AutoSize = true;
            this.senderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderLbl.Location = new System.Drawing.Point(3, 0);
            this.senderLbl.Name = "senderLbl";
            this.senderLbl.Padding = new System.Windows.Forms.Padding(0, 4, 0, 8);
            this.senderLbl.Size = new System.Drawing.Size(64, 37);
            this.senderLbl.TabIndex = 0;
            this.senderLbl.Text = "label2";
            // 
            // recipientLbl
            // 
            this.recipientLbl.AutoSize = true;
            this.recipientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLbl.Location = new System.Drawing.Point(3, 37);
            this.recipientLbl.Name = "recipientLbl";
            this.recipientLbl.Size = new System.Drawing.Size(64, 25);
            this.recipientLbl.TabIndex = 1;
            this.recipientLbl.Text = "label3";
            // 
            // downloadMenuStrip
            // 
            this.downloadMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.downloadMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.downloadMenuStrip.Name = "downloadMenuStrip";
            this.downloadMenuStrip.Size = new System.Drawing.Size(211, 56);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // ViewEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 555);
            this.Controls.Add(this.viewEmailPanel);
            this.Controls.Add(this.emailsListView);
            this.Name = "ViewEmails";
            this.Text = "ViewEmails";
            this.viewEmailPanel.ResumeLayout(false);
            this.viewEmailPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.downloadMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView emailsListView;
        private System.Windows.Forms.ColumnHeader emailSender;
        private System.Windows.Forms.ColumnHeader emailSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel viewEmailPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox emailBodyTxt;
        private System.Windows.Forms.Label senderLbl;
        private System.Windows.Forms.Label recipientLbl;
        private System.Windows.Forms.ListView attachmentsListView;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ContextMenuStrip downloadMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
    }
}