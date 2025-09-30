namespace EventDemoDay20Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.GetAge += Frm_GetAge;
            frm.Show();
        }

        private void Frm_GetAge(DateTime MyBirthDate)
        {
            label1.Text = (DateTime.Now.Year - MyBirthDate.Year).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteNumber(sender as Button);
        }




        private void WriteNumber(Control sender)
        {
            label2.Text += ((Button)sender).Text;
        }


    }
}
