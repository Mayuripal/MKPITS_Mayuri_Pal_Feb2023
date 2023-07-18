namespace Form1
{
    partial class FormCourseRegistration
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
            this.groupBoxUserDetail = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelNation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxFeeDetail = new System.Windows.Forms.GroupBox();
            this.textBoxBalAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelBalAmount = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelPymentDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxUserDetail.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxFeeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserDetail
            // 
            this.groupBoxUserDetail.Controls.Add(this.comboBox3);
            this.groupBoxUserDetail.Controls.Add(this.comboBox2);
            this.groupBoxUserDetail.Controls.Add(this.comboBox1);
            this.groupBoxUserDetail.Controls.Add(this.groupBoxGender);
            this.groupBoxUserDetail.Controls.Add(this.textBoxName);
            this.groupBoxUserDetail.Controls.Add(this.labelCity);
            this.groupBoxUserDetail.Controls.Add(this.labelState);
            this.groupBoxUserDetail.Controls.Add(this.labelNation);
            this.groupBoxUserDetail.Controls.Add(this.labelName);
            this.groupBoxUserDetail.Controls.Add(this.groupBoxCategory);
            this.groupBoxUserDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserDetail.Location = new System.Drawing.Point(7, 4);
            this.groupBoxUserDetail.Name = "groupBoxUserDetail";
            this.groupBoxUserDetail.Size = new System.Drawing.Size(341, 270);
            this.groupBoxUserDetail.TabIndex = 0;
            this.groupBoxUserDetail.TabStop = false;
            this.groupBoxUserDetail.Text = "UserDetails";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(115, 227);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 29);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(115, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 29);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonOther);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(8, 106);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(324, 56);
            this.groupBoxGender.TabIndex = 3;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(217, 27);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(80, 25);
            this.radioButtonOther.TabIndex = 2;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(95, 27);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(94, 25);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(15, 27);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(74, 25);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(217, 28);
            this.textBoxName.TabIndex = 2;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(6, 238);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(41, 21);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "City";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(6, 203);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 21);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State";
            // 
            // labelNation
            // 
            this.labelNation.AutoSize = true;
            this.labelNation.Location = new System.Drawing.Point(6, 169);
            this.labelNation.Name = "labelNation";
            this.labelNation.Size = new System.Drawing.Size(62, 21);
            this.labelNation.TabIndex = 4;
            this.labelNation.Text = "Nation";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Full Name";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.radioButton2);
            this.groupBoxCategory.Controls.Add(this.radioButton1);
            this.groupBoxCategory.Location = new System.Drawing.Point(8, 20);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(324, 54);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "IT Professional";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBoxFeeDetail
            // 
            this.groupBoxFeeDetail.Controls.Add(this.textBoxBalAmount);
            this.groupBoxFeeDetail.Controls.Add(this.textBoxPaidAmount);
            this.groupBoxFeeDetail.Controls.Add(this.textBoxTotalAmount);
            this.groupBoxFeeDetail.Controls.Add(this.dateTimePickerPaymentDate);
            this.groupBoxFeeDetail.Controls.Add(this.labelTotalAmount);
            this.groupBoxFeeDetail.Controls.Add(this.labelBalAmount);
            this.groupBoxFeeDetail.Controls.Add(this.labelPaidAmount);
            this.groupBoxFeeDetail.Controls.Add(this.labelPymentDate);
            this.groupBoxFeeDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFeeDetail.Location = new System.Drawing.Point(356, 4);
            this.groupBoxFeeDetail.Name = "groupBoxFeeDetail";
            this.groupBoxFeeDetail.Size = new System.Drawing.Size(380, 165);
            this.groupBoxFeeDetail.TabIndex = 1;
            this.groupBoxFeeDetail.TabStop = false;
            this.groupBoxFeeDetail.Text = "Fees Detail";
            // 
            // textBoxBalAmount
            // 
            this.textBoxBalAmount.Location = new System.Drawing.Point(152, 115);
            this.textBoxBalAmount.Name = "textBoxBalAmount";
            this.textBoxBalAmount.ReadOnly = true;
            this.textBoxBalAmount.Size = new System.Drawing.Size(217, 28);
            this.textBoxBalAmount.TabIndex = 7;
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(152, 85);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(217, 28);
            this.textBoxPaidAmount.TabIndex = 5;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(152, 56);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(217, 28);
            this.textBoxTotalAmount.TabIndex = 3;
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(152, 27);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(217, 28);
            this.dateTimePickerPaymentDate.TabIndex = 1;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(7, 62);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(113, 21);
            this.labelTotalAmount.TabIndex = 2;
            this.labelTotalAmount.Text = "Total Amount";
            // 
            // labelBalAmount
            // 
            this.labelBalAmount.AutoSize = true;
            this.labelBalAmount.Location = new System.Drawing.Point(7, 125);
            this.labelBalAmount.Name = "labelBalAmount";
            this.labelBalAmount.Size = new System.Drawing.Size(139, 21);
            this.labelBalAmount.TabIndex = 6;
            this.labelBalAmount.Text = "Balance Amount";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(7, 93);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(110, 21);
            this.labelPaidAmount.TabIndex = 4;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // labelPymentDate
            // 
            this.labelPymentDate.AutoSize = true;
            this.labelPymentDate.Location = new System.Drawing.Point(7, 30);
            this.labelPymentDate.Name = "labelPymentDate";
            this.labelPymentDate.Size = new System.Drawing.Size(123, 21);
            this.labelPymentDate.TabIndex = 0;
            this.labelPymentDate.Text = "Payment Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFeeDetail);
            this.Controls.Add(this.groupBoxUserDetail);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCourseRegistration";
            this.Text = "CourseRegistration";
            this.Load += new System.EventHandler(this.FormCourseRegistration_Load);
            this.groupBoxUserDetail.ResumeLayout(false);
            this.groupBoxUserDetail.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.groupBoxFeeDetail.ResumeLayout(false);
            this.groupBoxFeeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserDetail;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelNation;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxFeeDetail;
        private System.Windows.Forms.Label labelPymentDate;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelBalAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.TextBox textBoxBalAmount;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

