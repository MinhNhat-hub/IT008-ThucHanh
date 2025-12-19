using System.Drawing.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AddFontAndSize();
        }

        private string CurrentFilePath = "";

        private void AddFontAndSize()
        {
            InstalledFontCollection Fonts = new InstalledFontCollection();

            foreach (FontFamily font in Fonts.Families)
            {
                FontBox.Items.Add(font.Name);
                FontBox.AutoCompleteCustomSource.Add(font.Name);
            }
            FontBox.SelectedItem = "Tahoma";

            this.KeyPreview = true;

        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Dữ liệu sẽ mất nếu như bạn chưa lưu dữ liệu, bạn có chắc chắn không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LuuNoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt|Rich Text Files|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
                    TextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                else
                    File.WriteAllText(sfd.FileName, TextBox.Text);
            }
        }

        private void MoTapTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|Rich Text Files|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).ToLower() == ".rtf")
                    TextBox.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                else
                    TextBox.Text = File.ReadAllText(ofd.FileName);
                CurrentFilePath = ofd.FileName;
            }
        }

        private void TaoVanBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }

        private void TaoVanBanMoi()
        {
            TextBox.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
            TextBox.Text = string.Empty;
        }

        private void DinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog CurrentFont = new FontDialog();
            if (CurrentFont.ShowDialog() == DialogResult.OK)
            {
                TextBox.Font = CurrentFont.Font;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TextBox.Text = string.Empty;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                TaoVanBanMoi();
                e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                LuuText();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LuuText();
        }

        private void LuuText()
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files|*.rtf|Rich Text Files|*.txt";
                sfd.Title = "Save As";
                sfd.FileName = "Untitled";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CurrentFilePath = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                if (Path.GetExtension(CurrentFilePath).ToLower() == ".rtf")
                    TextBox.SaveFile(CurrentFilePath, RichTextBoxStreamType.RichText);
                else
                    File.WriteAllText(CurrentFilePath, TextBox.Text);
                MessageBox.Show("Lưu thành công!", "Lưu dữ liệu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (TextBox.SelectionFont == null) return;

            Font CurrentFont = TextBox.SelectionFont;
            FontStyle NewFontStyle;

            NewFontStyle = CurrentFont.Style ^ style;

            TextBox.SelectionFont = new Font(CurrentFont.FontFamily, CurrentFont.Size, NewFontStyle);
        }

        private void FontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBox.SelectionFont == null) return;
            if (FontBox.SelectedItem == null) return;
            Font CurrentFont = TextBox.SelectionFont;
            TextBox.SelectionFont = new Font(FontBox.SelectedItem.ToString()!, CurrentFont.Size, CurrentFont.Style);
        }

        private void FontBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.SelectionFont == null) return;
        }

        private void FontBox_Leave(object sender, EventArgs e)
        {
            string FontName = FontBox.Text.Trim();

            bool FontExists = FontFamily.Families.Any(f => f.Name.Equals(FontName, StringComparison.OrdinalIgnoreCase));

            if (FontExists)
            {
                if (TextBox.SelectionFont != null)
                {
                    Font CurrentFont = TextBox.Font;
                    TextBox.SelectionFont = new Font(FontName, CurrentFont.Size, CurrentFont.Style);
                }
            }
            else
            {
                FontBox.Text = "Tahoma";
            }
        }

        private void FontSizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FontSizeBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(FontSizeBox.Text, out int value))
            {
                if (value <= 0)
                {
                    FontSizeBox.Text = "14";
                    FontSizeBox.Focus();
                }
                else
                {
                    Font CurrentFont = TextBox.Font;
                    TextBox.SelectionFont = new Font(CurrentFont.Name, value, CurrentFont.Style);
                }
            }
            else
            {
                FontSizeBox.Text = "14";
            }
        }
    }
}
