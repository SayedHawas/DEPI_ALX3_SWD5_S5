namespace Day10Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Day 10 Labs ----------");
            // Indexers   Done 
            /* Use the this keyword to declare an indexer
               Use get and set accessors to provide access to the collection

                 In C#, indexers are special class members that allow instances of a class or struct to be indexed just like arrays []. 
                 They are defined using the this keyword, followed by one or more parameters in square brackets.
                 Indexers enable objects to be accessed using the array-like syntax.

                Here's a basic example to illustrate indexers in C#:
            */


            // Arch N-Layer  & N-tires   Done 
            // Entity Framework Core Code First 

            // Into HTML
            #region Session Part 1
            //Array fix Length 
            int[] Numbers = new int[5]; //{ 22, 55, 88, 77, 99, 2, 4, 57, 2, 550 };
            Numbers[0] = 1;
            Numbers[1] = 2;

            Console.WriteLine(Numbers[0]);

            //List Dymaic Length 
            List<int> Values = new List<int>();
            Values.Add(100);
            Values.Add(200);
            //Values[2] = 300; Error
            Values.Add(400);

            Console.WriteLine(Values[0]);
            Console.WriteLine(Values[2]);

            //List<Employee> Employees = new List<Employee>();
            //Employees.Add(new Employee() { Id = 1, Name = "Ahmed", Salary = 15000 });
            ////Employees[1] = new Employee() { Id = 2, Name = "tamer", Salary = 20000 };

            //Console.WriteLine(Employees[0].ToString());

            //for (int i = 1; i < Employees.Count; i++)
            //{
            //    Console.WriteLine(Employees[i].ToString());
            //}

            //Employee[] EmployeesList = new Employee[2];
            //EmployeesList[0] = new Employee() { Id = 1, Name = "Ahmed", Salary = 15000 };
            //EmployeesList[1] = new Employee() { Id = 2, Name = "tamer", Salary = 20000 };

            //for (int i = 0; i < EmployeesList.Length; i++)
            //{
            //    Console.WriteLine(EmployeesList[i].ToString());
            //}

            Console.WriteLine(" -------------- Indexer in C# -----------");
            SampleCollection<int> Nums = new SampleCollection<int>();
            Nums.Add(100); //0
            Nums[1] = 200;
            for (int i = 0; i < Nums.Count; i++)
            {
                Console.WriteLine(Nums[i]);
            }

            SampleCollection<Employee> Employees = new SampleCollection<Employee>();
            Employees.Add(new Employee() { Id = 1, Name = "Ahmed", Salary = 15000 });
            Employees[1] = new Employee() { Id = 2, Name = "tamer", Salary = 20000 };
            Employees[2] = new Employee() { Id = 3, Name = "Retaj", Salary = 22000 };

            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine(Employees[i].ToString());
            }
            #endregion
            Console.ReadLine();
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return $"Id : {Id} Name : {Name} Salary : {Salary}";
        }
    }

    public class SampleCollection<T>
    {
        // Declare an array to store the collection elements
        private List<T> data = new List<T>();
        // Define an indexer to allow array-like access
        public T this[int index] //0 1 2 3 ...
        {
            get
            {
                // The get accessor returns the value at the specified index
                return data[index];
            }
            set
            {
                //0 1  2
                // The set accessor assigns a value to the element at the specified index
                if (index < data.Count)
                {
                    data[index] = value;
                }
                else
                {
                    data.Add(value);
                }
            }
        }
        //Read Only Prop
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        //Method
        public void Add(T item)
        {
            data.Add(item);
        }
    }

    public class SampleNonGenericCollection
    {
        // Declare an array to store the collection elements
        private List<int> data = new List<int>();
        // Define an indexer to allow array-like access
        public int this[int index] //0 1 2 3 ...
        {
            get
            {
                // The get accessor returns the value at the specified index
                return data[index];
            }
            set
            {
                //0 1  2
                // The set accessor assigns a value to the element at the specified index
                if (index < data.Count)
                {
                    data[index] = value;
                }
                else
                {
                    data.Add(value);
                }
            }
        }
        //Read Only Prop
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        //Method
        public void Add(int item)
        {
            data.Add(item);
        }
    }
}
