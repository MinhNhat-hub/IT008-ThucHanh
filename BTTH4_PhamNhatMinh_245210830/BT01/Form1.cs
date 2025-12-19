namespace BT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tọa độ chuột tại vị trí click: X = " + e.X.ToString() + " ,Y = " + e.Y.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyvalue = e.KeyChar;
            MessageBox.Show("Phím đã được nhấn : " + e.KeyChar.ToString() + " Mã ASCII : " + keyvalue.ToString());
        }
    }
}
