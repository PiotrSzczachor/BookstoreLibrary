namespace BookstoreLibrary.GUI
{
    partial class StoresMapForm
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
            this.StoresMap = new GMap.NET.WindowsForms.GMapControl();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.EditStoreButton = new System.Windows.Forms.Button();
            this.DeleteStoreButton = new System.Windows.Forms.Button();
            this.StoresListLabel = new System.Windows.Forms.Label();
            this.StoresList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StoresList)).BeginInit();
            this.SuspendLayout();
            // 
            // StoresMap
            // 
            this.StoresMap.Bearing = 0F;
            this.StoresMap.CanDragMap = true;
            this.StoresMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.StoresMap.GrayScaleMode = false;
            this.StoresMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.StoresMap.LevelsKeepInMemory = 5;
            this.StoresMap.Location = new System.Drawing.Point(394, 40);
            this.StoresMap.MarkersEnabled = true;
            this.StoresMap.MaxZoom = 18;
            this.StoresMap.MinZoom = 2;
            this.StoresMap.MouseWheelZoomEnabled = true;
            this.StoresMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.StoresMap.Name = "StoresMap";
            this.StoresMap.NegativeMode = false;
            this.StoresMap.PolygonsEnabled = true;
            this.StoresMap.RetryLoadTile = 0;
            this.StoresMap.RoutesEnabled = true;
            this.StoresMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.StoresMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.StoresMap.ShowTileGridLines = false;
            this.StoresMap.Size = new System.Drawing.Size(324, 316);
            this.StoresMap.TabIndex = 0;
            this.StoresMap.Zoom = 13D;
            this.StoresMap.Load += new System.EventHandler(this.StoresMap_Load);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 322);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(85, 34);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.Location = new System.Drawing.Point(103, 322);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(85, 34);
            this.AddStoreButton.TabIndex = 3;
            this.AddStoreButton.Text = "Add new store";
            this.AddStoreButton.UseVisualStyleBackColor = true;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // EditStoreButton
            // 
            this.EditStoreButton.Location = new System.Drawing.Point(194, 322);
            this.EditStoreButton.Name = "EditStoreButton";
            this.EditStoreButton.Size = new System.Drawing.Size(85, 34);
            this.EditStoreButton.TabIndex = 4;
            this.EditStoreButton.Text = "Edit store info";
            this.EditStoreButton.UseVisualStyleBackColor = true;
            // 
            // DeleteStoreButton
            // 
            this.DeleteStoreButton.Location = new System.Drawing.Point(285, 322);
            this.DeleteStoreButton.Name = "DeleteStoreButton";
            this.DeleteStoreButton.Size = new System.Drawing.Size(85, 34);
            this.DeleteStoreButton.TabIndex = 5;
            this.DeleteStoreButton.Text = "Delete store";
            this.DeleteStoreButton.UseVisualStyleBackColor = true;
            // 
            // StoresListLabel
            // 
            this.StoresListLabel.AutoSize = true;
            this.StoresListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StoresListLabel.Location = new System.Drawing.Point(12, 20);
            this.StoresListLabel.Name = "StoresListLabel";
            this.StoresListLabel.Size = new System.Drawing.Size(90, 18);
            this.StoresListLabel.TabIndex = 6;
            this.StoresListLabel.Text = "Stores list:";
            // 
            // StoresList
            // 
            this.StoresList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.StoresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresList.Location = new System.Drawing.Point(12, 41);
            this.StoresList.Name = "StoresList";
            this.StoresList.Size = new System.Drawing.Size(358, 275);
            this.StoresList.TabIndex = 7;
            // 
            // StoresMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 367);
            this.Controls.Add(this.StoresList);
            this.Controls.Add(this.StoresListLabel);
            this.Controls.Add(this.DeleteStoreButton);
            this.Controls.Add(this.EditStoreButton);
            this.Controls.Add(this.AddStoreButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.StoresMap);
            this.Name = "StoresMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoresMapForm";
            ((System.ComponentModel.ISupportInitialize)(this.StoresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl StoresMap;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button AddStoreButton;
        private System.Windows.Forms.Button EditStoreButton;
        private System.Windows.Forms.Button DeleteStoreButton;
        private System.Windows.Forms.Label StoresListLabel;
        private System.Windows.Forms.DataGridView StoresList;
    }
}