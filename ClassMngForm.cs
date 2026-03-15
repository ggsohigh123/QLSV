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
    public partial class ClassMngForm : Form
    {
        QLSVDataContext db = new QLSVDataContext();
        public ClassMngForm()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dgvsinhvien.DataSource = db.Lops.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Lop moi = new Lop();
            moi.MaLop = txt_HoTen.Text; 
            moi.TenLop = textBox1.Text;  

            db.Lops.InsertOnSubmit(moi);
            db.SubmitChanges(); 

            LoadData(); 
            MessageBox.Show("Thêm lớp thành công!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var lop = db.Lops.SingleOrDefault(x => x.MaLop == txt_HoTen.Text);

            if (lop != null)
            {
                db.Lops.DeleteOnSubmit(lop);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Đã xóa lớp!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var lop = db.Lops.SingleOrDefault(x => x.MaLop == txt_HoTen.Text);
            if (lop != null)
            {
                lop.TenLop = textBox1.Text; 
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsinhvien.Rows[e.RowIndex];

                txt_HoTen.Text = row.Cells["MaLop"].Value.ToString();
                textBox1.Text = row.Cells["TenLop"].Value.ToString();
            }
        }
    }
}
