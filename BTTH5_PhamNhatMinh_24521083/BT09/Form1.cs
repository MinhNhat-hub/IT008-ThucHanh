namespace BT09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        Pen pen = new Pen(Color.Red, 2);
        Brush brush = new SolidBrush(Color.Red);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            else if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                e.Graphics.DrawEllipse(pen, 100, 100, 100, 100);
            }
            else if (comboBox1.SelectedItem.ToString() == "Square")
            {
                e.Graphics.DrawRectangle(pen, 100, 100, 100, 100);
            }
            else if (comboBox1.SelectedItem.ToString() == "Ellipse")
            {
                e.Graphics.DrawEllipse(pen, 100, 100, 100, 200);
            }
            else if (comboBox1.SelectedItem.ToString() == "Pie")
            {
                e.Graphics.DrawPie(pen, 100, 100, 100, 100, 0, 90);
            }
            else if (comboBox1.SelectedItem.ToString() == "Filled Circle")
            {
                e.Graphics.FillEllipse(brush, 100, 100, 100, 100);
            }
            else if (comboBox1.SelectedItem.ToString() == "Filled Square")
            {
                e.Graphics.FillRectangle(brush, 100, 100, 100, 100);
            }
            else if (comboBox1.SelectedItem.ToString() == "Filled Ellipse")
            {
                e.Graphics.FillEllipse(brush, 100, 100, 100, 200);
            }
            else if (comboBox1.SelectedItem.ToString() == "Filled Pie")
            {
                e.Graphics.FillPie(brush, 100, 100, 100, 100, 0, 90);
            }
        }
    }
}
