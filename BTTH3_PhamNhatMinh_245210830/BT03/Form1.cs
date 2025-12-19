namespace BT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            int X = rand.Next(0, 255);
            int Y = rand.Next(0,255);
            int Z = rand.Next(0,255);
            this.BackColor = Color.FromArgb(X, Y, Z);
        }
    }
}
