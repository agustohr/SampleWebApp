using System;
using System.Collections.Generic;

namespace SampleWebApp.Models;

public partial class Department
{
    public decimal Departmentid { get; set; }

    public string Departmentname { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
