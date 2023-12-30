﻿namespace OOD_Project.Admin
{
    partial class AddClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassForm));
            this.classPage = new System.Windows.Forms.TableLayoutPanel();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.comboDay = new System.Windows.Forms.ComboBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.classPage.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // classPage
            // 
            this.classPage.ColumnCount = 4;
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.classPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.classPage.Controls.Add(this.timeEnd, 1, 1);
            this.classPage.Controls.Add(this.comboDay, 1, 2);
            this.classPage.Controls.Add(this.txtRoom, 3, 1);
            this.classPage.Controls.Add(this.label5, 0, 2);
            this.classPage.Controls.Add(this.label1, 0, 1);
            this.classPage.Controls.Add(this.label3, 2, 1);
            this.classPage.Controls.Add(this.label4, 2, 0);
            this.classPage.Controls.Add(this.txtBuilding, 3, 0);
            this.classPage.Controls.Add(this.label7, 0, 0);
            this.classPage.Controls.Add(this.timeStart, 1, 0);
            this.classPage.Controls.Add(this.btnAdd, 0, 4);
            this.classPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classPage.Location = new System.Drawing.Point(0, 58);
            this.classPage.Margin = new System.Windows.Forms.Padding(0);
            this.classPage.Name = "classPage";
            this.classPage.Padding = new System.Windows.Forms.Padding(10);
            this.classPage.RowCount = 5;
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.classPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.classPage.Size = new System.Drawing.Size(729, 206);
            this.classPage.TabIndex = 44;
            // 
            // timeEnd
            // 
            this.timeEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeEnd.CustomFormat = "hh:mm tt";
            this.timeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeEnd.Location = new System.Drawing.Point(164, 53);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(185, 24);
            this.timeEnd.TabIndex = 53;
            this.timeEnd.Value = new System.DateTime(2023, 12, 29, 8, 0, 0, 0);
            // 
            // comboDay
            // 
            this.comboDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDay.FormattingEnabled = true;
            this.comboDay.Location = new System.Drawing.Point(164, 87);
            this.comboDay.Name = "comboDay";
            this.comboDay.Size = new System.Drawing.Size(185, 32);
            this.comboDay.TabIndex = 51;
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(543, 50);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(173, 31);
            this.txtRoom.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "Day:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "End Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Room Number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Building Number:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilding.Location = new System.Drawing.Point(543, 13);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(173, 31);
            this.txtBuilding.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Start Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeStart
            // 
            this.timeStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeStart.CustomFormat = "hh:mm tt";
            this.timeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeStart.Location = new System.Drawing.Point(164, 16);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(185, 24);
            this.timeStart.TabIndex = 52;
            this.timeStart.Value = new System.DateTime(2023, 12, 29, 8, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(166)))));
            this.classPage.SetColumnSpan(this.btnAdd, 4);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(238, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 54);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(221)))));
            this.panelHeader.Controls.Add(this.headerLbl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(729, 58);
            this.panelHeader.TabIndex = 45;
            // 
            // headerLbl
            // 
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(729, 58);
            this.headerLbl.TabIndex = 37;
            this.headerLbl.Text = "Class Form";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(729, 264);
            this.Controls.Add(this.classPage);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Class";
            this.classPage.ResumeLayout(false);
            this.classPage.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel classPage;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.ComboBox comboDay;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button btnAdd;
    }
}