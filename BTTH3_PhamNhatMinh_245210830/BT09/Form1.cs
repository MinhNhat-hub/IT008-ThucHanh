namespace BT09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Click += button4_Click!;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (NamCheckBox.Checked)
            {
                NuCheckBox.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (NuCheckBox.Checked)
            {
                NamCheckBox.Checked = false;
            }
        }

        private void LuuThongTinButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaSVTextBox.Text) || string.IsNullOrWhiteSpace(HoTenTextBox.Text) || ChuyenNganhComboBox.SelectedItem == null || (!NamCheckBox.Checked && !NuCheckBox.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string GioiTinh = NamCheckBox.Checked ? "Nam" : "Nữ";

            ListViewItem item = new ListViewItem(MaSVTextBox.Text);
            item.SubItems.Add(HoTenTextBox.Text);
            item.SubItems.Add(ChuyenNganhComboBox.SelectedItem.ToString());
            item.SubItems.Add(GioiTinh);
            item.SubItems.Add(ChuyenNganhDaChonListBox.Items.Count.ToString());

            listView1.Items.Add(item);

            MaSVTextBox.Clear();
            HoTenTextBox.Clear();
            NamCheckBox.Checked = true;
            NuCheckBox.Checked = false;
            ChuyenNganhComboBox.SelectedIndex = -1;
            foreach (var monHoc in ChuyenNganhDaChonListBox.Items)
                ChonChuyenNganhListBox.Items.Add(monHoc);
            ChuyenNganhDaChonListBox.Items.Clear();
        }

        private void XoaChonButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ChonChuyenNganhListBox.SelectedItem != null)
            {
                ChuyenNganhDaChonListBox.Items.Add(ChonChuyenNganhListBox.SelectedItem);
                ChonChuyenNganhListBox.Items.Remove(ChonChuyenNganhListBox.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ChuyenNganhDaChonListBox.SelectedItem != null)
            {
                ChonChuyenNganhListBox.Items.Add(ChuyenNganhDaChonListBox.SelectedItem);
                ChuyenNganhDaChonListBox.Items.Remove(ChuyenNganhDaChonListBox.SelectedItem);
            }
        }
    }
}
