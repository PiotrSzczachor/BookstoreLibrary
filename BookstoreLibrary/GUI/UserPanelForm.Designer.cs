namespace BookstoreLibrary.GUI
{
    partial class UserPanelForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.StoresButton = new System.Windows.Forms.Button();
            this.BooksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(14, 15);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(35, 13);
            this.InfoLabel.TabIndex = 11;
            this.InfoLabel.Text = "label1";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(35, 182);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 41);
            this.LogOutButton.TabIndex = 10;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(35, 135);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(117, 41);
            this.AccountButton.TabIndex = 9;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // StoresButton
            // 
            this.StoresButton.Location = new System.Drawing.Point(35, 88);
            this.StoresButton.Name = "StoresButton";
            this.StoresButton.Size = new System.Drawing.Size(117, 41);
            this.StoresButton.TabIndex = 8;
            this.StoresButton.Text = "Stores";
            this.StoresButton.UseVisualStyleBackColor = true;
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(35, 41);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(117, 41);
            this.BooksButton.TabIndex = 6;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 233);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.StoresButton);
            this.Controls.Add(this.BooksButton);
            this.Name = "UserPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button StoresButton;
        private System.Windows.Forms.Button BooksButton;
    }
}