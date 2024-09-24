namespace Group_1
{
    partial class AllProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProjectForm));
            this.backArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.fillterTextBox = new System.Windows.Forms.TextBox();
            this.projectslistView = new System.Windows.Forms.ListView();
            this.createNewOrderbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backArrowPictureBox
            // 
            this.backArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backArrowPictureBox.BackgroundImage")));
            this.backArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backArrowPictureBox.Location = new System.Drawing.Point(12, 418);
            this.backArrowPictureBox.Name = "backArrowPictureBox";
            this.backArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.backArrowPictureBox.TabIndex = 65;
            this.backArrowPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(9, 460);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 64;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.employeeLabel.Location = new System.Drawing.Point(167, 33);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(322, 81);
            this.employeeLabel.TabIndex = 59;
            this.employeeLabel.Text = "PROJECT";
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackColor = System.Drawing.Color.IndianRed;
            this.createProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createProjectButton.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProjectButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createProjectButton.Location = new System.Drawing.Point(120, 400);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(133, 30);
            this.createProjectButton.TabIndex = 56;
            this.createProjectButton.Text = "NEW PROJECT";
            this.createProjectButton.UseVisualStyleBackColor = false;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // fillterTextBox
            // 
            this.fillterTextBox.Location = new System.Drawing.Point(394, 152);
            this.fillterTextBox.Name = "fillterTextBox";
            this.fillterTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fillterTextBox.Size = new System.Drawing.Size(176, 20);
            this.fillterTextBox.TabIndex = 66;
            this.fillterTextBox.TextChanged += new System.EventHandler(this.fillterTextBox_TextChanged);
            // 
            // projectslistView
            // 
            this.projectslistView.Location = new System.Drawing.Point(120, 182);
            this.projectslistView.Name = "projectslistView";
            this.projectslistView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectslistView.RightToLeftLayout = true;
            this.projectslistView.Size = new System.Drawing.Size(450, 210);
            this.projectslistView.TabIndex = 67;
            this.projectslistView.UseCompatibleStateImageBehavior = false;
            this.projectslistView.SelectedIndexChanged += new System.EventHandler(this.projectslistView_SelectedIndexChanged_1);
            // 
            // createNewOrderbutton
            // 
            this.createNewOrderbutton.BackColor = System.Drawing.Color.IndianRed;
            this.createNewOrderbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewOrderbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createNewOrderbutton.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewOrderbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createNewOrderbutton.Location = new System.Drawing.Point(120, 146);
            this.createNewOrderbutton.Name = "createNewOrderbutton";
            this.createNewOrderbutton.Size = new System.Drawing.Size(147, 30);
            this.createNewOrderbutton.TabIndex = 68;
            this.createNewOrderbutton.Text = "SELECT PROJECT";
            this.createNewOrderbutton.UseVisualStyleBackColor = false;
            this.createNewOrderbutton.Click += new System.EventHandler(this.createNewOrderbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 71;
            this.label1.Text = "Home Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Transparent;
            this.homePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePageButton.BackgroundImage")));
            this.homePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homePageButton.Location = new System.Drawing.Point(594, 12);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 70;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // AllProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.createNewOrderbutton);
            this.Controls.Add(this.projectslistView);
            this.Controls.Add(this.fillterTextBox);
            this.Controls.Add(this.backArrowPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.createProjectButton);
            this.Name = "AllProjectForm";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backArrowPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.TextBox fillterTextBox;
        private System.Windows.Forms.ListView projectslistView;
        private System.Windows.Forms.Button createNewOrderbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
    }
}