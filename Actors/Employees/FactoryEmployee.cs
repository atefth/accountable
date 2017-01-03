using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Companies.Factories;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Administrators;

namespace Accountable.Actors.Employees
{
    class FactoryEmployee : Employee
    {
        public int? FactoryID { get; set; }
        //[ForeignKey("FactoryID")]
        public virtual Factory Factory { get; set; }

        public int? FactoryWorkOrderID { get; set; }
        public virtual FactoryWorkOrder FactoryWorkOrder { get; set; }

        public int? FactoryAdminID { get; set; }
        //[ForeignKey("FactoryAdminID")]
        public virtual FactoryAdmin FactoryAdmin { get; set; }                
        
    }
}
