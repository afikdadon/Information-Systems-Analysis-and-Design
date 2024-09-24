namespace Group_1
{
    partial class CreateInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInvoiceForm));
            this.createInvoiceLabel = new System.Windows.Forms.Label();
            this.InvoiceProductLabel = new System.Windows.Forms.Label();
            this.InvoiceSupplierLabel = new System.Windows.Forms.Label();
            this.InvoiceProductComboBox = new System.Windows.Forms.ComboBox();
            this.InvoiceAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InvoiceaddProductButton = new System.Windows.Forms.Button();
            this.InvoiceAmountLabel = new System.Windows.Forms.Label();
            this.InvoiceRemoveProductButton = new System.Windows.Forms.Button();
            this.InvoiceDataGridView1 = new System.Windows.Forms.DataGridView();
            this.skuCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceBackArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.InvoiceBackButton = new System.Windows.Forms.Button();
            this.InvoiceCheckOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.SerchIDButton = new System.Windows.Forms.Button();
            this.InvoiceSupplier = new System.Windows.Forms.TextBox();
            this.InvoiceTotalSumCalc = new System.Windows.Forms.TextBox();
            this.InvoiceTotalPriceLabel = new System.Windows.Forms.Label();
            this.generateExceptionReport = new System.Windows.Forms.Button();
            this.InvoiceIDlabel = new System.Windows.Forms.Label();
            this.InvoiceIDtextbox = new System.Windows.Forms.TextBox();
            this.invoicePriceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.homePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBackArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createInvoiceLabel
            // 
            this.createInvoiceLabel.AutoSize = true;
            this.createInvoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.createInvoiceLabel.Font = new System.Drawing.Font("Maiandra GD", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createInvoiceLabel.ForeColor = System.Drawing.Color.Navy;
            this.createInvoiceLabel.Location = new System.Drawing.Point(46, 9);
            this.createInvoiceLabel.Name = "createInvoiceLabel";
            this.createInvoiceLabel.Size = new System.Drawing.Size(691, 81);
            this.createInvoiceLabel.TabIndex = 32;
            this.createInvoiceLabel.Text = "Create a New Invoice";
            this.createInvoiceLabel.Click += new System.EventHandler(this.createInvoiceLabel_Click);
            // 
            // InvoiceProductLabel
            // 
            this.InvoiceProductLabel.AutoSize = true;
            this.InvoiceProductLabel.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceProductLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceProductLabel.Location = new System.Drawing.Point(56, 208);
            this.InvoiceProductLabel.Name = "InvoiceProductLabel";
            this.InvoiceProductLabel.Size = new System.Drawing.Size(71, 19);
            this.InvoiceProductLabel.TabIndex = 61;
            this.InvoiceProductLabel.Text = "Product";
            this.InvoiceProductLabel.Click += new System.EventHandler(this.InvoiceProductLabel_Click);
            // 
            // InvoiceSupplierLabel
            // 
            this.InvoiceSupplierLabel.AutoSize = true;
            this.InvoiceSupplierLabel.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceSupplierLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceSupplierLabel.Location = new System.Drawing.Point(417, 165);
            this.InvoiceSupplierLabel.Name = "InvoiceSupplierLabel";
            this.InvoiceSupplierLabel.Size = new System.Drawing.Size(79, 19);
            this.InvoiceSupplierLabel.TabIndex = 59;
            this.InvoiceSupplierLabel.Text = "Supplier:";
            this.InvoiceSupplierLabel.Click += new System.EventHandler(this.InvoiceSupplierLabel_Click);
            // 
            // InvoiceProductComboBox
            // 
            this.InvoiceProductComboBox.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceProductComboBox.FormattingEnabled = true;
            this.InvoiceProductComboBox.Location = new System.Drawing.Point(170, 204);
            this.InvoiceProductComboBox.Name = "InvoiceProductComboBox";
            this.InvoiceProductComboBox.Size = new System.Drawing.Size(228, 23);
            this.InvoiceProductComboBox.TabIndex = 72;
            this.InvoiceProductComboBox.SelectedIndexChanged += new System.EventHandler(this.InvoiceProductComboBox_SelectedIndexChanged);
            // 
            // InvoiceAmountNumericUpDown
            // 
            this.InvoiceAmountNumericUpDown.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceAmountNumericUpDown.Location = new System.Drawing.Point(789, 206);
            this.InvoiceAmountNumericUpDown.Name = "InvoiceAmountNumericUpDown";
            this.InvoiceAmountNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.InvoiceAmountNumericUpDown.TabIndex = 75;
            this.InvoiceAmountNumericUpDown.ValueChanged += new System.EventHandler(this.InvoiceAmountNumericUpDown_ValueChanged);
            // 
            // InvoiceaddProductButton
            // 
            this.InvoiceaddProductButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.InvoiceaddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceaddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InvoiceaddProductButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceaddProductButton.ForeColor = System.Drawing.Color.Black;
            this.InvoiceaddProductButton.Location = new System.Drawing.Point(60, 254);
            this.InvoiceaddProductButton.Name = "InvoiceaddProductButton";
            this.InvoiceaddProductButton.Size = new System.Drawing.Size(101, 24);
            this.InvoiceaddProductButton.TabIndex = 74;
            this.InvoiceaddProductButton.Text = "Add +";
            this.InvoiceaddProductButton.UseVisualStyleBackColor = false;
            this.InvoiceaddProductButton.Click += new System.EventHandler(this.InvoiceaddProductButton_Click);
            // 
            // InvoiceAmountLabel
            // 
            this.InvoiceAmountLabel.AutoSize = true;
            this.InvoiceAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceAmountLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceAmountLabel.Location = new System.Drawing.Point(695, 208);
            this.InvoiceAmountLabel.Name = "InvoiceAmountLabel";
            this.InvoiceAmountLabel.Size = new System.Drawing.Size(73, 19);
            this.InvoiceAmountLabel.TabIndex = 73;
            this.InvoiceAmountLabel.Text = "Amount";
            this.InvoiceAmountLabel.Click += new System.EventHandler(this.InvoiceAmountLabel_Click);
            // 
            // InvoiceRemoveProductButton
            // 
            this.InvoiceRemoveProductButton.BackColor = System.Drawing.Color.Maroon;
            this.InvoiceRemoveProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceRemoveProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InvoiceRemoveProductButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceRemoveProductButton.ForeColor = System.Drawing.Color.Black;
            this.InvoiceRemoveProductButton.Location = new System.Drawing.Point(808, 254);
            this.InvoiceRemoveProductButton.Name = "InvoiceRemoveProductButton";
            this.InvoiceRemoveProductButton.Size = new System.Drawing.Size(101, 24);
            this.InvoiceRemoveProductButton.TabIndex = 76;
            this.InvoiceRemoveProductButton.Text = "Remove";
            this.InvoiceRemoveProductButton.UseVisualStyleBackColor = false;
            this.InvoiceRemoveProductButton.Click += new System.EventHandler(this.InvoiceRemoveProductButton_Click);
            // 
            // InvoiceDataGridView1
            // 
            this.InvoiceDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skuCode,
            this.productName,
            this.price,
            this.amount,
            this.overallPrice});
            this.InvoiceDataGridView1.Location = new System.Drawing.Point(60, 284);
            this.InvoiceDataGridView1.Name = "InvoiceDataGridView1";
            this.InvoiceDataGridView1.Size = new System.Drawing.Size(849, 249);
            this.InvoiceDataGridView1.TabIndex = 77;
            this.InvoiceDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvoiceDataGridView1_CellContentClick);
            // 
            // skuCode
            // 
            this.skuCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skuCode.HeaderText = "skuCode";
            this.skuCode.Name = "skuCode";
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "productName";
            this.productName.Name = "productName";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            // 
            // overallPrice
            // 
            this.overallPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.overallPrice.HeaderText = "overallPrice";
            this.overallPrice.Name = "overallPrice";
            // 
            // InvoiceBackArrowPictureBox
            // 
            this.InvoiceBackArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceBackArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InvoiceBackArrowPictureBox.BackgroundImage")));
            this.InvoiceBackArrowPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InvoiceBackArrowPictureBox.Location = new System.Drawing.Point(12, 605);
            this.InvoiceBackArrowPictureBox.Name = "InvoiceBackArrowPictureBox";
            this.InvoiceBackArrowPictureBox.Size = new System.Drawing.Size(69, 41);
            this.InvoiceBackArrowPictureBox.TabIndex = 80;
            this.InvoiceBackArrowPictureBox.TabStop = false;
            this.InvoiceBackArrowPictureBox.Click += new System.EventHandler(this.InvoiceBackArrowPictureBox_Click);
            // 
            // InvoiceBackButton
            // 
            this.InvoiceBackButton.BackColor = System.Drawing.Color.DarkGray;
            this.InvoiceBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceBackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InvoiceBackButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceBackButton.Location = new System.Drawing.Point(12, 653);
            this.InvoiceBackButton.Name = "InvoiceBackButton";
            this.InvoiceBackButton.Size = new System.Drawing.Size(75, 23);
            this.InvoiceBackButton.TabIndex = 79;
            this.InvoiceBackButton.Text = "BACK";
            this.InvoiceBackButton.UseVisualStyleBackColor = false;
            this.InvoiceBackButton.Click += new System.EventHandler(this.InvoiceBackButton_Click);
            // 
            // InvoiceCheckOutButton
            // 
            this.InvoiceCheckOutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.InvoiceCheckOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceCheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InvoiceCheckOutButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceCheckOutButton.ForeColor = System.Drawing.Color.Black;
            this.InvoiceCheckOutButton.Location = new System.Drawing.Point(760, 546);
            this.InvoiceCheckOutButton.Name = "InvoiceCheckOutButton";
            this.InvoiceCheckOutButton.Size = new System.Drawing.Size(149, 33);
            this.InvoiceCheckOutButton.TabIndex = 78;
            this.InvoiceCheckOutButton.Text = "CHECKOUT";
            this.InvoiceCheckOutButton.UseVisualStyleBackColor = false;
            this.InvoiceCheckOutButton.Click += new System.EventHandler(this.InvoiceCheckOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Order ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDTextBox.Location = new System.Drawing.Point(170, 112);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(137, 22);
            this.OrderIDTextBox.TabIndex = 82;
            this.OrderIDTextBox.TextChanged += new System.EventHandler(this.OrderIDTextBox_TextChanged);
            // 
            // SerchIDButton
            // 
            this.SerchIDButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SerchIDButton.Location = new System.Drawing.Point(313, 111);
            this.SerchIDButton.Name = "SerchIDButton";
            this.SerchIDButton.Size = new System.Drawing.Size(75, 23);
            this.SerchIDButton.TabIndex = 83;
            this.SerchIDButton.Text = "Search";
            this.SerchIDButton.UseVisualStyleBackColor = true;
            this.SerchIDButton.Click += new System.EventHandler(this.SerchIDButton_Click);
            // 
            // InvoiceSupplier
            // 
            this.InvoiceSupplier.Cursor = System.Windows.Forms.Cursors.No;
            this.InvoiceSupplier.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceSupplier.Location = new System.Drawing.Point(502, 164);
            this.InvoiceSupplier.Name = "InvoiceSupplier";
            this.InvoiceSupplier.Size = new System.Drawing.Size(137, 22);
            this.InvoiceSupplier.TabIndex = 84;
            this.InvoiceSupplier.TextChanged += new System.EventHandler(this.InvoiceSupplier_TextChanged);
            // 
            // InvoiceTotalSumCalc
            // 
            this.InvoiceTotalSumCalc.Cursor = System.Windows.Forms.Cursors.No;
            this.InvoiceTotalSumCalc.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceTotalSumCalc.Location = new System.Drawing.Point(182, 552);
            this.InvoiceTotalSumCalc.Name = "InvoiceTotalSumCalc";
            this.InvoiceTotalSumCalc.Size = new System.Drawing.Size(116, 22);
            this.InvoiceTotalSumCalc.TabIndex = 85;
            this.InvoiceTotalSumCalc.TextChanged += new System.EventHandler(this.InvoiceTotalSumCalc_TextChanged);
            // 
            // InvoiceTotalPriceLabel
            // 
            this.InvoiceTotalPriceLabel.AllowDrop = true;
            this.InvoiceTotalPriceLabel.AutoSize = true;
            this.InvoiceTotalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceTotalPriceLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceTotalPriceLabel.Location = new System.Drawing.Point(56, 553);
            this.InvoiceTotalPriceLabel.Name = "InvoiceTotalPriceLabel";
            this.InvoiceTotalPriceLabel.Size = new System.Drawing.Size(96, 19);
            this.InvoiceTotalPriceLabel.TabIndex = 86;
            this.InvoiceTotalPriceLabel.Text = "Total Price";
            this.InvoiceTotalPriceLabel.Click += new System.EventHandler(this.InvoiceTotalPriceLabel_Click);
            // 
            // generateExceptionReport
            // 
            this.generateExceptionReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.generateExceptionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateExceptionReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateExceptionReport.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExceptionReport.ForeColor = System.Drawing.Color.Black;
            this.generateExceptionReport.Location = new System.Drawing.Point(591, 605);
            this.generateExceptionReport.Name = "generateExceptionReport";
            this.generateExceptionReport.Size = new System.Drawing.Size(318, 35);
            this.generateExceptionReport.TabIndex = 87;
            this.generateExceptionReport.Text = "GENERATE AN EXCEPTION REPORT";
            this.generateExceptionReport.UseVisualStyleBackColor = false;
            this.generateExceptionReport.Click += new System.EventHandler(this.generateExceptionReport_Click);
            // 
            // InvoiceIDlabel
            // 
            this.InvoiceIDlabel.AutoSize = true;
            this.InvoiceIDlabel.BackColor = System.Drawing.Color.Transparent;
            this.InvoiceIDlabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceIDlabel.Location = new System.Drawing.Point(56, 165);
            this.InvoiceIDlabel.Name = "InvoiceIDlabel";
            this.InvoiceIDlabel.Size = new System.Drawing.Size(93, 19);
            this.InvoiceIDlabel.TabIndex = 88;
            this.InvoiceIDlabel.Text = "Invoice ID";
            this.InvoiceIDlabel.Click += new System.EventHandler(this.InvoiceIDlabel_Click);
            // 
            // InvoiceIDtextbox
            // 
            this.InvoiceIDtextbox.Cursor = System.Windows.Forms.Cursors.No;
            this.InvoiceIDtextbox.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceIDtextbox.Location = new System.Drawing.Point(170, 166);
            this.InvoiceIDtextbox.Name = "InvoiceIDtextbox";
            this.InvoiceIDtextbox.Size = new System.Drawing.Size(137, 22);
            this.InvoiceIDtextbox.TabIndex = 89;
            this.InvoiceIDtextbox.TextChanged += new System.EventHandler(this.InvoiceIDtextbox_TextChanged);
            // 
            // invoicePriceLabel
            // 
            this.invoicePriceLabel.AutoSize = true;
            this.invoicePriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.invoicePriceLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicePriceLabel.Location = new System.Drawing.Point(417, 203);
            this.invoicePriceLabel.Name = "invoicePriceLabel";
            this.invoicePriceLabel.Size = new System.Drawing.Size(48, 19);
            this.invoicePriceLabel.TabIndex = 90;
            this.invoicePriceLabel.Text = "Price";
            this.invoicePriceLabel.Click += new System.EventHandler(this.invoicePriceLabel_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(502, 206);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(137, 22);
            this.priceTextBox.TabIndex = 91;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 93;
            this.label2.Text = "Home Page";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.BackColor = System.Drawing.Color.Transparent;
            this.homePageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePageButton.BackgroundImage")));
            this.homePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.homePageButton.Location = new System.Drawing.Point(921, 9);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(50, 39);
            this.homePageButton.TabIndex = 92;
            this.homePageButton.UseVisualStyleBackColor = false;
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // CreateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homePageButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.invoicePriceLabel);
            this.Controls.Add(this.InvoiceIDtextbox);
            this.Controls.Add(this.InvoiceIDlabel);
            this.Controls.Add(this.generateExceptionReport);
            this.Controls.Add(this.InvoiceTotalPriceLabel);
            this.Controls.Add(this.InvoiceTotalSumCalc);
            this.Controls.Add(this.InvoiceSupplier);
            this.Controls.Add(this.SerchIDButton);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InvoiceBackArrowPictureBox);
            this.Controls.Add(this.InvoiceBackButton);
            this.Controls.Add(this.InvoiceCheckOutButton);
            this.Controls.Add(this.InvoiceDataGridView1);
            this.Controls.Add(this.InvoiceRemoveProductButton);
            this.Controls.Add(this.InvoiceAmountNumericUpDown);
            this.Controls.Add(this.InvoiceaddProductButton);
            this.Controls.Add(this.InvoiceAmountLabel);
            this.Controls.Add(this.InvoiceProductComboBox);
            this.Controls.Add(this.InvoiceProductLabel);
            this.Controls.Add(this.InvoiceSupplierLabel);
            this.Controls.Add(this.createInvoiceLabel);
            this.Name = "CreateInvoiceForm";
            this.Text = "Create Invoice";
            this.Load += new System.EventHandler(this.CreateInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceBackArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createInvoiceLabel;
        private System.Windows.Forms.Label InvoiceProductLabel;
        private System.Windows.Forms.Label InvoiceSupplierLabel;
        private System.Windows.Forms.ComboBox InvoiceProductComboBox;
        private System.Windows.Forms.NumericUpDown InvoiceAmountNumericUpDown;
        private System.Windows.Forms.Button InvoiceaddProductButton;
        private System.Windows.Forms.Label InvoiceAmountLabel;
        private System.Windows.Forms.Button InvoiceRemoveProductButton;
        private System.Windows.Forms.DataGridView InvoiceDataGridView1;
        private System.Windows.Forms.PictureBox InvoiceBackArrowPictureBox;
        private System.Windows.Forms.Button InvoiceBackButton;
        private System.Windows.Forms.Button InvoiceCheckOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.Button SerchIDButton;
        private System.Windows.Forms.TextBox InvoiceSupplier;
        private System.Windows.Forms.TextBox InvoiceTotalSumCalc;
        private System.Windows.Forms.Label InvoiceTotalPriceLabel;
        private System.Windows.Forms.Button generateExceptionReport;
        private System.Windows.Forms.Label InvoiceIDlabel;
        private System.Windows.Forms.TextBox InvoiceIDtextbox;
        private System.Windows.Forms.Label invoicePriceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn skuCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn overallPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homePageButton;
    }
}