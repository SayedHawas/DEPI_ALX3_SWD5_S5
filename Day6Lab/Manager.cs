namespace Day6Lab
{
    public class Manager : Employee
    {
        public string DepartmentMaganement { get; set; }
        public double Bouns { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nDepartmentManaging : {DepartmentMaganement}\nBouns :  {Bouns}";
        }
        public double Income()
        {
            return Salary + Bouns;
        }
        //public override double Income()
        //{
        //    return base.Income();
        //}
    }
}
