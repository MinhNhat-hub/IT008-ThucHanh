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
            FontBox = new ComboBox();
            FontLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BoldCheckBox = new CheckBox();
            ItalicCheckBox = new CheckBox();
            UnderlineCheckBox = new CheckBox();
            SizeLabel = new Label();
            ColoLabel = new Label();
            ColorButton = new Button();
            numericUpDown1 = new NumericUpDown();
            AlignTextGroup = new GroupBox();
            RightButton = new RadioButton();
            CenterButton = new RadioButton();
            LeftButton = new RadioButton();
            DemoTextPanel = new Panel();
            DemoLabel = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            AlignTextGroup.SuspendLayout();
            DemoTextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FontBox
            // 
            FontBox.FormattingEnabled = true;
            FontBox.Location = new Point(77, 51);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(168, 28);
            FontBox.TabIndex = 0;
            FontBox.SelectedIndexChanged += UpdateFont;
            // 
            // FontLabel
            // 
            FontLabel.AutoSize = true;
            FontLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FontLabel.Location = new Point(19, 49);
            FontLabel.Name = "FontLabel";
            FontLabel.Size = new Size(52, 28);
            FontLabel.TabIndex = 1;
            FontLabel.Text = "Font";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BoldCheckBox);
            flowLayoutPanel1.Controls.Add(ItalicCheckBox);
            flowLayoutPanel1.Controls.Add(UnderlineCheckBox);
            flowLayoutPanel1.Location = new Point(28, 95);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(217, 55);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // BoldCheckBox
            // 
            BoldCheckBox.AutoSize = true;
            BoldCheckBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BoldCheckBox.Location = new Point(3, 3);
            BoldCheckBox.Name = "BoldCheckBox";
            BoldCheckBox.Size = new Size(46, 29);
            BoldCheckBox.TabIndex = 3;
            BoldCheckBox.Text = "B";
            BoldCheckBox.UseVisualStyleBackColor = true;
            BoldCheckBox.CheckedChanged += UpdateFont;
            // 
            // ItalicCheckBox
            // 
            ItalicCheckBox.AutoSize = true;
            ItalicCheckBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ItalicCheckBox.Location = new Point(55, 3);
            ItalicCheckBox.Name = "ItalicCheckBox";
            ItalicCheckBox.Size = new Size(39, 29);
            ItalicCheckBox.TabIndex = 4;
            ItalicCheckBox.Text = "I";
            ItalicCheckBox.UseVisualStyleBackColor = true;
            ItalicCheckBox.CheckedChanged += UpdateFont;
            // 
            // UnderlineCheckBox
            // 
            UnderlineCheckBox.AutoSize = true;
            UnderlineCheckBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            UnderlineCheckBox.Location = new Point(100, 3);
            UnderlineCheckBox.Name = "UnderlineCheckBox";
            UnderlineCheckBox.Size = new Size(46, 29);
            UnderlineCheckBox.TabIndex = 5;
            UnderlineCheckBox.Text = "U";
            UnderlineCheckBox.UseVisualStyleBackColor = true;
            UnderlineCheckBox.CheckedChanged += UpdateFont;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SizeLabel.Location = new Point(309, 51);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(47, 28);
            SizeLabel.TabIndex = 3;
            SizeLabel.Text = "Size";
            // 
            // ColoLabel
            // 
            ColoLabel.AutoSize = true;
            ColoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ColoLabel.Location = new Point(300, 95);
            ColoLabel.Name = "ColoLabel";
            ColoLabel.Size = new Size(60, 28);
            ColoLabel.TabIndex = 4;
            ColoLabel.Text = "Color";
            // 
            // ColorButton
            // 
            ColorButton.BackColor = Color.Black;
            ColorButton.Location = new Point(378, 100);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(33, 25);
            ColorButton.TabIndex = 5;
            ColorButton.UseVisualStyleBackColor = false;
            ColorButton.Click += ColorButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(378, 54);
            numericUpDown1.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 14, 0, 0, 0 });
            numericUpDown1.ValueChanged += UpdateFont;
            // 
            // AlignTextGroup
            // 
            AlignTextGroup.Controls.Add(RightButton);
            AlignTextGroup.Controls.Add(CenterButton);
            AlignTextGroup.Controls.Add(LeftButton);
            AlignTextGroup.Location = new Point(28, 181);
            AlignTextGroup.Name = "AlignTextGroup";
            AlignTextGroup.Size = new Size(217, 125);
            AlignTextGroup.TabIndex = 7;
            AlignTextGroup.TabStop = false;
            AlignTextGroup.Text = "Align Text";
            // 
            // RightButton
            // 
            RightButton.AutoSize = true;
            RightButton.Location = new Point(6, 86);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(65, 24);
            RightButton.TabIndex = 10;
            RightButton.Text = "Right";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.CheckedChanged += UpdateAlignment;
            // 
            // CenterButton
            // 
            CenterButton.AutoSize = true;
            CenterButton.Location = new Point(6, 56);
            CenterButton.Name = "CenterButton";
            CenterButton.Size = new Size(73, 24);
            CenterButton.TabIndex = 9;
            CenterButton.Text = "Center";
            CenterButton.UseVisualStyleBackColor = true;
            CenterButton.CheckedChanged += UpdateAlignment;
            // 
            // LeftButton
            // 
            LeftButton.AutoSize = true;
            LeftButton.Location = new Point(6, 26);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(55, 24);
            LeftButton.TabIndex = 8;
            LeftButton.Text = "Left";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.CheckedChanged += UpdateAlignment;
            // 
            // DemoTextPanel
            // 
            DemoTextPanel.BackColor = Color.White;
            DemoTextPanel.Controls.Add(DemoLabel);
            DemoTextPanel.Location = new Point(309, 207);
            DemoTextPanel.Name = "DemoTextPanel";
            DemoTextPanel.Size = new Size(250, 69);
            DemoTextPanel.TabIndex = 8;
            // 
            // DemoLabel
            // 
            DemoLabel.ForeColor = Color.Black;
            DemoLabel.Location = new Point(103, 21);
            DemoLabel.Name = "DemoLabel";
            DemoLabel.Size = new Size(45, 20);
            DemoLabel.TabIndex = 0;
            DemoLabel.Text = "Hello";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 358);
            Controls.Add(DemoTextPanel);
            Controls.Add(AlignTextGroup);
            Controls.Add(numericUpDown1);
            Controls.Add(ColorButton);
            Controls.Add(ColoLabel);
            Controls.Add(SizeLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(FontLabel);
            Controls.Add(FontBox);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            AlignTextGroup.ResumeLayout(false);
            AlignTextGroup.PerformLayout();
            DemoTextPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FontBox;
        private Label FontLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox BoldCheckBox;
        private CheckBox ItalicCheckBox;
        private CheckBox UnderlineCheckBox;
        private Label SizeLabel;
        private Label ColoLabel;
        private Button ColorButton;
        private NumericUpDown numericUpDown1;
        private GroupBox AlignTextGroup;
        private RadioButton RightButton;
        private RadioButton CenterButton;
        private RadioButton LeftButton;
        private Panel DemoTextPanel;
        private Label DemoLabel;
    }
}
