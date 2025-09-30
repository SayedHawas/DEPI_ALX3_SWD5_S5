namespace EventWinDay20Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Event On Button 1 ....");
            button1.Click += ShowMessage;
        }



        private void ShowMessage(object sender, EventArgs e)
        {
            MessageBox.Show("From My Method ....");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove Event On Button 1 ....");
            button1.Click -= ShowMessage;
        }
    }
}
