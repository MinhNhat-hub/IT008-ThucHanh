namespace BT05
{
    partial class ThemSinhVien
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
            MaSVlabel = new Label();
            TenSVlabel = new Label();
            Khoalabel = new Label();
            DiemTBlabel = new Label();
            MaSVtextBox = new TextBox();
            TenSVtextBox = new TextBox();
            DiemTBtextBox = new TextBox();
            KhoaComboBox = new ComboBox();
            Thembutton = new Button();
            Thoatbutton = new Button();
            SuspendLayout();
            // 
            // MaSVlabel
            // 
            MaSVlabel.AutoSize = true;
            MaSVlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaSVlabel.Location = new Point(100, 84);
            MaSVlabel.Name = "MaSVlabel";
            MaSVlabel.Size = new Size(179, 31);
            MaSVlabel.TabIndex = 0;
            MaSVlabel.Text = "Mã Số Sinh Viên";
            // 
            // TenSVlabel
            // 
            TenSVlabel.AutoSize = true;
            TenSVlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TenSVlabel.Location = new Point(100, 148);
            TenSVlabel.Name = "TenSVlabel";
            TenSVlabel.Size = new Size(150, 31);
            TenSVlabel.TabIndex = 1;
            TenSVlabel.Text = "Tên Sinh Viên";
            // 
            // Khoalabel
            // 
            Khoalabel.AutoSize = true;
            Khoalabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Khoalabel.Location = new Point(100, 212);
            Khoalabel.Name = "Khoalabel";
            Khoalabel.Size = new Size(65, 31);
            Khoalabel.TabIndex = 2;
            Khoalabel.Text = "Khoa";
            // 
            // DiemTBlabel
            // 
            DiemTBlabel.AutoSize = true;
            DiemTBlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiemTBlabel.Location = new Point(100, 276);
            DiemTBlabel.Name = "DiemTBlabel";
            DiemTBlabel.Size = new Size(99, 31);
            DiemTBlabel.TabIndex = 3;
            DiemTBlabel.Text = "Điểm TB";
            // 
            // MaSVtextBox
            // 
            MaSVtextBox.Location = new Point(310, 88);
            MaSVtextBox.Name = "MaSVtextBox";
            MaSVtextBox.Size = new Size(211, 27);
            MaSVtextBox.TabIndex = 4;
            // 
            // TenSVtextBox
            // 
            TenSVtextBox.Location = new Point(310, 152);
            TenSVtextBox.Name = "TenSVtextBox";
            TenSVtextBox.Size = new Size(436, 27);
            TenSVtextBox.TabIndex = 5;
            // 
            // DiemTBtextBox
            // 
            DiemTBtextBox.Location = new Point(310, 280);
            DiemTBtextBox.Name = "DiemTBtextBox";
            DiemTBtextBox.Size = new Size(97, 27);
            DiemTBtextBox.TabIndex = 6;
            // 
            // KhoaComboBox
            // 
            KhoaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KhoaComboBox.FormattingEnabled = true;
            KhoaComboBox.Items.AddRange(new object[] { "Khoa học máy tính", "Khoa học và Kỹ thuật thông tin", "Kỹ thuật máy tính", "Công nghệ phần mềm", "Hệ thống thông tin", "Mạng máy tính và truyền thông" });
            KhoaComboBox.Location = new Point(310, 215);
            KhoaComboBox.Name = "KhoaComboBox";
            KhoaComboBox.Size = new Size(436, 28);
            KhoaComboBox.TabIndex = 7;
            // 
            // Thembutton
            // 
            Thembutton.BackColor = Color.FromArgb(0, 192, 0);
            Thembutton.Location = new Point(507, 380);
            Thembutton.Name = "Thembutton";
            Thembutton.Size = new Size(128, 41);
            Thembutton.TabIndex = 8;
            Thembutton.Text = "Thêm Mới";
            Thembutton.UseVisualStyleBackColor = false;
            Thembutton.Click += Thembutton_Click;
            // 
            // Thoatbutton
            // 
            Thoatbutton.BackColor = Color.FromArgb(255, 128, 0);
            Thoatbutton.Location = new Point(641, 380);
            Thoatbutton.Name = "Thoatbutton";
            Thoatbutton.Size = new Size(128, 41);
            Thoatbutton.TabIndex = 9;
            Thoatbutton.Text = "Thoát";
            Thoatbutton.UseVisualStyleBackColor = false;
            // 
            // ThemSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoatbutton);
            Controls.Add(Thembutton);
            Controls.Add(KhoaComboBox);
            Controls.Add(DiemTBtextBox);
            Controls.Add(TenSVtextBox);
            Controls.Add(MaSVtextBox);
            Controls.Add(DiemTBlabel);
            Controls.Add(Khoalabel);
            Controls.Add(TenSVlabel);
            Controls.Add(MaSVlabel);
            Name = "ThemSinhVien";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MaSVlabel;
        private Label TenSVlabel;
        private Label Khoalabel;
        private Label DiemTBlabel;
        private TextBox MaSVtextBox;
        private TextBox TenSVtextBox;
        private TextBox DiemTBtextBox;
        private ComboBox KhoaComboBox;
        private Button Thembutton;
        private Button Thoatbutton;
    }
}
