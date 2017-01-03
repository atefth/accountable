using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Companies;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Companies.Offices;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Actors.Administrators
{
    class EmployeeAdmin : Administrator
    {        
        public int? RootAdminID { get; set; }
        //[ForeignKey("AdministratorID")]
        public virtual RootAdmin RootAdmin {get; set;}

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
