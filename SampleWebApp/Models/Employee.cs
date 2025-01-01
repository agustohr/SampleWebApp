using System;
using System.Collections.Generic;

namespace SampleWebApp.Models;

public partial class Employee
{
    public decimal Employeeid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public decimal? Departmentid { get; set; }

    public virtual Department? Department { get; set; }
}
