namespace Day10CodeFirstLab.Models
{
    public class Employee  //Entity --> Row 
    {
        //Key 
        //Configuration
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"Id : {Id} Name : {Name} Job : {Job} Age :{Age}  Salary : {Salary:C}";
        }
    }
}
