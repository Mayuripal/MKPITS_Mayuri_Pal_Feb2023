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
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNation = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBoxFeeDetail = new System.Windows.Forms.GroupBox();
            this.labelPymentDate = new System.Windows.Forms.Label();
            this.groupBoxUserDetail.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxFeeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserDetail
            // 
            this.groupBoxUserDetail.Controls.Add(this.comboBox3);
            this.groupBoxUserDetail.Controls.Add(this.comboBox2);
            this.groupBoxUserDetail.Controls.Add(this.comboBox1);
            this.groupBoxUserDetail.Controls.Add(this.groupBoxGender);
            this.groupBoxUserDetail.Controls.Add(this.textBox1);
            this.groupBoxUserDetail.Controls.Add(this.labelCity);
            this.groupBoxUserDetail.Controls.Add(this.labelState);
            this.groupBoxUserDetail.Controls.Add(this.labelNation);
            this.groupBoxUserDetail.Controls.Add(this.labelName);
            this.groupBoxUserDetail.Controls.Add(this.groupBoxCategory);
            this.groupBoxUserDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserDetail.Location = new System.Drawing.Point(13, 4);
            this.groupBoxUserDetail.Name = "groupBoxUserDetail";
            this.groupBoxUserDetail.Size = new System.Drawing.Size(352, 291);
            this.groupBoxUserDetail.TabIndex = 0;
            this.groupBoxUserDetail.TabStop = false;
            this.groupBoxUserDetail.Text = "UserDetails";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.radioButton2);
            this.groupBoxCategory.Controls.Add(this.radioButton1);
            this.groupBoxCategory.Location = new System.Drawing.Point(16, 19);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(323, 62);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Student";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(165, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "IT Professional";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Full Name";
            // 
            // labelNation
            // 
            this.labelNation.AutoSize = true;
            this.labelNation.Location = new System.Drawing.Point(16, 187);
            this.labelNation.Name = "labelNation";
            this.labelNation.Size = new System.Drawing.Size(62, 21);
            this.labelNation.TabIndex = 2;
            this.labelNation.Text = "Nation";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(16, 220);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(52, 21);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(16, 257);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(41, 21);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "City";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 28);
            this.textBox1.TabIndex = 5;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonOther);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(16, 115);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(323, 63);
            this.groupBoxGender.TabIndex = 6;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(33, 26);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(74, 25);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(127, 26);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(94, 25);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(230, 26);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(80, 25);
            this.radioButtonOther.TabIndex = 2;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 29);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 29);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(143, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(196, 29);
            this.comboBox3.TabIndex = 9;
            // 
            // groupBoxFeeDetail
            // 
            this.groupBoxFeeDetail.Controls.Add(this.labelPymentDate);
            this.groupBoxFeeDetail.Location = new System.Drawing.Point(376, 5);
            this.groupBoxFeeDetail.Name = "groupBoxFeeDetail";
            this.groupBoxFeeDetail.Size = new System.Drawing.Size(352, 240);
            this.groupBoxFeeDetail.TabIndex = 1;
            this.groupBoxFeeDetail.TabStop = false;
            this.groupBoxFeeDetail.Text = "Fees Detail";
            // 
            // labelPymentDate
            // 
            this.labelPymentDate.AutoSize = true;
            this.labelPymentDate.Location = new System.Drawing.Point(16, 26);
            this.labelPymentDate.Name = "labelPymentDate";
            this.labelPymentDate.Size = new System.Drawing.Size(110, 20);
            this.labelPymentDate.TabIndex = 0;
            this.labelPymentDate.Text = "Payment Date";
            // 
            // FormCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 306);
            this.Controls.Add(this.groupBoxFeeDetail);
            this.Controls.Add(this.groupBoxUserDetail);
            this.Name = "FormCourseRegistration";
            this.Text = "CourseRegistration";
            this.groupBoxUserDetail.ResumeLayout(false);
            this.groupBoxUserDetail.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

