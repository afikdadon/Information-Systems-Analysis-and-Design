namespace Group_1
{
    partial class UpdateOrDeleteProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOrDeleteProductForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.skuCodeTextBox = new System.Windows.Forms.TextBox();
            this.enterEmployeeIdLabel = new System.Windows.Forms.Label();
            this.ChoseDeleteProductButton = new System.Windows.Forms.Button();
            this.ChoseUpdateProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 41);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Silver;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(20, 301);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // skuCodeTextBox
            // 
            this.skuCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.skuCodeTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skuCodeTextBox.Location = new System.Drawing.Point(469, 89);
            this.skuCodeTextBox.Name = "skuCodeTextBox";
            this.skuCodeTextBox.Size = new System.Drawing.Size(100, 27);
            this.skuCodeTextBox.TabIndex = 36;
            this.skuCodeTextBox.TextChanged += new System.EventHandler(this.skuCodeTextBox_TextChanged);
            // 
            // enterEmployeeIdLabel
            // 
            this.enterEmployeeIdLabel.AutoSize = true;
            this.enterEmployeeIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterEmployeeIdLabel.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmployeeIdLabel.Location = new System.Drawing.Point(61, 84);
            this.enterEmployeeIdLabel.Name = "enterEmployeeIdLabel";
            this.enterEmployeeIdLabel.Size = new System.Drawing.Size(400, 32);
            this.enterEmployeeIdLabel.TabIndex = 35;
            this.enterEmployeeIdLabel.Text = "Please Enter The Product SKU:";
            this.enterEmployeeIdLabel.Click += new System.EventHandler(this.enterEmployeeIdLabel_Click);
            // 
            // ChoseDeleteProductButton
            // 
            this.ChoseDeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.ChoseDeleteProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoseDeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChoseDeleteProductButton.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoseDeleteProductButton.Location = new System.Drawing.Point(104, 174);
            this.ChoseDeleteProductButton.Name = "ChoseDeleteProductButton";
            this.ChoseDeleteProductButton.Size = new System.Drawing.Size(135, 47);
            this.ChoseDeleteProductButton.TabIndex = 40;
            this.ChoseDeleteProductButton.Text = "DELETE";
            this.ChoseDeleteProductButton.UseVisualStyleBackColor = false;
            this.ChoseDeleteProductButton.Click += new System.EventHandler(this.ChoseDeleteProductButton_Click);
            // 
            // ChoseUpdateProductButton
            // 
            this.ChoseUpdateProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.ChoseUpdateProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoseUpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChoseUpdateProductButton.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoseUpdateProductButton.Location = new System.Drawing.Point(411, 174);
            this.ChoseUpdateProductButton.Name = "ChoseUpdateProductButton";
            this.ChoseUpdateProductButton.Size = new System.Drawing.Size(135, 47);
            this.ChoseUpdateProductButton.TabIndex = 39;
            this.ChoseUpdateProductButton.Text = "UPDATE";
            this.ChoseUpdateProductButton.UseVisualStyleBackColor = false;
            this.ChoseUpdateProductButton.Click += new System.EventHandler(this.ChoseUpdateProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 54);
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
            this.homePageButton.Location = new System.Drawing.Point(573, 12);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 54;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // UpdateOrDeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.ChoseDeleteProductButton);
            this.Controls.Add(this.ChoseUpdateProductButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.skuCodeTextBox);
            this.Controls.Add(this.enterEmployeeIdLabel);
            this.Name = "UpdateOrDeleteProductForm";
            this.Text = "Product Id";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox skuCodeTextBox;
        private System.Windows.Forms.Label enterEmployeeIdLabel;
        private System.Windows.Forms.Button ChoseDeleteProductButton;
        private System.Windows.Forms.Button ChoseUpdateProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
    }
}