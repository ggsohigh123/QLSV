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
    }
}
