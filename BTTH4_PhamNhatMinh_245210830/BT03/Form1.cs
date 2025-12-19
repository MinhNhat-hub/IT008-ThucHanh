using System.Diagnostics;

namespace BT03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timelabel.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Media Files (*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MediaPlayer.URL = ofd.FileName;
                MediaPlayer.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
