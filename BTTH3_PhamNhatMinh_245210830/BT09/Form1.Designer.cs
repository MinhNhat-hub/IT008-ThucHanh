namespace BT09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            ChuyenNganhDaChonListBox = new ListBox();
            ChonChuyenNganhListBox = new ListBox();
            ChuyenNganhComboBox = new ComboBox();
            NuCheckBox = new CheckBox();
            NamCheckBox = new CheckBox();
            HoTenTextBox = new TextBox();
            MaSVTextBox = new TextBox();
            button4 = new Button();
            button3 = new Button();
            XoaChonButton = new Button();
            LuuThongTinButton = new Button();
            ChonMonHoclabel = new Label();
            GioiTinhlabel = new Label();
            ChuyenNganhlabel = new Label();
            HoTenlabel = new Label();
            MaSVlabel = new Label();
            label1 = new Label();
            listView1 = new ListView();
            MSSV = new ColumnHeader();
            HoTen = new ColumnHeader();
            ChuyenNganh = new ColumnHeader();
            GioiTinh = new ColumnHeader();
            SoMon = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChuyenNganhDaChonListBox);
            groupBox1.Controls.Add(ChonChuyenNganhListBox);
            groupBox1.Controls.Add(ChuyenNganhComboBox);
            groupBox1.Controls.Add(NuCheckBox);
            groupBox1.Controls.Add(NamCheckBox);
            groupBox1.Controls.Add(HoTenTextBox);
            groupBox1.Controls.Add(MaSVTextBox);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(XoaChonButton);
            groupBox1.Controls.Add(LuuThongTinButton);
            groupBox1.Controls.Add(ChonMonHoclabel);
            groupBox1.Controls.Add(GioiTinhlabel);
            groupBox1.Controls.Add(ChuyenNganhlabel);
            groupBox1.Controls.Add(HoTenlabel);
            groupBox1.Controls.Add(MaSVlabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(831, 331);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // ChuyenNganhDaChonListBox
            // 
            ChuyenNganhDaChonListBox.FormattingEnabled = true;
            ChuyenNganhDaChonListBox.Location = new Point(489, 219);
            ChuyenNganhDaChonListBox.Name = "ChuyenNganhDaChonListBox";
            ChuyenNganhDaChonListBox.Size = new Size(320, 64);
            ChuyenNganhDaChonListBox.TabIndex = 18;
            // 
            // ChonChuyenNganhListBox
            // 
            ChonChuyenNganhListBox.FormattingEnabled = true;
            ChonChuyenNganhListBox.Items.AddRange(new object[] { "Giới thiệu ngành Kỹ thuật Phần mềm", "Giải tích", "Đại số tuyến tính", "Tổ chức và Cấu trúc Máy tính II", "Nhập môn lập trình", "Anh văn 1", "Anh văn 2", "Anh văn 3", "Triết học Mác – Lênin", "Kỹ năng nghề nghiệp", "Xác suất thống kê", "Cấu trúc rời rạc", "Cấu trúc dữ liệu và giải thuật", "Lập trình hướng đối tượng", "Cơ sở dữ liệu", "Lập trình trực quan", "Nhập môn mạng máy tính", "Kinh tế chính trị Mác – Lênin", "Pháp luật đại cương" });
            ChonChuyenNganhListBox.Location = new Point(44, 220);
            ChonChuyenNganhListBox.Name = "ChonChuyenNganhListBox";
            ChonChuyenNganhListBox.ScrollAlwaysVisible = true;
            ChonChuyenNganhListBox.Size = new Size(337, 64);
            ChonChuyenNganhListBox.TabIndex = 17;
            // 
            // ChuyenNganhComboBox
            // 
            ChuyenNganhComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChuyenNganhComboBox.FormattingEnabled = true;
            ChuyenNganhComboBox.Items.AddRange(new object[] { "Truyền thông đa phương tiện", "Thương mại điện tử", "Khoa học dữ liệu", "Khoa học máy tính", "Mạng máy tính và truyền thông dữ liệu", "Kỹ thuật phần mềm", "Hệ thống thông tin", "Hệ thống thông tin (tiên tiến)", "Kỹ thuật máy tính", "Trí tuệ nhân tạo", "Công nghệ thông tin", "Công nghệ thông tin Việt Nhật", "An toàn thông tin", "Thiết kế Vi mạch" });
            ChuyenNganhComboBox.Location = new Point(276, 114);
            ChuyenNganhComboBox.Name = "ChuyenNganhComboBox";
            ChuyenNganhComboBox.Size = new Size(448, 28);
            ChuyenNganhComboBox.TabIndex = 16;
            // 
            // NuCheckBox
            // 
            NuCheckBox.AutoSize = true;
            NuCheckBox.Location = new Point(345, 148);
            NuCheckBox.Name = "NuCheckBox";
            NuCheckBox.Size = new Size(51, 24);
            NuCheckBox.TabIndex = 15;
            NuCheckBox.Text = "Nữ";
            NuCheckBox.UseVisualStyleBackColor = true;
            NuCheckBox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // NamCheckBox
            // 
            NamCheckBox.AutoSize = true;
            NamCheckBox.Location = new Point(276, 148);
            NamCheckBox.Name = "NamCheckBox";
            NamCheckBox.Size = new Size(63, 24);
            NamCheckBox.TabIndex = 14;
            NamCheckBox.Text = "Nam";
            NamCheckBox.UseVisualStyleBackColor = true;
            NamCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // HoTenTextBox
            // 
            HoTenTextBox.Location = new Point(276, 81);
            HoTenTextBox.Name = "HoTenTextBox";
            HoTenTextBox.Size = new Size(448, 27);
            HoTenTextBox.TabIndex = 12;
            // 
            // MaSVTextBox
            // 
            MaSVTextBox.Location = new Point(276, 48);
            MaSVTextBox.Name = "MaSVTextBox";
            MaSVTextBox.Size = new Size(226, 27);
            MaSVTextBox.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(415, 252);
            button4.Name = "button4";
            button4.Size = new Size(47, 32);
            button4.TabIndex = 10;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(415, 220);
            button3.Name = "button3";
            button3.Size = new Size(47, 33);
            button3.TabIndex = 9;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // XoaChonButton
            // 
            XoaChonButton.Location = new Point(438, 296);
            XoaChonButton.Name = "XoaChonButton";
            XoaChonButton.Size = new Size(94, 29);
            XoaChonButton.TabIndex = 8;
            XoaChonButton.Text = "Xóa chọn";
            XoaChonButton.UseVisualStyleBackColor = true;
            XoaChonButton.Click += XoaChonButton_Click;
            // 
            // LuuThongTinButton
            // 
            LuuThongTinButton.Location = new Point(287, 296);
            LuuThongTinButton.Name = "LuuThongTinButton";
            LuuThongTinButton.Size = new Size(126, 29);
            LuuThongTinButton.TabIndex = 1;
            LuuThongTinButton.Text = "Lưu thông tin";
            LuuThongTinButton.UseVisualStyleBackColor = true;
            LuuThongTinButton.Click += LuuThongTinButton_Click;
            // 
            // ChonMonHoclabel
            // 
            ChonMonHoclabel.AutoSize = true;
            ChonMonHoclabel.Location = new Point(137, 197);
            ChonMonHoclabel.Name = "ChonMonHoclabel";
            ChonMonHoclabel.Size = new Size(194, 20);
            ChonMonHoclabel.TabIndex = 5;
            ChonMonHoclabel.Text = "Chọn các môn học tham gia";
            // 
            // GioiTinhlabel
            // 
            GioiTinhlabel.AutoSize = true;
            GioiTinhlabel.Location = new Point(137, 148);
            GioiTinhlabel.Name = "GioiTinhlabel";
            GioiTinhlabel.Size = new Size(65, 20);
            GioiTinhlabel.TabIndex = 4;
            GioiTinhlabel.Text = "Giới tính";
            // 
            // ChuyenNganhlabel
            // 
            ChuyenNganhlabel.AutoSize = true;
            ChuyenNganhlabel.Location = new Point(137, 114);
            ChuyenNganhlabel.Name = "ChuyenNganhlabel";
            ChuyenNganhlabel.Size = new Size(102, 20);
            ChuyenNganhlabel.TabIndex = 3;
            ChuyenNganhlabel.Text = "Chuyên ngành";
            // 
            // HoTenlabel
            // 
            HoTenlabel.AutoSize = true;
            HoTenlabel.Location = new Point(137, 81);
            HoTenlabel.Name = "HoTenlabel";
            HoTenlabel.Size = new Size(54, 20);
            HoTenlabel.TabIndex = 2;
            HoTenlabel.Text = "Họ tên";
            // 
            // MaSVlabel
            // 
            MaSVlabel.AutoSize = true;
            MaSVlabel.Location = new Point(137, 48);
            MaSVlabel.Name = "MaSVlabel";
            MaSVlabel.Size = new Size(95, 20);
            MaSVlabel.TabIndex = 1;
            MaSVlabel.Text = "Mã Sinh Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { MSSV, HoTen, ChuyenNganh, GioiTinh, SoMon });
            listView1.Location = new Point(12, 349);
            listView1.Name = "listView1";
            listView1.Size = new Size(831, 196);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // MSSV
            // 
            MSSV.Text = "MSSV";
            MSSV.Width = 150;
            // 
            // HoTen
            // 
            HoTen.Text = "Họ Tên";
            HoTen.Width = 200;
            // 
            // ChuyenNganh
            // 
            ChuyenNganh.Text = "Chuyên Ngành";
            ChuyenNganh.Width = 270;
            // 
            // GioiTinh
            // 
            GioiTinh.Text = "Giới Tính";
            GioiTinh.Width = 120;
            // 
            // SoMon
            // 
            SoMon.Text = "Số Môn";
            SoMon.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 557);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nhập liệu sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label ChonMonHoclabel;
        private Label GioiTinhlabel;
        private Label ChuyenNganhlabel;
        private Label HoTenlabel;
        private Label MaSVlabel;
        private Label label1;
        private CheckBox NuCheckBox;
        private CheckBox NamCheckBox;
        private TextBox HoTenTextBox;
        private TextBox MaSVTextBox;
        private Button button4;
        private Button button3;
        private Button XoaChonButton;
        private Button LuuThongTinButton;
        private ListView listView1;
        private ComboBox ChuyenNganhComboBox;
        private ColumnHeader MSSV;
        private ColumnHeader HoTen;
        private ColumnHeader ChuyenNganh;
        private ColumnHeader GioiTinh;
        private ColumnHeader SoMon;
        private ListBox ChonChuyenNganhListBox;
        private ListBox ChuyenNganhDaChonListBox;
    }
}
