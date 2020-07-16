using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MODEL;
using BUS_TIER;

namespace DormitoryManagement
{
    public partial class Room_Form : Form
    {
        Room_Bus busRoom = new Room_Bus();
        public Room_Form()
        {
            InitializeComponent();
        }

        private void Phong_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busRoom.getListRoom();
        }

        int i;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dataGridView1.CurrentRow.Index;
            this.textBox_idRoom.Text = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox_nameRoom.Text = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.textBox_currentPeople.Text = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            this.textBox_capacity.Text = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.comboBox_typeRoom.Text = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.textBox_idEmployee.Text = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_idRoom.Text != "" )
            {
                Room l = new Room(textBox_idRoom.Text, textBox_nameRoom.Text, textBox_currentPeople.Text, textBox_capacity.Text, comboBox_typeRoom.Text, textBox_idEmployee.Text);
                if (busRoom.addNewRoom(l))
                {
                    dataGridView1.DataSource = busRoom.getListRoom();
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

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Room l = new Room(textBox_idRoom.Text, textBox_nameRoom.Text, textBox_currentPeople.Text, textBox_capacity.Text, comboBox_typeRoom.Text, textBox_idEmployee.Text);
                if (textBox_idRoom.Text != "")
                    if (busRoom.editRoom(l))
                        dataGridView1.DataSource = busRoom.getListRoom();
                    else
                        MessageBox.Show("Không sửa được !");
                else
                    MessageBox.Show("Hãy chọn Phòng muốn sửa !");
            }
            else MessageBox.Show("Danh sách rỗng !");
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (textBox_idRoom.Text != "")
                {
                    if (busRoom.deleteRoom(textBox_idRoom.Text))
                    {
                        MessageBox.Show("Xóa thành công !");
                        dataGridView1.DataSource = busRoom.getListRoom();
                    }
                    else
                        MessageBox.Show("Không xóa được !");
                }
                else
                    MessageBox.Show("Hãy chọn phòng muốn xóa !");
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

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busRoom.search(textBox_search.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
