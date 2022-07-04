using ApplicationServices.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.EmployeeFactory
{
    public class EmployeeFactory
    {
        public IEmployee GetEmployeeType(int employeeType) 
        {
            if (employeeType == (int)EmployeeType.FullTime)
            {
                return new FullTimeEmployee();
            }
            else if (employeeType == (int)EmployeeType.PartTime)
            {
                return new PartTimeEmployee();
            }

            return null;
        }
    }

    enum EmployeeType 
    {
        FullTime = 0,
        PartTime = 1
    }
}
