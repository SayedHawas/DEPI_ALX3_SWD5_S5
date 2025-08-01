namespace Day5Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------- Day 5 Lab ---------");
            #region Session Part 1 
            /*
           
            OOP
                1-Object Class
	            2-Inheritance
	            3-Polymorphism 
	            4-Encapsulation
	            5-Abstraction
             Push & Pull & Clone Github Repos Done    
             Class Members 
                     Fields              Done                    
                     Methods             Done         
                     Property Full       Done        
                     Property Auto       Done        
                     Create Object From Class     Done    
            Constructor                           Done 
            OverLoad (Method , Constructor)       Done
            Method OverLoad                       Done          
            Constructor OverLoad                  Done
            Readonly Vs Const                     Done

              Const     -- Fix Over Class  ---> Class Name   -- Static   Done  
              ReadOnly  -- Fix Over Object Initil (CTOR)                 Done
            Inheritance                            Done 
            Windows Form                           Done
          //Polymorphism(OverLoad, Override + Inheritance) Done 
            
           
            Type Can be DataType                     Done 
            
            Types Enum , Struct ( Value type )        Done        
            Use type (Enum , Struct)                  Done

            */
            //Create Object From Class 
            //Console.WriteLine($"{int.MinValue}  {int.MaxValue}");
            //Console.WriteLine(Person.ApplicationName); //Const Class 

            //Person ahmed = new Person();
            //ahmed.Id = 1;
            //ahmed.Name = "Ahmed";
            //ahmed.Address = "alex";
            //Console.WriteLine(ahmed.SayInfo());
            //Console.WriteLine($" Income {ahmed.Income()}");
            //ahmed.SayHello();
            ////ahmed.InstanceName = "Ahmed Copy"; Error ReadOnly Field
            //Console.WriteLine(ahmed.InstanceName);
            //Console.WriteLine(ahmed.ConnectionDatabase);
            //ahmed.SayHello();

            ////Create Object From Class Using Non-ctor
            //Person tamer = new Person(2, "tamer", "Cairo");
            //Console.WriteLine(tamer.SayInfo());
            ////tamer.InstanceName = "Ahmed Copy";Error ReadOnly Field
            //Console.WriteLine(tamer.InstanceName);




            //// Inheritance 
            //Employee emp = new Employee();
            //emp.Job = "Developer ";
            //emp.Salary = 15000;
            //Console.WriteLine($" Income {emp.Income()}");
            //emp.EmployeeType = Employee._EmployeeType.FullTime;
            //emp.SayHello();

            //Manager manager = new Manager();
            //manager.DepartmentManagment = "Software";
            //manager.EmployeeType = Employee._EmployeeType.FullTime;
            //manager.Salary = 25000;
            //manager.Bouns = 5000;
            //Console.WriteLine($" Income {manager.Income()}");


            ////Type Can be DataType
            //List<int> list = new List<int>() { 12, 2, 3, 5, 8, 8, 7, 8 };
            //List<string> list2 = new List<string>();

            ////Person Class 
            ////Employee Class

            ////Create Object 
            //Employee employee = new Employee() { Id = 2, Name = "Toto", Address = "Alex", Salary = 15000, Job = "Developer" };
            ////employee.Name = "";
            ////employee.Id = 2;

            //List<Employee> employees = new List<Employee>();
            //employees.Add(employee);


            ////struct 
            //Point p = new Point(100, 200);
            //Console.WriteLine(p.PrintPoint());

            //Collection Array , Array List , List<T> ,Dic <int, string>
            //Collection Fix Eum 

            Console.WriteLine($"{Employee._EmployeeType.FullTime.ToString()}");
            Employee Emp1 = new Employee();
            Emp1.EmployeeType = Employee._EmployeeType.FullTime;
            Emp1.Salary = 15000;
            Console.WriteLine(Emp1.Income());

            Console.WriteLine($"{Employee._EmployeeType.PartTime.ToString()}");
            Employee Emp2 = new Employee();
            Emp2.EmployeeType = Employee._EmployeeType.PartTime;
            Emp2.Hours = 40;
            Emp2.HourRate = 1000;
            Console.WriteLine(Emp2.Income());


            Console.WriteLine($"{Employee._EmployeeType.FreeLance.ToString()}");
            Employee Emp3 = new Employee();
            Emp3.EmployeeType = Employee._EmployeeType.FreeLance;
            Emp3.ProjectPrice = 12000;
            Console.WriteLine(Emp3.Income());


            Console.ReadLine();








            #endregion
        }
    }
}
