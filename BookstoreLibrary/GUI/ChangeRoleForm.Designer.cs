namespace BookstoreLibrary.GUI
{
    partial class ChangeRoleForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.RolesComboBox = new System.Windows.Forms.ComboBox();
            this.ChangesChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(162, 38);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 26);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(84, 38);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(72, 26);
            this.GoBackButton.TabIndex = 11;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Enabled = false;
            this.UsernameBox.Location = new System.Drawing.Point(22, 12);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(149, 20);
            this.UsernameBox.TabIndex = 13;
            // 
            // RolesComboBox
            // 
            this.RolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolesComboBox.FormattingEnabled = true;
            this.RolesComboBox.Location = new System.Drawing.Point(180, 12);
            this.RolesComboBox.Name = "RolesComboBox";
            this.RolesComboBox.Size = new System.Drawing.Size(121, 21);
            this.RolesComboBox.TabIndex = 14;
            // 
            // ChangesChecker
            // 
            this.ChangesChecker.Tick += new System.EventHandler(this.ChangesChecker_Tick);
            // 
            // ChangeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 75);
            this.Controls.Add(this.RolesComboBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Name = "ChangeRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRoleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.ComboBox RolesComboBox;
        private System.Windows.Forms.Timer ChangesChecker;
    }
}