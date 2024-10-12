namespace practiceWeek10
{
    partial class StudentCreation
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
            lblID = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtBirthDate = new TextBox();
            lblBirthDate = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtNumber = new TextBox();
            lblNumber = new Label();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(46, 51);
            lblID.Name = "lblID";
            lblID.Size = new Size(79, 20);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(182, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(191, 27);
            txtID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 104);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(46, 111);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(182, 172);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(46, 179);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "LastName";
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(182, 225);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(191, 27);
            txtBirthDate.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(46, 232);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(72, 20);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "BirthDate";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 290);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(191, 27);
            txtAddress.TabIndex = 9;
            txtAddress.TextChanged += textBox4_TextChanged;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(46, 297);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(68, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 416);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(168, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(182, 337);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(191, 27);
            txtNumber.TabIndex = 13;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(46, 344);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(108, 20);
            lblNumber.TabIndex = 12;
            lblNumber.Text = "Phone Number";
            // 
            // StudentCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 565);
            Controls.Add(txtNumber);
            Controls.Add(lblNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Name = "StudentCreation";
            Text = "StudentCreation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private TextBox txtID;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtBirthDate;
        private Label lblBirthDate;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtNumber;
        private Label lblNumber;
    }
}