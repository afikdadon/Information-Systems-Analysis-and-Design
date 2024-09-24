namespace Group_1
{
    partial class CreateAnExceptionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAnExceptionReport));
            this.ERorderID = new System.Windows.Forms.Label();
            this.ERinvoiceID = new System.Windows.Forms.Label();
            this.ERInvoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.ERorderIDTextBox = new System.Windows.Forms.TextBox();
            this.ERheadline = new System.Windows.Forms.Label();
            this.ERgridInvoice = new System.Windows.Forms.DataGridView();
            this.skuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERordergrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERtotalPriceInvoicelabel = new System.Windows.Forms.Label();
            this.ERInvoiceTotalSumCalc = new System.Windows.Forms.TextBox();
            this.ERtotalPriceOrderlabel = new System.Windows.Forms.Label();
            this.EROrderTotalSumCalc = new System.Windows.Forms.TextBox();
            this.ERbackArrow = new System.Windows.Forms.PictureBox();
            this.ERbackButton = new System.Windows.Forms.Button();
            this.ERtotalExceptionLabel = new System.Windows.Forms.Label();
            this.ERtotalExceptioncalc = new System.Windows.Forms.TextBox();
            this.ERexceptionPerProduct = new System.Windows.Forms.DataGridView();
            this.skuCodeCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceException = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.createPdfButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ERgridInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERordergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERbackArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERexceptionPerProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ERorderID
            // 
            this.ERorderID.AutoSize = true;
            this.ERorderID.BackColor = System.Drawing.Color.Transparent;
            this.ERorderID.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERorderID.Location = new System.Drawing.Point(580, 93);
            this.ERorderID.Name = "ERorderID";
            this.ERorderID.Size = new System.Drawing.Size(81, 19);
            this.ERorderID.TabIndex = 82;
            this.ERorderID.Text = "Order ID";
            this.ERorderID.Click += new System.EventHandler(this.ERorderID_Click);
            // 
            // ERinvoiceID
            // 
            this.ERinvoiceID.AutoSize = true;
            this.ERinvoiceID.BackColor = System.Drawing.Color.Transparent;
            this.ERinvoiceID.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERinvoiceID.Location = new System.Drawing.Point(14, 93);
            this.ERinvoiceID.Name = "ERinvoiceID";
            this.ERinvoiceID.Size = new System.Drawing.Size(93, 19);
            this.ERinvoiceID.TabIndex = 83;
            this.ERinvoiceID.Text = "Invoice ID";
            this.ERinvoiceID.Click += new System.EventHandler(this.ERinvoiceID_Click);
            // 
            // ERInvoiceIDTextBox
            // 
            this.ERInvoiceIDTextBox.Location = new System.Drawing.Point(113, 94);
            this.ERInvoiceIDTextBox.Name = "ERInvoiceIDTextBox";
            this.ERInvoiceIDTextBox.Size = new System.Drawing.Size(83, 20);
            this.ERInvoiceIDTextBox.TabIndex = 84;
            this.ERInvoiceIDTextBox.TextChanged += new System.EventHandler(this.ERInvoiceIDTextBox_TextChanged);
            // 
            // ERorderIDTextBox
            // 
            this.ERorderIDTextBox.Location = new System.Drawing.Point(667, 92);
            this.ERorderIDTextBox.Name = "ERorderIDTextBox";
            this.ERorderIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ERorderIDTextBox.TabIndex = 85;
            this.ERorderIDTextBox.TextChanged += new System.EventHandler(this.ERorderIDTextBox_TextChanged);
            // 
            // ERheadline
            // 
            this.ERheadline.AutoSize = true;
            this.ERheadline.BackColor = System.Drawing.Color.Transparent;
            this.ERheadline.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERheadline.ForeColor = System.Drawing.Color.SteelBlue;
            this.ERheadline.Location = new System.Drawing.Point(4, -6);
            this.ERheadline.Name = "ERheadline";
            this.ERheadline.Size = new System.Drawing.Size(581, 81);
            this.ERheadline.TabIndex = 86;
            this.ERheadline.Text = "Exceptions Report";
            this.ERheadline.Click += new System.EventHandler(this.ERheadline_Click);
            // 
            // ERgridInvoice
            // 
            this.ERgridInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ERgridInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuCode,
            this.productName,
            this.price,
            this.amount,
            this.overallPrice});
            this.ERgridInvoice.Location = new System.Drawing.Point(6, 120);
            this.ERgridInvoice.Name = "ERgridInvoice";
            this.ERgridInvoice.Size = new System.Drawing.Size(523, 246);
            this.ERgridInvoice.TabIndex = 87;
            this.ERgridInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ERgridInvoice_CellContentClick);
            // 
            // skuCode
            // 
            this.skuCode.HeaderText = "skuCode";
            this.skuCode.Name = "skuCode";
            // 
            // productName
            // 
            this.productName.HeaderText = "productName";
            this.productName.Name = "productName";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            // 
            // overallPrice
            // 
            this.overallPrice.HeaderText = "overallPrice";
            this.overallPrice.Name = "overallPrice";
            // 
            // ERordergrid
            // 
            this.ERordergrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ERordergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ERordergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ERordergrid.Location = new System.Drawing.Point(544, 120);
            this.ERordergrid.Name = "ERordergrid";
            this.ERordergrid.Size = new System.Drawing.Size(546, 246);
            this.ERordergrid.TabIndex = 88;
            this.ERordergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ERordergrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "skuCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "productName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "overallPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ERtotalPriceInvoicelabel
            // 
            this.ERtotalPriceInvoicelabel.AllowDrop = true;
            this.ERtotalPriceInvoicelabel.AutoSize = true;
            this.ERtotalPriceInvoicelabel.BackColor = System.Drawing.Color.Transparent;
            this.ERtotalPriceInvoicelabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERtotalPriceInvoicelabel.Location = new System.Drawing.Point(380, 370);
            this.ERtotalPriceInvoicelabel.Name = "ERtotalPriceInvoicelabel";
            this.ERtotalPriceInvoicelabel.Size = new System.Drawing.Size(96, 19);
            this.ERtotalPriceInvoicelabel.TabIndex = 90;
            this.ERtotalPriceInvoicelabel.Text = "Total Price";
            this.ERtotalPriceInvoicelabel.Click += new System.EventHandler(this.ERtotalPriceInvoicelabel_Click);
            // 
            // ERInvoiceTotalSumCalc
            // 
            this.ERInvoiceTotalSumCalc.Location = new System.Drawing.Point(482, 372);
            this.ERInvoiceTotalSumCalc.Name = "ERInvoiceTotalSumCalc";
            this.ERInvoiceTotalSumCalc.Size = new System.Drawing.Size(47, 20);
            this.ERInvoiceTotalSumCalc.TabIndex = 89;
            this.ERInvoiceTotalSumCalc.TextChanged += new System.EventHandler(this.ERInvoiceTotalSumCalc_TextChanged);
            // 
            // ERtotalPriceOrderlabel
            // 
            this.ERtotalPriceOrderlabel.AllowDrop = true;
            this.ERtotalPriceOrderlabel.AutoSize = true;
            this.ERtotalPriceOrderlabel.BackColor = System.Drawing.Color.Transparent;
            this.ERtotalPriceOrderlabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERtotalPriceOrderlabel.Location = new System.Drawing.Point(936, 371);
            this.ERtotalPriceOrderlabel.Name = "ERtotalPriceOrderlabel";
            this.ERtotalPriceOrderlabel.Size = new System.Drawing.Size(96, 19);
            this.ERtotalPriceOrderlabel.TabIndex = 92;
            this.ERtotalPriceOrderlabel.Text = "Total Price";
            this.ERtotalPriceOrderlabel.Click += new System.EventHandler(this.ERtotalPriceOrderlabel_Click);
            // 
            // EROrderTotalSumCalc
            // 
            this.EROrderTotalSumCalc.Location = new System.Drawing.Point(1039, 372);
            this.EROrderTotalSumCalc.Name = "EROrderTotalSumCalc";
            this.EROrderTotalSumCalc.Size = new System.Drawing.Size(51, 20);
            this.EROrderTotalSumCalc.TabIndex = 91;
            this.EROrderTotalSumCalc.TextChanged += new System.EventHandler(this.EROrderTotalSumCalc_TextChanged);
            // 
            // ERbackArrow
            // 
            this.ERbackArrow.BackColor = System.Drawing.Color.Transparent;
            this.ERbackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ERbackArrow.BackgroundImage")));
            this.ERbackArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ERbackArrow.Location = new System.Drawing.Point(18, 455);
            this.ERbackArrow.Name = "ERbackArrow";
            this.ERbackArrow.Size = new System.Drawing.Size(69, 41);
            this.ERbackArrow.TabIndex = 94;
            this.ERbackArrow.TabStop = false;
            this.ERbackArrow.Click += new System.EventHandler(this.ERbackArrow_Click);
            // 
            // ERbackButton
            // 
            this.ERbackButton.BackColor = System.Drawing.Color.DarkGray;
            this.ERbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ERbackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ERbackButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERbackButton.Location = new System.Drawing.Point(18, 503);
            this.ERbackButton.Name = "ERbackButton";
            this.ERbackButton.Size = new System.Drawing.Size(75, 23);
            this.ERbackButton.TabIndex = 93;
            this.ERbackButton.Text = "BACK";
            this.ERbackButton.UseVisualStyleBackColor = false;
            this.ERbackButton.Click += new System.EventHandler(this.ERbackButton_Click);
            // 
            // ERtotalExceptionLabel
            // 
            this.ERtotalExceptionLabel.AllowDrop = true;
            this.ERtotalExceptionLabel.AutoSize = true;
            this.ERtotalExceptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ERtotalExceptionLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERtotalExceptionLabel.Location = new System.Drawing.Point(1008, 455);
            this.ERtotalExceptionLabel.Name = "ERtotalExceptionLabel";
            this.ERtotalExceptionLabel.Size = new System.Drawing.Size(134, 19);
            this.ERtotalExceptionLabel.TabIndex = 95;
            this.ERtotalExceptionLabel.Text = "Total Exception";
            this.ERtotalExceptionLabel.Click += new System.EventHandler(this.ERtotalExceptionLabel_Click);
            // 
            // ERtotalExceptioncalc
            // 
            this.ERtotalExceptioncalc.Location = new System.Drawing.Point(1148, 454);
            this.ERtotalExceptioncalc.Name = "ERtotalExceptioncalc";
            this.ERtotalExceptioncalc.Size = new System.Drawing.Size(100, 20);
            this.ERtotalExceptioncalc.TabIndex = 96;
            this.ERtotalExceptioncalc.TextChanged += new System.EventHandler(this.ERtotalExceptioncalc_TextChanged);
            // 
            // ERexceptionPerProduct
            // 
            this.ERexceptionPerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ERexceptionPerProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuCodeCheck,
            this.PriceException});
            this.ERexceptionPerProduct.Location = new System.Drawing.Point(1096, 120);
            this.ERexceptionPerProduct.Name = "ERexceptionPerProduct";
            this.ERexceptionPerProduct.Size = new System.Drawing.Size(248, 246);
            this.ERexceptionPerProduct.TabIndex = 97;
            this.ERexceptionPerProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ERexceptionPerProduct_CellContentClick);
            // 
            // skuCodeCheck
            // 
            this.skuCodeCheck.HeaderText = "skuCode";
            this.skuCodeCheck.Name = "skuCodeCheck";
            // 
            // PriceException
            // 
            this.PriceException.HeaderText = "PriceException";
            this.PriceException.Name = "PriceException";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReportButton.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.Location = new System.Drawing.Point(940, 89);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(75, 23);
            this.generateReportButton.TabIndex = 98;
            this.generateReportButton.Text = "Generate";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // createPdfButton
            // 
            this.createPdfButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPdfButton.Location = new System.Drawing.Point(1148, 496);
            this.createPdfButton.Name = "createPdfButton";
            this.createPdfButton.Size = new System.Drawing.Size(109, 42);
            this.createPdfButton.TabIndex = 99;
            this.createPdfButton.Text = "CREATE PDF";
            this.createPdfButton.UseVisualStyleBackColor = true;
            this.createPdfButton.Click += new System.EventHandler(this.createPdfButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1291, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 101;
            this.label1.Text = "Home Page";
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Transparent;
            this.homePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePageButton.BackgroundImage")));
            this.homePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homePageButton.Location = new System.Drawing.Point(1294, 12);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 100;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // CreateAnExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.createPdfButton);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.ERexceptionPerProduct);
            this.Controls.Add(this.ERtotalExceptioncalc);
            this.Controls.Add(this.ERtotalExceptionLabel);
            this.Controls.Add(this.ERbackArrow);
            this.Controls.Add(this.ERbackButton);
            this.Controls.Add(this.ERtotalPriceOrderlabel);
            this.Controls.Add(this.EROrderTotalSumCalc);
            this.Controls.Add(this.ERtotalPriceInvoicelabel);
            this.Controls.Add(this.ERInvoiceTotalSumCalc);
            this.Controls.Add(this.ERordergrid);
            this.Controls.Add(this.ERgridInvoice);
            this.Controls.Add(this.ERheadline);
            this.Controls.Add(this.ERorderIDTextBox);
            this.Controls.Add(this.ERInvoiceIDTextBox);
            this.Controls.Add(this.ERinvoiceID);
            this.Controls.Add(this.ERorderID);
            this.Name = "CreateAnExceptionReport";
            this.Text = "Create An Exception Report";
            ((System.ComponentModel.ISupportInitialize)(this.ERgridInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERordergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERbackArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERexceptionPerProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ERorderID;
        private System.Windows.Forms.Label ERinvoiceID;
        private System.Windows.Forms.TextBox ERInvoiceIDTextBox;
        private System.Windows.Forms.TextBox ERorderIDTextBox;
        private System.Windows.Forms.Label ERheadline;
        private System.Windows.Forms.DataGridView ERgridInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallPrice;
        private System.Windows.Forms.DataGridView ERordergrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label ERtotalPriceInvoicelabel;
        private System.Windows.Forms.TextBox ERInvoiceTotalSumCalc;
        private System.Windows.Forms.Label ERtotalPriceOrderlabel;
        private System.Windows.Forms.TextBox EROrderTotalSumCalc;
        private System.Windows.Forms.PictureBox ERbackArrow;
        private System.Windows.Forms.Button ERbackButton;
        private System.Windows.Forms.Label ERtotalExceptionLabel;
        private System.Windows.Forms.TextBox ERtotalExceptioncalc;
        private System.Windows.Forms.DataGridView ERexceptionPerProduct;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuCodeCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceException;
        private System.Windows.Forms.Button createPdfButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homePageButton;
    }
}