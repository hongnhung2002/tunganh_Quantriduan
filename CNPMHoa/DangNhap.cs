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

namespace CNPMHoa
{
    public partial class DangNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        public DangNhap()
        {
            InitializeComponent();
            lb_ten.Enabled = false;
            lb_user.Enabled = false;
            lb_sdt.Enabled = false;
            cb_user.Enabled = false;
            tb_ten.Enabled = false;
            tb_sdt.Enabled = false;
        }

       private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_taikhoan.Text != "" || tb_matkhau.Text != "" )
                {
                    cmd = new SqlCommand("INSERT INTO Nguoidung (Manv,Tennv,Gioitinh,Sodienthoai,Cccd,Diachi,Chucvu,Ngaysinh) VALUES(@manv, @tennv, @gioitinh, @ngaysinh, @chucvu ,@sdt ,@cccd, @diachi)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_taikhoan.Text);
                    cmd.Parameters.AddWithValue("tennv", tb_matkhau.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
                con.Open();
                string taikhoan = tb_taikhoan.Text;
                string matkhau = tb_matkhau.Text;
                string sql = "SELECT * FROM Nguoidung WHERE Taikhoan='" + taikhoan + "' AND Matkhau= '" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (matkhau.Length < 6 )
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu đủ 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dt.Rows.Count > 0 )
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HeThong hethong = new HeThong();
                    hethong.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_taikhoan.Text != "" || tb_matkhau.Text != "" ||  tb_sdt.Text != "" || tb_ten.Text != "" )
                {
                    cmd = new SqlCommand("INSERT INTO Nguoidung (Taikhoan,Matkhau) VALUES(@taikhoan,@matkhau)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_taikhoan.Text);
                    cmd.Parameters.AddWithValue("tennv", tb_matkhau.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



            private void rb_tkmoi_CheckedChanged(object sender, EventArgs e)
        {
            lb_ten.Enabled = true;
            lb_user.Enabled = true;
            lb_sdt.Enabled = true;
            tb_sdt.Enabled = true;
            cb_user.Enabled = true;
            tb_ten.Enabled = true;
        }

        private void bt_ttk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_taikhoan.Text != "" || tb_matkhau.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Nguoidung (Taikhoan,Matkhau,[User],Ten,Sdt) VALUES(@taikhoan, @matkhau,@sdt,@ten,@user)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("taikhoan", tb_taikhoan.Text);
                    cmd.Parameters.AddWithValue("matkhau", tb_matkhau.Text);
                    cmd.Parameters.AddWithValue("ten", tb_ten.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("user", cb_user);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Tạo tài khoản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
