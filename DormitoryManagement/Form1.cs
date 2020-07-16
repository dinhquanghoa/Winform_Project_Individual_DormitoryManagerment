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

namespace DormitoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DTU\2.2 Winform\DormitoryManagerment\DormitoryManagement\DORMITORY_MANAGEMENT.mdf;Integrated Security=True");
        public int type;
        private int getID(string username, string password)
        {
            int type = -1;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE username ='" + username + "' and password='" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        type = int.Parse(dr["type"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return type;
        }
        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            type = getID(textBox_username.Text, textBox_password.Text);
            if (type != -1)
            {
                Main_Form m  = new Main_Form(this);
                m.type = this.type;
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
            }
        }
       

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
