using Day10CodeFirstLab.Models;

namespace Day10CodeFirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------- CRUD Using EF Core Code First ------------");
            #region Session Part 1
            //1) Create New Project 
            //2) Install Packages  EntityFrameWork.Core , ...SqlServe , ...Tools
            //3) Create Folder Models
            //4) Create Class Entity (Table Employees)
            //      Table Structure Row Collection Table 
            //5) Create Class Inherit Form DbContext  (Microsoft.Entityframework.core)
            //6) Add into Class <MyDbContext> Proprty DbSet<Employee> Employees ({Table Employees})
            //7) Override OnConfiguration ( Option builder --> UseSQLServer ) Pass Connection

            //8) Migration (PMC Package Manager Console) View
            //PM > get-help entityframework
            //6) add-migration <InitialCreate>
            //7) Update-Database Execute Creation Script

            Console.WriteLine(" ----------- CRUD Operation USING EF CORE ------------");
            //Linq 
            //8) Create Object From Class : DbContext

            //Full CRUD Code First Done 
            using (MyDbContext db = new MyDbContext())
            {
                //var emps = from e in db.Employees
                //           where e.Id > 0
                //           select e;

                LoadData(db);
                Console.WriteLine("----------- Create ---------- ");
                Console.Write("Enter your Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter your Job : ");
                string job = Console.ReadLine();
                Console.Write("Enter your age : ");
                int age;
                int.TryParse(Console.ReadLine(), out age);
                Console.Write("Enter your Salary : ");
                double salary;
                double.TryParse(Console.ReadLine(), out salary);

                //Create Add On Dbset 
                db.Employees.Add(new Employee { Name = name, Job = job, Salary = salary, Age = age });
                //Save Changer
                db.SaveChanges(); //DML
                Console.WriteLine("Saving New Employee ....");
                LoadData(db);

                Console.WriteLine("----------- Update ---------- ");

                Employee MyEmployee = SelectEmployee(db);

                Console.Write("Enter your New Name : ");
                string newname = Console.ReadLine();
                Console.Write("Enter your new Job : ");
                string newjob = Console.ReadLine();
                Console.Write("Enter your New age : ");
                int newage;
                int.TryParse(Console.ReadLine(), out newage);
                Console.Write("Enter your new Salary : ");
                double newsalary;
                double.TryParse(Console.ReadLine(), out newsalary);

                MyEmployee.Name = newname;
                MyEmployee.Salary = newsalary;
                MyEmployee.Job = newjob;
                MyEmployee.Age = newage;
                //Save Changer
                db.SaveChanges(); //DML
                Console.WriteLine("Updating New Employee ....");
                LoadData(db);


                Console.WriteLine("----------- Delete ---------- ");

                Employee DeleteEmployee = SelectEmployee(db);

                db.Employees.Remove(DeleteEmployee);
                db.SaveChanges();
                Console.WriteLine("Deleted Done ....");
                LoadData(db);

            }


            #endregion
            Console.ReadLine();
        }

        private static Employee SelectEmployee(MyDbContext db)
        {
            Console.Write("Enter your ID : ");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            //First , FirstOrDefault  , Last , LastOrDefault , Single , SingleOrDefault
            //Tracking
            Employee SelectEmployee = db.Employees.SingleOrDefault(e => e.Id == id);
            if (SelectEmployee == null)
            {
                Console.WriteLine("Id Not Found");
                return null;
            }
            return SelectEmployee;
        }

        private static void LoadData(MyDbContext db)
        {
            int Rows = db.Employees.Count();
            Console.WriteLine($"Rows in Employees : {Rows}");
            Console.WriteLine("-----------------------------------------------");
            //Lambda Expression 
            var employees = db.Employees.Where(e => e.Id > 0);
            Console.WriteLine("----------------- Read All Employees -------------");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        //public static void LoadData(MyDbContext db)
        //{
        //    int Rows = db.Employees.Count();
        //    Console.WriteLine($"Rows in Employees : {Rows}");
        //    Console.WriteLine("-----------------------------------------------");
        //    //Lambda Expression 
        //    var employees = db.Employees.Where(e => e.Id > 0);
        //    Console.WriteLine("----------------- Read All Employees -------------");
        //    foreach (var employee in employees)
        //    {
        //        Console.WriteLine(employee.ToString());
        //    }
        //}
    }
}
