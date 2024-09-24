namespace Group_1
{
    partial class UpdateStageStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStageStatus));
            this.newProjectLabel = new System.Windows.Forms.Label();
            this.stagesDataGridView = new System.Windows.Forms.DataGridView();
            this.StageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.didntStartProgress = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.inProgress = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            this.backArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newProjectLabel
            // 
            this.newProjectLabel.AutoSize = true;
            this.newProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.newProjectLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProjectLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.newProjectLabel.Location = new System.Drawing.Point(26, 19);
            this.newProjectLabel.Name = "newProjectLabel";
            this.newProjectLabel.Size = new System.Drawing.Size(445, 81);
            this.newProjectLabel.TabIndex = 94;
            this.newProjectLabel.Text = "Project Stages";
            // 
            // stagesDataGridView
            // 
            this.stagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StageName,
            this.Type,
            this.Deadline,
            this.didntStartProgress,
            this.inProgress,
            this.completed});
            this.stagesDataGridView.Location = new System.Drawing.Point(30, 167);
            this.stagesDataGridView.Name = "stagesDataGridView";
            this.stagesDataGridView.Size = new System.Drawing.Size(714, 150);
            this.stagesDataGridView.TabIndex = 123;
            this.stagesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagesDataGridView_CellContentClick);
            // 
            // StageName
            // 
            this.StageName.HeaderText = "Stage Name";
            this.StageName.Name = "StageName";
            this.StageName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // didntStartProgress
            // 
            this.didntStartProgress.HeaderText = "Didnt Start Progress";
            this.didntStartProgress.Name = "didntStartProgress";
            this.didntStartProgress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.didntStartProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // inProgress
            // 
            this.inProgress.HeaderText = "In Progress";
            this.inProgress.Name = "inProgress";
            this.inProgress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // completed
            // 
            this.completed.HeaderText = "Completed";
            this.completed.Name = "completed";
            this.completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.IndianRed;
            this.newOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newOrderButton.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newOrderButton.Location = new System.Drawing.Point(30, 354);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(103, 30);
            this.newOrderButton.TabIndex = 124;
            this.newOrderButton.Text = "UPDATE";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 126;
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
            this.homePageButton.Location = new System.Drawing.Point(724, 12);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 125;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // backArrowPictureBox
            // 
            this.backArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.backArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backArrowPictureBox.BackgroundImage")));
            this.backArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backArrowPictureBox.Location = new System.Drawing.Point(12, 419);
            this.backArrowPictureBox.Name = "backArrowPictureBox";
            this.backArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.backArrowPictureBox.TabIndex = 128;
            this.backArrowPictureBox.TabStop = false;
            this.backArrowPictureBox.Click += new System.EventHandler(this.backArrowPictureBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(9, 461);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 127;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UpdateStageStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 488);
            this.Controls.Add(this.backArrowPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.stagesDataGridView);
            this.Controls.Add(this.newProjectLabel);
            this.Name = "UpdateStageStatus";
            this.Text = "Update Stage Status";
            this.Load += new System.EventHandler(this.UpdateStageStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newProjectLabel;
        public System.Windows.Forms.DataGridView stagesDataGridView;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.PictureBox backArrowPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn didntStartProgress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inProgress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completed;
    }
}