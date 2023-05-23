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
    public partial class BCTK : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C8GFA9A8\SQLEXPRESS;Initial Catalog=QLHoa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int row_id = 0;
        public BCTK()
        {
            InitializeComponent();
           
        }
        private void Display_bctk()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM BCTK ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_bctk.DataSource = dt;
            con.Close();
        }
        private void Clear_bctk()
        {
            tb_mabc.Text = "";
            tb_mahoa.Text = "";
            tb_tenhoa.Text = "";
            tb_loaihoa.Text = "";
            tb_mauhoa.Text = "";
            tb_nhap.Text = "";
            tb_note.Text = "";
            tb_xuat.Text = "";
            tb_ton.Text = "";

        }
        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            Display_bctk();
        }

        private void dgv_bctk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            tb_mabc.Text = dgv_bctk.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_mahoa.Text = dgv_bctk.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_tenhoa.Text = dgv_bctk.Rows[row_id].Cells[2].Value.ToString().Trim();
            tb_loaihoa.Text = dgv_bctk.Rows[row_id].Cells[3].Value.ToString().Trim();
            tb_mauhoa.Text = dgv_bctk.Rows[row_id].Cells[4].Value.ToString().Trim();
            tb_ton.Text = dgv_bctk.Rows[row_id].Cells[5].Value.ToString().Trim();
            tb_nhap.Text = dgv_bctk.Rows[row_id].Cells[6].Value.ToString().Trim();
            tb_note.Text = dgv_bctk.Rows[row_id].Cells[8].Value.ToString().Trim();
            tb_xuat.Text = dgv_bctk.Rows[row_id].Cells[7].Value.ToString().Trim();
        }

        private void bt_ton_Click(object sender, EventArgs e)
        {
            tb_ton.Enabled = true;
            lb_ton.Enabled = true;
            tb_nhap.Enabled = false;
            lb_nhap.Enabled = false;
            tb_xuat.Enabled = false;
            lb_xuat.Enabled = false;
        
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT Mabctk,Mahoa,Tenhoa,Loaihoa,Mauhoa,Ton,Note FROM BCTK ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_bctk.DataSource = dt;
            con.Close();
            
        }

        private void bt_nhap_Click(object sender, EventArgs e)
        {
            tb_nhap.Enabled = true;
            lb_nhap.Enabled = true;
            tb_ton.Enabled = false;
            lb_ton.Enabled = false;
            tb_xuat.Enabled = false;
            lb_xuat.Enabled = false;

            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT Mabctk,Mahoa,Tenhoa,Loaihoa,Mauhoa,Nhap,Note FROM BCTK ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_bctk.DataSource = dt;
            con.Close();
        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            tb_xuat.Enabled = true;
            lb_xuat.Enabled = true;
            tb_nhap.Enabled = false;
            lb_nhap.Enabled = false;
            tb_ton.Enabled = false;
            lb_ton.Enabled = false;

            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT Mabctk,Mahoa,Tenhoa,Loaihoa,Mauhoa,Xuat,Note FROM BCTK ", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_bctk.DataSource = dt;
            con.Close();
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThong hethong = new HeThong();
            hethong.ShowDialog();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_mabc.Text != "" || tb_tenhoa.Text != "" || tb_mahoa.Text != "" || tb_loaihoa.Text != "" || tb_mauhoa.Text != "" || tb_ton.Text != "" || tb_nhap.Text != "" || tb_xuat.Text != "" || tb_note.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO BCTK (Mabctk,Tenhoa,Mahoa,Loaihoa,Mauhoa,Ton,Nhap,Xuat,Note) VALUES(@mabc, @tenhoa, @mahoa, @loaihoa, @mauhoa ,@ton, @nhap , @xuat,@note)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mabc", tb_mabc.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mauhoa.Text);
                    cmd.Parameters.AddWithValue("ton", tb_ton.Text);
                    cmd.Parameters.AddWithValue("nhap", tb_nhap.Text);
                    cmd.Parameters.AddWithValue("xuat", tb_xuat.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display_bctk();
                    Clear_bctk();
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
                if (tb_mabc.Text != "" || tb_tenhoa.Text != "" || tb_mahoa.Text != "" || tb_loaihoa.Text != "" || tb_mauhoa.Text != "" || tb_ton.Text != "" || tb_nhap.Text != "" || tb_xuat.Text != "" || tb_note.Text != "")
                {
                    cmd = new SqlCommand("UPDATE BCTK SET Tenhoa= @tenhoa, Mahoa= @mahoa, Loaihoa= @loaihoa, Mauhoa= @mauhoa, Ton= @ton, Nhap= @nhap, Xuat=@xuat, Note=@note WHERE Mabctk= @mabc", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mabc", tb_mabc.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mauhoa.Text);
                    cmd.Parameters.AddWithValue("ton", tb_ton.Text);
                    cmd.Parameters.AddWithValue("nhap", tb_nhap.Text);
                    cmd.Parameters.AddWithValue("xuat", tb_xuat.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Sửa báo cáo thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_bctk();
                    Clear_bctk();
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
                if (tb_mabc.Text != "" || tb_tenhoa.Text != "" || tb_mahoa.Text != "" || tb_loaihoa.Text != "" || tb_mauhoa.Text != "" || tb_ton.Text != "" || tb_nhap.Text != "" || tb_xuat.Text != "" || tb_note.Text != "")
                {
                    cmd = new SqlCommand("DELETE BCTK WHERE Tenhoa= @tenhoa AND Mahoa= @mahoa AND Loaihoa= @loaihoa AND Mauhoa= @mauhoa AND Ton= @ton AND Nhap= @nhap AND Xuat=@xuat AND Note=@note AND Mabctk= @mabc ", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("mabc", tb_mabc.Text);
                    cmd.Parameters.AddWithValue("tenhoa", tb_tenhoa.Text);
                    cmd.Parameters.AddWithValue("mahoa", tb_mahoa.Text);
                    cmd.Parameters.AddWithValue("loaihoa", tb_loaihoa.Text);
                    cmd.Parameters.AddWithValue("mauhoa", tb_mauhoa.Text);
                    cmd.Parameters.AddWithValue("ton", tb_ton.Text);
                    cmd.Parameters.AddWithValue("nhap", tb_nhap.Text);
                    cmd.Parameters.AddWithValue("xuat", tb_xuat.Text);
                    cmd.Parameters.AddWithValue("note", tb_note.Text);
                    int RowAffected = cmd.ExecuteNonQuery();
                    if (RowAffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                    Display_bctk();
                    Clear_bctk();
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
                if (tb_mabc.Text != "")
                {
                    string mabc = tb_mabc.Text;
                    cmd = new SqlCommand("SELECT * FROM BCTK WHERE Mabctk = " + mabc + "'", con);
                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_bctk.DataSource = dt;
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
