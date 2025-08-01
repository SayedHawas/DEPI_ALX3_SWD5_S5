namespace Day5Lab
{
    public class Employee : Person   //Person : Super    , Employee Sub  
    {

        string day = DayOfWeek.Friday.ToString();
        public double Hours { get; set; }
        public double HourRate { get; set; }
        public double ProjectPrice { get; set; }
        //Type Data Type 
        public enum _EmployeeType //Int
        {
            FullTime = 1,
            PartTime = 2,
            FreeLance = 3
        }

        public _EmployeeType EmployeeType { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, string address, string job, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Job = job;
            this.Salary = salary;
        }
        //Prop
        public double Salary { get; set; }
        public string Job { get; set; }
        //Method
        public string SayHello(string name, string msg, string moreText)
        {
            return $"{msg} {name} {moreText}";
        }
        //Method Override
        public override double Income()
        {
            switch (EmployeeType)
            {
                case _EmployeeType.FullTime:
                    Salary = Salary;
                    break;
                case _EmployeeType.PartTime:
                    Salary = Hours * HourRate;
                    break;
                case _EmployeeType.FreeLance:
                    Salary = ProjectPrice;
                    break;
                default:
                    break;
            }


            return base.Income() + Salary;
        }
    }
}
