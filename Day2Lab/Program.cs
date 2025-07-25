namespace Day2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 2 Lab ");
            #region Session Day 2 Part 1
            ////What are Data Types?
            ///*
            // * byte , sbyte , short , int , long    Done 
            // * float , double , decimal             Done
            // * string                               Done
            // * char                                 Done
            // * bool                                 Done
            // * Date time                            Done
            // */
            //byte b = 255;
            //Console.WriteLine(b);

            //double d = 1 / 3D;
            //Console.WriteLine(d);
            //double dd = 1.2587d;
            //Console.WriteLine(dd);

            //float f = 1.25f;
            //Console.WriteLine(f);


            //float fl = 1 / 3f;
            //double du = 1 / 3d;
            //decimal dc = 1 / 3m;
            //Console.WriteLine(fl);
            //Console.WriteLine(du); // Default
            //Console.WriteLine(dc);

            //string str = "Hello World !!";
            //Console.WriteLine(str);
            //char a = 'a'; // Int
            //Console.WriteLine(a);
            //char A = (char)65;  //Casting
            //Console.WriteLine(A);
            //char letter = (char)75;  //Casting
            //Console.WriteLine(letter);

            //bool yesOrNo = true;
            //Console.WriteLine(yesOrNo);
            //// > , >= , < , < = , == , !=
            //// & , && , |,  || , ! 
            //yesOrNo = 1 > 10;
            //Console.WriteLine(yesOrNo);

            //yesOrNo = 1 < 10 && 10 < 12;
            //Console.WriteLine(yesOrNo);

            //yesOrNo = 1 < 10 && 10 > 12;
            //Console.WriteLine(yesOrNo);

            //yesOrNo = 1 < 10 || 10 < 12;
            //Console.WriteLine(yesOrNo);
            //yesOrNo = 1 > 10 || 10 < 12;
            //Console.WriteLine(yesOrNo);
            //yesOrNo = 1 < 10 || 10 > 12;
            //Console.WriteLine(yesOrNo);
            //yesOrNo = 1 > 10 || 10 > 12;
            //Console.WriteLine(yesOrNo);

            ////True 
            //yesOrNo = 1 < 10 || 10 > 12;
            //Console.WriteLine(yesOrNo);
            ////False
            //yesOrNo = 1 < 10 && 10 > 12 && 1 == 1 && 1 > 0;
            //Console.WriteLine(yesOrNo);
            ////DateTime 
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt);

            ////Assign Operator (=) += , -= , *= , /=
            ////Left Hand =Right Hand  
            //int x = 100;
            //Console.WriteLine(x);
            //x = x + 50;
            //Console.WriteLine(x);
            //x += 50;
            //Console.WriteLine(x);
            //x -= 20;
            //Console.WriteLine(x);//180

            //// ++ ,  --   PostFix Surfix  , Prefix 
            ////x--;
            ////x++;
            ////++x;
            //Console.WriteLine(++x); //Prefix 
            //Console.WriteLine(x);
            //Console.WriteLine(x++); //postfix
            //Console.WriteLine(x);
            ////+ Concat
            //Console.Write("Enter First Number : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number : ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2)); //Logical Error
            //Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            //Console.WriteLine(number1 + " X " + number2 + " = " + (number1 * number2));
            //Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));

            ////Format string 
            //Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
            ////Best
            //Console.WriteLine($"{number1} + {number2} = {(number1 + number2)}");
            #endregion
            //int x = 5;
            //x = "ahmed";  Error
            /*
            //Data type 
                   -- Value Type       Stack
                   -- Reference  Type   heap 
            */
            #region Session Day 2 Part 2 
            ////* object
            ////* var
            ////* Dynamic 

            //object obj = "Ahmed";
            //obj = 123;
            //obj = "Ali";
            //obj = 5;
            //int total = 10 + (int)obj; //Cast  Unboxing 
            //Console.WriteLine(total);

            //obj = "Mohamed";
            //string str = (string)obj;


            //object ob = 100;
            //int x = (int)ob; // UnBoxing

            //int num = 321311;
            //long lg = 65465465445;

            ////Implicit & Explicit 
            ////Small -->  big  Implicit
            ////Big   --> Small  Explicit
            //lg = num;
            //num = (int)lg;

            //double d = 1.254d;
            //decimal de;
            //de = (decimal)d;

            //string str2 = de.ToString();

            ////Implicit DataType Var
            //var v = 15;
            //Console.WriteLine(v);
            //var n = "Ali";
            //Console.WriteLine(n);
            ////n = 152.5;

            ////var va; //Error 
            //var xx = (string)null;
            //Console.WriteLine(xx);
            //string str3 = null;
            //Console.WriteLine(str3);
            //object obj2 = null;
            //Console.WriteLine(obj2);

            ////int number = null;  //Not Allow Null 

            ////Dynamic
            ////Runtime Error 
            //dynamic dy = "Ahmed";
            //dy = 15;
            //int i = dy + 15;
            //Console.WriteLine(i);


            //var str4 = "Hello World ...";
            //Console.WriteLine(str4.Length);

            //dynamic str5 = "Hello World ...";
            //Console.WriteLine(str5.Length);

            //dynamic int1 = 15;
            ////Console.WriteLine(int1.Length);

            #endregion
            #region Session Day 2 Part 3
            ////const:-
            //const decimal by = 4.13M;
            ////by = 2.15;

            //Console.WriteLine(int.MaxValue);


            ////Using Math Library


            //Console.WriteLine("Please Enter Number");
            //double X = double.Parse(Console.ReadLine());
            //Console.WriteLine("Cube of Number Is " + System.Math.Pow(X, 3));
            //Console.ReadLine();

            // Jump Statment

            //Start:
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.Clear();
            //    Console.Write("Enter your name :  ");
            //    string x = Console.ReadLine();
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Clear();
            //    Console.WriteLine("Welcome " + x);
            //    Console.ReadLine();
            //    Console.Clear();
            //    goto Start;


            // *)Literals Letters:-
            //-----------------------
            //Console.Write("Ahmed \n Ali ");
            //Console.WriteLine("Sayed hawas");
            //Console.WriteLine("Sayed       Hawas");
            //Console.WriteLine("Sayed\t hawas");
            //Console.WriteLine("----------------");
            //Console.WriteLine("Sayed\n hawas");
            //Console.WriteLine("Sayed \"Said\" Hawas");
            //Console.WriteLine("c:\\folder\\ahmed.doc");
            //Console.WriteLine(@"c\folder\ahmed.doc \n");
            //Console.WriteLine("\a"); // beep 
            //Console.WriteLine("\0"); // Null

            #endregion
            #region Session Day 2 Part 4
            //-Implementing Conditional Logic
            // ?: , IF , Switch

            Console.WriteLine(1 < 10 && 2 < 10 ? "True" : "False");

            //if (Logical)
            //{
            //    //Code 
            //}
            //else
            //{ 
            //    //Code 
            //}

            //Console.Write("Enter Username : ");
            //string username = Console.ReadLine();
            //Console.Write("Enter Password : ");
            //string password = Console.ReadLine();

            //if ((username == "sayed" && password == "123") || (username == "retaj" && password == "555"))
            //{
            //    if (username == "sayed")
            //    {
            //        Console.WriteLine("Hi Sayed...");
            //        Console.WriteLine("Date" + DateTime.Now);
            //    }
            //    Console.WriteLine("Welcome Admin " + username);
            //}
            //else if ((username == "ahmed" && password == "222") || (username == "tamer" && password == "777"))
            //{
            //    Console.WriteLine("Welcome  EndUser " + username);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Username Or Password ");
            //}

            //Console.WriteLine("plz enter ur grade");
            //int grade = int.Parse(Console.ReadLine());
            //if ((grade > 100) || (grade < 0))
            //{
            //    Console.WriteLine("invalid grade");
            //}
            //else
            //{
            //    if (grade >= 90)
            //    {
            //        Console.WriteLine("excellent");
            //    }
            //    else
            //    {
            //        if (grade >= 80)
            //        {
            //            Console.WriteLine("v good");
            //        }
            //        else
            //        {
            //            if (grade >= 65)
            //            {
            //                Console.WriteLine("good");
            //            }
            //            else
            //            {
            //                if (grade >= 50)
            //                {
            //                    Console.WriteLine("pass");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("fail");
            //                }
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("plz enter ur grade");
            //int grade = int.Parse(Console.ReadLine());
            //if ((grade > 100) || (grade < 0))
            //{
            //    Console.WriteLine("invalid grade");
            //}
            //else if (grade >= 90)
            //{
            //    Console.WriteLine("excellent");
            //}
            //else if (grade >= 80)
            //{
            //    Console.WriteLine("v good");
            //}
            //else if (grade >= 65)
            //{
            //    Console.WriteLine("good");
            //}
            //else if (grade >= 50)
            //{
            //    Console.WriteLine("pass");
            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}

            //int i = 300;
            //switch (i)
            //{
            //    case 100:
            //    case 150:
            //        Console.WriteLine("100");
            //        break;
            //    case 200:
            //        Console.WriteLine("200");
            //        break;
            //    case 300:
            //        Console.WriteLine("300");
            //        break;
            //    default:
            //        Console.WriteLine("No Range");
            //        break;
            //}
            //Console.WriteLine("plz enter user name");
            //string uname = Console.ReadLine();
            //switch (uname)
            //{
            //    case "ahmed":
            //    case "Ahmed":
            //        Console.WriteLine("Hello Admin");
            //        break;
            //    case "Fawzy":
            //    case "fawzy":
            //        Console.WriteLine("Hello User");
            //        break;
            //    default:
            //        Console.WriteLine("invalid user");
            //        break;
            //}

            Console.Write("Enter First Number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Operator: ");
            char OP = char.Parse(Console.ReadLine());

            switch (OP)
            {
                case '+':
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case '*':
                    Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Can Not div By Zero ..");
                        break;
                    }
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.ReadLine();

            //-Implementing Iteration Logic
            #endregion
        }


    }
}
