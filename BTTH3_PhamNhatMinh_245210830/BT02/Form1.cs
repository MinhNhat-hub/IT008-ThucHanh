namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private Random rand = new Random();

        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            int X = rand.Next(0, this.ClientSize.Width - 100);
            int Y = rand.Next(0, this.ClientSize.Height - 30);

            Font font = new Font("Ariel", 15);
            Brush brush = Brushes.Aqua;
            e.Graphics.DrawString("Paint Event", font, brush, X, Y);
        }
    }
}
