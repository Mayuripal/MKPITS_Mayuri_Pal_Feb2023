namespace FendalPrep
{
    partial class Register
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(2, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(107, 7);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(215, 28);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(2, 45);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(41, 21);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(2, 79);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(102, 21);
            this.labelMobile.TabIndex = 4;
            this.labelMobile.Text = "Mobile No.";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(107, 41);
            this.textBoxAge.MaxLength = 2;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(215, 28);
            this.textBoxAge.TabIndex = 3;
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobileNo.Location = new System.Drawing.Point(107, 75);
            this.textBoxMobileNo.MaxLength = 10;
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.Size = new System.Drawing.Size(215, 28);
            this.textBoxMobileNo.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(200, 107);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(60, 34);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(262, 107);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 34);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 145);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxMobileNo);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxMobileNo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
    }
}

