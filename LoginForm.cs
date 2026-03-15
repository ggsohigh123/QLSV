using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            tb_password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "admin" && password == "1")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm main = new MainForm();

                main.Show();

                this.Hide();

                main.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_password.Clear();
                tb_username.Focus();
            }
        }
    }
}