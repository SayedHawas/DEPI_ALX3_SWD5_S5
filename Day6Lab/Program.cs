using MyClassLibrary;

namespace Day6Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Day 6 Demos Lab ----------");
            #region Session Part 1
            /*
            1 - Object Class                                                   Done
            2 - Inheritance                                                    Done
            3 - Polymorphism  Overload - Override                              Done
                         Method overriding  virtual ,override ,new             Done

            How to Open IL Disassembly in VS CLR C# -- MSIL --> JIT --> 0101   Done
            ---------------------------------
            SDK Framework
            Open this path C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools
            Open File ilasm.exe
            Drag and Drop (exe Or dll) File to show the IL Dasm Code For it 
            
            Recursion Method                                                   Done

            Types Of Class  (Referenace Type)                                  Done
            ***************
            Normal Class                                                       Done
            Sealed Class                                                       Done
            static Class                                                       Done
            Partial Class                                                      Done
            Abstract Class                                                     Done
            [Inner]Internal Class}                                             Done
            Is                                                                 Done
            --------------------------------------------------
             Extension Method                                                  Done
            4 - Encapsulation  DLL  (Hide Data)  Property Full Auto            Done
            5 - Access Modifiers                                               Done                    
                -----------------
                https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

	                (public ,private ,protected,internal,protected internal, private protected ,file)
	
	                public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
	                private: Only code declared in the same class or struct can access this member.
	                protected: Only code in the same class or in a derived class can access this type or member.
	                internal: Only code in the same assembly can access this type or member.
	                protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
	                private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
	                file: Only code in the same file can access the type or member.
            
            
             6 - IO Library

             5 - Abstraction
                  - Abstract Class
                  - Interface
           
            */

            //Console.WriteLine("----------- Human --------------");
            //Human h = new Human() { Id = 1, Name = "Mariem", Age = 21 };
            //Console.WriteLine(h.ToString());
            //Console.WriteLine($" Income : {h.Income()} ");


            //Console.WriteLine("----------- Employee --------------");
            //Employee E = new Employee() { Id = 1, Name = "Mariem", Age = 21, JobTitle = "Full Stack", Salary = 15000 };
            //Console.WriteLine(E.ToString());
            //Console.WriteLine($" Income : {E.Income()} ");

            //Console.WriteLine(Factorial(6));
            //Console.WriteLine(FactorialRecursion(6));

            //StaticClass.Sayhello();

            //Int32 i = new Int32();

            //Console.ReadLine();
            #endregion

            #region Session Part2
            //Extension Method
            //SOILD      O OPEN & Close   OPEN Extension  , Close Modification
            int x = 10;
            Console.WriteLine(x.Add(50));
            Console.ReadLine();


            //----------------------------

            #endregion
        }
        //6 * 5  *4 * 3 * 2 * 1 
        public static long Factorial(int Number)
        {
            long Result = Number;
            for (int i = Number - 1; i >= 1; i--)
            {
                Result *= i;
            }
            return Result;
        }
        public static long FactorialRecursion(int Number)
        {
            if (Number == 0)
            {
                return 1;
            }
            return Number * FactorialRecursion(Number - 1);
        }

    }
    public class TestObject
    {
        public TestObject()
        {
            MyClass Mc = new MyClass();
            Mc.PublicValue = 100;
            //Mc.InternalValue = 200;             X
            //Mc.InternalProtectedValue = 300;    X

        }
    }
    public class TestInhertiance : MyClass
    {
        public TestInhertiance()
        {
            PublicValue = 100;
            //InternalValue = 100;
            ProtectedValue = 100;
            InternalProtectedValue = 100;   //  X O
            //PrivateProtectedValue = 100;    //  X X
        }
    }


    public static class NewInt
    {
        //static NewInt()
        //{
        //    //this
        //}
        public static int Add(this int x, int y)
        {
            return x + y;
        }
    }
    //public class NewInt : Int32
    //{ 

    //}
    /// <summary>
    ///     Object  && Inheritance (From - To)
    /// </summary>
    // 1) Normal Class
    //Can Create Object
    //Inheritance From
    //Inheritance To
    public class NormalClass : TestInheritanceTo
    {
        //Static member
        public static int Code { get; set; }
        //Non Static (Instance)
        public int Id { get; set; }
        public string MethodTest()
        {
            this.Id = 1;
            return "test";
        }
    }

    //2) Sealed Class
    //Can Create Object
    //Can Not Inheritance From
    //Inheritance To
    public sealed class SealedClass : NormalClass
    {

    }

    //3) Static Class
    //Can Not Create Object
    //Can Not Inheritance From
    //Can Not Inheritance To
    public static class StaticClass  //: TestInheritanceTo
    {
        //member static
        //Method Non-Static 
        public static void Sayhello()
        {
            Console.WriteLine("Say Hello ...");
        }
        static StaticClass()
        {
            Console.WriteLine("From Static");
        }
        //static StaticClass(int x , int y )
        //{
        //    Console.WriteLine("From Static");
        //}

    }

    // 4) Partial Class
    //Can Create Object 
    //Inheritance From
    //Inheritance To
    public partial class PartialClass
    {
        public void Save()
        {

        }
    }

    //5) Abstract Class 0%  To 100% 
    //Can Not Create Object 
    //Can Inheritance From (Implementing)
    //Can Inheritance To
    public abstract class AbstractClass //
    {
        public abstract void CreateNew();
    }

    // 6) [Inner] Internal Class
    public class OuterClass
    {
        private string str;

        public OuterClass()
        {

        }
        public class InnerClass
        {
            private string StrInner;
            public InnerClass()
            {
                //OuterClass Oc = new OuterClass();
                //Oc.str = "Private ...";
            }
        }
    }
    //public class TestObject
    //{

    //    public TestObject()
    //    {
    //        NormalClass NC = new NormalClass();
    //        NC.Id = 1;
    //        NC.TestInherit = 10;

    //        SealedClass Sc = new SealedClass();
    //        Sc.Id = 2;

    //        //StaticClass sc2 = new StaticClass();

    //        StaticClass.Sayhello();

    //        PartialClass Pc = new PartialClass();
    //        Pc.Save();
    //        Pc.Edit();

    //        //AbstractClass Ac = new AbstractClass();

    //        OuterClass Oc = new OuterClass();
    //        OuterClass.InnerClass IC = new OuterClass.InnerClass();

    //    }

    //}
    public class TestInheritanceTo
    {
        public int TestInherit { get; set; }
    }
    public class TestInheritanceFrom : NormalClass   //:SealedClass  StaticClass //  Int32 //  Error
    {

    }
    public class testAbstractionClass : AbstractionTwo
    {
        public override void CreateNew()
        {
            Console.WriteLine("Create New ");
            //Code 
        }
        public override void update()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class AbstractionTwo : AbstractClass
    {
        public void NormalMethod()
        {
            Console.WriteLine("Normal Method ...");
        }

        public abstract void update();
    }
    public class testTwo
    {
        public virtual void add()
        {
            Console.WriteLine("Add");
        }
    }
    public class testThree : testTwo
    {
        public override void add()
        {
            base.add();
        }
    }
    public abstract class abstractest
    {
        public abstract void update();
    }
    public class testfour : abstractest
    {
        public override void update()
        {

        }
    }
}
