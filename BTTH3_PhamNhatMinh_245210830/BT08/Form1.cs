using System.Resources;

namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvTaiKhoan.View = View.Details;
        }

        int TongTien = 0;

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            string SoTK = txtSoTK.Text.Trim();
            string TenKH = txtTenKH.Text.Trim();
            string DiaChi = txtDiaChi.Text.Trim();
            string SoTien = txtSoTien.Text.Trim();

            if (string.IsNullOrEmpty(SoTK) || string.IsNullOrEmpty(TenKH) ||
                string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(SoTien))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool tonTai = false;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == SoTK)
                {
                    item.SubItems[2].Text = TenKH;
                    item.SubItems[3].Text = DiaChi;
                    item.SubItems[4].Text = SoTien;
                    tonTai = true;
                    TinhTongTien();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                    break;
                }
            }

            if (!tonTai)
            {
                ListViewItem newItem = new ListViewItem((lvTaiKhoan.Items.Count + 1).ToString());
                newItem.SubItems.Add(SoTK);
                newItem.SubItems.Add(TenKH);
                newItem.SubItems.Add(DiaChi);
                newItem.SubItems.Add(SoTien);
                lvTaiKhoan.Items.Add(newItem);
                TinhTongTien();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTK.Text.Trim();
            if (string.IsNullOrEmpty(soTK))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool TimThay = false;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    TimThay = true;
                    DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        TinhTongTien();
                        lvTaiKhoan.Items.Remove(item);
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
                    }
                    break;
                }
            }

            if (!TimThay)
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                txtSoTK.Text = item.SubItems[1].Text;
                txtTenKH.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TinhTongTien()
        {
            TongTien = 0;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                TongTien += int.Parse(item.SubItems[4].Text);
            }
            TongTienlabel.Text = $"Tổng Tiền : {TongTien}";
        }

    }
}
