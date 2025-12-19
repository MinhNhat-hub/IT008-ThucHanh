using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace BT10
{
    public partial class Form1 : Form
    {
        private DashStyle dashStyle = DashStyle.Solid;
        private float penWidth = 1;
        private LineJoin lineJoin = LineJoin.Miter;
        private DashCap dashCap = DashCap.Flat;
        private LineCap startCap = LineCap.Flat;
        private LineCap endCap = LineCap.Flat;

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(DashStyle)));
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.AddRange(new object[] { 1, 2, 4, 6, 8, 9, 10, 15 });
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.AddRange(Enum.GetNames(typeof(LineJoin)));
            comboBox3.SelectedIndex = 0;

            comboBox4.Items.AddRange(Enum.GetNames(typeof(DashCap)));
            comboBox4.SelectedIndex = 0;

            comboBox5.Items.AddRange(Enum.GetNames(typeof(LineCap)));
            comboBox5.SelectedIndex = 0;

            comboBox6.Items.AddRange(Enum.GetNames(typeof(LineCap)));
            comboBox6.SelectedIndex = 0;
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Red, penWidth);
            pen.DashStyle = dashStyle;
            pen.LineJoin = lineJoin;
            pen.DashCap = dashCap;
            pen.StartCap = startCap;
            pen.EndCap = endCap;

            Point p1 = new Point(10, 50);
            Point p2 = new Point(100, 200);

            Point a1 = new Point(70, 300);
            Point a2 = new Point(140, 400);
            Point a3 = new Point(160, 300);

            g.DrawLines(pen, new Point[] { p1, p2 });
            g.DrawLines(pen, new Point[] { a1, a2, a3 });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), comboBox1.Text);
            panel1.Invalidate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            penWidth = float.Parse(comboBox2.Text);
            panel1.Invalidate();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), comboBox3.Text);
            panel1.Invalidate();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dashCap = (DashCap)Enum.Parse(typeof(DashCap), comboBox4.Text);
            panel1.Invalidate();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            startCap = (LineCap)Enum.Parse(typeof(LineCap), comboBox5.Text);
            panel1.Invalidate();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            endCap = (LineCap)Enum.Parse(typeof(LineCap), comboBox6.Text);
            panel1.Invalidate();
        }
    }
}
