namespace Group_1
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.logInButton = new System.Windows.Forms.Button();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.galtamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Firebrick;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.Black;
            this.logInButton.Location = new System.Drawing.Point(259, 263);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(126, 49);
            this.logInButton.TabIndex = 37;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.BackColor = System.Drawing.Color.Silver;
            this.EmployeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(348, 179);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(126, 40);
            this.EmployeeIDTextBox.TabIndex = 36;
            this.EmployeeIDTextBox.TextChanged += new System.EventHandler(this.EmployeeIDTextBox_TextChanged);
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeIDLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(164, 184);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(158, 29);
            this.employeeIDLabel.TabIndex = 35;
            this.employeeIDLabel.Text = "Employee ID";
            this.employeeIDLabel.Click += new System.EventHandler(this.employeeIDLabel_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.BackgroundImage")));
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Location = new System.Drawing.Point(423, 38);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(96, 98);
            this.LogoPictureBox.TabIndex = 34;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // galtamLabel
            // 
            this.galtamLabel.AutoSize = true;
            this.galtamLabel.BackColor = System.Drawing.Color.Transparent;
            this.galtamLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galtamLabel.ForeColor = System.Drawing.Color.Black;
            this.galtamLabel.Location = new System.Drawing.Point(102, 55);
            this.galtamLabel.Name = "galtamLabel";
            this.galtamLabel.Size = new System.Drawing.Size(315, 81);
            this.galtamLabel.TabIndex = 33;
            this.galtamLabel.Text = "GALTAM";
            this.galtamLabel.Click += new System.EventHandler(this.galtamLabel_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 350);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.galtamLabel);
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label galtamLabel;
    }
}