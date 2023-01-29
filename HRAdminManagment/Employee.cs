using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminManagment
{
    class Employee : Department, IEmployee
    {
        private int _employeeDepID;
        private int _employeeID;
        private string _fullName;
        private DateTime _dateOfBirth;

        public Employee() 
        {
            EmployeeDepID = 0;
            EmployeeID = 0;
            FullName = null;
            DateOfBirth = DateTime.Now;
        }
        public Employee(int employeeDepID, int employeeID, string fullName, DateTime dateOfBirth)
        {
            EmployeeDepID = employeeDepID;
            EmployeeID = employeeID;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
        }
        public int EmployeeDepID { get => _employeeDepID; set => _employeeDepID = value; }
        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
    }
}
