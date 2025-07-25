namespace Day4Lab
{
    //Date Can be dataType  (User Create Type)
    public class Employee
    {

        //Create Class For Full Student Data 
        //Create 2 Object Pass Data 
        //Create Method To Print Data 



        //Member Public 
        #region Fields 
        //Fields variables 
        private string _applicationName = "Smart software";
        private int _id;
        private string _name;
        private string _Job;
        private double _salary;
        private string _address = "Alex ";
        private string _attend;
        #endregion

        #region Constructor
        // Default Constructor
        //1- Public  *
        //2- Without Return type (Void | Return ) 
        //3- the name Of class 
        //4- default without parameters  ( ! Non- default)

        //CTOR
        public Employee()
        {
            Console.WriteLine("Say From Constructor ...");
        }
        #endregion
        #region Properties
        //Auto Property  -- > Database 
        public int Age { get; set; }  // Private 
        public string City { get; set; } = "Alex ";
        //PropFull
        //Property Full 
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Job
        {
            get { return _Job; }
            set { _Job = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 1000)
                {
                    _salary = 1000;
                }
                else
                {
                    _salary = value;
                }

            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        //Read Only 
        public string ApplicationName
        {
            get { return _applicationName; }
        }
        //Set Only
        public string Attend
        {
            set { _attend = value; }
        }
        #endregion
        #region Methods 
        //Method
        public string GetInfo()
        {
            return $"-My Name is {_name} \n-Id is {_id}\n-Job is {_Job}\n-Salary is {_salary:C}\n-Age is {Age}  ";
        }
        #endregion
        #region Old Setter & getter
        ////Getter _Id
        //public int Id()
        //{
        //    return _id;
        //}
        ////Setter _Id
        //public void setId(int id)
        //{
        //    _id = id;
        //}
        #endregion
    }
}
