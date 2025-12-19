namespace BT05
{
    partial class QuanLySinhVien
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
            menuStrip1 = new MenuStrip();
            ChucNangMenuStrip = new ToolStripMenuItem();
            ThemMoiMenuStrip = new ToolStripMenuItem();
            ThoatMenuStrip = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            ThemButton = new ToolStripButton();
            ThemMoiLabel = new ToolStripLabel();
            TimKiemLabel = new ToolStripLabel();
            TimKiemTextBox = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSinhVien = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DiemTrungBinh = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ChucNangMenuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ChucNangMenuStrip
            // 
            ChucNangMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { ThemMoiMenuStrip, ThoatMenuStrip });
            ChucNangMenuStrip.Name = "ChucNangMenuStrip";
            ChucNangMenuStrip.Size = new Size(93, 24);
            ChucNangMenuStrip.Text = "Chức năng";
            // 
            // ThemMoiMenuStrip
            // 
            ThemMoiMenuStrip.Name = "ThemMoiMenuStrip";
            ThemMoiMenuStrip.Size = new Size(233, 26);
            ThemMoiMenuStrip.Text = "Thêm mới   (Ctrl + N)";
            ThemMoiMenuStrip.Click += ThemMoiMenuStrip_Click;
            // 
            // ThoatMenuStrip
            // 
            ThoatMenuStrip.Name = "ThoatMenuStrip";
            ThoatMenuStrip.Size = new Size(233, 26);
            ThoatMenuStrip.Text = "Thoát";
            ThoatMenuStrip.Click += ThoatMenuStrip_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ThemButton, ThemMoiLabel, TimKiemLabel, TimKiemTextBox });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ThemButton
            // 
            ThemButton.AutoSize = false;
            ThemButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ThemButton.Image = Properties.Resources.Add;
            ThemButton.ImageTransparentColor = Color.Magenta;
            ThemButton.Name = "ThemButton";
            ThemButton.Size = new Size(40, 38);
            ThemButton.Text = "toolStripButton1";
            ThemButton.Click += ThemButton_Click;
            // 
            // ThemMoiLabel
            // 
            ThemMoiLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThemMoiLabel.Name = "ThemMoiLabel";
            ThemMoiLabel.Size = new Size(118, 38);
            ThemMoiLabel.Text = "Thêm Mới";
            // 
            // TimKiemLabel
            // 
            TimKiemLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimKiemLabel.Name = "TimKiemLabel";
            TimKiemLabel.Padding = new Padding(130, 0, 0, 0);
            TimKiemLabel.Size = new Size(328, 38);
            TimKiemLabel.Text = "Tìm kiếm theo tên";
            TimKiemLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TimKiemTextBox
            // 
            TimKiemTextBox.AutoSize = false;
            TimKiemTextBox.Name = "TimKiemTextBox";
            TimKiemTextBox.Size = new Size(250, 41);
            TimKiemTextBox.TextChanged += TimKiemTextBox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, MaSoSV, TenSinhVien, Khoa, DiemTrungBinh });
            dataGridView1.Location = new Point(0, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 378);
            dataGridView1.TabIndex = 2;
            // 
            // STT
            // 
            STT.HeaderText = "Số TT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.Width = 125;
            // 
            // MaSoSV
            // 
            MaSoSV.HeaderText = "Mã Số SV";
            MaSoSV.MinimumWidth = 6;
            MaSoSV.Name = "MaSoSV";
            MaSoSV.Width = 125;
            // 
            // TenSinhVien
            // 
            TenSinhVien.HeaderText = "Tên Sinh Viên";
            TenSinhVien.MinimumWidth = 6;
            TenSinhVien.Name = "TenSinhVien";
            TenSinhVien.Width = 200;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.Width = 200;
            // 
            // DiemTrungBinh
            // 
            DiemTrungBinh.HeaderText = "Diểm TB";
            DiemTrungBinh.MinimumWidth = 6;
            DiemTrungBinh.Name = "DiemTrungBinh";
            DiemTrungBinh.Width = 125;
            // 
            // QuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "QuanLySinhVien";
            Text = "QuanLySinhVien";
            KeyDown += QuanLySinhVien_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ChucNangMenuStrip;
        private ToolStripMenuItem ThemMoiMenuStrip;
        private ToolStripMenuItem ThoatMenuStrip;
        private ToolStrip toolStrip1;
        private ToolStripButton ThemButton;
        private ToolStripLabel ThemMoiLabel;
        private ToolStripLabel TimKiemLabel;
        private ToolStripTextBox TimKiemTextBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSinhVien;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DiemTrungBinh;
    }
}