using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPMHoa
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lb_tench_Click(object sender, EventArgs e)
        {

        }

        private void bt_nv_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLNhanVien nhanvien = new QLNhanVien();
            nhanvien.ShowDialog();
        }

        private void bt_hoa_Click(object sender, EventArgs e)
        {
            this.Hide();
           Hoa hoa = new Hoa();
            hoa.ShowDialog();
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khachhang khachhang = new Khachhang();
            khachhang.ShowDialog();
        }

        private void bt_bctk_Click(object sender, EventArgs e)
        {
            this.Hide();
            BCTK bctk = new BCTK();
            bctk.ShowDialog();
        }

        private void bt_banhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hoadon banhang = new Hoadon();
            banhang.ShowDialog();
        }
    }
}
