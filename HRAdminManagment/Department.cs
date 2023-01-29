using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminManagment
{
     class Department:IDepartment
    {
        private int _departmentID;
        private string _departmentName;
        public Department()
        {
            DepartmentID = 0;
            DepartmentName = null;
        }
        public Department(int departmentID, string departmentName)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;

        }
    
        public int DepartmentID { get => _departmentID; set => _departmentID=value; }
        public string DepartmentName { get => _departmentName; set => _departmentName=value; }
    }
}
