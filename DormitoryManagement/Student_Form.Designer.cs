namespace DormitoryManagement
{
    partial class Student_Form
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
            this.textBox_nameStudent = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_dateOfBirthStudent = new System.Windows.Forms.DateTimePicker();
            this.textBox_addressStudent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_phoneNumberStudent = new System.Windows.Forms.TextBox();
            this.textBox_idStudent = new System.Windows.Forms.TextBox();
            this.textBox_idRoom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_sua = new System.Windows.Forms.Button();
            this.textBox_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nameStudent
            // 
            this.textBox_nameStudent.Location = new System.Drawing.Point(153, 209);
            this.textBox_nameStudent.Name = "textBox_nameStudent";
            this.textBox_nameStudent.Size = new System.Drawing.Size(129, 22);
            this.textBox_nameStudent.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_dateOfBirthStudent);
            this.groupBox1.Controls.Add(this.textBox_addressStudent);
            this.groupBox1.Controls.Add(this.textBox_nameStudent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_phoneNumberStudent);
            this.groupBox1.Controls.Add(this.textBox_idStudent);
            this.groupBox1.Controls.Add(this.textBox_idRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 480);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sinh Viên";
            // 
            // dateTimePicker_dateOfBirthStudent
            // 
            this.dateTimePicker_dateOfBirthStudent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateOfBirthStudent.Location = new System.Drawing.Point(153, 277);
            this.dateTimePicker_dateOfBirthStudent.Name = "dateTimePicker_dateOfBirthStudent";
            this.dateTimePicker_dateOfBirthStudent.Size = new System.Drawing.Size(129, 22);
            this.dateTimePicker_dateOfBirthStudent.TabIndex = 3;
            // 
            // textBox_addressStudent
            // 
            this.textBox_addressStudent.Location = new System.Drawing.Point(153, 348);
            this.textBox_addressStudent.Name = "textBox_addressStudent";
            this.textBox_addressStudent.Size = new System.Drawing.Size(129, 22);
            this.textBox_addressStudent.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Sinh Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // textBox_phoneNumberStudent
            // 
            this.textBox_phoneNumberStudent.Location = new System.Drawing.Point(153, 420);
            this.textBox_phoneNumberStudent.Name = "textBox_phoneNumberStudent";
            this.textBox_phoneNumberStudent.Size = new System.Drawing.Size(129, 22);
            this.textBox_phoneNumberStudent.TabIndex = 5;
            // 
            // textBox_idStudent
            // 
            this.textBox_idStudent.Location = new System.Drawing.Point(153, 56);
            this.textBox_idStudent.Name = "textBox_idStudent";
            this.textBox_idStudent.Size = new System.Drawing.Size(129, 22);
            this.textBox_idStudent.TabIndex = 0;
            // 
            // textBox_idRoom
            // 
            this.textBox_idRoom.Location = new System.Drawing.Point(153, 135);
            this.textBox_idRoom.Name = "textBox_idRoom";
            this.textBox_idRoom.Size = new System.Drawing.Size(129, 22);
            this.textBox_idRoom.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 477);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 459);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button_last
            // 
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.Location = new System.Drawing.Point(927, 597);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(75, 23);
            this.button_last.TabIndex = 23;
            this.button_last.Text = ">>";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(824, 598);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(78, 23);
            this.button_next.TabIndex = 24;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prev.Location = new System.Drawing.Point(646, 598);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 25;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(541, 598);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 26;
            this.button_start.Text = "<<";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(252, 597);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(73, 37);
            this.button_xoa.TabIndex = 8;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(23, 597);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 37);
            this.button_them.TabIndex = 6;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(135, 597);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(78, 37);
            this.button_sua.TabIndex = 7;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // textBox_timkiem
            // 
            this.textBox_timkiem.Location = new System.Drawing.Point(1067, 84);
            this.textBox_timkiem.Name = "textBox_timkiem";
            this.textBox_timkiem.Size = new System.Drawing.Size(153, 20);
            this.textBox_timkiem.TabIndex = 22;
            this.textBox_timkiem.Text = "Nhập mã SV hoặc tên SV";
            this.textBox_timkiem.TextChanged += new System.EventHandler(this.textBox_timkiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1002, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tìm kiếm: ";
            // 
            // Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1229, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.textBox_timkiem);
            this.Controls.Add(this.label2);
            this.Name = "Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SinhVien_Form";
            this.Load += new System.EventHandler(this.SinhVien_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_nameStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phoneNumberStudent;
        private System.Windows.Forms.TextBox textBox_idStudent;
        private System.Windows.Forms.TextBox textBox_idRoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.TextBox textBox_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOfBirthStudent;
        private System.Windows.Forms.TextBox textBox_addressStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
    }
}