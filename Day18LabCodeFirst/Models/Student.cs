using System;
using System.Collections.Generic;

namespace Day18LabCodeFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Mark { get; set; }

    public string? Class { get; set; }

    public bool IsDelete { get; set; }

    public string? Subject { get; set; }
}
