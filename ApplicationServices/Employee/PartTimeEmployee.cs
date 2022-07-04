using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.Employee
{
    public class PartTimeEmployee : IEmployee
    {
        public decimal CalculateEmployeeSalary()
        {
            return 5.00M;
        }
    }
}
