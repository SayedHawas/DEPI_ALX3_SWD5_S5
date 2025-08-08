using System.Text;

namespace IO_Demo
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }
        //DriveInfo, Directory , DirectoryInfo ,File ,FileInfo
        private void Form1_Load(object sender, EventArgs e)
        {
            var Drives = DriveInfo.GetDrives();
            foreach (var item in Drives)
            {
                if (item.IsReady == true && item.DriveType == DriveType.Fixed)
                    comboBox1.Items.Add(item.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            //string result = "";
            DriveInfo Di = new DriveInfo(comboBox1.Text);  //comboBox1.SelectedItem;
            //result = Di.Name + Environment.NewLine;
            //result += $"Total Size : {Di.TotalSize / 1024 / 1024 / 1024} GB" + Environment.NewLine;
            //result += $"Total Free Space : {Di.TotalFreeSpace / 1024 / 1024 / 1024} GB" + Environment.NewLine;
            stringBuilder.Append(Di.Name + Environment.NewLine);
            stringBuilder.Append($"Total Size : {Di.TotalSize / 1024 / 1024 / 1024} GB" + Environment.NewLine);
            stringBuilder.Append($"Total Free Space : {Di.TotalFreeSpace / 1024 / 1024 / 1024} GB" + Environment.NewLine);

            //lbl.Text = result;
            lbl.Text = stringBuilder.ToString();


            //DriveInfo dir = new DriveInfo("C:");
            //string name = dir.Name;
            //double size = dir.TotalSize;
            //double freeA = dir.AvailableFreeSpace;
            //double freeT = dir.TotalFreeSpace;
            //MessageBox.Show(name + "\n" + size + "\n" + freeA + "\n" + freeT);


            //Directory DirectoryInfo   Folder 
            //Directory      --> static Methods
            //DirectoryInfo  --> instanced Method Must Create Object

            //Directory folders = new Directory();

            //DirectoryInfo folderinfo = new DirectoryInfo(comboBox1.Text);
            //folderinfo.

            string[] Folders = Directory.GetDirectories(comboBox1.Text);
            listBox1.Items.Clear();
            foreach (string folder in Folders)
            {
                listBox1.Items.Add(folder);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(listBox1.Text);
            listBox2.Items.Clear();
            foreach (string item in files)
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = listBox2.Text;
            FileInfo fi = new FileInfo(listBox2.Text);
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(fi.Name + Environment.NewLine);
            stringBuilder.Append($"FullName : {fi.FullName + Environment.NewLine}");
            stringBuilder.Append($"Extension : {fi.Extension}" + Environment.NewLine);
            stringBuilder.Append($"Creation Date : {fi.CreationTimeUtc}" + Environment.NewLine);
            label4.Text = stringBuilder.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(comboBox1.Text + "NewFolderFromMyApp");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(comboBox1.Text + "NewFolderFromMyApp"))
            {
                Directory.Delete(comboBox1.Text + "NewFolderFromMyApp");
                MessageBox.Show("Folder is Deleted ....");
            }
            else
            {
                MessageBox.Show("Folder Not Found ....");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(@"F:\s.txt", richTextBox1.Text);
            File.WriteAllLines(@"D:\s.txt", richTextBox1.Lines);
            MessageBox.Show("Saving ");
            richTextBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\s.txt"))
            {    // File Read
                richTextBox1.Lines = File.ReadAllLines(@"D:\s.txt");
                //richTextBox1.Text = File.ReadAllText(@"F:\s.txt");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Stream s = new Stream();
            // to create file By FileStream
            //if (!File.Exists(@"D:\Sayed1.txt"))
            //    File.Create(@"D:\Sayed1.txt");

            fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // to read the File 
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();

            sr.Close();
            MessageBox.Show("Open ....");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //fs = new FileStream(@"D:\Sayed1.txt", FileMode.OpenOrCreate);
            //// to write the text 
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write(richTextBox1.Text);
            //sw.Close();
            //MessageBox.Show("Saving ....");
            //richTextBox1.Text = string.Empty;


            //Using 
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(richTextBox1.Text);
            }

            MessageBox.Show("Saving ....");
            richTextBox1.Text = string.Empty;
        }
    }
}
