namespace DormitoryManagement
{
    partial class Room_Form
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
            this.button_last = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nameRoom = new System.Windows.Forms.TextBox();
            this.textBox_idRoom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.comboBox_typeRoom = new System.Windows.Forms.ComboBox();
            this.textBox_currentPeople = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_idEmployee = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_last
            // 
            this.button_last.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.Location = new System.Drawing.Point(889, 550);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(77, 38);
            this.button_last.TabIndex = 12;
            this.button_last.Text = ">>";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(749, 551);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(76, 37);
            this.button_next.TabIndex = 11;
            this.button_next.Text = ">";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_prev.Location = new System.Drawing.Point(613, 551);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(76, 37);
            this.button_prev.TabIndex = 10;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(491, 551);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(76, 37);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "<<";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(251, 551);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 37);
            this.button_xoa.TabIndex = 8;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Location = new System.Drawing.Point(134, 551);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(78, 37);
            this.button_sua.TabIndex = 7;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_them
            // 
            this.button_them.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(22, 551);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(78, 37);
            this.button_them.TabIndex = 6;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(1040, 103);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(153, 21);
            this.textBox_search.TabIndex = 10;
            this.textBox_search.Text = "Nhập mã phòng hoặc tên phòng";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(975, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tìm kiếm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ THÔNG TIN PHÒNG KÝ TÚC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(334, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 425);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sức chứa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng hiện tại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã phòng:";
            // 
            // textBox_nameRoom
            // 
            this.textBox_nameRoom.Location = new System.Drawing.Point(153, 109);
            this.textBox_nameRoom.Name = "textBox_nameRoom";
            this.textBox_nameRoom.Size = new System.Drawing.Size(129, 22);
            this.textBox_nameRoom.TabIndex = 1;
            // 
            // textBox_idRoom
            // 
            this.textBox_idRoom.Location = new System.Drawing.Point(153, 51);
            this.textBox_idRoom.Name = "textBox_idRoom";
            this.textBox_idRoom.Size = new System.Drawing.Size(129, 22);
            this.textBox_idRoom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_capacity);
            this.groupBox1.Controls.Add(this.comboBox_typeRoom);
            this.groupBox1.Controls.Add(this.textBox_currentPeople);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_idEmployee);
            this.groupBox1.Controls.Add(this.textBox_nameRoom);
            this.groupBox1.Controls.Add(this.textBox_idRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Phòng";
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Location = new System.Drawing.Point(156, 225);
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.Size = new System.Drawing.Size(129, 22);
            this.textBox_capacity.TabIndex = 3;
            // 
            // comboBox_typeRoom
            // 
            this.comboBox_typeRoom.FormattingEnabled = true;
            this.comboBox_typeRoom.Location = new System.Drawing.Point(153, 291);
            this.comboBox_typeRoom.Name = "comboBox_typeRoom";
            this.comboBox_typeRoom.Size = new System.Drawing.Size(129, 24);
            this.comboBox_typeRoom.TabIndex = 4;
            // 
            // textBox_currentPeople
            // 
            this.textBox_currentPeople.Location = new System.Drawing.Point(153, 168);
            this.textBox_currentPeople.Name = "textBox_currentPeople";
            this.textBox_currentPeople.Size = new System.Drawing.Size(129, 22);
            this.textBox_currentPeople.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã Nhân Viên quản lý:";
            // 
            // textBox_idEmployee
            // 
            this.textBox_idEmployee.Location = new System.Drawing.Point(153, 353);
            this.textBox_idEmployee.Name = "textBox_idEmployee";
            this.textBox_idEmployee.Size = new System.Drawing.Size(129, 22);
            this.textBox_idEmployee.TabIndex = 5;
            // 
            // Room_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1229, 621);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Room_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phong_Form";
            this.Load += new System.EventHandler(this.Phong_Form_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nameRoom;
        private System.Windows.Forms.TextBox textBox_idRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_typeRoom;
        private System.Windows.Forms.TextBox textBox_currentPeople;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_idEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.TextBox textBox_capacity;
    }
}