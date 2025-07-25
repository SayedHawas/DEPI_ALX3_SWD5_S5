namespace Day4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Day 4  Lab ----------");
            #region Session Part 1 
            //Task *
            //int number = 12;
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            #endregion
            #region Session Part 2
            // Exception Handling                              Done 
            //1 - Try... Catch                                 Done 
            //2 - Try... Catch... Finally                      Done 
            //3 - Raising(Throwing) Exceptions                 Done 
            //Catch with Exception Like Default Switch  
            //Exception Error Runtime (Logical , Runtime error {Bug})
            //do
            //{
            //    Console.Clear();
            //    try
            //    {
            //        //object obj = null;

            //        Console.Write("Enter Number 1 : ");
            //        int n1 = int.Parse(Console.ReadLine());
            //        //int n1 = (int)obj;
            //        Console.Write("Enter Number 2 : ");
            //        int n2 = int.Parse(Console.ReadLine());

            //        int result = n1 / n2;
            //        Console.WriteLine(result);
            //        //Console.ReadLine();
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Must Enter Number Only .....");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine($"Please Enter Number Between {int.MinValue} And {int.MaxValue}");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Can Not Div By Zero ...");
            //    }
            //    catch (NullReferenceException)
            //    {
            //        Console.WriteLine("Can Not Use Null Value ...");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.StackTrace);
            //        //Console.WriteLine(ex.InnerException);
            //        //Console.WriteLine(ex.HelpLink);
            //        Console.WriteLine("Please Call Support 012315651 ....");

            //    }
            //    finally
            //    {
            //        //Connection | Streaming 
            //        Console.WriteLine("Finish Application ....");
            //    }
            //    Console.ReadLine();
            //} while (true);
            //try
            //{
            //    Console.WriteLine(div(100, 0));
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Still Complete ");
            //Console.ReadLine();
            #endregion
            #region Session Part 3 OOP
            /*
                1-Object Class
                2-Inheritance
                3-Polymorphism 
                4-Encapsulation
                5-Abstraction
             */

            //// Create Class 
            //// Create Object 
            //Human ahmed = new Human();
            //ahmed._name = "Ahmed Ali ";
            //ahmed._id = 10;
            //Console.WriteLine(ahmed.SayHello());
            //Console.WriteLine(ahmed.SayName());
            //Console.WriteLine("-----------------------");
            //Human sayed = new Human();
            //ahmed._name = "sayed hawas ";
            //ahmed._id = 15;
            //Console.WriteLine(ahmed.SayHello());
            //Console.WriteLine(ahmed.SayName());


            //Employee tamer = new Employee();  //Create Any Class : Object Class  
            ////tamer.setId(100);
            ////Console.WriteLine(tamer.Id());
            ////tamer.Id = 150;
            ////Console.WriteLine(tamer.Id);

            ////Pass Property 
            ////tamer.ApplicationName = "Toto";
            //Console.WriteLine(tamer.ApplicationName);
            //tamer.Id = 1;
            //tamer.Name = "Tammer Ali ";
            //tamer.Salary = 15000;
            //tamer.Job = "Full stack Developer";
            //tamer.Address = "Alex";
            //Console.WriteLine(tamer.GetInfo());
            //tamer.Attend = "@ 25-7-2025  7:40pm";
            //// Console.WriteLine(tamer.Attend);

            //tamer.City = "Tanta";
            //tamer.Age = 25;

            Console.ReadLine();

            //List<Employee> employees = new List<Employee>();


            Employee Mariem = new Employee();
            Mariem.Name = "Mareim";
            Console.WriteLine(Mariem.GetInfo());
            #endregion



            //String str = new string("youssef "); //Class 
            //Console.WriteLine(str);

            //string str2 = "Ahmed ali ";

            //Int32 i = new Int32(); //Struct 
            //i = 10;

            //int x = 10;

            //object obj = "ahmed ";

            //Object obj2 = new Object();
            //obj2 = "Ali";

            //   OOP
            //   1-Object Class
            //2-Inheritance
            //3-Polymorphism 
            //4-Encapsulation
            //5-Abstraction

            //Class Members    
            //         Fields        (Variables )  Done 
            //         Methods                     Done
            //         Property Full               Done 
            //         Property Auto               Done 
            //         Create Object From Class    Done 
            //         Constructor    ---          Done               
            //     Method OverLoad
            //     Constructor OverLoad
            //Readonly Vs Const
            //Inheritance   OverView


        }
        /// <summary>
        /// this Method To Div to Number 
        /// </summary>
        /// <param name="n1"> Integer Number 1</param>
        /// <param name="n2">Integer Number 2</param>
        /// <returns> Div N1 / N2 </returns>
        /// <exception cref="Exception"> If N2 = 0 </exception>
        static int div(int n1, int n2)
        {
            //Raising Exception 
            if (n2 == 0)
            {
                throw new Exception("Sayed Say Can Not Div By Zero");
            }
            return n1 / n2;
        }
    }

    //Access Modifier 
    //Private , Internal , Public 
    public class Human
    {
        //Fields 
        public string _name;
        public int _id;
        //Method
        public string SayHello()
        {
            return "Hello ...";
        }
        public string SayName()
        {
            return $"My Name is {_name}";
        }
    }
}
