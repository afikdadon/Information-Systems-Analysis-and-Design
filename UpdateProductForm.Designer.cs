namespace Group_1
{
    partial class UpdateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductForm));
            this.updateProductButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.skuCodeTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.skuCodeLabel = new System.Windows.Forms.Label();
            this.updateProductLabel = new System.Windows.Forms.Label();
            this.backArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateProductButton
            // 
            this.updateProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.updateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateProductButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductButton.ForeColor = System.Drawing.Color.Black;
            this.updateProductButton.Location = new System.Drawing.Point(395, 410);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(249, 71);
            this.updateProductButton.TabIndex = 46;
            this.updateProductButton.Text = "UPDATE PRODUCT";
            this.updateProductButton.UseVisualStyleBackColor = false;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.priceTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.priceTextBox.Location = new System.Drawing.Point(222, 301);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 27);
            this.priceTextBox.TabIndex = 45;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.productNameTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.productNameTextBox.Location = new System.Drawing.Point(222, 237);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(207, 27);
            this.productNameTextBox.TabIndex = 44;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            // 
            // skuCodeTextBox
            // 
            this.skuCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.skuCodeTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.skuCodeTextBox.Location = new System.Drawing.Point(222, 170);
            this.skuCodeTextBox.Name = "skuCodeTextBox";
            this.skuCodeTextBox.Size = new System.Drawing.Size(207, 27);
            this.skuCodeTextBox.TabIndex = 43;
            this.skuCodeTextBox.TextChanged += new System.EventHandler(this.skuCodeTextBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(48, 309);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 19);
            this.priceLabel.TabIndex = 42;
            this.priceLabel.Text = "Price";
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(48, 245);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(124, 19);
            this.productNameLabel.TabIndex = 41;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // skuCodeLabel
            // 
            this.skuCodeLabel.AutoSize = true;
            this.skuCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.skuCodeLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuCodeLabel.Location = new System.Drawing.Point(48, 171);
            this.skuCodeLabel.Name = "skuCodeLabel";
            this.skuCodeLabel.Size = new System.Drawing.Size(84, 19);
            this.skuCodeLabel.TabIndex = 40;
            this.skuCodeLabel.Text = "Sku Code";
            this.skuCodeLabel.Click += new System.EventHandler(this.skuCodeLabel_Click);
            // 
            // updateProductLabel
            // 
            this.updateProductLabel.AutoSize = true;
            this.updateProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateProductLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.updateProductLabel.Location = new System.Drawing.Point(26, 24);
            this.updateProductLabel.Name = "updateProductLabel";
            this.updateProductLabel.Size = new System.Drawing.Size(512, 81);
            this.updateProductLabel.TabIndex = 39;
            this.updateProductLabel.Text = "Update Product";
            this.updateProductLabel.Click += new System.EventHandler(this.updateProductLabel_Click);
            // 
            // backArrowPictureBox
            // 
            this.backArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backArrowPictureBox.BackgroundImage")));
            this.backArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backArrowPictureBox.Location = new System.Drawing.Point(27, 416);
            this.backArrowPictureBox.Name = "backArrowPictureBox";
            this.backArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.backArrowPictureBox.TabIndex = 38;
            this.backArrowPictureBox.TabStop = false;
            this.backArrowPictureBox.Click += new System.EventHandler(this.backArrowPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(24, 458);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.BackColor = System.Drawing.Color.Transparent;
            this.supplierLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(48, 368);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(73, 19);
            this.supplierLabel.TabIndex = 47;
            this.supplierLabel.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.supplierComboBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(222, 365);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(207, 27);
            this.supplierComboBox.TabIndex = 48;
            this.supplierComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 55;
            this.label1.Text = "Home Page";
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Transparent;
            this.homePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePageButton.BackgroundImage")));
            this.homePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homePageButton.Location = new System.Drawing.Point(609, 8);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 54;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.skuCodeTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.skuCodeLabel);
            this.Controls.Add(this.updateProductLabel);
            this.Controls.Add(this.backArrowPictureBox);
            this.Controls.Add(this.backButton);
            this.Name = "UpdateProductForm";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateProductButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox skuCodeTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label skuCodeLabel;
        private System.Windows.Forms.Label updateProductLabel;
        private System.Windows.Forms.PictureBox backArrowPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
    }
}