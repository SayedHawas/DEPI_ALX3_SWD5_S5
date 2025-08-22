namespace Day11Day1CssDatabaseFirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Day 11
            **********************************
            C# Connection with Database EF Core Database First      Done 
            IEnumerable vs IQueryable (LINQ)                        Done

            CSS Day 1 session  1 ~ 1:30   INTRO  HTML 5 + CSS 3     Done
            Types Execution Of LINQ 
            *************************
            Deferred and Immediate Execution
            *Deferred  --- Connect Mode     (execute when Call data) Show update 
            *Immediate --- Disconnect Mode  (execute immediate) Do  not Show update
            Serializing and De serializing Data
             */

            //PM Scaffold-DbContext "Connection string" DataBase Provider 
            //1)Create Project 
            //2)Add Package NuGet
            //Revers Engineering By using scaffold 
            Console.WriteLine("-------------------- Entity FrameWorkCore Database First ---------------------");
            #region Session Part 1 EF Core  Database First 
            Console.WriteLine("----------- List Departments --------");
            using (EfcoreDatabaseFirstDbContext db = new EfcoreDatabaseFirstDbContext())
            {
                ////var departments = db.Departments.ToList();
                //Console.WriteLine("------------------- Query -------------------");
                //string strQuery = db.Departments.ToQueryString();
                //Console.WriteLine(strQuery);
                //Console.WriteLine("--------------------------------------");
                //IEnumerable<Department> departments = db.Departments.ToList();
                //foreach (Department department in departments)
                //{
                //    Console.WriteLine(department.Name);
                //}
                //Console.WriteLine("------------------- Query IN SQL -------------------");
                //string strQuery2 = db.Employees.Where(e => e.EmployeeId > 2).ToQueryString();
                //Console.WriteLine(strQuery2);
                //Console.WriteLine("--------------------------------------");
                //Console.WriteLine("----------- List Employees --------");

                //IQueryable<Employee> employees = db.Employees.Where(e => e.EmployeeId > 2);
                //foreach (Employee employee in employees)
                //{
                //    Console.WriteLine(employee.ToString());
                //}
                ////----------------------------------------
                ////CRUD Department , Employees
                ////-------------------------------------------
                ////IEnumerable vs IQueryable 

                //SQL Profile
                //Select Top(5) * from Employees Where IsDelete = false
                IEnumerable<Employee> emps = db.Employees.Where(q => q.IsDelete == false).ToList().Take(3);
                Console.WriteLine("------------ IEnumerable -------------");
                foreach (Employee emp in emps)
                {
                    Console.WriteLine(emp.ToString());
                }
                Console.WriteLine("------------ IQueryable -------------");
                IQueryable<Employee> emps2 = db.Employees.Where(q => q.IsDelete == false).Take(3);
                foreach (Employee emp in emps2)
                {
                    Console.WriteLine(emp.ToString());
                }

            }

            #endregion
            Console.ReadLine();
        }
    }
}
