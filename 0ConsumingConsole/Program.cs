namespace _0ConsumingConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            using (HttpClient client = new HttpClient())
            {
                //https://localhost:7153/api/departments  Get
                client.BaseAddress = new Uri("https://localhost:7153/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respone = client.GetAsync("api/departments").Result;
                //if (respone.StatusCode == System.Net.HttpStatusCode.OK ||
                //    respone.StatusCode == System.Net.HttpStatusCode.NoContent)
                //{ 
                //}
                if (respone.IsSuccessStatusCode)
                {
                    List<DepartmentData> result = await respone.Content.ReadAsAsync<List<DepartmentData>>();
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("----------- End Read  -------------");
                }
                else
                {
                    Console.WriteLine("EndPoint Not Running .....");
                }

                Console.Write("Enter the Id : ");
                int id;
                int.TryParse(Console.ReadLine(), out id);
                if (id > 0)
                {
                    HttpResponseMessage responeById = client.GetAsync($"api/departments/{id}").Result;
                    if (responeById.IsSuccessStatusCode)
                    {
                        DepartmentData result = await responeById.Content.ReadAsAsync<DepartmentData>();
                        Console.WriteLine(result.ToString());
                        Console.WriteLine("----------- End Read  -------------");
                    }
                    else if (responeById.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Console.WriteLine($"Department With Id {id} Not Found ....");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Id ....");
                }


            }

            Console.ReadLine();

        }

        public class DepartmentData
        {
            public int departmentId { get; set; }
            public string name { get; set; }
            public string description { get; set; }

            public override string ToString()
            {
                return $"Id : {departmentId} Name : {name}  Description : {description}";
            }
        }
    }
}
