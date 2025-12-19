namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool WrongNum = false;

        private double Number1;
        private double Number2;
        private double Result;

        private void button1_Click(object sender, EventArgs e)
        {
            ThucHienCong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThucHienTru();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThucHienNhan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThucHienChia();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsControl(ch))
                return;

            if (ch == '-')
            {
                if (textBox1.SelectionStart != 0 || textBox1.Text.Contains('-'))
                    e.Handled = true;
                return;
            }

            if (ch == '.')
            {
                if (textBox1.Text.Contains('.'))
                    e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch))
                e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (char.IsControl(ch))
                return;

            if (ch == '-')
            {
                if (textBox1.SelectionStart != 0 || textBox1.Text.Contains('-'))
                    e.Handled = true;
                return;
            }

            if (ch == '.')
            {
                if (textBox1.Text.Contains('.'))
                    e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(textBox1.Text, out value))
            {
                Number1 = value;
            }
            else
            {
                Number1 = 0;
                WrongNum = true;
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(textBox2.Text, out value))
            {
                Number2 = value;
            }
            else
            {
                Number2 = 0;
                WrongNum = true;
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ThucHienCong()
        {
            Result = Number1 + Number2;
            richTextBox1.Text = Result.ToString();
        }
        private void ThucHienTru()
        {
            Result = Number1 - Number2;
            richTextBox1.Text = Result.ToString();
        }
        private void ThucHienNhan()
        {
            Result = Number1 * Number2;
            richTextBox1.Text = Result.ToString();
        }
        private void ThucHienChia()
        {
            if (Number2 == 0)
            {
                richTextBox1.Text = "Khong the chia";
            }
            else
            {
                Result = Number1 / Number2;
                richTextBox1.Text = Result.ToString();
            }
        }
    }
}
