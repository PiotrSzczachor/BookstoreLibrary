namespace BookstoreLibrary.GUI
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
            this.UsersTypeLabel.Location = new System.Drawing.Point(387, 43);
            this.UsersTypeLabel.Name = "UsersTypeLabel";
            this.UsersTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.UsersTypeLabel.TabIndex = 1;
            this.UsersTypeLabel.Text = "label1";
            // 
            // UsersManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}