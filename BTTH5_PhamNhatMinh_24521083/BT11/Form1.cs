using System.Drawing;
using System.Drawing.Drawing2D;

namespace BT11
{

    enum ShapesMode
    {
        None,
        Line,
        Rectangle,
        Ellipse
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panel1.GetType()
          .GetProperty("DoubleBuffered",
              System.Reflection.BindingFlags.Instance |
              System.Reflection.BindingFlags.NonPublic)
          ?.SetValue(panel1, true, null);

            canvas = new Bitmap(panel1.Width, panel1.Height);
            gCanvas = Graphics.FromImage(canvas);
            gCanvas.Clear(Color.White);
            gCanvas.SmoothingMode = SmoothingMode.AntiAlias;
        }

        #region StartUpData
        Pen pen = new Pen(Color.Black, 2);
        Brush brush = new SolidBrush(Color.Black);
        Color colorChanged = Color.Black;

        Point startPoint;
        Point endPoint;
        bool isDrawing = false;

        ShapesMode currentMode = ShapesMode.None;

        Bitmap canvas;
        Graphics gCanvas;
        #endregion

        #region UpdatePenAndBrush
        private void UpdatePen()
        {
            if (WidthBox.Value <= 0)
            {
                WidthBox.Value = 1;
            }

            pen.Dispose();
            pen = new Pen(colorChanged, (float)WidthBox.Value);
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y)
            );
        }
        #endregion

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cdg = new ColorDialog();
            if (cdg.ShowDialog() == DialogResult.OK)
            {
                colorChanged = cdg.Color;
                UpdatePen();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.DrawImageUnscaled(canvas, Point.Empty);

            if (!isDrawing) return;

            Rectangle rect = GetRectangle(startPoint, endPoint);

            switch (currentMode)
            {
                case ShapesMode.Line:
                    e.Graphics.DrawLine(pen, startPoint, endPoint);
                    break;

                case ShapesMode.Rectangle:
                    e.Graphics.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
                    e.Graphics.FillRectangle(brush, GetRectangle(startPoint, endPoint));
                    break;

                case ShapesMode.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle(startPoint, endPoint));
                    e.Graphics.FillEllipse(brush, GetRectangle(startPoint, endPoint));
                    break;
            }
        }

        #region Shapes
        private void LineButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LineButton.Checked)
            {
                currentMode = ShapesMode.Line;
                UpdatePen();
            }
        }

        private void RectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RectangleButton.Checked)
            {
                currentMode = ShapesMode.Rectangle;
                UpdatePen();
            }
        }

        private void EllipseButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EllipseButton.Checked)
            {
                currentMode = ShapesMode.Ellipse;
                UpdatePen();
            }
        }
        #endregion


        #region Brushes
        private void SolidBrushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SolidBrushButton.Checked)
            {
                brush = new SolidBrush(Color.Green);
            }
        }

        private void HatchBrushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HatchBrushButton.Checked)
            {
                brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
        }

        private void TextureBrushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TextureBrushButton.Checked)
            {
                Bitmap bmp = new Bitmap(20, 20);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                    g.FillEllipse(new SolidBrush(colorChanged), 0, 0, 20, 20);
                }
                brush = new TextureBrush(bmp);
            }
        }

        private void LinearGradientBrushButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LinearGradientBrushButton.Checked)
            {
                brush = new LinearGradientBrush(panel1.ClientRectangle, Color.Red, Color.Green, LinearGradientMode.Vertical);
            }
        }
        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            endPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;

            Rectangle rect = GetRectangle(startPoint, endPoint);

            switch (currentMode)
            {
                case ShapesMode.Line:
                    gCanvas.DrawLine(pen, startPoint, endPoint);
                    break;

                case ShapesMode.Rectangle:
                    gCanvas.FillRectangle(brush, rect);
                    gCanvas.DrawRectangle(pen, rect);
                    break;

                case ShapesMode.Ellipse:
                    gCanvas.FillEllipse(brush, rect);
                    gCanvas.DrawEllipse(pen, rect);
                    break;
            }

            panel1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Bitmap(panel1.Width, panel1.Height);
            gCanvas = Graphics.FromImage(canvas);
            gCanvas.Clear(Color.White);

            gCanvas.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void WidthBox_ValueChanged(object sender, EventArgs e)
        {
            if(WidthBox.Value <= 0)
            {
                WidthBox.Value = 1;
            }

            UpdatePen();
        }
    }
}
