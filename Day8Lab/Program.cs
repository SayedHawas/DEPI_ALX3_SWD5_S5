namespace Day8Lab
{
    internal class Program
    {
        public delegate void SayHelloHandler(string x);
        static void Main(string[] args)
        {
            Console.WriteLine("   ---------Day 8 Demos -------");

            #region Session Part 1
            ////Object Collection 
            int[] Numbers = new int[] { 12, 22, 55, 99, 78, 77, 22, 66, 5 };
            //string[] Names = new string[] { "Ali", "ahmed" };

            //var name = from nn in Names
            //           where nn.StartsWith('a')
            //           select nn;

            //Console.WriteLine("--------- SQl Expression  -----------");
            ////SQl Expression 
            //var N = from n in Numbers
            //        where n % 2 == 0
            //        select n;
            //foreach (var item in N)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("--------- Lambda Expression  -----------");
            //Lambda Expression
            var b = Numbers.Where(e => e % 2 == 1);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            ////LINQ Principles:-
            ////------------------
            ////1)Implicit type(Var)
            //var v = (string)null;
            ////int x = null;

            ////2)Object Initializer.
            //Employee emp = new Employee() { id = 1, Name = "Ahmed", Salary = 20000 };
            //Employee emp1 = new Employee { id = 1, Name = "Ahmed", Salary = 20000 };


            ////3)Anonymous Object
            //new Employee();


            ////4)Collection Initializer.
            //List<Employee> ListEmployee = new List<Employee>()
            //{
            // new Employee { id= 1 , Name = "Ahmed" , Salary = 5000},
            // new Employee { id= 2 , Name = "ali" , Salary = 7000},
            // new Employee { id= 3 , Name = "Mohamed" , Salary = 15000}
            //};

            ////5)Dynamic Name.
            //string str = "Ahmed";
            //Console.WriteLine(str.Length);
            //int x = 10;
            ////Console.WriteLine(x.Length);

            //dynamic d = 10;
            ////Console.WriteLine(d.Length);

            //dynamic myObject = new System.Dynamic.ExpandoObject();
            //myObject.DynamicPropertyName = "Some Value"; // Adding a property with a dynamic name
            //Console.WriteLine(myObject.DynamicPropertyName);

            ////6)Generic type.





            ////7)Anonymous Types.
            //var g = new { id = 1, Name = "sayed", Age = 40 };
            ////g.id = 5;

            //var h = from m in ListEmployee
            //        where m.id >= 2
            //        select m;

            //var h1 = from m in ListEmployee
            //         where m.id >= 2
            //         select new { m.Name, m.id };

            ////var a = ListEmployee.where

            ////8)Generic type.


            ////9)Extension Methods.


            ////10)Delegate.
            ////Delegates are used as pointers to methods that handle events
            ///*
            // - Delegates is A Function Pointer
            // - Delegate  is a type safe Function
            // - Delegate  is Reference type (Heap) 
            // - the Signature of Delegate Must Match the Signature Of Function Pointed it. 
            //*/

            ////* To Link Action ----> Delegate----->Event
            ////* To Do Event  ----call----->Delegate------ - Point To------ > Action

            //SayHelloHandler sh = new SayHelloHandler(SayHello);
            //sh("Ahmed From Delegate");


            ////11)Build -in Delegate.


            //Func<int, int, int> add = delegate (int x, int y) { return x + y; };
            //Console.WriteLine( add(10, 20));

            //Action<int,int> sum = delegate (int x, int y) {Console.WriteLine(x + y);};
            //sum(100, 200);

            //Predicate<int> Check = delegate (int x) { return x % 2 == 0; };


            ////12)Anonymous Delegate.
            ////13)Anonymous Method. 
            ////14)Linq Lambda Express
            //Func<int, int, int> add2 =  ( x,  y) => x + y;
            //Action<int, int> sum2 = ( x,  y) => Console.WriteLine(x + y);
            //Predicate<int> Check2 =  x=> x % 2 == 0;







            ////9)Linq To Object(Linq Query).
            ////10)Anonymous Delegate.
            ////11)Anonymous Method. 
            ////12)Linq Lambda Expression.


            #endregion

            //using (Employee e = new Employee())
            //{

            //}

            #region Session Part 2

            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee { ID = 1, Name = "Retaj", Job = "Developer", Salary = 5000, Attend = true });
            ListEmployees.Add(new Employee { ID = 2, Name = "Mariam", Job = "Dr", Salary = 6000, Attend = true });
            ListEmployees.Add(new Employee { ID = 3, Name = "sayed", Job = "Developer", Salary = 3000, Attend = false });
            ListEmployees.Add(new Employee { ID = 4, Name = "osama", Job = "eng", Salary = 7000, Attend = true });
            #endregion

            //Employee.CheckHandler check = new Employee.CheckHandler(CheckMethod);

            Employee.Report(ListEmployees, e => e.Attend == true);

            Console.ReadLine();

        }

        //public static bool CheckMethod(Employee employee)
        //{
        //    return employee.Job == "Developer";//employee.ID > 2;
        //}
        public static void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void SayHello(string str)
        {
            Console.WriteLine("Welcome " + str);
        }

    }
    public class Employee
    {
        public delegate bool CheckHandler(Employee emp);
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public bool Attend { get; set; }

        public static void Report(List<Employee> employeeList, CheckHandler checkHandler)
        {
            foreach (Employee emp in employeeList)
            {
                //Hard code
                //if (emp.Salary > 4000)
                if (checkHandler(emp))
                {
                    Console.WriteLine($"the Id {emp.ID} name {emp.Name} salary {emp.Salary} job {emp.Job}");
                }

            }
        }
    }
    ////Any Type can be Data type
    //public class Employee : IDisposable
    //{



    //    public Employee()
    //    {

    //    }
    //    public Employee(int id, string name, double salary)
    //    {
    //        this.id = id;
    //        Name = name;
    //        Salary = salary;
    //    }

    //    public int id { get; set; }
    //    public string Name { get; set; }
    //    public double Salary { get; set; }


    //    ~Employee()
    //    {

    //    }

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
