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
            this.emailDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.emailDG)).BeginInit();
            this.SuspendLayout();
            // 
            // emailDG
            // 
            this.emailDG.AllowUserToAddRows = false;
            this.emailDG.AllowUserToDeleteRows = false;
            this.emailDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDG.Location = new System.Drawing.Point(12, 12);
            this.emailDG.Name = "emailDG";
            this.emailDG.ReadOnly = true;
            this.emailDG.RowHeadersWidth = 51;
            this.emailDG.RowTemplate.Height = 24;
            this.emailDG.Size = new System.Drawing.Size(776, 426);
            this.emailDG.TabIndex = 0;
            // 
            // ViewEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailDG);
            this.Name = "ViewEmails";
            this.Text = "ViewEmails";
            ((System.ComponentModel.ISupportInitialize)(this.emailDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView emailDG;
    }
}