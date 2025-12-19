using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartData();
        }

        #region SettingData
        private void StartData()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily font in fonts.Families)
            {
                FontBox.Items.Add(font.Name);
            }
            FontBox.SelectedIndex = 0;

            DemoLabel.Text = "Hello";
            DemoLabel.Dock = DockStyle.Fill;
            DemoLabel.TextAlign = ContentAlignment.MiddleLeft;
            DemoLabel.Font = new Font(FontBox.Text, (float)numericUpDown1.Value);
            DemoLabel.ForeColor = Color.Black;

            LeftButton.Checked = true;
        }

        #endregion

        private void UpdateFont(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (BoldCheckBox.Checked)
                style |= FontStyle.Bold;
            if (ItalicCheckBox.Checked)
                style |= FontStyle.Italic;
            if (UnderlineCheckBox.Checked)
                style |= FontStyle.Underline;

            DemoLabel.Font = new Font(
                FontBox.Text,
                (float)numericUpDown1.Value,
                style
            );
        }

        private void UpdateAlignment(object sender, EventArgs e)
        {
            if (LeftButton.Checked)
                DemoLabel.TextAlign = ContentAlignment.MiddleLeft;
            else if (CenterButton.Checked)
                DemoLabel.TextAlign = ContentAlignment.MiddleCenter;
            else if (RightButton.Checked)
                DemoLabel.TextAlign = ContentAlignment.MiddleRight;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                DemoLabel.ForeColor = colorDialog.Color;
                ColorButton.BackColor = colorDialog.Color;
            }
        }
    }
}
