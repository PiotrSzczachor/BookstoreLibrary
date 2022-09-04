﻿namespace BookstoreLibrary.GUI
{
    partial class UsersManagementForm
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
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.UsersTypeLabel = new System.Windows.Forms.Label();
            this.DaleteButton = new System.Windows.Forms.Button();
            this.ShowHistoryButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ShowAddressButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTable
            // 
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Location = new System.Drawing.Point(12, 65);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.Size = new System.Drawing.Size(776, 339);
            this.UsersTable.TabIndex = 0;
            // 
            // UsersTypeLabel
            // 
            this.UsersTypeLabel.AutoSize = true;
            this.UsersTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsersTypeLabel.Location = new System.Drawing.Point(387, 43);
            this.UsersTypeLabel.Name = "UsersTypeLabel";
            this.UsersTypeLabel.Size = new System.Drawing.Size(52, 18);
            this.UsersTypeLabel.TabIndex = 1;
            this.UsersTypeLabel.Text = "label1";
            // 
            // DaleteButton
            // 
            this.DaleteButton.Location = new System.Drawing.Point(506, 410);
            this.DaleteButton.Name = "DaleteButton";
            this.DaleteButton.Size = new System.Drawing.Size(85, 28);
            this.DaleteButton.TabIndex = 2;
            this.DaleteButton.Text = "Delete";
            this.DaleteButton.UseVisualStyleBackColor = true;
            // 
            // ShowHistoryButton
            // 
            this.ShowHistoryButton.Location = new System.Drawing.Point(324, 410);
            this.ShowHistoryButton.Name = "ShowHistoryButton";
            this.ShowHistoryButton.Size = new System.Drawing.Size(85, 28);
            this.ShowHistoryButton.TabIndex = 3;
            this.ShowHistoryButton.Text = "Show history";
            this.ShowHistoryButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(415, 410);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 28);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // ShowAddressButton
            // 
            this.ShowAddressButton.Location = new System.Drawing.Point(233, 410);
            this.ShowAddressButton.Name = "ShowAddressButton";
            this.ShowAddressButton.Size = new System.Drawing.Size(85, 28);
            this.ShowAddressButton.TabIndex = 5;
            this.ShowAddressButton.Text = "Show address";
            this.ShowAddressButton.UseVisualStyleBackColor = true;
            this.ShowAddressButton.Click += new System.EventHandler(this.ShowAddressButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 410);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(85, 28);
            this.GoBackButton.TabIndex = 6;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ShowAddressButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ShowHistoryButton);
            this.Controls.Add(this.DaleteButton);
            this.Controls.Add(this.UsersTypeLabel);
            this.Controls.Add(this.UsersTable);
            this.Name = "UsersManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersPanel";
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.Label UsersTypeLabel;
        private System.Windows.Forms.Button DaleteButton;
        private System.Windows.Forms.Button ShowHistoryButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ShowAddressButton;
        private System.Windows.Forms.Button GoBackButton;
    }
}