namespace Group_1
{
    partial class createTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTaskForm));
            this.createTaskLabel = new System.Windows.Forms.Label();
            this.responsibleLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.backArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.classificationComboBox = new System.Windows.Forms.ComboBox();
            this.responsibleComboBox = new System.Windows.Forms.ComboBox();
            this.sortEmployeeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createTaskLabel
            // 
            this.createTaskLabel.AutoSize = true;
            this.createTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.createTaskLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(160)))), ((int)(((byte)(121)))));
            this.createTaskLabel.Location = new System.Drawing.Point(21, 40);
            this.createTaskLabel.Name = "createTaskLabel";
            this.createTaskLabel.Size = new System.Drawing.Size(606, 81);
            this.createTaskLabel.TabIndex = 30;
            this.createTaskLabel.Text = "Create a New Task";
            this.createTaskLabel.Click += new System.EventHandler(this.createProductLabel_Click);
            // 
            // responsibleLabel
            // 
            this.responsibleLabel.AutoSize = true;
            this.responsibleLabel.BackColor = System.Drawing.Color.Transparent;
            this.responsibleLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibleLabel.Location = new System.Drawing.Point(65, 373);
            this.responsibleLabel.Name = "responsibleLabel";
            this.responsibleLabel.Size = new System.Drawing.Size(101, 19);
            this.responsibleLabel.TabIndex = 64;
            this.responsibleLabel.Text = "Responsible";
            this.responsibleLabel.Click += new System.EventHandler(this.responsibleLabel_Click);
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.BackColor = System.Drawing.Color.Transparent;
            this.classificationLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationLabel.Location = new System.Drawing.Point(65, 323);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(112, 19);
            this.classificationLabel.TabIndex = 62;
            this.classificationLabel.Text = "Classification";
            this.classificationLabel.Click += new System.EventHandler(this.classificationLabel_Click);
            // 
            // createTaskButton
            // 
            this.createTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(160)))), ((int)(((byte)(121)))));
            this.createTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTaskButton.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskButton.ForeColor = System.Drawing.Color.Black;
            this.createTaskButton.Location = new System.Drawing.Point(419, 499);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(249, 71);
            this.createTaskButton.TabIndex = 61;
            this.createTaskButton.Text = "CREATE TASK";
            this.createTaskButton.UseVisualStyleBackColor = false;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click_1);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.subjectTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.subjectTextBox.Location = new System.Drawing.Point(237, 166);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(235, 27);
            this.subjectTextBox.TabIndex = 58;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged_1);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.endDateLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(65, 271);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(81, 19);
            this.endDateLabel.TabIndex = 57;
            this.endDateLabel.Text = "End Date";
            this.endDateLabel.Click += new System.EventHandler(this.endDateLabel_Click_1);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(65, 220);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(86, 19);
            this.startDateLabel.TabIndex = 56;
            this.startDateLabel.Text = "start Date";
            this.startDateLabel.Click += new System.EventHandler(this.startDateLabel_Click_1);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubjectLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(65, 167);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(65, 19);
            this.SubjectLabel.TabIndex = 55;
            this.SubjectLabel.Text = "Subject";
            this.SubjectLabel.Click += new System.EventHandler(this.SubjectLabel_Click_1);
            // 
            // backArrowPictureBox
            // 
            this.backArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backArrowPictureBox.BackgroundImage")));
            this.backArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backArrowPictureBox.Location = new System.Drawing.Point(45, 499);
            this.backArrowPictureBox.Name = "backArrowPictureBox";
            this.backArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.backArrowPictureBox.TabIndex = 54;
            this.backArrowPictureBox.TabStop = false;
            this.backArrowPictureBox.Click += new System.EventHandler(this.backArrowPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DarkGray;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(42, 541);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 53;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.BackColor = System.Drawing.Color.Transparent;
            this.noteLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(65, 446);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(136, 19);
            this.noteLabel.TabIndex = 66;
            this.noteLabel.Text = "Note (optional)";
            this.noteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.noteTextBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold);
            this.noteTextBox.Location = new System.Drawing.Point(237, 438);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(237, 27);
            this.noteTextBox.TabIndex = 67;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.startDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(160)))), ((int)(((byte)(121)))));
            this.startDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.startDatePicker.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(239, 212);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(233, 27);
            this.startDatePicker.TabIndex = 68;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged_1);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.endDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.endDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.endDatePicker.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(237, 267);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(233, 27);
            this.endDatePicker.TabIndex = 69;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged_1);
            // 
            // classificationComboBox
            // 
            this.classificationComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.classificationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.classificationComboBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classificationComboBox.FormattingEnabled = true;
            this.classificationComboBox.Location = new System.Drawing.Point(237, 323);
            this.classificationComboBox.Name = "classificationComboBox";
            this.classificationComboBox.Size = new System.Drawing.Size(235, 27);
            this.classificationComboBox.TabIndex = 70;
            this.classificationComboBox.SelectedIndexChanged += new System.EventHandler(this.classificationComboBox_SelectedIndexChanged);
            // 
            // responsibleComboBox
            // 
            this.responsibleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.responsibleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.responsibleComboBox.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibleComboBox.FormattingEnabled = true;
            this.responsibleComboBox.Location = new System.Drawing.Point(239, 373);
            this.responsibleComboBox.Name = "responsibleComboBox";
            this.responsibleComboBox.Size = new System.Drawing.Size(235, 27);
            this.responsibleComboBox.TabIndex = 71;
            this.responsibleComboBox.SelectedIndexChanged += new System.EventHandler(this.responsibleComboBox_SelectedIndexChanged);
            // 
            // sortEmployeeLabel
            // 
            this.sortEmployeeLabel.AutoSize = true;
            this.sortEmployeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortEmployeeLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortEmployeeLabel.Location = new System.Drawing.Point(236, 403);
            this.sortEmployeeLabel.Name = "sortEmployeeLabel";
            this.sortEmployeeLabel.Size = new System.Drawing.Size(415, 16);
            this.sortEmployeeLabel.TabIndex = 72;
            this.sortEmployeeLabel.Text = "*Employees are sorted in ascending order of their open tasks ";
            this.sortEmployeeLabel.Click += new System.EventHandler(this.sortEmployeeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 74;
            this.label1.Text = "Home Page";
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Transparent;
            this.homePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePageButton.BackgroundImage")));
            this.homePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homePageButton.Location = new System.Drawing.Point(690, 10);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 73;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // createTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.sortEmployeeLabel);
            this.Controls.Add(this.responsibleComboBox);
            this.Controls.Add(this.classificationComboBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.responsibleLabel);
            this.Controls.Add(this.classificationLabel);
            this.Controls.Add(this.createTaskButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.backArrowPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createTaskLabel);
            this.Name = "createTaskForm";
            this.Text = "create Task";
            this.Load += new System.EventHandler(this.createTaskForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTaskLabel;
        private System.Windows.Forms.Label responsibleLabel;
        private System.Windows.Forms.Label classificationLabel;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.PictureBox backArrowPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox classificationComboBox;
        private System.Windows.Forms.ComboBox responsibleComboBox;
        private System.Windows.Forms.Label sortEmployeeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
    }
}