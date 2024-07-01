namespace EmployeeMgmt1
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DailySalTb = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            DOBTb = new DateTimePicker();
            JDateTb = new DateTimePicker();
            AddBtn = new Button();
            EditBtn = new Button();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            DepartmentLbl = new Label();
            pictureBox4 = new PictureBox();
            SalaryLbl = new Label();
            pictureBox5 = new PictureBox();
            LogoutLbl = new Label();
            EmployeeList = new DataGridView();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 91);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 26);
            label1.Name = "label1";
            label1.Size = new Size(561, 38);
            label1.TabIndex = 2;
            label1.Text = "Employee Management System Version 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(537, 164);
            label2.Name = "label2";
            label2.Size = new Size(271, 38);
            label2.TabIndex = 3;
            label2.Text = "Manage Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(48, 200);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 7;
            label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameTb.Location = new Point(48, 231);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(355, 34);
            EmpNameTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(48, 281);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 9;
            label4.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(48, 446);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 13;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(48, 365);
            label6.Name = "label6";
            label6.Size = new Size(217, 28);
            label6.TabIndex = 11;
            label6.Text = "Employee Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(48, 616);
            label7.Name = "label7";
            label7.Size = new Size(211, 28);
            label7.TabIndex = 17;
            label7.Text = "Employee Daily Salary";
            // 
            // DailySalTb
            // 
            DailySalTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DailySalTb.Location = new Point(48, 647);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(355, 34);
            DailySalTb.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(48, 535);
            label8.Name = "label8";
            label8.Size = new Size(97, 28);
            label8.TabIndex = 15;
            label8.Text = "Join Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 781);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 15);
            panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female" });
            GenCb.Location = new Point(48, 312);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(355, 36);
            GenCb.TabIndex = 20;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(48, 396);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(355, 36);
            DepCb.TabIndex = 21;
            // 
            // DOBTb
            // 
            DOBTb.CalendarForeColor = Color.Teal;
            DOBTb.CalendarTitleForeColor = Color.Teal;
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(48, 477);
            DOBTb.Name = "DOBTb";
            DOBTb.Size = new Size(355, 34);
            DOBTb.TabIndex = 23;
            // 
            // JDateTb
            // 
            JDateTb.CalendarForeColor = Color.Teal;
            JDateTb.CalendarTitleForeColor = Color.Teal;
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(48, 566);
            JDateTb.Name = "JDateTb";
            JDateTb.Size = new Size(355, 34);
            JDateTb.TabIndex = 23;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(48, 702);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(161, 57);
            AddBtn.TabIndex = 24;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Teal;
            EditBtn.Location = new Point(242, 702);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(161, 57);
            EditBtn.TabIndex = 25;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(461, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(535, 107);
            label9.Name = "label9";
            label9.Size = new Size(101, 28);
            label9.TabIndex = 27;
            label9.Text = "Employee";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(667, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentLbl.ForeColor = Color.Teal;
            DepartmentLbl.Location = new Point(741, 107);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(131, 28);
            DepartmentLbl.TabIndex = 27;
            DepartmentLbl.Text = "Departments";
            DepartmentLbl.Click += DepartmentLbl_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(903, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryLbl.ForeColor = Color.Teal;
            SalaryLbl.Location = new Point(977, 107);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(66, 28);
            SalaryLbl.TabIndex = 27;
            SalaryLbl.Text = "Salary";
            SalaryLbl.Click += SalaryLbl_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1074, 97);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(68, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 26;
            pictureBox5.TabStop = false;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLbl.ForeColor = Color.Teal;
            LogoutLbl.Location = new Point(1148, 107);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(86, 28);
            LogoutLbl.TabIndex = 27;
            LogoutLbl.Text = "Log Out";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // EmployeeList
            // 
            EmployeeList.BackgroundColor = Color.White;
            EmployeeList.BorderStyle = BorderStyle.None;
            EmployeeList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle4;
            EmployeeList.GridColor = Color.White;
            EmployeeList.Location = new Point(461, 231);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeList.Size = new Size(773, 450);
            EmployeeList.TabIndex = 41;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(767, 702);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(161, 57);
            DeleteBtn.TabIndex = 42;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 796);
            Controls.Add(DeleteBtn);
            Controls.Add(EmployeeList);
            Controls.Add(LogoutLbl);
            Controls.Add(SalaryLbl);
            Controls.Add(DepartmentLbl);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(DailySalTb);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox DailySalTb;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private DateTimePicker DOBTb;
        private DateTimePicker JDateTb;
        private Button AddBtn;
        private Button EditBtn;
        private PictureBox pictureBox2;
        private Label label9;
        private PictureBox pictureBox3;
        private Label DepartmentLbl;
        private PictureBox pictureBox4;
        private Label SalaryLbl;
        private PictureBox pictureBox5;
        private Label LogoutLbl;
        private DataGridView EmployeeList;
        private Button DeleteBtn;
    }
}