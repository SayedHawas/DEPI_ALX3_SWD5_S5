namespace MyFirstWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "sayed" && txtPassword.Text.Trim() == "123")
            {
                //Form 2
                MainFrm mainFrm = new MainFrm();
                mainFrm.Show();
            }
            else
            {
                MessageBox.Show("Username Or Password Invalid ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
