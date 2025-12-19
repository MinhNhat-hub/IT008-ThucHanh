namespace TestBT07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KhoiTao();
        }

        private List<Button> danhSachGhe = new List<Button>();

        private Color mauChuaBan = Color.White;
        private Color mauDangChon = Color.LightGreen;
        private Color mauDaBan = Color.Yellow;

        private int tongTien = 0;

        private void KhoiTao()
        {
            btnChon.Click += BtnChon_Click;
            btnHuy.Click += BtnHuy_Click;
            btnThoat.Click += BtnChon_Click;
            danhSachGhe = panelGhe.Controls.OfType<Button>().ToList();
            foreach (Button ghe in danhSachGhe)
            {
                ghe.BackColor = mauChuaBan;
                ghe.Click += Ghe_Click;
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button ghe = sender as Button;

            if (ghe.BackColor == mauDaBan)
            {
                MessageBox.Show($"Ghế {ghe.Text} đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ghe.BackColor == mauDangChon)
            {
                ghe.BackColor = mauChuaBan;
            }
            else if (ghe.BackColor == mauChuaBan)
            {
                ghe.BackColor = mauDangChon;
            }
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            foreach (Button ghe in danhSachGhe)
            {
                if (ghe.BackColor == mauDangChon)
                {
                    ghe.BackColor = mauDaBan;
                    int soGhe = int.Parse(ghe.Text);
                    if (soGhe <= 5)
                        tongTien += 5000;
                    else if (soGhe <= 10)
                        tongTien += 6500;
                    else
                        tongTien += 8000;
                }
            }

            textBox1.Text = tongTien.ToString();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button ghe in danhSachGhe)
            {
                if (ghe.BackColor == mauDangChon)
                {
                    ghe.BackColor = mauChuaBan;
                }
            }

            tongTien = 0;
            textBox1.Text = tongTien.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
