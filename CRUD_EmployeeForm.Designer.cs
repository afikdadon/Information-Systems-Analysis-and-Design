namespace Group_1
{
    partial class CRUD_EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_EmployeeForm));
            this.createButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.createPictureBox = new System.Windows.Forms.PictureBox();
            this.viewPictureBox = new System.Windows.Forms.PictureBox();
            this.updatePictureBox = new System.Windows.Forms.PictureBox();
            this.deletePictureBox = new System.Windows.Forms.PictureBox();
            this.backArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createButton.Location = new System.Drawing.Point(121, 204);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(122, 52);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.viewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.Black;
            this.viewButton.Location = new System.Drawing.Point(121, 332);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(122, 52);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(384, 248);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(122, 106);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "UPDATE OR DELETE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateOrDeleteButton_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.employeeLabel.Location = new System.Drawing.Point(111, 60);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(373, 81);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "EMPLOYEE";
            this.employeeLabel.Click += new System.EventHandler(this.employeeLabel_Click);
            // 
            // createPictureBox
            // 
            this.createPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.createPictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.createPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("createPictureBox.Image")));
            this.createPictureBox.Location = new System.Drawing.Point(69, 202);
            this.createPictureBox.Name = "createPictureBox";
            this.createPictureBox.Size = new System.Drawing.Size(51, 50);
            this.createPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createPictureBox.TabIndex = 5;
            this.createPictureBox.TabStop = false;
            this.createPictureBox.UseWaitCursor = true;
            this.createPictureBox.Click += new System.EventHandler(this.createPictureBox_Click);
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.viewPictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.viewPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("viewPictureBox.Image")));
            this.viewPictureBox.Location = new System.Drawing.Point(69, 332);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(51, 50);
            this.viewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewPictureBox.TabIndex = 6;
            this.viewPictureBox.TabStop = false;
            this.viewPictureBox.UseWaitCursor = true;
            this.viewPictureBox.Click += new System.EventHandler(this.viewPictureBox_Click);
            // 
            // updatePictureBox
            // 
            this.updatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.updatePictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.updatePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("updatePictureBox.Image")));
            this.updatePictureBox.Location = new System.Drawing.Point(327, 238);
            this.updatePictureBox.Name = "updatePictureBox";
            this.updatePictureBox.Size = new System.Drawing.Size(51, 50);
            this.updatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updatePictureBox.TabIndex = 7;
            this.updatePictureBox.TabStop = false;
            this.updatePictureBox.UseWaitCursor = true;
            this.updatePictureBox.Click += new System.EventHandler(this.updatePictureBox_Click);
            // 
            // deletePictureBox
            // 
            this.deletePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.deletePictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.deletePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePictureBox.Image")));
            this.deletePictureBox.Location = new System.Drawing.Point(327, 318);
            this.deletePictureBox.Name = "deletePictureBox";
            this.deletePictureBox.Size = new System.Drawing.Size(51, 50);
            this.deletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePictureBox.TabIndex = 8;
            this.deletePictureBox.TabStop = false;
            this.deletePictureBox.UseWaitCursor = true;
            this.deletePictureBox.Click += new System.EventHandler(this.deletePictureBox_Click);
            // 
            // backArrowPictureBox
            // 
            this.backArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backArrowPictureBox.BackgroundImage")));
            this.backArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backArrowPictureBox.Location = new System.Drawing.Point(12, 411);
            this.backArrowPictureBox.Name = "backArrowPictureBox";
            this.backArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.backArrowPictureBox.TabIndex = 55;
            this.backArrowPictureBox.TabStop = false;
            this.backArrowPictureBox.Click += new System.EventHandler(this.backArrowPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(9, 453);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 54;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CRUD_EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 487);
            this.Controls.Add(this.backArrowPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deletePictureBox);
            this.Controls.Add(this.updatePictureBox);
            this.Controls.Add(this.viewPictureBox);
            this.Controls.Add(this.createPictureBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.createButton);
            this.Name = "CRUD_EmployeeForm";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.CRUD_EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.PictureBox createPictureBox;
        private System.Windows.Forms.PictureBox viewPictureBox;
        private System.Windows.Forms.PictureBox updatePictureBox;
        private System.Windows.Forms.PictureBox deletePictureBox;
        private System.Windows.Forms.PictureBox backArrowPictureBox;
        private System.Windows.Forms.Button backButton;
    }
}