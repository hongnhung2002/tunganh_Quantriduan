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
    public partial class Hoa : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int row_id = 0;

        public Hoa()
        {
            InitializeComponent();
        }
        private void Display_Sanpham()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Sanpham ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_hoa.DataSource = dt;
            con.Close();
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong hethong = new HeThong();
            hethong.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_Sanpham();
        }

        private void dgv_hoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            tb_mahoa.Text = dgv_hoa.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_tenhoa.Text = dgv_hoa.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_loaihoa.Text = dgv_hoa.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_mau.Text = dgv_hoa.Rows[row_id].Cells[3].Value.ToString().Trim();
        }
        private void Clear_Sanpham()
        {
            tb_mahoa.Text = "";
            tb_tenhoa.Text = "";
            tb_loaihoa.Text = "";
            tb_mau.Text = "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_mahoa.Text != "" || tb_tenhoa.Text != "" || tb_loaihoa.Text != "" || tb_mau.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Sanpham (Mahoa,Tenhoa,Loaihoa, Mauhoa) VALUES(@mahoa, @tenhoa, @loaihoa, @mauhoa)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mau.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thông tin thành công !S", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display_Sanpham();
                    Clear_Sanpham();
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
                if (tb_mahoa.Text != "" || tb_tenhoa.Text != "" || tb_loaihoa.Text != "" || tb_mau.Text != "")
                {
                    cmd = new SqlCommand("DELETE Sanpham WHERE Tenhoa= @tenhoa AND Loaihoa= @loaihoa AND Mahoa=@mahoa AND Mauhoa=@mauhoa ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mau.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Sanpham();
                    Clear_Sanpham();
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
                if (tb_mahoa.Text != "" || tb_tenhoa.Text != "" || tb_loaihoa.Text != "" || tb_mau.Text != "")
                {
                    cmd = new SqlCommand("UPDATE Sanpham SET Tenhoa= @tenhoa, Loaihoa= @loaihoa, Mauhoa=@mauhoa WHERE Mahoa=@mahoa", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mau.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Sanpham();
                    Clear_Sanpham();
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
                if (tb_tenhoa.Text != "")
                {
                    string tenhoa = tb_tenhoa.Text;
                    cmd = new SqlCommand("SELECT * FROM Sanpham WHERE Tenhoa =N'" + tenhoa + "'", con);
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_hoa.DataSource = dt;
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
