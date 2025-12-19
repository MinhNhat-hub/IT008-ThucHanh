namespace BT1
{
    public partial class Form1 : Form
    {
        private ListBox listBoxEvents;

        public Form1()
        {
            InitializeComponent();
            listBoxEvents = new ListBox();
            listBoxEvents.Dock = DockStyle.Fill;
            Controls.Add(listBoxEvents);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Shown");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Activated");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Deactivate");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBoxEvents.Items.Add("FormClosing");
        }
    }
}
