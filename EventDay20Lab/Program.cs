namespace EventDay20Lab
{
    //Delegate
    public delegate string StringHandler(string str);

    //int x; 

    internal class Program
    {


        static void Main(string[] args)
        {
            // Close
            // Closed  , Closing


            Console.WriteLine("Hello, World!");
            // Delegate pointer For Function 
            MyString ms = new MyString();
            Console.Write("Enter Your text : ");
            string Entrytext = Console.ReadLine();


            StringHandler sh = new StringHandler(ms.CaseText);

            Console.WriteLine(sh.Invoke("Ahmed Ali"));
            Console.WriteLine(sh("AHMED ALI"));
            Console.WriteLine(sh(Entrytext));


            StringHandler sh2 = ms.StringLenght;
            Console.WriteLine(sh2(Entrytext));

            //ms.CheckText += new StringHandler(ms.CaseText);
            //ms.CheckText += ms.CaseText;

            ms.CheckText += Ms_CheckText;
            Console.ReadLine();
            int x = 10;
            x += 5;
        }
        private static string Ms_CheckText(string str)
        {
            return $" {str}Welcome From Event ....";
        }
    }

    class MyString
    {
        //Event 
        public event StringHandler CheckText;

        public string CaseText(string text)
        {
            if (text == text.ToUpper())
            {
                return ("String is Capitals");
            }
            else if (text == text.ToLower())
            {
                return ("String is Small");
            }
            else
            {
                return ("String is Mixed ");
            }
        }

        public string StringLenght(string text)
        {
            return string.Format("the length for text is : {0}", text.Length.ToString());
        }
    }
}
