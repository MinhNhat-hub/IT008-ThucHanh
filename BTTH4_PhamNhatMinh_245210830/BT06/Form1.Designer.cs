namespace BT06
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            DestText = new TextBox();
            SourceText = new TextBox();
            DichButton = new Button();
            CopyButton = new Button();
            NguonButton = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            TapTinDuocTai = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DestText);
            groupBox1.Controls.Add(SourceText);
            groupBox1.Controls.Add(DichButton);
            groupBox1.Controls.Add(CopyButton);
            groupBox1.Controls.Add(NguonButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1045, 226);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // DestText
            // 
            DestText.Location = new Point(253, 126);
            DestText.Name = "DestText";
            DestText.ReadOnly = true;
            DestText.Size = new Size(647, 27);
            DestText.TabIndex = 7;
            // 
            // SourceText
            // 
            SourceText.Location = new Point(253, 54);
            SourceText.Name = "SourceText";
            SourceText.ReadOnly = true;
            SourceText.Size = new Size(647, 27);
            SourceText.TabIndex = 6;
            // 
            // DichButton
            // 
            DichButton.Location = new Point(906, 126);
            DichButton.Name = "DichButton";
            DichButton.Size = new Size(45, 29);
            DichButton.TabIndex = 5;
            DichButton.Text = "...";
            DichButton.UseVisualStyleBackColor = true;
            DichButton.Click += DichButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Location = new Point(253, 182);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(192, 29);
            CopyButton.TabIndex = 2;
            CopyButton.Text = "Sao Chép";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // NguonButton
            // 
            NguonButton.Location = new Point(906, 52);
            NguonButton.Name = "NguonButton";
            NguonButton.Size = new Size(45, 29);
            NguonButton.TabIndex = 4;
            NguonButton.Text = "...";
            NguonButton.UseVisualStyleBackColor = true;
            NguonButton.Click += NguonButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 135);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 2;
            label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 61);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 1;
            label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(12, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1045, 98);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(28, 40);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1002, 29);
            progressBar1.TabIndex = 6;
            // 
            // TapTinDuocTai
            // 
            TapTinDuocTai.AutoSize = true;
            TapTinDuocTai.Location = new Point(12, 421);
            TapTinDuocTai.Name = "TapTinDuocTai";
            TapTinDuocTai.Size = new Size(115, 20);
            TapTinDuocTai.TabIndex = 6;
            TapTinDuocTai.Text = "Đang sao chép: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 450);
            Controls.Add(TapTinDuocTai);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button DichButton;
        private Button CopyButton;
        private Label label2;
        private Label label1;
        private Button NguonButton;
        private GroupBox groupBox2;
        private ProgressBar progressBar1;
        private Label TapTinDuocTai;
        private ToolTip toolTip1;
        private TextBox SourceText;
        private TextBox DestText;
    }
}
