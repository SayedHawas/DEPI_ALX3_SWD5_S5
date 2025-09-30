namespace EventDemoDay20Lab
{
    public partial class Form1 : Form
    {
        //Delegate 
        public delegate void HandlerDate(DateTime MyBirthDate);
        //Event 
        public event HandlerDate GetAge;
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //label1.Text = dateTimePicker1.Value.ToString();
            GetAge(dateTimePicker1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
