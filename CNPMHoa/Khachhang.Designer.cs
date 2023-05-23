namespace CNPMHoa
{
    partial class Khachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.lb_makh = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_cccd = new System.Windows.Forms.Label();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_gioitinh = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_cccd = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.bt_hienthi = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.BackColor = System.Drawing.Color.Pink;
            this.lb_makh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_makh.Location = new System.Drawing.Point(12, 31);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(127, 22);
            this.lb_makh.TabIndex = 0;
            this.lb_makh.Text = "Mã Khách hàng";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenkh.Location = new System.Drawing.Point(10, 89);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(129, 22);
            this.lb_tenkh.TabIndex = 1;
            this.lb_tenkh.Text = "Tên khách hàng";
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_gioitinh.Location = new System.Drawing.Point(16, 269);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(73, 22);
            this.lb_gioitinh.TabIndex = 2;
            this.lb_gioitinh.Text = "Giới tính";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sdt.Location = new System.Drawing.Point(12, 210);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(108, 22);
            this.lb_sdt.TabIndex = 3;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_diachi.Location = new System.Drawing.Point(16, 328);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(63, 22);
            this.lb_diachi.TabIndex = 4;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_email.Location = new System.Drawing.Point(16, 384);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(53, 22);
            this.lb_email.TabIndex = 5;
            this.lb_email.Text = "Email";
            // 
            // lb_cccd
            // 
            this.lb_cccd.AutoSize = true;
            this.lb_cccd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_cccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_cccd.Location = new System.Drawing.Point(12, 150);
            this.lb_cccd.Name = "lb_cccd";
            this.lb_cccd.Size = new System.Drawing.Size(155, 22);
            this.lb_cccd.TabIndex = 6;
            this.lb_cccd.Text = "Căn cước công dân";
            // 
            // tb_makh
            // 
            this.tb_makh.Location = new System.Drawing.Point(179, 31);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(245, 22);
            this.tb_makh.TabIndex = 7;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(179, 382);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(245, 22);
            this.tb_email.TabIndex = 8;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(179, 321);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(245, 22);
            this.tb_diachi.TabIndex = 9;
            // 
            // tb_gioitinh
            // 
            this.tb_gioitinh.Location = new System.Drawing.Point(179, 267);
            this.tb_gioitinh.Name = "tb_gioitinh";
            this.tb_gioitinh.Size = new System.Drawing.Size(245, 22);
            this.tb_gioitinh.TabIndex = 10;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(179, 210);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(245, 22);
            this.tb_sdt.TabIndex = 11;
            // 
            // tb_cccd
            // 
            this.tb_cccd.Location = new System.Drawing.Point(179, 148);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.Size = new System.Drawing.Size(245, 22);
            this.tb_cccd.TabIndex = 12;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Location = new System.Drawing.Point(179, 87);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(245, 22);
            this.tb_tenkh.TabIndex = 13;
            // 
            // dgv_kh
            // 
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kh.Location = new System.Drawing.Point(474, 12);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.RowTemplate.Height = 24;
            this.dgv_kh.Size = new System.Drawing.Size(792, 336);
            this.dgv_kh.TabIndex = 14;
            this.dgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellContentClick);
            // 
            // bt_hienthi
            // 
            this.bt_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_hienthi.Image = ((System.Drawing.Image)(resources.GetObject("bt_hienthi.Image")));
            this.bt_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_hienthi.Location = new System.Drawing.Point(557, 447);
            this.bt_hienthi.Name = "bt_hienthi";
            this.bt_hienthi.Size = new System.Drawing.Size(141, 61);
            this.bt_hienthi.TabIndex = 15;
            this.bt_hienthi.Text = "Hiển thị";
            this.bt_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_hienthi.UseVisualStyleBackColor = true;
            this.bt_hienthi.Click += new System.EventHandler(this.bt_hienthi_Click);
            // 
            // bt_them
            // 
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(39, 447);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(142, 61);
            this.bt_them.TabIndex = 16;
            this.bt_them.Text = "Thêm";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_sua.Image = ((System.Drawing.Image)(resources.GetObject("bt_sua.Image")));
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(236, 447);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(125, 61);
            this.bt_sua.TabIndex = 17;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.Image")));
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(721, 447);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(147, 61);
            this.bt_timkiem.TabIndex = 19;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("bt_quaylai.Image")));
            this.bt_quaylai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quaylai.Location = new System.Drawing.Point(917, 450);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(138, 58);
            this.bt_quaylai.TabIndex = 20;
            this.bt_quaylai.Text = "Quay lại";
            this.bt_quaylai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(391, 447);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(120, 61);
            this.bt_xoa.TabIndex = 21;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(1081, 361);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 173);
            this.button8.TabIndex = 22;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1297, 539);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_hienthi);
            this.Controls.Add(this.dgv_kh);
            this.Controls.Add(this.tb_tenkh);
            this.Controls.Add(this.tb_cccd);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_gioitinh);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_makh);
            this.Controls.Add(this.lb_cccd);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_gioitinh);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.lb_makh);
            this.Name = "Khachhang";
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.Label lb_tenkh;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_cccd;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_gioitinh;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_cccd;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.Button bt_hienthi;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button button8;
    }
}