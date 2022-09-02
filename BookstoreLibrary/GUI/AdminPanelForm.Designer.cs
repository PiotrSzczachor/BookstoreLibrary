namespace BookstoreLibrary.GUI
{
    partial class AdminPanelForm
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
            this.BooksButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.StoresButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksButton
            // 
            this.BooksButton.Location = new System.Drawing.Point(33, 45);
            this.BooksButton.Name = "BooksButton";
            this.BooksButton.Size = new System.Drawing.Size(117, 41);
            this.BooksButton.TabIndex = 0;
            this.BooksButton.Text = "Books";
            this.BooksButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            this.UsersButton.Location = new System.Drawing.Point(33, 92);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(117, 41);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            // 
            // StoresButton
            // 
            this.StoresButton.Location = new System.Drawing.Point(33, 139);
            this.StoresButton.Name = "StoresButton";
            this.StoresButton.Size = new System.Drawing.Size(117, 41);
            this.StoresButton.TabIndex = 2;
            this.StoresButton.Text = "Stores";
            this.StoresButton.UseVisualStyleBackColor = true;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(33, 186);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(117, 41);
            this.AccountButton.TabIndex = 3;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(33, 233);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 41);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 19);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(35, 13);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "label1";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 299);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.StoresButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.BooksButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BooksButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button StoresButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}