using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminManagment
{
  interface IDepartment
    {
        int DepartmentID { get; set; }
        string DepartmentName { get; set; }
    }
}
