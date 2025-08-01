namespace Day5Lab
{
    public class Manager : Employee
    {
        public double Bouns { get; set; }
        public string DepartmentManagment { get; set; }

        public override double Income()
        {
            return base.Income() + Bouns;
        }
    }
}
