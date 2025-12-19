using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT06
{
    public partial class Form1 : Form
    {
        private void InitializeFontFamilies()
        {
            InstalledFontCollection fontFamily = new InstalledFontCollection();
            foreach (FontFamily font in fontFamily.Families)
            {
                listBox1.Items.Add(font.Name);
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeFontFamilies();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            string fontName = listBox1.Items[e.Index].ToString()!;
            e.DrawBackground();
            using (Font f = new Font(fontName, 14))
                e.Graphics.DrawString(fontName, f, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }
    }
}
