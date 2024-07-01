namespace EmployeeMgmt1
{
    partial class Departments
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            EditBtn = new Button();
            AddBtn = new Button();
            DepList = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            DepNameTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            LogoutLbl = new Label();
            SalaryLbl = new Label();
            label10 = new Label();
            EmpLbl = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Teal;
            EditBtn.Location = new Point(242, 339);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(161, 57);
            EditBtn.TabIndex = 44;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(48, 339);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(161, 57);
            AddBtn.TabIndex = 43;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepList
            // 
            DepList.BackgroundColor = Color.White;
            DepList.BorderStyle = BorderStyle.None;
            DepList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle4;
            DepList.GridColor = Color.White;
            DepList.Location = new Point(500, 258);
            DepList.Name = "DepList";
            DepList.RowHeadersWidth = 51;
            DepList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DepList.Size = new Size(773, 450);
            DepList.TabIndex = 40;
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(48, 200);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 29;
            label3.Text = "Department Name";
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepNameTb.Location = new Point(48, 231);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(355, 34);
            DepNameTb.TabIndex = 28;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(802, 212);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 45;
            label4.Text = "Departments List";
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutLbl.ForeColor = Color.Teal;
            LogoutLbl.Location = new Point(1134, 107);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(86, 28);
            LogoutLbl.TabIndex = 51;
            LogoutLbl.Text = "Log Out";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryLbl.ForeColor = Color.Teal;
            SalaryLbl.Location = new Point(963, 107);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(66, 28);
            SalaryLbl.TabIndex = 52;
            SalaryLbl.Text = "Salary";
            SalaryLbl.Click += SalaryLbl_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(727, 107);
            label10.Name = "label10";
            label10.Size = new Size(131, 28);
            label10.TabIndex = 53;
            label10.Text = "Departments";
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpLbl.ForeColor = Color.Teal;
            EmpLbl.Location = new Point(521, 107);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(101, 28);
            EmpLbl.TabIndex = 54;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1060, 97);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(68, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(889, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(653, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(447, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(488, 157);
            label2.Name = "label2";
            label2.Size = new Size(303, 38);
            label2.TabIndex = 46;
            label2.Text = "Manage Departments";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(147, 419);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(161, 57);
            DeleteBtn.TabIndex = 55;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 796);
            Controls.Add(DeleteBtn);
            Controls.Add(LogoutLbl);
            Controls.Add(SalaryLbl);
            Controls.Add(label10);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepNameTb);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private DataGridView DepList;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private TextBox DepNameTb;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label LogoutLbl;
        private Label SalaryLbl;
        private Label label10;
        private Label EmpLbl;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private Button DeleteBtn;
    }
}