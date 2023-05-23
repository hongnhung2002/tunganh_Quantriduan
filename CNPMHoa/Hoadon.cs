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
    public partial class Hoadon : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int row_id = 0;
        public Hoadon()
        {
            InitializeComponent();
        }
        private void Display_Banhang()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Hoadon ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_bh.DataSource = dt;
            con.Close();
        }
        private void Clear_Banhang()
        {
            tb_mahoa.Text = "";
            tb_mahd.Text = "";
            tb_manv.Text = "";
            tb_makh.Text = "";
            tb_tenkh.Text = "";
            tb_httt.Text = "";
            tb_sotien.Text = "";
            tb_note.Text = "";
            tb_sdt.Text = "";
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Banhang_Load(object sender, EventArgs e)
        {

        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_Banhang();
        }

        private void dgv_bh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            row_id = e.RowIndex;
            tb_mahd.Text = dgv_bh.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_manv.Text = dgv_bh.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_makh.Text = dgv_bh.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_tenkh.Text = dgv_bh.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_sdt.Text = dgv_bh.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_mahoa.Text = dgv_bh.Rows[row_id].Cells[5].Value.ToString().Trim();
            tb_sotien.Text = dgv_bh.Rows[row_id].Cells[6].Value.ToString().Trim();
            tb_httt.Text = dgv_bh.Rows[row_id].Cells[7].Value.ToString().Trim();
            tb_note.Text = dgv_bh.Rows[row_id].Cells[8].Value.ToString().Trim();
        }
    

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_manv.Text != "" || tb_mahd.Text != "" || tb_makh.Text != "" || tb_sdt.Text != "" || tb_tenkh.Text != "" || tb_mahoa.Text != "" || tb_httt.Text != "" || tb_note.Text != "" )
                {
                    cmd = new SqlCommand("INSERT INTO Hoadon (Manv,Tenkh,Mahd,Makh ,Sdt, Mahoa,Sotien, Hinhthuctt,Note) VALUES(@manv, @tenkh, @mahd, @makh, @sdt ,@mahoa, @sotien , @httt,@note)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                    cmd.Parameters.AddWithValue("mahd", tb_mahd.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("sotien", tb_sotien.Text);
                    cmd.Parameters.AddWithValue("httt", tb_httt.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display_Banhang();
                    Clear_Banhang();
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
                if (tb_manv.Text != "" || tb_mahd.Text != "" || tb_makh.Text != "" || tb_sdt.Text != "" || tb_tenkh.Text != "" || tb_mahoa.Text != "" || tb_httt.Text != "" || tb_note.Text != "")
                {
                    cmd = new SqlCommand("UPDATE Hoadon SET Tenkh= @tenkh, Manv= @manv, Makh= @makh, Sotien= @sotien, Hinhthuctt =@httt, Note=@note , Mahoa= @mahoa, Sdt= @sdt WHERE Mahd= @mahd", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                    cmd.Parameters.AddWithValue("mahd", tb_mahd.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("sotien", tb_sotien.Text);
                    cmd.Parameters.AddWithValue("httt", tb_httt.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Banhang();
                    Clear_Banhang();
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
                if (tb_manv.Text != "" || tb_mahd.Text != "" || tb_makh.Text != "" || tb_sdt.Text != "" || tb_tenkh.Text != "" || tb_mahoa.Text != "" || tb_httt.Text != "" || tb_note.Text != "")
                {
                    cmd = new SqlCommand("DELETE Hoadon WHERE Tenkh= @tenkh AND Manv= @manv AND Makh= @makh AND Sotien= @sotien AND Hinhthuctt =@httt AND Note=@note AND Mahoa= @mahoa  AND Sdt= @sdt AND Mahd= @mahd ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("manv", tb_manv.Text);
                    cmd.Parameters.AddWithValue("tenkh", tb_tenkh.Text);
                    cmd.Parameters.AddWithValue("mahd", tb_mahd.Text);
                    cmd.Parameters.AddWithValue("sdt", tb_sdt.Text);
                    cmd.Parameters.AddWithValue("makh", tb_makh.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("sotien", tb_sotien.Text);
                    cmd.Parameters.AddWithValue("httt", tb_httt.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_Banhang();
                    Clear_Banhang();
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
                if (tb_mahd.Text != "")
                {
                    string mahd = tb_mahd.Text;
                    cmd = new SqlCommand("SELECT * FROM Hoadon WHERE Mahd =" + mahd + "'", con);
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_bh.DataSource = dt;
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

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong hethong = new HeThong();
            hethong.ShowDialog();
        }
    }
}
