using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BT05
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private ThemSinhVien AddSVForm = new ThemSinhVien();

        private void ThemMoiMenuStrip_Click(object sender, EventArgs e)
        {
            ThemSinhVienMoi();
        }

        private void ThemSinhVienMoi()
        {
            if(AddSVForm.ShowDialog() == DialogResult.OK)
            {
                if (!IsPrimaryKeyUnique(AddSVForm.mssv))
                {
                    MessageBox.Show("MSSV đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dataGridView1.Rows.Add(dataGridView1.RowCount, AddSVForm.mssv, AddSVForm.ten, AddSVForm.khoa,  AddSVForm.dtb);
                MessageBox.Show("Thêm mới thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsPrimaryKeyUnique(string mssv)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string existingMSSV = row.Cells["MaSoSV"].Value.ToString();
                if (existingMSSV == mssv)
                {
                    return false;
                }
            }
            return true;
        }

        private void QuanLySinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                ThemSinhVienMoi();
            }
        }

        private void FilterNames(string HoTen)
        {
            HoTen = HoTen.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string fullName = row.Cells["TenSinhVien"].Value.ToString();
                string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string lastName = nameParts[nameParts.Length - 1].ToLower();
                if (lastName.StartsWith(HoTen))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            ThemSinhVienMoi();
        }

        private void ThoatMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TimKiemTextBox.Text == "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Visible = true;
                }
            }
            else
            {
                FilterNames(TimKiemTextBox.Text);
            }
        }
    }
}
