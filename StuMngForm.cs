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
    public partial class StuMngForm : Form
    {
        public StuMngForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsinhvien.Rows[e.RowIndex];

                txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();
                txt_GioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txt_NgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                cb_MaLop.SelectedValue = row.Cells["MaLop"].Value.ToString();
            }
        }
    }
}
