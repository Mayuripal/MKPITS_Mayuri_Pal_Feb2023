namespace InvoiceGeneration
{
    partial class InvoiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxEMIDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewEMIDetail = new System.Windows.Forms.DataGridView();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.textBoxSoldPersonId = new System.Windows.Forms.TextBox();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.labelSoldPersonId = new System.Windows.Forms.Label();
            this.labelNetAmount = new System.Windows.Forms.Label();
            this.radioButtonEMI = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.groupBoxCustomerDetail = new System.Windows.Forms.GroupBox();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxInvoiceTable = new System.Windows.Forms.GroupBox();
            this.textBoxSgstAmount = new System.Windows.Forms.TextBox();
            this.textBoxCGSTAmount = new System.Windows.Forms.TextBox();
            this.textBoxPercentSGST = new System.Windows.Forms.TextBox();
            this.textBoxPercentCGST = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantityRequired = new System.Windows.Forms.TextBox();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.labelSGSTAmount = new System.Windows.Forms.Label();
            this.labelCGSTAmount = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelQuantityRequired = new System.Windows.Forms.Label();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.groupBoxProductDetail = new System.Windows.Forms.GroupBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalQuantity = new System.Windows.Forms.TextBox();
            this.textBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalQuantity = new System.Windows.Forms.Label();
            this.labelAvailableQuantity = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.groupBoxProductName = new System.Windows.Forms.GroupBox();
            this.listBoxProductName = new System.Windows.Forms.ListBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxEMIDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMIDetail)).BeginInit();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxCustomerDetail.SuspendLayout();
            this.groupBoxInvoiceTable.SuspendLayout();
            this.groupBoxProductDetail.SuspendLayout();
            this.groupBoxProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxEMIDetails);
            this.panel1.Controls.Add(this.groupBoxPayment);
            this.panel1.Controls.Add(this.groupBoxCustomerDetail);
            this.panel1.Controls.Add(this.groupBoxInvoiceTable);
            this.panel1.Controls.Add(this.groupBoxProductDetail);
            this.panel1.Controls.Add(this.groupBoxProductName);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 711);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxEMIDetails
            // 
            this.groupBoxEMIDetails.Controls.Add(this.dataGridViewEMIDetail);
            this.groupBoxEMIDetails.Location = new System.Drawing.Point(23, 472);
            this.groupBoxEMIDetails.Name = "groupBoxEMIDetails";
            this.groupBoxEMIDetails.Size = new System.Drawing.Size(349, 216);
            this.groupBoxEMIDetails.TabIndex = 0;
            this.groupBoxEMIDetails.TabStop = false;
            this.groupBoxEMIDetails.Text = "EMI Detail";
            // 
            // dataGridViewEMIDetail
            // 
            this.dataGridViewEMIDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEMIDetail.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewEMIDetail.Name = "dataGridViewEMIDetail";
            this.dataGridViewEMIDetail.RowHeadersWidth = 62;
            this.dataGridViewEMIDetail.RowTemplate.Height = 28;
            this.dataGridViewEMIDetail.Size = new System.Drawing.Size(349, 170);
            this.dataGridViewEMIDetail.TabIndex = 0;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.textBoxSoldPersonId);
            this.groupBoxPayment.Controls.Add(this.textBoxNetAmount);
            this.groupBoxPayment.Controls.Add(this.labelSoldPersonId);
            this.groupBoxPayment.Controls.Add(this.labelNetAmount);
            this.groupBoxPayment.Controls.Add(this.radioButtonEMI);
            this.groupBoxPayment.Controls.Add(this.radioButtonCash);
            this.groupBoxPayment.Location = new System.Drawing.Point(394, 472);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(366, 216);
            this.groupBoxPayment.TabIndex = 5;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment Mode";
            // 
            // textBoxSoldPersonId
            // 
            this.textBoxSoldPersonId.Location = new System.Drawing.Point(189, 162);
            this.textBoxSoldPersonId.Name = "textBoxSoldPersonId";
            this.textBoxSoldPersonId.Size = new System.Drawing.Size(151, 26);
            this.textBoxSoldPersonId.TabIndex = 5;
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Location = new System.Drawing.Point(189, 104);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(152, 26);
            this.textBoxNetAmount.TabIndex = 3;
            // 
            // labelSoldPersonId
            // 
            this.labelSoldPersonId.AutoSize = true;
            this.labelSoldPersonId.Location = new System.Drawing.Point(21, 165);
            this.labelSoldPersonId.Name = "labelSoldPersonId";
            this.labelSoldPersonId.Size = new System.Drawing.Size(116, 20);
            this.labelSoldPersonId.TabIndex = 4;
            this.labelSoldPersonId.Text = "Sold Person ID";
            // 
            // labelNetAmount
            // 
            this.labelNetAmount.AutoSize = true;
            this.labelNetAmount.Location = new System.Drawing.Point(21, 107);
            this.labelNetAmount.Name = "labelNetAmount";
            this.labelNetAmount.Size = new System.Drawing.Size(94, 20);
            this.labelNetAmount.TabIndex = 2;
            this.labelNetAmount.Text = "Net Amount";
            // 
            // radioButtonEMI
            // 
            this.radioButtonEMI.AutoSize = true;
            this.radioButtonEMI.Location = new System.Drawing.Point(189, 52);
            this.radioButtonEMI.Name = "radioButtonEMI";
            this.radioButtonEMI.Size = new System.Drawing.Size(63, 24);
            this.radioButtonEMI.TabIndex = 1;
            this.radioButtonEMI.TabStop = true;
            this.radioButtonEMI.Text = "EMI";
            this.radioButtonEMI.UseVisualStyleBackColor = true;
            this.radioButtonEMI.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(38, 52);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(71, 24);
            this.radioButtonCash.TabIndex = 0;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBoxCustomerDetail
            // 
            this.groupBoxCustomerDetail.Controls.Add(this.textBoxPaidAmount);
            this.groupBoxCustomerDetail.Controls.Add(this.textBoxMobileNo);
            this.groupBoxCustomerDetail.Controls.Add(this.radioButtonOther);
            this.groupBoxCustomerDetail.Controls.Add(this.radioButtonFemale);
            this.groupBoxCustomerDetail.Controls.Add(this.radioButtonMale);
            this.groupBoxCustomerDetail.Controls.Add(this.textBoxLastName);
            this.groupBoxCustomerDetail.Controls.Add(this.textBoxFirstName);
            this.groupBoxCustomerDetail.Controls.Add(this.labelPaidAmount);
            this.groupBoxCustomerDetail.Controls.Add(this.labelMobileNo);
            this.groupBoxCustomerDetail.Controls.Add(this.labelGender);
            this.groupBoxCustomerDetail.Controls.Add(this.labelLastName);
            this.groupBoxCustomerDetail.Controls.Add(this.labelFirstName);
            this.groupBoxCustomerDetail.Location = new System.Drawing.Point(23, 238);
            this.groupBoxCustomerDetail.Name = "groupBoxCustomerDetail";
            this.groupBoxCustomerDetail.Size = new System.Drawing.Size(349, 228);
            this.groupBoxCustomerDetail.TabIndex = 3;
            this.groupBoxCustomerDetail.TabStop = false;
            this.groupBoxCustomerDetail.Text = "Customer Detail";
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(178, 179);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(150, 26);
            this.textBoxPaidAmount.TabIndex = 11;
            this.textBoxPaidAmount.Leave += new System.EventHandler(this.textBox14_Leave);
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Location = new System.Drawing.Point(178, 143);
            this.textBoxMobileNo.MaxLength = 10;
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(150, 26);
            this.textBoxMobileNo.TabIndex = 9;
            this.textBoxMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox13_KeyPress);
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(271, 109);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(74, 24);
            this.radioButtonOther.TabIndex = 7;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(178, 109);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 6;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(104, 109);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 5;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(178, 68);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(150, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(178, 33);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(150, 26);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(20, 186);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(100, 20);
            this.labelPaidAmount.TabIndex = 10;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Location = new System.Drawing.Point(20, 149);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(83, 20);
            this.labelMobileNo.TabIndex = 8;
            this.labelMobileNo.Text = "Mobile No.";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(20, 109);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 72);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 36);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // groupBoxInvoiceTable
            // 
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxSgstAmount);
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxCGSTAmount);
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxPercentSGST);
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxPercentCGST);
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxInvoiceTable.Controls.Add(this.textBoxQuantityRequired);
            this.groupBoxInvoiceTable.Controls.Add(this.dateTimePickerInvoiceDate);
            this.groupBoxInvoiceTable.Controls.Add(this.labelSGSTAmount);
            this.groupBoxInvoiceTable.Controls.Add(this.labelCGSTAmount);
            this.groupBoxInvoiceTable.Controls.Add(this.labelTotalPrice);
            this.groupBoxInvoiceTable.Controls.Add(this.labelQuantityRequired);
            this.groupBoxInvoiceTable.Controls.Add(this.labelInvoiceDate);
            this.groupBoxInvoiceTable.Location = new System.Drawing.Point(394, 238);
            this.groupBoxInvoiceTable.Name = "groupBoxInvoiceTable";
            this.groupBoxInvoiceTable.Size = new System.Drawing.Size(363, 228);
            this.groupBoxInvoiceTable.TabIndex = 4;
            this.groupBoxInvoiceTable.TabStop = false;
            this.groupBoxInvoiceTable.Text = "Invoice Table";
            // 
            // textBoxSgstAmount
            // 
            this.textBoxSgstAmount.Location = new System.Drawing.Point(243, 175);
            this.textBoxSgstAmount.Name = "textBoxSgstAmount";
            this.textBoxSgstAmount.ReadOnly = true;
            this.textBoxSgstAmount.Size = new System.Drawing.Size(94, 26);
            this.textBoxSgstAmount.TabIndex = 11;
            // 
            // textBoxCGSTAmount
            // 
            this.textBoxCGSTAmount.Location = new System.Drawing.Point(242, 142);
            this.textBoxCGSTAmount.Name = "textBoxCGSTAmount";
            this.textBoxCGSTAmount.ReadOnly = true;
            this.textBoxCGSTAmount.Size = new System.Drawing.Size(95, 26);
            this.textBoxCGSTAmount.TabIndex = 8;
            // 
            // textBoxPercentSGST
            // 
            this.textBoxPercentSGST.Location = new System.Drawing.Point(185, 175);
            this.textBoxPercentSGST.Name = "textBoxPercentSGST";
            this.textBoxPercentSGST.ReadOnly = true;
            this.textBoxPercentSGST.Size = new System.Drawing.Size(51, 26);
            this.textBoxPercentSGST.TabIndex = 10;
            // 
            // textBoxPercentCGST
            // 
            this.textBoxPercentCGST.Location = new System.Drawing.Point(185, 142);
            this.textBoxPercentCGST.Name = "textBoxPercentCGST";
            this.textBoxPercentCGST.ReadOnly = true;
            this.textBoxPercentCGST.Size = new System.Drawing.Size(51, 26);
            this.textBoxPercentCGST.TabIndex = 7;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(185, 102);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(152, 26);
            this.textBoxTotalPrice.TabIndex = 5;
            // 
            // textBoxQuantityRequired
            // 
            this.textBoxQuantityRequired.Location = new System.Drawing.Point(185, 68);
            this.textBoxQuantityRequired.Name = "textBoxQuantityRequired";
            this.textBoxQuantityRequired.Size = new System.Drawing.Size(152, 26);
            this.textBoxQuantityRequired.TabIndex = 3;
            //this.textBoxQuantityRequired.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(185, 31);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerInvoiceDate.TabIndex = 1;
            // 
            // labelSGSTAmount
            // 
            this.labelSGSTAmount.AutoSize = true;
            this.labelSGSTAmount.Location = new System.Drawing.Point(11, 186);
            this.labelSGSTAmount.Name = "labelSGSTAmount";
            this.labelSGSTAmount.Size = new System.Drawing.Size(117, 20);
            this.labelSGSTAmount.TabIndex = 9;
            this.labelSGSTAmount.Text = "SGST & Amount";
            // 
            // labelCGSTAmount
            // 
            this.labelCGSTAmount.AutoSize = true;
            this.labelCGSTAmount.Location = new System.Drawing.Point(11, 149);
            this.labelCGSTAmount.Name = "labelCGSTAmount";
            this.labelCGSTAmount.Size = new System.Drawing.Size(117, 20);
            this.labelCGSTAmount.TabIndex = 6;
            this.labelCGSTAmount.Text = "CGST & Amount";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(11, 109);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // labelQuantityRequired
            // 
            this.labelQuantityRequired.AutoSize = true;
            this.labelQuantityRequired.Location = new System.Drawing.Point(11, 72);
            this.labelQuantityRequired.Name = "labelQuantityRequired";
            this.labelQuantityRequired.Size = new System.Drawing.Size(137, 20);
            this.labelQuantityRequired.TabIndex = 2;
            this.labelQuantityRequired.Text = "Quantity Required";
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(11, 36);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(98, 20);
            this.labelInvoiceDate.TabIndex = 0;
            this.labelInvoiceDate.Text = "Invoice Date";
            // 
            // groupBoxProductDetail
            // 
            this.groupBoxProductDetail.Controls.Add(this.textBoxPrice);
            this.groupBoxProductDetail.Controls.Add(this.textBoxTotalQuantity);
            this.groupBoxProductDetail.Controls.Add(this.textBoxAvailableQuantity);
            this.groupBoxProductDetail.Controls.Add(this.textBoxProductName);
            this.groupBoxProductDetail.Controls.Add(this.labelPrice);
            this.groupBoxProductDetail.Controls.Add(this.labelTotalQuantity);
            this.groupBoxProductDetail.Controls.Add(this.labelAvailableQuantity);
            this.groupBoxProductDetail.Controls.Add(this.labelProductName);
            this.groupBoxProductDetail.Location = new System.Drawing.Point(394, 25);
            this.groupBoxProductDetail.Name = "groupBoxProductDetail";
            this.groupBoxProductDetail.Size = new System.Drawing.Size(362, 207);
            this.groupBoxProductDetail.TabIndex = 2;
            this.groupBoxProductDetail.TabStop = false;
            this.groupBoxProductDetail.Text = "Product Detail";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(184, 158);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(137, 26);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxTotalQuantity
            // 
            this.textBoxTotalQuantity.Location = new System.Drawing.Point(184, 118);
            this.textBoxTotalQuantity.Name = "textBoxTotalQuantity";
            this.textBoxTotalQuantity.ReadOnly = true;
            this.textBoxTotalQuantity.Size = new System.Drawing.Size(137, 26);
            this.textBoxTotalQuantity.TabIndex = 5;
            // 
            // textBoxAvailableQuantity
            // 
            this.textBoxAvailableQuantity.Location = new System.Drawing.Point(184, 78);
            this.textBoxAvailableQuantity.Name = "textBoxAvailableQuantity";
            this.textBoxAvailableQuantity.ReadOnly = true;
            this.textBoxAvailableQuantity.Size = new System.Drawing.Size(137, 26);
            this.textBoxAvailableQuantity.TabIndex = 3;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(184, 31);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(137, 26);
            this.textBoxProductName.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(10, 161);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price";
            // 
            // labelTotalQuantity
            // 
            this.labelTotalQuantity.AutoSize = true;
            this.labelTotalQuantity.Location = new System.Drawing.Point(10, 124);
            this.labelTotalQuantity.Name = "labelTotalQuantity";
            this.labelTotalQuantity.Size = new System.Drawing.Size(107, 20);
            this.labelTotalQuantity.TabIndex = 4;
            this.labelTotalQuantity.Text = "Total Quantity";
            // 
            // labelAvailableQuantity
            // 
            this.labelAvailableQuantity.AutoSize = true;
            this.labelAvailableQuantity.Location = new System.Drawing.Point(10, 78);
            this.labelAvailableQuantity.Name = "labelAvailableQuantity";
            this.labelAvailableQuantity.Size = new System.Drawing.Size(135, 20);
            this.labelAvailableQuantity.TabIndex = 2;
            this.labelAvailableQuantity.Text = "Available Quantity";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(10, 31);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(110, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name";
            // 
            // groupBoxProductName
            // 
            this.groupBoxProductName.Controls.Add(this.listBoxProductName);
            this.groupBoxProductName.Location = new System.Drawing.Point(23, 25);
            this.groupBoxProductName.Name = "groupBoxProductName";
            this.groupBoxProductName.Size = new System.Drawing.Size(349, 207);
            this.groupBoxProductName.TabIndex = 1;
            this.groupBoxProductName.TabStop = false;
            this.groupBoxProductName.Text = "Product Name";
            // 
            // listBoxProductName
            // 
            this.listBoxProductName.FormattingEnabled = true;
            this.listBoxProductName.ItemHeight = 20;
            this.listBoxProductName.Location = new System.Drawing.Point(24, 31);
            this.listBoxProductName.Name = "listBoxProductName";
            this.listBoxProductName.Size = new System.Drawing.Size(304, 144);
            this.listBoxProductName.TabIndex = 0;
            //this.listBoxProductName.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(434, 742);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(109, 44);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(598, 742);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(109, 44);
            this.ButtonReset.TabIndex = 2;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 798);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "Invoice Generation";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxEMIDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMIDetail)).EndInit();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxCustomerDetail.ResumeLayout(false);
            this.groupBoxCustomerDetail.PerformLayout();
            this.groupBoxInvoiceTable.ResumeLayout(false);
            this.groupBoxInvoiceTable.PerformLayout();
            this.groupBoxProductDetail.ResumeLayout(false);
            this.groupBoxProductDetail.PerformLayout();
            this.groupBoxProductName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxProductName;
        private System.Windows.Forms.GroupBox groupBoxProductDetail;
        private System.Windows.Forms.TextBox textBoxAvailableQuantity;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotalQuantity;
        private System.Windows.Forms.Label labelAvailableQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTotalQuantity;
        private System.Windows.Forms.GroupBox groupBoxInvoiceTable;
        private System.Windows.Forms.Label labelSGSTAmount;
        private System.Windows.Forms.Label labelCGSTAmount;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelQuantityRequired;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.TextBox textBoxSgstAmount;
        private System.Windows.Forms.TextBox textBoxCGSTAmount;
        private System.Windows.Forms.TextBox textBoxPercentSGST;
        private System.Windows.Forms.TextBox textBoxPercentCGST;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.TextBox textBoxQuantityRequired;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxMobileNo;
        private System.Windows.Forms.GroupBox groupBoxEMIDetails;
        private System.Windows.Forms.DataGridView dataGridViewEMIDetail;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label labelSoldPersonId;
        private System.Windows.Forms.Label labelNetAmount;
        private System.Windows.Forms.RadioButton radioButtonEMI;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.TextBox textBoxSoldPersonId;
        private System.Windows.Forms.TextBox textBoxNetAmount;
        private System.Windows.Forms.ListBox listBoxProductName;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReset;
    }
}

