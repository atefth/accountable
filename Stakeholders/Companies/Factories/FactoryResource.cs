using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Expense;
using Accountable.Properties;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies.Factories
{
    class FactoryResource : Resource
    {
        public FactoryResource()
        {
            this.Type = Resources.factory;
            this.Status = true;
        }

        public int? FactoryID { get; set; }
        public virtual Factory Factory {get; set;}

        public int? FactoryWorkOrderID { get; set; }
        public virtual FactoryWorkOrder FactoryWorkOrder { get; set; }
    }
}
