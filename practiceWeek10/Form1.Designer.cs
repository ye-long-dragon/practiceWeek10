namespace practiceWeek10
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudent = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(12, 125);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(776, 313);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Row";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(142, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Row";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(267, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Row";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvStudent);
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudent;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
