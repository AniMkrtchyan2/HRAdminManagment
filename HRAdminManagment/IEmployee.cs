using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminManagment
{
    internal interface IEmployee
    {
        int EmployeeDepID { get; set; }
        int EmployeeID { get; set; }
        string FullName { get; set; }
        DateTime DateOfBirth { get; set; }
    }

}
