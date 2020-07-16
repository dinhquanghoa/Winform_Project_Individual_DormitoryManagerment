using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_TIER;
using MODEL;

namespace DormitoryManagement
{
    public partial class Student_Form : Form
    {
        Student_Bus busStudent = new Student_Bus();
        public Student_Form()
        {
            InitializeComponent();
        }

        private void SinhVien_Form_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busStudent.getListStudent();
        }

        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            this.textBox_idStudent.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox_idRoom.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.textBox_nameStudent.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            this.dateTimePicker_dateOfBirthStudent.Text = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.textBox_addressStudent.Text = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.textBox_phoneNumberStudent.Text = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_idStudent.Text != "" )
            {
                Student sv = new Student(textBox_idStudent.Text, textBox_idRoom.Text, textBox_nameStudent.Text, dateTimePicker_dateOfBirthStudent.Text, textBox_addressStudent.Text, textBox_phoneNumberStudent.Text);
                if (busStudent.addNewStudent(sv))
                    dataGridView1.DataSource = busStudent.getListStudent();
                else
                    MessageBox.Show("Thêm không thành công!");
            }
            else
            {
                MessageBox.Show("Thiếu thông tin!");
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Student sv = new Student(textBox_idStudent.Text, textBox_idRoom.Text, textBox_nameStudent.Text, dateTimePicker_dateOfBirthStudent.Text, textBox_addressStudent.Text,textBox_phoneNumberStudent.Text);
                if (textBox_idStudent.Text != "")
                    if (busStudent.editStudent(sv))
                        dataGridView1.DataSource = busStudent.getListStudent();
                    else
                        MessageBox.Show("Không sửa được !");
                else
                    MessageBox.Show("Hãy chọn sinh viên muốn sửa !");
            }
            else MessageBox.Show("Danh sách rỗng !");
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (textBox_idStudent.Text != "")
                    if (busStudent.deleteStudent(textBox_idStudent.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        dataGridView1.DataSource = busStudent.getListStudent();
                    }
                    else
                        MessageBox.Show("Không xóa được !");
                else
                    MessageBox.Show("Hãy chọn sinh viên muốn xóa !");
            }
            else MessageBox.Show("Danh sách rỗng !");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[i].Selected = false;
            dataGridView1.Rows[0].Selected = true;
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                dataGridView1.Rows[i].Selected = false;
                dataGridView1.Rows[--i].Selected = true;
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (i < dataGridView1.RowCount - 1)
            {
                dataGridView1.Rows[i].Selected = false;
                dataGridView1.Rows[++i].Selected = true;
            }
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[i].Selected = false;
            i = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[i].Selected = true;
        }

        private void textBox_timkiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busStudent.search(textBox_timkiem.Text);
        }
    }
}
