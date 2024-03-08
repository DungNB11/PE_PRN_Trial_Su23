namespace Q1
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
            gbFilter = new GroupBox();
            cbPosition = new ComboBox();
            label2 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            rbGender = new RadioButton();
            txtName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(461, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(880, 529);
            dgvEmployee.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(cbPosition);
            gbFilter.Controls.Add(label2);
            gbFilter.Controls.Add(rbFemale);
            gbFilter.Controls.Add(rbMale);
            gbFilter.Controls.Add(rbGender);
            gbFilter.Controls.Add(txtName);
            gbFilter.Controls.Add(label1);
            gbFilter.Location = new Point(12, 12);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(418, 528);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            gbFilter.Enter += groupBox1_Enter;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "All positions", "Developer", "Leader", "Tester", "Manager" });
            cbPosition.Location = new Point(137, 247);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(151, 28);
            cbPosition.TabIndex = 6;
            cbPosition.SelectedIndexChanged += cbPosition_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 250);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Position";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(299, 141);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 4;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(202, 141);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbGender
            // 
            rbGender.AutoSize = true;
            rbGender.Checked = true;
            rbGender.Location = new Point(45, 141);
            rbGender.Name = "rbGender";
            rbGender.Size = new Size(117, 24);
            rbGender.TabIndex = 2;
            rbGender.TabStop = true;
            rbGender.Text = "Male/Female";
            rbGender.UseVisualStyleBackColor = true;
            rbGender.CheckedChanged += rbGender_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(137, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 61);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 552);
            Controls.Add(gbFilter);
            Controls.Add(dgvEmployee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployee;
        private GroupBox gbFilter;
        private ComboBox cbPosition;
        private Label label2;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private RadioButton rbGender;
        private TextBox txtName;
        private Label label1;
    }
}
