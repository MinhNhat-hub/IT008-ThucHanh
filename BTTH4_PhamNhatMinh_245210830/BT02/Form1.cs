namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Times new roman", 14, FontStyle.Regular);
            this.DoubleBuffered = true;
            e.Graphics.DrawString(DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt"), font, Brushes.Black, 200, 173);
        }
    }
}
