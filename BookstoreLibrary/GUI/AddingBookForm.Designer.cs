namespace BookstoreLibrary.GUI
{
    partial class AddingBookForm
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
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.PageNumberBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.PageNumberLabel = new System.Windows.Forms.Label();
            this.PublishYearLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.PublishYearComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.BookForSaleCheckBox = new System.Windows.Forms.CheckBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CurrencyFlagPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyFlagPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(100, 9);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(152, 20);
            this.TitleBox.TabIndex = 0;
            // 
            // PriceBox
            // 
            this.PriceBox.Enabled = false;
            this.PriceBox.Location = new System.Drawing.Point(100, 219);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(152, 20);
            this.PriceBox.TabIndex = 8;
            this.PriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceBox_KeyPress);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(100, 165);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(152, 20);
            this.QuantityBox.TabIndex = 6;
            this.QuantityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityBox_KeyPress);
            // 
            // PageNumberBox
            // 
            this.PageNumberBox.Location = new System.Drawing.Point(100, 139);
            this.PageNumberBox.Name = "PageNumberBox";
            this.PageNumberBox.Size = new System.Drawing.Size(152, 20);
            this.PageNumberBox.TabIndex = 5;
            this.PageNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PageNumberBox_KeyPress);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(8, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Title:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(8, 38);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Author:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(8, 64);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type:";
            // 
            // PageNumberLabel
            // 
            this.PageNumberLabel.AutoSize = true;
            this.PageNumberLabel.Location = new System.Drawing.Point(8, 142);
            this.PageNumberLabel.Name = "PageNumberLabel";
            this.PageNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.PageNumberLabel.TabIndex = 14;
            this.PageNumberLabel.Text = "Page number:";
            // 
            // PublishYearLabel
            // 
            this.PublishYearLabel.AutoSize = true;
            this.PublishYearLabel.Location = new System.Drawing.Point(8, 116);
            this.PublishYearLabel.Name = "PublishYearLabel";
            this.PublishYearLabel.Size = new System.Drawing.Size(67, 13);
            this.PublishYearLabel.TabIndex = 13;
            this.PublishYearLabel.Text = "Publish year:";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(8, 90);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(53, 13);
            this.PublisherLabel.TabIndex = 12;
            this.PublisherLabel.Text = "Publisher:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(8, 222);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 17;
            this.PriceLabel.Text = "Price:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(8, 168);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantityLabel.TabIndex = 16;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(8, 248);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(52, 13);
            this.CurrencyLabel.TabIndex = 15;
            this.CurrencyLabel.Text = "Currency:";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.Enabled = false;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(100, 245);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(110, 21);
            this.CurrencyComboBox.TabIndex = 9;
            this.CurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencyComboBox_SelectedIndexChanged);
            // 
            // PublishYearComboBox
            // 
            this.PublishYearComboBox.FormattingEnabled = true;
            this.PublishYearComboBox.Location = new System.Drawing.Point(100, 113);
            this.PublishYearComboBox.Name = "PublishYearComboBox";
            this.PublishYearComboBox.Size = new System.Drawing.Size(152, 21);
            this.PublishYearComboBox.TabIndex = 4;
            this.PublishYearComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PublishYearComboBox_KeyPress);
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(100, 87);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(152, 21);
            this.PublisherComboBox.TabIndex = 3;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(100, 61);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.TypeComboBox.TabIndex = 2;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(100, 35);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(152, 21);
            this.AuthorComboBox.TabIndex = 1;
            // 
            // BookForSaleCheckBox
            // 
            this.BookForSaleCheckBox.AutoSize = true;
            this.BookForSaleCheckBox.Location = new System.Drawing.Point(11, 198);
            this.BookForSaleCheckBox.Name = "BookForSaleCheckBox";
            this.BookForSaleCheckBox.Size = new System.Drawing.Size(95, 21);
            this.BookForSaleCheckBox.TabIndex = 7;
            this.BookForSaleCheckBox.Text = "Book for sale";
            this.BookForSaleCheckBox.UseVisualStyleBackColor = true;
            this.BookForSaleCheckBox.CheckedChanged += new System.EventHandler(this.BookForSaleCheckBox_CheckedChanged);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(56, 272);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(70, 26);
            this.GoBackButton.TabIndex = 10;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(132, 272);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 26);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CurrencyFlagPictureBox
            // 
            this.CurrencyFlagPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrencyFlagPictureBox.Location = new System.Drawing.Point(216, 245);
            this.CurrencyFlagPictureBox.Name = "CurrencyFlagPictureBox";
            this.CurrencyFlagPictureBox.Size = new System.Drawing.Size(35, 21);
            this.CurrencyFlagPictureBox.TabIndex = 26;
            this.CurrencyFlagPictureBox.TabStop = false;
            // 
            // AddingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 304);
            this.Controls.Add(this.CurrencyFlagPictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.BookForSaleCheckBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.PublisherComboBox);
            this.Controls.Add(this.PublishYearComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.PageNumberLabel);
            this.Controls.Add(this.PublishYearLabel);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.PageNumberBox);
            this.Controls.Add(this.TitleBox);
            this.Name = "AddingBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddingBookForm";
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyFlagPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox PageNumberBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label PageNumberLabel;
        private System.Windows.Forms.Label PublishYearLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox PublishYearComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.CheckBox BookForSaleCheckBox;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox CurrencyFlagPictureBox;
    }
}