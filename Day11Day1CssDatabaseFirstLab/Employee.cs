namespace Day11Day1CssDatabaseFirstLab;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Job { get; set; } = null!;

    public string? Email { get; set; }

    public decimal Salary { get; set; }

    public bool IsDelete { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;


    public override string ToString()
    {
        //return base.ToString();
        return $"Id {EmployeeId} Name :{Name} Job {Job} Salary {Salary:C} ";
    }
}
