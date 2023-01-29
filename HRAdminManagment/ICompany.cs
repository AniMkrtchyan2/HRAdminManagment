using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminManagment
{
     interface ICompany
    {
        public int AddDepartment(string deptName);
        public int AddEmployee(IEmployee e, out int id);
        public IEmployee ViewEmployee(int id);
        public IEmployee ViewEmployee(string name);
        public int DeleteEmployee(int id);
        public int ViewDepartment();
        public int ViewStatistics(int id);
    }
}
