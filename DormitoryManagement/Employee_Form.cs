using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using BUS_TIER;
using MODEL;
namespace DormitoryManagement
{
    public partial class Employee_Form : Form
    {
        Employee_Bus busEmployee = new Employee_Bus();
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void NhanVien_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busEmployee.getListEmployee();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if(textBox_idEmployee.Text != "" && textBox_nameEmployee.Text !="" && comboBox_genderEmployee.Text!= "" && comboBox_position.Text!="" && textBox_basicSalary.Text != "")
            {
                Employee gv = new Employee(textBox_idEmployee.Text, textBox_nameEmployee.Text, comboBox_genderEmployee.Text, comboBox_position.Text, textBox_basicSalary.Text);
                if (busEmployee.addNewEmployee(gv))
                {
                    dataGridView1.DataSource = busEmployee.getListEmployee();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show(" Thiếu thông tin");
            }
        }


        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (textBox_idEmployee.Text != "")
                {
                    if (busEmployee.deleteEmployee(textBox_idEmployee.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        dataGridView1.DataSource = busEmployee.getListEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được !");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhân viên muốn xóa !");
                }
            }
            else MessageBox.Show("Danh sách rỗng !");
        }


        private void button_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Employee gv = new Employee(textBox_idEmployee.Text, textBox_nameEmployee.Text, comboBox_genderEmployee.Text, comboBox_position.Text, textBox_basicSalary.Text);
                if (textBox_idEmployee.Text != "")
                {
                    if (busEmployee.editEmployee(gv))
                    {
                        dataGridView1.DataSource = busEmployee.getListEmployee(); 
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được !");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhân viên muốn sửa !");
                }
            }
            else MessageBox.Show("Danh sách rỗng !");
        }

        int i = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            this.textBox_idEmployee.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox_nameEmployee.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.comboBox_genderEmployee.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            this.comboBox_position.Text = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.textBox_basicSalary.Text = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busEmployee.search(textBox_search.Text);
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
    }
}
