using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace BT05
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }
        #region DataForAdd
        public string mssv, ten, khoa;
        public float dtb;
        #endregion


        #region Check
        private string MaSVPattern = @"^\d{8}$";
        private string DiemTBPattern = @"^(10(\.0+)?|[0-9](\.[0-9]+)?)$";
        #endregion

        private void Thembutton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(MaSVtextBox.Text, MaSVPattern) || !Regex.IsMatch(DiemTBtextBox.Text,DiemTBPattern) || KhoaComboBox.Text == "")  
            {
                MessageBox.Show("Thông tin đã nhập không hợp lệ!");
                return;
            }
            mssv = MaSVtextBox.Text;
            ten = TenSVtextBox.Text;
            khoa = KhoaComboBox.Text;
            dtb = float.Parse(DiemTBtextBox.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
