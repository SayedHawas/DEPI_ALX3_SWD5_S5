namespace Day3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*.DLL  --> namespace (Sub namespace) --> class --> method


            Console.WriteLine("Day 3 Demos Lab ....");
            #region Day2Task 
            //Start:
            //char choice;
            //do
            //{
            //    Console.Clear();
            //    Console.Write("Enter First Number : ");
            //    double firstNumber;
            //    double.TryParse(Console.ReadLine(), out firstNumber); //"12.5a"-- > 12.5a
            //    Console.Write("Enter Second Number : ");
            //    double secondNumber;
            //    double.TryParse(Console.ReadLine(), out secondNumber); //"12.5a"-- > 0
            //    Console.Write("Enter Operator + , - , * Or /");
            //    string operators = Console.ReadLine().Trim();

            //    switch (operators)
            //    {
            //        case "+":
            //            Console.WriteLine($"The result of {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"The result of {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"The result of {firstNumber} X {secondNumber} = {firstNumber * secondNumber}");
            //            break;
            //        case "/":
            //            if (secondNumber == 0)
            //            {
            //                Console.WriteLine("Division by zero is not allowed.");
            //                break;
            //                //return;
            //                //Console.WriteLine("Press Any Key To Start ....");
            //                //Console.ReadLine();
            //                //goto Start;
            //            }
            //            Console.WriteLine($"The result of {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //            break;
            //        default:
            //            Console.WriteLine($"Invalid Operator Please Enter + , - , *  Or / ");
            //            break;
            //    }
            //    //Console.WriteLine("Press Any Key To Start ....");
            //    Console.Write("Press Y | y To Repeat ....");
            //    //choice =char.Parse(Console.ReadLine());
            //    choice = Console.ReadKey().KeyChar;
            //    //Console.ReadLine();
            //} while (choice == 'y' || choice == 'Y');
            // goto Start;
            #endregion
            #region Session Part 1
            //Implementing Iteration Logic (Loops)
            //For , Do , While 
            //for (int i = 0; i < 10; i++)
            //{
            //    //Code 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    //Code 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //for (int i = 0; i <= 10; i += 2)
            //{
            //    //Code 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //for (int i = 1; i <= 10; i += 2)
            //{
            //    //Code 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //for (int i = 12; i >= 0; i--)
            //{

            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i < 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------break--------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i > 5)
            //    {
            //        break; //Jump Statment
            //    }
            //    Console.WriteLine(i);
            //}
            ////Nest For With IF 
            //Console.WriteLine("------continue---------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i < 5)
            //    {
            //        continue; //Jump Statment
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(" End Of Loop ....");

            ////Nest For Into For 
            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = i; j <= 12; j++)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i * j}");
            //    }
            //    Console.WriteLine("-----------");
            //}
            //int i = 0;
            //while (i < 10)
            //{
            //    //Console.WriteLine(i++);
            //    //i++;
            //    Console.WriteLine(++i);
            //}
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i++);
            //} while (i < 10);
            #endregion
            #region Session Part 2
            //*.DLL  --> namespace  --> class --> method
            // Collection Creating and Using Arrays
            //int x = 1;
            ////Array System.Arrey 
            ////Declare Array
            //int[] numbers = new int[3]; //[Count] = index + 1
            //numbers[0] = 200; //index  = count -1
            //numbers[1] = 90;
            //numbers[2] = 70;
            //Console.WriteLine("-------- Array befor Sort -----");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            ////numbers[4] = 100; //IndexOutOfRangeException
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine("Counter " + numbers.Length);
            ////Method Array 
            //Array.Sort(numbers); //Sort Method
            //Console.WriteLine("-------- Array befor Sort -----");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            ////Array.Reverse(numbers); //Reverse Method
            //string[] names = new string[3] { "Mariem", "Tamer", "Osama" };
            //string[] students = new string[] { "Mariem", "Tamer", "Osama", "Krime" };

            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            ////Array.IndexOf() Method
            //Array.IndexOf(students, "Tamer"); //Return Index of Tamer [1]

            //// Single Dimentional Array
            //Console.Write("Enter the Books Number :");
            //int booksCount;
            //int.TryParse(Console.ReadLine(), out booksCount);
            //string[] books = new string[booksCount];
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.Write($"Enter Book {i + 1} Name : ");
            //    books[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Press Any Key Tp Print your Library ...");
            //Console.ReadLine();
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            //2 Dimentional
            //int[,] x = new int[2, 3] { { 1, 20, 200 }, { 2, 300, 400 } };

            //for (int i = 0; i < x.GetLength(0); i++) //Rows 
            //{
            //    for (int l = 0; l < x.GetLength(1); l++) //Columns
            //    {
            //        Console.Write(x[i, l] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            ////int[][] jaggedArray = new int[2][];
            //-----------------------
            //Array List   Not Good 
            //------------------------
            //System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            //Base On object  Boxing and Unboxing
            //ArrayList arrlist = new ArrayList();
            //int[] v = new int[3] { 1, 222, 3 };
            //arrlist.Add(100); //0
            //arrlist.Add("Mariem");//1
            //arrlist.Add(12.5M);//2
            //arrlist.AddRange(v); //Add Array // 3 //Add Range //3 ,4 ,5
            //arrlist.Add(true);//4  //Be 6

            //Console.WriteLine(arrlist.Count);
            //Console.WriteLine(arrlist[4]);
            //for (int i = 0; i < arrlist.Count; i++)
            //{
            //    Console.WriteLine(arrlist[i]);
            //}
            ////arrlist.Remove(12.5M); //Remove By Value
            ////arrlist.RemoveAt(0); //Remove By Index
            ////arrlist.RemoveRange(2, 5); //Remove Range By Index
            //arrlist.Clear(); //Clear All Items
            //int Total = (int)arrlist[0] + 20; //Boxing and Unboxing


            #endregion
            //Task Array Vs List
            #region Session Part 3
            ////List<T>
            //List<int> numberslist = new List<int>();
            //numberslist.Add(100);//0
            //numberslist.Add(200);//1
            //numberslist.Add(300);//2

            //Console.WriteLine(numberslist.Count);
            //for (int i = 0; i < numberslist.Count; i++)
            //{
            //    Console.WriteLine(numberslist[i]);
            //}

            //List<string> names = new List<string>() { "sayed", "Mohamed", "Retaj", "sayed" };

            //Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Sayed");
            //students.Add(2, "Mohamed");
            //students.Add(3, "Retaj");
            //students.Add(4, "Sayed"); //Key Already Exist Exception
            //Console.WriteLine("Count of Students : " + students.Count);
            //Console.WriteLine("Key 1 : " + students[1]);
            //Console.WriteLine("Key 2 : " + students[2]);
            //Console.WriteLine("Key 3 : " + students[3]);
            //Console.WriteLine("Key 4 : " + students[4]);
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            #endregion
            #region Session Part 4 (Methods)
            //Creating and Invoking Methods
            /*
                1-What Is a Method?                             Done 
                2-Types Of Methods  (void | Return Datatype)    Done 
                3-Creating a Method                             Done
                4-Calling a Method                              Done
                5-Method With Paramenters   Optional Paramters  Done
                6-Pass Paramenters With Value & Ref & Out       Done 
                7-Using Parameter Arrays                        Done
                8-Key Words Params                              Done
                9-Overloaded Methods                            Done
             */
            //What Is a Method? Block Of Code That Can Be Reused
            //Head & MethodBody 
            //Type (Void , Return Type)

            //PrintMessage();
            //PrintMessage("Welcome");
            //Console.WriteLine(AddNumbers());
            //Console.WriteLine(AddNumbers(100, 55));

            //Console.WriteLine(Calc(100, 200, "+"));
            //Console.WriteLine(Calc(500, 2, "*"));
            //Console.WriteLine(Calc(400, 4, "/"));

            //Console.WriteLine(sum(100, 200));
            //Console.WriteLine(sum(y: 100, x: 200)); //Pass Naming 
            //Console.WriteLine(sum(500));

            //Pass Paramenters With Value & Ref & Out
            //Calling By value 
            int numebr = 5;
            Console.WriteLine("Before Add Value : " + numebr);
            Console.WriteLine(AddValue(numebr));
            Console.WriteLine("After Add Value : " + numebr);
            Console.WriteLine("------------- Ref ----------------");
            Console.WriteLine("Before Add refence : " + numebr);
            Console.WriteLine(AddRefer(ref numebr));
            Console.WriteLine("After Add refence : " + numebr);
            Console.WriteLine("-------------- Out ---------------");
            //int x;
            //int total = x + 30; //x is not initialized Error
            int OddNumber;
            Console.WriteLine(IsOdd(14, out OddNumber));
            Console.WriteLine(OddNumber);

            Console.WriteLine(IsOdd(15, out OddNumber));
            Console.WriteLine(OddNumber);
            int[] nums = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine(SumArray(nums));

            Console.WriteLine(SumArray(25, 52, 55, 99, 8, 11));
            #endregion

        }
        static bool IsOdd(int number, out int Result)
        {
            if (number % 2 != 0)
            {
                Result = number;
                return true; //Odd
            }
            Result = -1;
            return false; //Even
        }
        static int AddValue(int x) ////Pass By Value
        {
            return x += 10;
        }
        static int AddRefer(ref int x) ////Pass By reference
        {
            return x += 10;
        }

        //static void | Datatype Method Name (Parameters , Arguments)
        //Create Mothed
        static void PrintMessage() //Without Parameters
        {
            Console.WriteLine("Hello From Print Message Method ....");
        }
        //OverLoad 
        static void PrintMessage(string message) //With Parameters
        {
            Console.WriteLine(message);
        }
        static int AddNumbers()
        {
            return 10 + 20;
        }
        //OverLoad
        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        static string Calc(double firstNumber, double secondNumber, string operators)
        {
            string result = string.Empty;
            switch (operators)
            {
                case "+":
                    result = $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}";
                    break;
                case "-":
                    result = $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}";
                    break;
                case "*":
                    result = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}";
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        result = "Division by zero is not allowed.";
                        break;
                    }
                    result = $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}";
                    break;
                default:
                    result = "Invalid Operator. Please enter + , - , * or /";
                    break;
            }
            return result;
        }
        /// <summary>
        /// Sum Method
        /// </summary>
        /// <param name="x"> Number 1 Integer</param>
        /// <param name="y"> Number 2 Integer</param>
        /// <returns> Total Numebr1 + Number 2 </returns>
        static int sum(int x, int y = 200) //Optional Parameters(Default value ))
        {
            return x + y;
        }
        //sum(10,20,50)
        static int AddFun(int x, int y = 10, int z = 10) //Optional Parameters(Default value ))
        {
            return x + y + z;
        }

        static int SumArray(params int[] x)
        {
            int total = 0;
            for (int i = 0; i < x.Length; i++)
            {
                total += x[i];
            }
            return total;
        }


        //Tasks
        //Create Appliaction To Calc + , - , * , / In Method 
        //With Methods 
        //Number Odd / Even 
        //Create Method To get the Primary Number From Range  0-100
        //Task *

    }
}
