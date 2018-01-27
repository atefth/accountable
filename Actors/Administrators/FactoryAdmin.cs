using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Companies.Factories;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Actors.Administrators
{
    class FactoryAdmin : Administrator
    {
        public int RootAdminID { get; set; }
        //[ForeignKey("AdministratorID")]      
        public virtual RootAdmin RootAdmin {get; set;}

        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<FactoryEmployee> FactoryEmployees { get; set; }
    }
}
