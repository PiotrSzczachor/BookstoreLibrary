namespace BookstoreLibrary.GUI
{
    partial class UserEditForm
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
            this.PhoneCodesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ChangesChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PhoneCodesComboBox
            // 
            this.PhoneCodesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneCodesComboBox.FormattingEnabled = true;
            this.PhoneCodesComboBox.Location = new System.Drawing.Point(107, 96);
            this.PhoneCodesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneCodesComboBox.Name = "PhoneCodesComboBox";
            this.PhoneCodesComboBox.Size = new System.Drawing.Size(55, 21);
            this.PhoneCodesComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(164, 96);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(126, 20);
            this.PhoneBox.TabIndex = 14;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(106, 76);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(184, 20);
            this.EmailBox.TabIndex = 12;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(106, 32);
            this.SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(184, 20);
            this.SurnameBox.TabIndex = 11;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(106, 11);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(184, 20);
            this.NameBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Username:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(106, 54);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(184, 20);
            this.UsernameBox.TabIndex = 19;
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(150, 121);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(106, 29);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(39, 121);
            this.GoBackButton.Margin = new System.Windows.Forms.Padding(2);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(106, 29);
            this.GoBackButton.TabIndex = 21;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ChangesChecker
            // 
            this.ChangesChecker.Tick += new System.EventHandler(this.ChangesChecker_Tick);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 154);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.PhoneCodesComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "UserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PhoneCodesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Timer ChangesChecker;
    }
}