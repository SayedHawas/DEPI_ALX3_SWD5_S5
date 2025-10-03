namespace _0ConsumingWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7153/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respone = client.GetAsync("api/departments").Result;

                if (respone.IsSuccessStatusCode)
                {
                    List<DepartmentData> result = await respone.Content.ReadAsAsync<List<DepartmentData>>();
                    dataGridView1.DataSource = result;
                }
            }

        }
    }

    public class DepartmentData
    {
        public int departmentId { get; set; }
        public string name { get; set; }
        public string description { get; set; }

    }
}
