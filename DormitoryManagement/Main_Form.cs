using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class Main_Form : Form
    {
        Form1 login;
        
        public int type = -1;
        public Main_Form(Form1 login)
        {
            InitializeComponent();
            this.login = login;
        }

        Employee_Form nv;
        Student_Form sv;
        Room_Form phong;
   

        private void NhanVien_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            nv = null;
        }

        private void Phong_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            phong = null;
        }

        private void SinhVien_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            sv = null;
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Close();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.type == 1)
            {
                MessageBox.Show("Bạn là nhân viên, Bạn không có quyền vào mục này !", "Ký túc xá Duy Tân", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nv == null)
            {
                nv = new Employee_Form();
                nv.FormClosed += new FormClosedEventHandler(NhanVien_Form_FormClosed);
                nv.MdiParent = this;
                nv.Show();
            }
            else
                nv.Activate();
        }

        private void phongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.type == 1)
            {
                MessageBox.Show("Bạn là nhân viên, Bạn không có quyền vào mục này !", "Duy Tân University", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (phong == null)
            {
                phong = new Room_Form();
                phong.FormClosed += new FormClosedEventHandler(Phong_Form_FormClosed);
                phong.MdiParent = this;
                phong.Show();
            }
            else
                phong.Activate();
        }

        private void sINHVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sv == null)
            {
                sv = new Student_Form();
                sv.FormClosed += new FormClosedEventHandler(SinhVien_Form_FormClosed);
                sv.MdiParent = this;
                sv.Show();
            }
            else
                sv.Activate();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (this.type == 0)
                this.label_type.Text = "Xin chào quản lý !";
            else
                this.label_type.Text = "Xin chào nhân viên!";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void label_type_Click(object sender, EventArgs e)
        {

        }
    }
}
