namespace DormitoryManagement
{
    partial class Employee_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.comboBox_genderEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_basicSalary = new System.Windows.Forms.TextBox();
            this.textBox_nameEmployee = new System.Windows.Forms.TextBox();
            this.textBox_idEmployee = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_them = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_position);
            this.groupBox1.Controls.Add(this.comboBox_genderEmployee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_basicSalary);
            this.groupBox1.Controls.Add(this.textBox_nameEmployee);
            this.groupBox1.Controls.Add(this.textBox_idEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nhân Viên";
            // 
            // comboBox_position
            // 
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "Quản lý",
            "Giám Đốc",
            "Nhân Viên"});
            this.comboBox_position.Location = new System.Drawing.Point(138, 280);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(129, 24);
            this.comboBox_position.TabIndex = 3;
            // 
            // comboBox_genderEmployee
            // 
            this.comboBox_genderEmployee.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.comboBox_genderEmployee.FormattingEnabled = true;
            this.comboBox_genderEmployee.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_genderEmployee.Location = new System.Drawing.Point(138, 203);
            this.comboBox_genderEmployee.Name = "comboBox_genderEmployee";
            this.comboBox_genderEmployee.Size = new System.Drawing.Size(129, 24);
            this.comboBox_genderEmployee.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lương cơ bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // textBox_basicSalary
            // 
            this.textBox_basicSalary.Location = new System.Drawing.Point(138, 365);
            this.textBox_basicSalary.Name = "textBox_basicSalary";
            this.textBox_basicSalary.Size = new System.Drawing.Size(129, 22);
            this.textBox_basicSalary.TabIndex = 4;
            // 
            // textBox_nameEmployee
            // 
            this.textBox_nameEmployee.Location = new System.Drawing.Point(138, 132);
            this.textBox_nameEmployee.Name = "textBox_nameEmployee";
            this.textBox_nameEmployee.Size = new System.Drawing.Size(129, 22);
            this.textBox_nameEmployee.TabIndex = 1;
            // 
            // textBox_idEmployee
            // 
            this.textBox_idEmployee.Location = new System.Drawing.Point(138, 63);
            this.textBox_idEmployee.Name = "textBox_idEmployee";
            this.textBox_idEmployee.Size = new System.Drawing.Size(129, 22);
            this.textBox_idEmployee.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(373, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Mã Giảng Viên";
            this.loaiPhong.Name = "loaiPhong";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên Giảng Viên";
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức danh";
            this.chucvu.Name = "chucvu";
            // 
            // hsl
            // 
            this.hsl.DataPropertyName = "hsl";
            this.hsl.HeaderText = "Hệ số lương";
            this.hsl.Name = "hsl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(1046, 101);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(153, 20);
            this.textBox_search.TabIndex = 4;
            this.textBox_search.Text = "Nhập mã NV hoặc Tên NV";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(54, 562);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(73, 35);
            this.button_them.TabIndex = 5;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(166, 562);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(73, 35);
            this.button_sua.TabIndex = 6;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(283, 562);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 35);
            this.button_xoa.TabIndex = 7;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(563, 574);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "<<";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_prev
            // 
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prev.Location = new System.Drawing.Point(668, 574);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(69, 23);
            this.button_prev.TabIndex = 5;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(848, 574);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 5;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_last
            // 
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.Location = new System.Drawing.Point(951, 573);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(75, 23);
            this.button_last.TabIndex = 5;
            this.button_last.Text = ">>";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(983, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tìm kiếm:";
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1229, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Employee_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NhanVien_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_basicSalary;
        private System.Windows.Forms.TextBox textBox_nameEmployee;
        private System.Windows.Forms.TextBox textBox_idEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.ComboBox comboBox_genderEmployee;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
    }
}