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
    public partial class Khachhang : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int row_id = 0;
        public Khachhang()
        {
            InitializeComponent();
        }
        private void Display_Khachhang()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Khachhang ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_kh.DataSource = dt;
            con.Close();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {

        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_Khachhang();
        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            tb_makh.Text = dgv_kh.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tenkh.Text = dgv_kh.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_cccd.Text = dgv_kh.Rows[row_id].Cells[6].Value.ToString().Trim();
            tb_gioitinh.Text = dgv_kh.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_sdt.Text = dgv_kh.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_diachi.Text = dgv_kh.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_email.Text = dgv_kh.Rows[row_id].Cells[5].Value.ToString().Trim();
        }
        private void Clear_Khachhang()
        {
            tb_makh.Text = "";
            tb_tenkh.Text = "";
            tb_gioitinh.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            tb_cccd.Text = "";
            tb_email.Text = "";

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
        { 
            if (tb_makh.Text != "" || tb_tenkh.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_email.Text !="" )
            {
                cmd = new SqlCommand("INSERT INTO Khachhang (Makh,Tenkh,Gioitinh,Sodienthoai,Cccd,Diachi,Email) VALUES(@makh, @tenkh, @gioitinh,@sdt ,@cccd, @diachi, @email)", con);
                con.Open();
                cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                cmd.Parameters.AddWithValue("gioitinh", tb_gioitinh.Text);
                cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                cmd.Parameters.AddWithValue("cccd", tb_cccd.Text);
                cmd.Parameters.AddWithValue("diachi", tb_diachi.Text);
                cmd.Parameters.AddWithValue("email", tb_email.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display_Khachhang();
                Clear_Khachhang();
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

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong hethong = new HeThong();
            hethong.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_makh.Text != "" || tb_tenkh.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_email.Text != "")
                {
                    cmd = new SqlCommand("UPDATE Khachhang SET Tenkh= @tenkh, Gioitinh= @gioitinh, Sodienthoai= @sdt, Diachi= @diachi, Cccd= @cccd, Email= @email WHERE Makh= @makh", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                    cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                    cmd.Parameters.AddWithValue("gioitinh", tb_gioitinh.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("cccd", tb_cccd.Text);
                    cmd.Parameters.AddWithValue("diachi", tb_diachi.Text);
                    cmd.Parameters.AddWithValue("email", tb_email.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Khachhang();
                    Clear_Khachhang();
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
                if (tb_makh.Text != "" || tb_tenkh.Text != "" || tb_gioitinh.Text != "" || tb_sdt.Text != "" || tb_diachi.Text != "" || tb_cccd.Text != "" || tb_email.Text != "")
                {
                    cmd = new SqlCommand("DELETE Khachhang WHERE Tenkh= @tenkh AND Gioitinh= @gioitinh AND Sodienthoai= @sdt AND Diachi= @diachi AND Cccd= @cccd AND Email= @email AND Makh= @makh ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                    cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                    cmd.Parameters.AddWithValue("gioitinh", tb_gioitinh.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("cccd", tb_cccd.Text);
                    cmd.Parameters.AddWithValue("diachi", tb_diachi.Text);
                    cmd.Parameters.AddWithValue("email", tb_email.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Khachhang();
                    Clear_Khachhang();
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

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_tenkh.Text != "")
                {
                    string tenkh = tb_tenkh.Text;
                    cmd = new SqlCommand("SELECT * FROM Khachhang WHERE Tenkh =N'" + tenkh + "'", con);
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_kh.DataSource = dt;
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
    }
}
