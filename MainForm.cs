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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_qlop_Click(object sender, EventArgs e)
        {
            ClassMngForm classForm = new ClassMngForm();
            classForm.StartPosition = FormStartPosition.CenterScreen;
            classForm.Show();
        }

        private void btn_qlsv_Click(object sender, EventArgs e)
        {
            StuMngForm stuForm = new StuMngForm();
            stuForm.StartPosition = FormStartPosition.CenterScreen;
            stuForm.Show();
        }
    }
}
