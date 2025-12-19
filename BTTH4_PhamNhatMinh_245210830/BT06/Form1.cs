namespace BT06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region StartData
        private int totalFiles = 0;
        private int copiedFiles = 0;
        #endregion

        private void NguonButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SourceText.Text = fbd.SelectedPath;
            }
        }

        private void DichButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DestText.Text = dlg.SelectedPath;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string source = SourceText.Text;
            string dest = DestText.Text;

            if (!File.Exists(source) && !Directory.Exists(source))
            {
                MessageBox.Show("Đường dẫn nguồn không tồn tại!");
                return;
            }

            if (!Directory.Exists(dest))
            {
                MessageBox.Show("Thư mục đích không tồn tại!");
                return;
            }

            progressBar1.Value = 0;
            TapTinDuocTai.Text = "";

            totalFiles = CountFiles(source);
            copiedFiles = 0;

            CopyFolder(source, dest);

            MessageBox.Show("Sao chép thư mục hoàn tất!");
        }

        private int CountFiles(string folder)
        {
            int count = Directory.GetFiles(folder).Length;

            foreach (string dir in Directory.GetDirectories(folder))
            {
                count += CountFiles(dir);
            }
            return count;
        }

        private void CopyFolder(string source, string dest)
        {
            string folderName = Path.GetFileName(source);
            string newFolder = Path.Combine(dest, folderName);

            if (!Directory.Exists(newFolder))
                Directory.CreateDirectory(newFolder);

            foreach (string file in Directory.GetFiles(source))
            {
                string name = Path.GetFileName(file);
                string destFile = Path.Combine(newFolder, name);

                if (File.Exists(destFile))
                {
                    continue;
                }

                TapTinDuocTai.Text = "Đang sao chép: " + name;
                toolTip1.SetToolTip(TapTinDuocTai, TapTinDuocTai.Text);
                Application.DoEvents();

                File.Copy(file, destFile, false);

                copiedFiles++;
                progressBar1.Value = copiedFiles * 100 / totalFiles;
                Application.DoEvents();
            }

            foreach (string dir in Directory.GetDirectories(source))
            {
                string subFolderName = Path.GetFileName(dir);
                string newSubFolder = Path.Combine(newFolder, subFolderName);

                if (Directory.Exists(newSubFolder))
                {
                    continue;
                }

                CopyFolder(dir, newFolder);
            }
        }
    }
}
