using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Employees;

namespace Accountable.Stakeholders.Companies.Factories
{
    class FactoryWorkOrder : WorkOrder
    {
        public int FactoryID { get; set; }
        //[ForeignKey("StakeholderID")]
        public virtual Factory Factory { get; set; }

        public virtual ICollection<FactoryEmployee> FactoryEmployees { get; set; }

        public virtual ICollection<FactoryResource> FactoryResources { get; set; }                        
    }
}
