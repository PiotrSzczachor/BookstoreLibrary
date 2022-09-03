namespace BookstoreLibrary.GUI
{
    partial class AddressInfoForm
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
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.PostalCodeBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangesChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StreetBox
            // 
            this.StreetBox.Enabled = false;
            this.StreetBox.Location = new System.Drawing.Point(84, 12);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(172, 20);
            this.StreetBox.TabIndex = 0;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Enabled = false;
            this.NumberTextBox.Location = new System.Drawing.Point(84, 38);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(172, 20);
            this.NumberTextBox.TabIndex = 1;
            // 
            // CityBox
            // 
            this.CityBox.Enabled = false;
            this.CityBox.Location = new System.Drawing.Point(84, 64);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(172, 20);
            this.CityBox.TabIndex = 2;
            // 
            // PostalCodeBox
            // 
            this.PostalCodeBox.Enabled = false;
            this.PostalCodeBox.Location = new System.Drawing.Point(84, 90);
            this.PostalCodeBox.Name = "PostalCodeBox";
            this.PostalCodeBox.Size = new System.Drawing.Size(172, 20);
            this.PostalCodeBox.TabIndex = 3;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(12, 15);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 4;
            this.StreetLabel.Text = "Street:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(12, 41);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(47, 13);
            this.NumberLabel.TabIndex = 5;
            this.NumberLabel.Text = "Number:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(12, 67);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City:";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(12, 93);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.PostalCodeLabel.TabIndex = 7;
            this.PostalCodeLabel.Text = "Postal code:";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(65, 139);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(72, 26);
            this.GoBackButton.TabIndex = 8;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(143, 139);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 26);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditCheckBox
            // 
            this.EditCheckBox.AutoSize = true;
            this.EditCheckBox.Location = new System.Drawing.Point(15, 116);
            this.EditCheckBox.Name = "EditCheckBox";
            this.EditCheckBox.Size = new System.Drawing.Size(76, 17);
            this.EditCheckBox.TabIndex = 11;
            this.EditCheckBox.Text = "Allow edits";
            this.EditCheckBox.UseVisualStyleBackColor = true;
            this.EditCheckBox.CheckedChanged += new System.EventHandler(this.EditCheckBox_CheckedChanged);
            // 
            // ChangesChecker
            // 
            this.ChangesChecker.Tick += new System.EventHandler(this.ChangesChecker_Tick);
            // 
            // AddressInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 173);
            this.Controls.Add(this.EditCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.PostalCodeBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.StreetBox);
            this.Name = "AddressInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox PostalCodeBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox EditCheckBox;
        private System.Windows.Forms.Timer ChangesChecker;
    }
}