using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Companies;
using Accountable.Stakeholders.Companies.Offices;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Administrators;

namespace Accountable.Actors.Employees
{
    class OfficeEmployee : Employee
    {
        public int OfficeID { get; set; }
        public virtual Office Office { get; set; }

        public int OfficeWorkOrderID { get; set; }        
        public virtual OfficeWorkOrder OfficeWorkOrder { get; set; }

        public int OfficeAdminID { get; set; }
        public virtual OfficeAdmin OfficeAdmin { get; set; }
    }
}
