namespace BT06
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private double memoryValue = 0;
        private string currentOperator = "";
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            foreach (Control c in flowLayoutPanel3.Controls)
            {
                if (c is Button btn)
                {
                    if (char.IsDigit(btn.Text, 0))
                        btn.Click += NumberButton_Click;
                }
            }

            PlusButton.Click += Operator_Click;
            MinusButton.Click += Operator_Click;
            MultiplicationButton.Click += Operator_Click;
            DivisionButton.Click += Operator_Click;

            EqualButton.Click += EqualButton_Click;
            DotButton.Click += DotButton_Click;
            PlusOrMinusButton.Click += PlusOrMinusButton_Click;
            BackspaceButton.Click += BackspaceButton_Click;
            CEButton.Click += CEButton_Click;
            CButton.Click += CButton_Click;
            SQRTButton.Click += SQRTButton_Click;
            PercentButton.Click += PercentButton_Click;
            FractionButton.Click += FractionButton_Click;

            MCButton.Click += (s, e) => { memoryValue = 0; };
            MRButton.Click += (s, e) => { textBoxResult.Text = memoryValue.ToString(); isNewEntry = true; };
            MSButton.Click += (s, e) => { memoryValue = double.Parse(textBoxResult.Text); };
            MPlusButton.Click += (s, e) => { memoryValue += double.Parse(textBoxResult.Text); };
        }

        private void NumberButton_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender!;
            if (isNewEntry)
            {
                textBoxResult.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                if (textBoxResult.Text == "0")
                    textBoxResult.Text = btn.Text;
                else
                    textBoxResult.Text += btn.Text;
            }
        }

        private void DotButton_Click(object? sender, EventArgs e)
        {
            if (isNewEntry)
            {
                textBoxResult.Text = "0.";
                isNewEntry = false;
            }
            else if (!textBoxResult.Text.Contains("."))
            {
                textBoxResult.Text += ".";
            }
        }

        private void Operator_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender!;
            double value = double.Parse(textBoxResult.Text);

            if (!string.IsNullOrEmpty(currentOperator))
                Calculate(value);

            currentValue = double.Parse(textBoxResult.Text);
            currentOperator = btn.Text;

            PhepTinh.Text = currentValue.ToString() + currentOperator.ToString();
            textBoxResult.Text = "0";

            isNewEntry = true;
        }

        private void EqualButton_Click(object? sender, EventArgs e)
        {
            double value = double.Parse(textBoxResult.Text);
            Calculate(value);
            PhepTinh.Text = "";
            currentOperator = "";
        }

        private void Calculate(double newValue)
        {
            switch (currentOperator)
            {
                case "+": currentValue += newValue; break;
                case "-": currentValue -= newValue; break;
                case "*": currentValue *= newValue; break;
                case "/":
                    if (newValue == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }
                    currentValue /= newValue;
                    break;
                default:
                    currentValue = newValue;
                    break;
            }

            textBoxResult.Text = currentValue.ToString();
            isNewEntry = true;
        }

        private void PlusOrMinusButton_Click(object? sender, EventArgs e)
        {
            if (double.TryParse(textBoxResult.Text, out double val))
                textBoxResult.Text = (-val).ToString();
        }

        private void BackspaceButton_Click(object? sender, EventArgs e)
        {
            if (!isNewEntry && textBoxResult.Text.Length > 0)
            {
                textBoxResult.Text = textBoxResult.Text[..^1];
                if (textBoxResult.Text == "") textBoxResult.Text = "0";
            }
        }

        private void CEButton_Click(object? sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            isNewEntry = true;
        }

        private void CButton_Click(object? sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            currentValue = 0;
            currentOperator = "";
            isNewEntry = true;
        }

        private void SQRTButton_Click(object? sender, EventArgs e)
        {
            double val = double.Parse(textBoxResult.Text);
            if (val < 0)
            {
                MessageBox.Show("Không thể căn bậc hai số âm!");
                return;
            }
            textBoxResult.Text = Math.Sqrt(val).ToString();
            isNewEntry = true;
        }

        private void PercentButton_Click(object? sender, EventArgs e)
        {
            double val = double.Parse(textBoxResult.Text);
            textBoxResult.Text = (val / 100).ToString();
            isNewEntry = true;
        }

        private void FractionButton_Click(object? sender, EventArgs e)
        {
            double val = double.Parse(textBoxResult.Text);
            if (val == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }
            textBoxResult.Text = (1 / val).ToString();
            isNewEntry = true;
        }
    }
}