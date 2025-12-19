namespace BT11
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
            ShapesGroupBox = new GroupBox();
            EllipseButton = new RadioButton();
            RectangleButton = new RadioButton();
            LineButton = new RadioButton();
            PenGroupBox = new GroupBox();
            WidthBox = new NumericUpDown();
            ColorButton = new Button();
            widthLabel = new Label();
            BrushesGroupBox = new GroupBox();
            LinearGradientBrushButton = new RadioButton();
            TextureBrushButton = new RadioButton();
            HatchBrushButton = new RadioButton();
            SolidBrushButton = new RadioButton();
            panel1 = new Panel();
            ShapesGroupBox.SuspendLayout();
            PenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WidthBox).BeginInit();
            BrushesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ShapesGroupBox
            // 
            ShapesGroupBox.Controls.Add(EllipseButton);
            ShapesGroupBox.Controls.Add(RectangleButton);
            ShapesGroupBox.Controls.Add(LineButton);
            ShapesGroupBox.Location = new Point(12, 12);
            ShapesGroupBox.Name = "ShapesGroupBox";
            ShapesGroupBox.Size = new Size(178, 125);
            ShapesGroupBox.TabIndex = 0;
            ShapesGroupBox.TabStop = false;
            ShapesGroupBox.Text = "Shapes";
            // 
            // EllipseButton
            // 
            EllipseButton.AutoSize = true;
            EllipseButton.Location = new Point(13, 86);
            EllipseButton.Name = "EllipseButton";
            EllipseButton.Size = new Size(73, 24);
            EllipseButton.TabIndex = 5;
            EllipseButton.Text = "Ellipse";
            EllipseButton.UseVisualStyleBackColor = true;
            EllipseButton.CheckedChanged += EllipseButton_CheckedChanged;
            // 
            // RectangleButton
            // 
            RectangleButton.AutoSize = true;
            RectangleButton.Location = new Point(13, 56);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(96, 24);
            RectangleButton.TabIndex = 4;
            RectangleButton.Text = "Rectangle";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.CheckedChanged += RectangleButton_CheckedChanged;
            // 
            // LineButton
            // 
            LineButton.AutoSize = true;
            LineButton.Location = new Point(13, 26);
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(57, 24);
            LineButton.TabIndex = 3;
            LineButton.Text = "Line";
            LineButton.UseVisualStyleBackColor = true;
            LineButton.CheckedChanged += LineButton_CheckedChanged;
            // 
            // PenGroupBox
            // 
            PenGroupBox.Controls.Add(WidthBox);
            PenGroupBox.Controls.Add(ColorButton);
            PenGroupBox.Controls.Add(widthLabel);
            PenGroupBox.Location = new Point(12, 156);
            PenGroupBox.Name = "PenGroupBox";
            PenGroupBox.Size = new Size(178, 125);
            PenGroupBox.TabIndex = 1;
            PenGroupBox.TabStop = false;
            PenGroupBox.Text = "Pen";
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(58, 33);
            WidthBox.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            WidthBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(114, 27);
            WidthBox.TabIndex = 0;
            WidthBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            WidthBox.ValueChanged += WidthBox_ValueChanged;
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(36, 79);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(94, 29);
            ColorButton.TabIndex = 2;
            ColorButton.Text = "Color";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(0, 40);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(52, 20);
            widthLabel.TabIndex = 2;
            widthLabel.Text = "Width:";
            // 
            // BrushesGroupBox
            // 
            BrushesGroupBox.Controls.Add(LinearGradientBrushButton);
            BrushesGroupBox.Controls.Add(TextureBrushButton);
            BrushesGroupBox.Controls.Add(HatchBrushButton);
            BrushesGroupBox.Controls.Add(SolidBrushButton);
            BrushesGroupBox.Location = new Point(12, 296);
            BrushesGroupBox.Name = "BrushesGroupBox";
            BrushesGroupBox.Size = new Size(178, 242);
            BrushesGroupBox.TabIndex = 1;
            BrushesGroupBox.TabStop = false;
            BrushesGroupBox.Text = "Brushes";
            // 
            // LinearGradientBrushButton
            // 
            LinearGradientBrushButton.AutoSize = true;
            LinearGradientBrushButton.Location = new Point(13, 116);
            LinearGradientBrushButton.Name = "LinearGradientBrushButton";
            LinearGradientBrushButton.Size = new Size(163, 24);
            LinearGradientBrushButton.TabIndex = 3;
            LinearGradientBrushButton.Text = "LinearGradientBrush";
            LinearGradientBrushButton.UseVisualStyleBackColor = true;
            LinearGradientBrushButton.CheckedChanged += LinearGradientBrushButton_CheckedChanged;
            // 
            // TextureBrushButton
            // 
            TextureBrushButton.AutoSize = true;
            TextureBrushButton.Location = new Point(13, 86);
            TextureBrushButton.Name = "TextureBrushButton";
            TextureBrushButton.Size = new Size(114, 24);
            TextureBrushButton.TabIndex = 2;
            TextureBrushButton.Text = "TextureBrush";
            TextureBrushButton.UseVisualStyleBackColor = true;
            TextureBrushButton.CheckedChanged += TextureBrushButton_CheckedChanged;
            // 
            // HatchBrushButton
            // 
            HatchBrushButton.AutoSize = true;
            HatchBrushButton.Location = new Point(13, 56);
            HatchBrushButton.Name = "HatchBrushButton";
            HatchBrushButton.Size = new Size(105, 24);
            HatchBrushButton.TabIndex = 1;
            HatchBrushButton.Text = "HatchBrush";
            HatchBrushButton.UseVisualStyleBackColor = true;
            HatchBrushButton.CheckedChanged += HatchBrushButton_CheckedChanged;
            // 
            // SolidBrushButton
            // 
            SolidBrushButton.AutoSize = true;
            SolidBrushButton.Location = new Point(13, 26);
            SolidBrushButton.Name = "SolidBrushButton";
            SolidBrushButton.Size = new Size(100, 24);
            SolidBrushButton.TabIndex = 0;
            SolidBrushButton.Text = "SolidBrush";
            SolidBrushButton.UseVisualStyleBackColor = true;
            SolidBrushButton.CheckedChanged += SolidBrushButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(196, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 517);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 550);
            Controls.Add(panel1);
            Controls.Add(BrushesGroupBox);
            Controls.Add(PenGroupBox);
            Controls.Add(ShapesGroupBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ShapesGroupBox.ResumeLayout(false);
            ShapesGroupBox.PerformLayout();
            PenGroupBox.ResumeLayout(false);
            PenGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WidthBox).EndInit();
            BrushesGroupBox.ResumeLayout(false);
            BrushesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ShapesGroupBox;
        private GroupBox PenGroupBox;
        private GroupBox BrushesGroupBox;
        private Button ColorButton;
        private Label widthLabel;
        private CheckedListBox checkedListBox2;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton SolidBrushButton;
        private RadioButton EllipseButton;
        private RadioButton RectangleButton;
        private RadioButton LineButton;
        private RadioButton LinearGradientBrushButton;
        private RadioButton TextureBrushButton;
        private RadioButton HatchBrushButton;
        private NumericUpDown WidthBox;
    }
}
