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
    public partial class QLNhanVien : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int row_id = 0;
        public QLNhanVien()
        {
            InitializeComponent();
        }
        private void Display_NhanVien()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Nhanvien ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_nv.DataSource = dt;
            con.Close();
        }
        private void QLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_NhanVien();
        }

        private void dgv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            tb_manv.Text = dgv_nv.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tennv.Text = dgv_nv.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_gioitinh.Text = dgv_nv.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_sdt.Text = dgv_nv.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_diachi.Text = dgv_nv.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_cccd.Text = dgv_nv.Rows[row_id].Cells[5].Value.ToString().Trim();
            tb_chucvu.Text = dgv_nv.Rows[row_id].Cells[6].Value.ToString().Trim();
        }
        private void Clear_NhanVien()
        {
            tb_manv.Text = "";
            tb_tennv.Text = "";
            tb_gioitinh.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            tb_cccd.Text = "";
            tb_chucvu.Text = "";

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_manv.Text != "" || tb_tennv.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_chucvu.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Nhanvien (Manv,Tennv,Gioitinh,Sodienthoai,Cccd,Diachi,Chucvu) VALUES(@manv, @tennv, @gioitinh ,@sdt ,@cccd, @diachi, @chucvu)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("@tennv", tb_tennv.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", tb_gioitinh.Text);
                    cmd.Parameters.AddWithValue("@sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("@cccd", tb_cccd.Text);
                    cmd.Parameters.AddWithValue("@diachi", tb_diachi.Text);
                    cmd.Parameters.AddWithValue("@chucvu", tb_chucvu.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thông tin của nhân viên mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display_NhanVien();
                    Clear_NhanVien();
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

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_manv.Text != "" || tb_tennv.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_chucvu.Text != "")
                {
                    cmd = new SqlCommand("UPDATE Nhanvien SET Tennv= @tennv, Gioitinh= @gioitinh, Sodienthoai= @sdt, Diachi= @diachi, Cccd= @cccd, Chucvu= @chucvu WHERE Manv= @manv", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("tennv", tb_tennv.Text);
                    cmd.Parameters.AddWithValue("gioitinh", tb_gioitinh.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("cccd", tb_cccd.Text);
                    cmd.Parameters.AddWithValue("diachi", tb_diachi.Text);
                    cmd.Parameters.AddWithValue("chucvu", tb_chucvu.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_NhanVien();
                    Clear_NhanVien();
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

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_manv.Text != "" || tb_tennv.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_chucvu.Text != "")
                {
                    cmd = new SqlCommand("DELETE Nhanvien WHERE Tennv= @tennv AND Gioitinh= @gioitinh AND Ngaysinh= @ngaysinh AND Sodienthoai= @sdt AND Diachi= @diachi AND Cccd= @cccd AND Chucvu= @chucvu AND Manv= @manv ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("tennv", tb_tennv.Text);
                    cmd.Parameters.AddWithValue("gioitinh", tb_gioitinh.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("cccd", tb_cccd.Text);
                    cmd.Parameters.AddWithValue("diachi", tb_diachi.Text);
                    cmd.Parameters.AddWithValue("chucvu", tb_chucvu.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_NhanVien();
                    Clear_NhanVien();
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

        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_tennv.Text != "")
                {
                    string tennv = tb_tennv.Text;
                    cmd = new SqlCommand("SELECT * FROM Nhanvien WHERE tennv =N'" + tennv + "'", con);
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_nv.DataSource = dt;
                    con.Close();
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

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong hethong = new HeThong();
            hethong.ShowDialog();
        }
    }
}
