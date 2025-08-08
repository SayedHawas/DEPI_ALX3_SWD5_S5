namespace Day7Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------- Day 7 Demos ----------");
            #region Session Part 1
            /*
                - Generic type                Done 
                - IO Library                  Done
                - Abstraction                 Done
                - Abstract Class              Done
                - Interface                   Done
               
                - Abstraction { Abstract Class 0 To 100% - Interface 100% }  //Before .Net Core 8   Done
            LINQ Principles:-
            ------------------
            1)Implicit type (Var)
            2)Object Initializer.
            3)Collection Initializer.
            4)Dynamic Name.
            5)Anonymous Types.
            6)Generic type.
            7)Extension Methods.
            8)Delegate. 
            9)Linq To Object (Linq Query).
            10)Anonymous Delegate.
            11)Anonymous Method. 
            12)Linq Lambda Expression. 
            13)Bulid-in Delegate.
             
             */
            //Generic type                  Done 
            //Generic type.                 Done                              
            //Generic Method                Done
            //Generic Property              Done
            //Generic Parameter             Done

            //IntMyList Ml = new IntMyList(3);
            //Ml.Add(1000);
            //Ml.Add(2000);
            //Ml.Add(3000);

            //Console.WriteLine(Ml.GetValue(1));

            //GenericMyList<string> names = new GenericMyList<string>(3);
            //names.Add("Ahmed1");
            //names.Add("Ahmed2");
            //names.Add("Ahmed3");
            //Console.WriteLine(names.GetLength);
            //names.Name = "Welcome As string";
            //Console.WriteLine(names.Name);

            //Console.WriteLine(names.GetValue(2));

            //GenericMyList<double> Salaries = new GenericMyList<double>(3);
            //Salaries.Add(1.25);
            //Salaries.Add(1.27);
            //Salaries.Add(1.28);
            //Console.WriteLine(Salaries.GetLength);
            //Salaries.Name = 1000;
            //Console.WriteLine(Salaries.Name);

            //Console.WriteLine(Salaries.GetValue(0));


            ////Array List 
            //int[] x = new int[5];  //fix Lenght 
            //List<int> y = new List<int>();


            ////IO Library (Input , Output File , folder , streaming ...)
            ////DriveInfo, Directory , DirectoryInfo ,File ,FileInfo
            //DriveInfo[] Drives = DriveInfo.GetDrives();
            //foreach (var item in Drives)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //DriveInfo Di = new DriveInfo("C");
            //Console.WriteLine(Di.DriveFormat);
            //Console.WriteLine(Di.VolumeLabel);
            //Console.WriteLine($"TotalSize : {Di.TotalSize / 1024 / 1024 / 1024} GB ");
            //Console.WriteLine(Di.AvailableFreeSpace);

            //Console.ReadLine();
            #endregion

            #region Session Part 2 
            //LINQ Language Integrated Query
            List<string> Names = new List<string>() { "Ahmed", "Mohamed", "Ramy", "Ali", "Mariem", "Retaj", "Sayed" };

            var newlist = from n in Names
                          where n.Contains("m")
                          select n;

            foreach (var name in newlist)
            {
                Console.WriteLine(name);
            }
            //
            Console.WriteLine("----------- SQL Suger Expression -----------------");
            var newlist2 = from m in Names
                           where m.StartsWith("S")
                           select m;

            foreach (var name in newlist2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------Lambda Expression----------------");
            //Lambda Expression 
            var reult = Names.Where(x => x.Contains("A"));
            foreach (var name in reult)
            {
                Console.WriteLine(name);
            }


            //1)Implicit type (Var)

            var x = Names[0];

            //Data Source table Column    Id , Name , HireDate   
            //int , string , Datetime


            //2)Object Initializer.
            Teacher Ahmed = new Teacher { Id = 1, Name = "ahmed", Subject = "arabic" };
            //Ahmed.Id = 1;
            //Must Create Or Don't Remove Default Constructor


            //3)Anonymous Object 
            new Teacher();

            //4)Collection Initializer.
            //Type Can be Data Type

            List<Teacher> Tearches = new List<Teacher>()
            {
              new Teacher  { Id= 10 , Name="Ahmed", Subject ="Math" }, //0
              new Teacher  { Id= 20 , Name="Mohmed", Subject ="English" }, //1
              new Teacher  { Id= 30 , Name="Yasser", Subject ="Arabic" }, //2

            };

            foreach (var t in Tearches)
            {
                Console.WriteLine($"id : {t.Id} Name {t.Name} subject : {t.Subject}");
            }



            //5)Dynamic Name.

            string str = "Welcome ....";
            Console.WriteLine(str.Length);

            int i = 100;
            //Console.WriteLine(i.length);

            dynamic ii = 100;
            Console.WriteLine(ii.length);

            var xx = from v in Tearches
                     where v.Id == 10
                     select new { v.Id, v.Name };





            //6)Anonymous Types.
            var k = new { Id = 1, Name = "Sayed", Salary = 15000, Job = "Developer" };
            Console.WriteLine(k.Id);
            //k.Id = 5; Read Only 




            //Generic Interface
            //6)Generic type.
            //7)Extension Methods.
            //8)Delegate.
            //9)Linq To Object(Linq Query).
            //10)Anonymous Delegate.
            //11)Anonymous Method. 
            //12)Linq Lambda Expression.
            //13)Build -in Delegate.
            #endregion
        }
        public class IntMyList
        {
            private int[] MyList;
            private int CurrentIndex = 0;

            public IntMyList(int index)
            {
                MyList = new int[index];  //Int[] x = new int[3]
            }

            public void Add(int value)
            {
                MyList[CurrentIndex++] = value;
                //CurrentIndex++;
            }
            public int GetValue(int index)
            {
                return MyList[index];
            }
        }
        public class GenericMyList<T> // where T:class  //Generic Type
        {
            private T[] MyList;
            private int CurrentIndex = 0;
            //Property 
            public int GetLength { get { return MyList.Length; } }
            //Generic Property 
            public T Name { get; set; }
            public GenericMyList(int index)
            {
                MyList = new T[index];
            }

            public void Add(T value) //Generic Parameter
            {
                MyList[CurrentIndex++] = value;
            }
            public T GetValue(int index) //Generic Method
            {
                return MyList[index];
            }
        }
    }
    //public class Employee
    //{

    //}

    public class Teacher
    {
        public Teacher()
        {

        }
        public Teacher(int id, string name, string subject)
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }

}
