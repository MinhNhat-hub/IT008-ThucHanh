namespace BT08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtSoTK = new TextBox();
            txtTenKH = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            btnThemCapNhat = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lvTaiKhoan = new ListView();
            columnSTT = new ColumnHeader();
            columnMaTK = new ColumnHeader();
            columnTenKH = new ColumnHeader();
            columnDiaChi = new ColumnHeader();
            columnSoTien = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TongTienlabel = new Label();
            SuspendLayout();
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new Point(212, 70);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(453, 27);
            txtSoTK.TabIndex = 0;
            txtSoTK.KeyPress += txtSoTK_KeyPress;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(212, 116);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(453, 27);
            txtTenKH.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(212, 161);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(453, 27);
            txtDiaChi.TabIndex = 2;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(212, 213);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(453, 27);
            txtSoTien.TabIndex = 3;
            txtSoTien.KeyPress += txtSoTien_KeyPress;
            // 
            // btnThemCapNhat
            // 
            btnThemCapNhat.Location = new Point(337, 246);
            btnThemCapNhat.Name = "btnThemCapNhat";
            btnThemCapNhat.Size = new Size(128, 29);
            btnThemCapNhat.TabIndex = 4;
            btnThemCapNhat.Text = "Thêm/Cập nhật";
            btnThemCapNhat.UseVisualStyleBackColor = true;
            btnThemCapNhat.Click += btnThemCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(471, 246);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(571, 246);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { columnSTT, columnMaTK, columnTenKH, columnDiaChi, columnSoTien });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.Location = new Point(12, 281);
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(776, 176);
            lvTaiKhoan.TabIndex = 7;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // 
            // columnSTT
            // 
            columnSTT.Text = "STT";
            columnSTT.Width = 50;
            // 
            // columnMaTK
            // 
            columnMaTK.Text = "Mã tài khoản";
            columnMaTK.Width = 120;
            // 
            // columnTenKH
            // 
            columnTenKH.Text = "Tên khách hàng";
            columnTenKH.Width = 200;
            // 
            // columnDiaChi
            // 
            columnDiaChi.Text = "Địa chỉ";
            columnDiaChi.Width = 230;
            // 
            // columnSoTien
            // 
            columnSoTien.Text = "Số tiền";
            columnSoTien.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 73);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 8;
            label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 116);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 164);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 216);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 11;
            label4.Text = "Số tiền trong tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(62, 0);
            label5.Name = "label5";
            label5.Size = new Size(666, 67);
            label5.TabIndex = 12;
            label5.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // TongTienlabel
            // 
            TongTienlabel.AutoSize = true;
            TongTienlabel.Location = new Point(613, 465);
            TongTienlabel.Name = "TongTienlabel";
            TongTienlabel.Size = new Size(103, 20);
            TongTienlabel.TabIndex = 13;
            TongTienlabel.Text = "Tổng Tiền : 0đ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(TongTienlabel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThemCapNhat);
            Controls.Add(txtSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(txtSoTK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnThemCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.ColumnHeader columnSTT;
        private System.Windows.Forms.ColumnHeader columnMaTK;
        private System.Windows.Forms.ColumnHeader columnTenKH;
        private System.Windows.Forms.ColumnHeader columnDiaChi;
        private System.Windows.Forms.ColumnHeader columnSoTien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label TongTienlabel;
    }
}
