namespace Q2
{
    partial class Form1
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
            dgvEmployee = new DataGridView();
            gbEmployee = new GroupBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            cbPosition = new ComboBox();
            dtpDOB = new DateTimePicker();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(23, 24);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(809, 561);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // gbEmployee
            // 
            gbEmployee.Controls.Add(btnEdit);
            gbEmployee.Controls.Add(btnAdd);
            gbEmployee.Controls.Add(btnRefresh);
            gbEmployee.Controls.Add(cbPosition);
            gbEmployee.Controls.Add(dtpDOB);
            gbEmployee.Controls.Add(rbFemale);
            gbEmployee.Controls.Add(rbMale);
            gbEmployee.Controls.Add(txtName);
            gbEmployee.Controls.Add(txtId);
            gbEmployee.Controls.Add(label5);
            gbEmployee.Controls.Add(label4);
            gbEmployee.Controls.Add(label3);
            gbEmployee.Controls.Add(label2);
            gbEmployee.Controls.Add(label1);
            gbEmployee.Location = new Point(876, 24);
            gbEmployee.Name = "gbEmployee";
            gbEmployee.Size = new Size(380, 561);
            gbEmployee.TabIndex = 1;
            gbEmployee.TabStop = false;
            gbEmployee.Text = "Current Employee";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(265, 472);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(141, 472);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(17, 472);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(94, 376);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(265, 28);
            cbPosition.TabIndex = 10;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(94, 292);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(265, 27);
            dtpDOB.TabIndex = 9;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(259, 210);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 8;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(124, 210);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 7;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 74);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(265, 27);
            txtId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 384);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 297);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 212);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 2;
            label3.Text = "Sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 144);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 77);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 612);
            Controls.Add(gbEmployee);
            Controls.Add(dgvEmployee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbEmployee.ResumeLayout(false);
            gbEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private GroupBox gbEmployee;
        private DateTimePicker dtpDOB;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtName;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private ComboBox cbPosition;
    }
}
