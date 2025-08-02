namespace Day5Lab
{
    //Class Type --> Data type 
    public class Person
    {
        //Fields
        private int _id;
        private string _name;
        //Readonly Vs Const
        public const string ApplicationName = "Smart App "; //ReadOnly
        public readonly string InstanceName;
        public readonly string ConnectionDatabase;

        //Method default CTOR
        //3-Polymorphism (Overload ,Override)
        public Person()
        {
            Console.WriteLine("From Default CTOR ....");
            InstanceName = $" {typeof(Person).Name} Copy ...";
            ConnectionDatabase = "SQL Service .... Connection String ";
        }

        //Overload Non-Default
        public Person(int id, string name, string address)
        {
            InstanceName = $" {typeof(Person).Name} Copy ...";
            Console.WriteLine("From Non-Default CTOR ....");
            this._id = id;
            this._name = name;
            this.Address = address;
        }


        //Property Full
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        //Auto property 
        public string Address { get; set; }


        //Methods (Void , return Type)
        public string SayInfo()
        {
            return $" Id = {_id}\nName : {_name} \nAddress {Address} ";
        }


        //3-Polymorphism (Overload)
        public string SayHello()
        {
            return "Hello";
        }
        public string SayHello(string name)
        {
            return $"Hello {name} ";
        }
        public string SayHello(string name, string msg)
        {
            return $"{msg} {name}";
        }


        //Override 
        public virtual double Income()
        {
            return 0;
        }

    }
    //Inheritance OverView
    // Inheritance 
}
