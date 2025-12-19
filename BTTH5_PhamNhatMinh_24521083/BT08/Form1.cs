namespace BT08
{
    public partial class Form1 : Form
    {
        Bitmap hour, minute, second;
        float hourAngle, minuteAngle, secondAngle;
        int radius;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            string picturePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Picture"));
            hour = new Bitmap(Path.Combine(picturePath, "hour.png"));
            minute = new Bitmap(Path.Combine(picturePath, "minute.png"));
            second = new Bitmap(Path.Combine(picturePath, "second.png"));

        }
        void DrawTicks(Graphics g, int cx, int cy, int radius)
        {
            for (int i = 0; i < 60; i++)
            {
                float angle = i * 6 - 90;
                double rad = angle * Math.PI / 180;

                int x = cx + (int)(radius * Math.Cos(rad));
                int y = cy + (int)(radius * Math.Sin(rad));

                int dotSize = (i % 5 == 0) ? 20 : 8;

                Brush brush = Brushes.White;

                g.FillEllipse(brush, x - dotSize / 2, y - dotSize / 2, dotSize, dotSize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            secondAngle = dt.Second * 6f;
            minuteAngle = dt.Minute * 6f + dt.Second * 0.1f;
            hourAngle = (dt.Hour % 12) * 30f + dt.Minute * 0.5f;
            radius = Math.Min(this.ClientSize.Width / 2, this.ClientSize.Height / 2) - 20;
        }

        private void DrawHand(Graphics g, Image img, float cx, float cy, float px, float py, float angle, float scale)
        {
            g.TranslateTransform(cx, cy);
            g.RotateTransform(angle);
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(-px, -py);
            g.DrawImage(img, 0, 0);
            g.ResetTransform();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            secondAngle = dt.Second * 6f;
            minuteAngle = dt.Minute * 6f + dt.Second * 0.1f;
            hourAngle = (dt.Hour % 12) * 30f + dt.Minute * 0.5f;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            DrawTicks(g, cx, cy, radius);
            DrawHand(g, hour, cx, cy, 13, 148, hourAngle, radius * 0.8f / hour.Height);
            DrawHand(g, minute, cx, cy, 12, 256, minuteAngle, radius * 1f / minute.Height);
            DrawHand(g, second, cx, cy, 6, 212, secondAngle, radius * 1.25f / minute.Height);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            radius = Math.Min(this.ClientSize.Width / 2, this.ClientSize.Height / 2) - 20;
            this.Invalidate();
        }
    }
}
