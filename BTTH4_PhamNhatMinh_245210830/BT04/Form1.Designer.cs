namespace BT04
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
            TextBox = new RichTextBox();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            TaoVanBanToolStripMenuItem = new ToolStripMenuItem();
            MoTapTinToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            LuuNoiDungToolStripMenuItem = new ToolStripMenuItem();
            ThoatToolStripMenuItem = new ToolStripMenuItem();
            DinhDangToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            FontBox = new ToolStripComboBox();
            FontSizeBox = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(12, 61);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(1322, 574);
            TextBox.TabIndex = 0;
            TextBox.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, DinhDangToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1346, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TaoVanBanToolStripMenuItem, MoTapTinToolStripMenuItem, toolStripMenuItem1, LuuNoiDungToolStripMenuItem, ThoatToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // TaoVanBanToolStripMenuItem
            // 
            TaoVanBanToolStripMenuItem.Name = "TaoVanBanToolStripMenuItem";
            TaoVanBanToolStripMenuItem.Size = new Size(295, 26);
            TaoVanBanToolStripMenuItem.Text = "Tạo văn bản mới          Ctrl + N";
            TaoVanBanToolStripMenuItem.Click += TaoVanBanToolStripMenuItem_Click;
            // 
            // MoTapTinToolStripMenuItem
            // 
            MoTapTinToolStripMenuItem.Name = "MoTapTinToolStripMenuItem";
            MoTapTinToolStripMenuItem.Size = new Size(295, 26);
            MoTapTinToolStripMenuItem.Text = "Mở tập tin";
            MoTapTinToolStripMenuItem.Click += MoTapTinToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(292, 6);
            // 
            // LuuNoiDungToolStripMenuItem
            // 
            LuuNoiDungToolStripMenuItem.Name = "LuuNoiDungToolStripMenuItem";
            LuuNoiDungToolStripMenuItem.Size = new Size(295, 26);
            LuuNoiDungToolStripMenuItem.Text = "Lưu nội dung văn bản  Ctrl + S";
            LuuNoiDungToolStripMenuItem.Click += LuuNoiDungToolStripMenuItem_Click;
            // 
            // ThoatToolStripMenuItem
            // 
            ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            ThoatToolStripMenuItem.Size = new Size(295, 26);
            ThoatToolStripMenuItem.Text = "Thoát";
            ThoatToolStripMenuItem.Click += ThoatToolStripMenuItem_Click;
            // 
            // DinhDangToolStripMenuItem
            // 
            DinhDangToolStripMenuItem.Name = "DinhDangToolStripMenuItem";
            DinhDangToolStripMenuItem.Size = new Size(92, 24);
            DinhDangToolStripMenuItem.Text = "Định dạng";
            DinhDangToolStripMenuItem.Click += DinhDangToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator2, FontBox, FontSizeBox, toolStripSeparator3, toolStripButton3, toolStripButton4, toolStripButton5, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1346, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.NewPage;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "New Page";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.SaveButton;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "Save";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // FontBox
            // 
            FontBox.AutoCompleteMode = AutoCompleteMode.Append;
            FontBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            FontBox.DropDownWidth = 200;
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(121, 28);
            FontBox.Text = "Tahoma";
            FontBox.SelectedIndexChanged += FontBox_SelectedIndexChanged;
            FontBox.Leave += FontBox_Leave;
            FontBox.TextChanged += FontBox_TextChanged;
            // 
            // FontSizeBox
            // 
            FontSizeBox.AutoCompleteCustomSource.AddRange(new string[] { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "72" });
            FontSizeBox.AutoCompleteMode = AutoCompleteMode.Append;
            FontSizeBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            FontSizeBox.Items.AddRange(new object[] { "8", "9", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "72" });
            FontSizeBox.Name = "FontSizeBox";
            FontSizeBox.Size = new Size(121, 28);
            FontSizeBox.Text = "14";
            FontSizeBox.Leave += FontSizeBox_Leave;
            FontSizeBox.KeyPress += FontSizeBox_KeyPress;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.Bold;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 25);
            toolStripButton3.Text = "Bold";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.Italic;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 25);
            toolStripButton4.Text = "Italic";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.Underline;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 25);
            toolStripButton5.Text = "Undeline";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 647);
            Controls.Add(toolStrip1);
            Controls.Add(TextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem DinhDangToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox FontBox;
        private ToolStripMenuItem TaoVanBanToolStripMenuItem;
        private ToolStripMenuItem MoTapTinToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem LuuNoiDungToolStripMenuItem;
        private ToolStripMenuItem ThoatToolStripMenuItem;
        private ToolStripComboBox FontSizeBox;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
    }
}
