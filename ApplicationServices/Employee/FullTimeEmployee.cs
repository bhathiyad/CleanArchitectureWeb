using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.Employee
{
    public class FullTimeEmployee : IEmployee
    {
        public decimal CalculateEmployeeSalary()
        {
            return 10.00M;
        }
    }
}
