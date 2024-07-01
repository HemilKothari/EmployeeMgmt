namespace EmployeeMgmt1
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            UpdateBtn = new Button();
            AddBtn = new Button();
            EmpCb = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            DaysTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            LogoutLbl = new Label();
            label11 = new Label();
            DepartmentLbl = new Label();
            EmployeeLbl = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            label5 = new Label();
            PeriodTb = new DateTimePicker();
            SalaryList = new DataGridView();
            AmountTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.PaleTurquoise;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Teal;
            UpdateBtn.Location = new Point(242, 702);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(161, 57);
            UpdateBtn.TabIndex = 44;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
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
            AddBtn.TabIndex = 43;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EmpCb
            // 
            EmpCb.ForeColor = Color.Teal;
            EmpCb.FormattingEnabled = true;
            EmpCb.Location = new Point(48, 231);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(355, 36);
            EmpCb.TabIndex = 39;
            EmpCb.SelectionChangeCommitted += EmpCb_SelectionChangeCommitted;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 781);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 15);
            panel2.TabIndex = 36;
            // 
            // DaysTb
            // 
            DaysTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DaysTb.ForeColor = Color.Teal;
            DaysTb.Location = new Point(48, 312);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(355, 34);
            DaysTb.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(48, 281);
            label4.Name = "label4";
            label4.Size = new Size(146, 28);
            label4.TabIndex = 30;
            label4.Text = "Days Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(48, 200);
            label3.Name = "label3";
            label3.Size = new Size(101, 28);
            label3.TabIndex = 29;
            label3.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(515, 152);
            label2.Name = "label2";
            label2.Size = new Size(231, 38);
            label2.TabIndex = 27;
            label2.Text = "Manage Salaries";
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
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 91);
            panel1.TabIndex = 26;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLbl.ForeColor = Color.Teal;
            LogoutLbl.Location = new Point(1161, 107);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(86, 28);
            LogoutLbl.TabIndex = 49;
            LogoutLbl.Text = "Log Out";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(990, 107);
            label11.Name = "label11";
            label11.Size = new Size(66, 28);
            label11.TabIndex = 50;
            label11.Text = "Salary";
            // 
            // DepartmentLbl
            // 
            DepartmentLbl.AutoSize = true;
            DepartmentLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepartmentLbl.ForeColor = Color.Teal;
            DepartmentLbl.Location = new Point(754, 107);
            DepartmentLbl.Name = "DepartmentLbl";
            DepartmentLbl.Size = new Size(131, 28);
            DepartmentLbl.TabIndex = 51;
            DepartmentLbl.Text = "Departments";
            DepartmentLbl.Click += DepartmentLbl_Click;
            // 
            // EmployeeLbl
            // 
            EmployeeLbl.AutoSize = true;
            EmployeeLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeeLbl.ForeColor = Color.Teal;
            EmployeeLbl.Location = new Point(548, 107);
            EmployeeLbl.Name = "EmployeeLbl";
            EmployeeLbl.Size = new Size(101, 28);
            EmployeeLbl.TabIndex = 52;
            EmployeeLbl.Text = "Employee";
            EmployeeLbl.Click += EmployeeLbl_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1087, 97);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(68, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 45;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(916, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 46;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(680, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(474, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(48, 456);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 33;
            label8.Text = "Salary Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(48, 367);
            label5.Name = "label5";
            label5.Size = new Size(70, 28);
            label5.TabIndex = 32;
            label5.Text = "Period";
            // 
            // PeriodTb
            // 
            PeriodTb.CalendarForeColor = Color.Teal;
            PeriodTb.CalendarTitleForeColor = Color.Teal;
            PeriodTb.CalendarTrailingForeColor = Color.Teal;
            PeriodTb.Format = DateTimePickerFormat.Short;
            PeriodTb.Location = new Point(48, 398);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.Size = new Size(355, 34);
            PeriodTb.TabIndex = 41;
            // 
            // SalaryList
            // 
            SalaryList.BackgroundColor = Color.White;
            SalaryList.BorderStyle = BorderStyle.None;
            SalaryList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.Teal;
            dataGridViewCellStyle7.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Teal;
            dataGridViewCellStyle8.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle8;
            SalaryList.GridColor = Color.White;
            SalaryList.Location = new Point(474, 231);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersWidth = 51;
            SalaryList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryList.Size = new Size(773, 450);
            SalaryList.TabIndex = 53;
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Enabled = false;
            AmountTb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = Color.Teal;
            AmountTb.Location = new Point(48, 487);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(355, 31);
            AmountTb.TabIndex = 54;
            AmountTb.TextAlign = HorizontalAlignment.Right;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 796);
            Controls.Add(AmountTb);
            Controls.Add(SalaryList);
            Controls.Add(LogoutLbl);
            Controls.Add(label11);
            Controls.Add(DepartmentLbl);
            Controls.Add(EmployeeLbl);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(PeriodTb);
            Controls.Add(EmpCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(DaysTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Button AddBtn;
        private ComboBox EmpCb;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox DaysTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label LogoutLbl;
        private Label label11;
        private Label DepartmentLbl;
        private Label EmployeeLbl;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label8;
        private Label label5;
        private DateTimePicker PeriodTb;
        private DataGridView SalaryList;
        private TextBox AmountTb;
    }
}