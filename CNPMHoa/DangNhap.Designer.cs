namespace CNPMHoa
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_dangxuat = new System.Windows.Forms.Button();
            this.rb_tkmoi = new System.Windows.Forms.RadioButton();
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ttk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(219, 220);
            this.tb_taikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(252, 22);
            this.tb_taikhoan.TabIndex = 0;
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(70, 219);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(95, 22);
            this.lb_taikhoan.TabIndex = 1;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật Khẩu";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Location = new System.Drawing.Point(219, 263);
            this.tb_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.Size = new System.Drawing.Size(252, 22);
            this.tb_matkhau.TabIndex = 3;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.Pink;
            this.bt_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("bt_dangnhap.Image")));
            this.bt_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangnhap.Location = new System.Drawing.Point(29, 493);
            this.bt_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(168, 62);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.BackColor = System.Drawing.Color.Pink;
            this.bt_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("bt_dangxuat.Image")));
            this.bt_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangxuat.Location = new System.Drawing.Point(471, 493);
            this.bt_dangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.Size = new System.Drawing.Size(174, 62);
            this.bt_dangxuat.TabIndex = 5;
            this.bt_dangxuat.Text = "Đăng Xuất";
            this.bt_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dangxuat.UseVisualStyleBackColor = false;
            this.bt_dangxuat.Click += new System.EventHandler(this.bt_dangxuat_Click);
            // 
            // rb_tkmoi
            // 
            this.rb_tkmoi.AutoSize = true;
            this.rb_tkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rb_tkmoi.Location = new System.Drawing.Point(233, 438);
            this.rb_tkmoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_tkmoi.Name = "rb_tkmoi";
            this.rb_tkmoi.Size = new System.Drawing.Size(146, 24);
            this.rb_tkmoi.TabIndex = 7;
            this.rb_tkmoi.TabStop = true;
            this.rb_tkmoi.Text = "Người dùng mới";
            this.rb_tkmoi.UseVisualStyleBackColor = true;
            this.rb_tkmoi.CheckedChanged += new System.EventHandler(this.rb_tkmoi_CheckedChanged);
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ten.Location = new System.Drawing.Point(72, 363);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(48, 22);
            this.lb_ten.TabIndex = 8;
            this.lb_ten.Text = "Tên ";
            this.lb_ten.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sdt.Location = new System.Drawing.Point(70, 396);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(121, 22);
            this.lb_sdt.TabIndex = 9;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_user.Location = new System.Drawing.Point(72, 330);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(51, 22);
            this.lb_user.TabIndex = 10;
            this.lb_user.Text = "User";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(219, 394);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(252, 22);
            this.tb_sdt.TabIndex = 11;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(219, 362);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(252, 22);
            this.tb_ten.TabIndex = 12;
            // 
            // cb_user
            // 
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Items.AddRange(new object[] {
            "Nhân Viên",
            "Khách hàng",
            "Quản lý"});
            this.cb_user.Location = new System.Drawing.Point(219, 328);
            this.cb_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(108, 24);
            this.cb_user.TabIndex = 14;
            this.cb_user.SelectedIndexChanged += new System.EventHandler(this.cb_user_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu để từ 6 - 8 ký tự ";
            // 
            // bt_ttk
            // 
            this.bt_ttk.BackColor = System.Drawing.Color.Pink;
            this.bt_ttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_ttk.Image = ((System.Drawing.Image)(resources.GetObject("bt_ttk.Image")));
            this.bt_ttk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_ttk.Location = new System.Drawing.Point(242, 493);
            this.bt_ttk.Name = "bt_ttk";
            this.bt_ttk.Size = new System.Drawing.Size(190, 62);
            this.bt_ttk.TabIndex = 16;
            this.bt_ttk.Text = "Tạo tài khoản";
            this.bt_ttk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ttk.UseVisualStyleBackColor = false;
            this.bt_ttk.Click += new System.EventHandler(this.bt_ttk_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(78, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 187);
            this.button1.TabIndex = 17;
            this.button1.Text = "Welcome to the flower shop";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(693, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_ttk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.rb_tkmoi);
            this.Controls.Add(this.bt_dangxuat);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.tb_taikhoan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_dangxuat;
        private System.Windows.Forms.RadioButton rb_tkmoi;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.ComboBox cb_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ttk;
        private System.Windows.Forms.Button button1;
    }
}