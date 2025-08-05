namespace Day6Lab
{
    public class Developer : Employee   //Save()     //SaveInDatabase  //SaveInFile
    {
        public string Tasks { get; set; }

        public double Income()
        {
            return Salary; //base.Income();
        }
        public override string ToString()
        {
            return base.ToString() + $"\nTasks : {Tasks}";
        }
    }
}
