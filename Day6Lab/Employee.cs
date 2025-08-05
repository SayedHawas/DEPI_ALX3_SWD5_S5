namespace Day6Lab
{
    public class Employee : Human
    {
        public string JobTitle { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nJobTitle : {JobTitle}\nSalary : {Salary}";
        }
        public new double Income()
        {
            return base.Income() + Salary;
        }
    }
}
