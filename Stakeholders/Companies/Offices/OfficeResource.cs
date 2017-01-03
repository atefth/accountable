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

namespace Accountable.Stakeholders.Companies.Offices
{
    class OfficeResource : Resource
    {
        public OfficeResource()
        {
            this.Type = Resources.factory;
            this.Status = true;
        }

        public int OfficeId { get; set; }
        //[ForeignKey("StakeholderID")]        
        public virtual Office Office {get; set;}

        public int OfficeWorkOrderID { get; set; }
        public virtual OfficeWorkOrder OfficeWorkOrder { get; set; }
    }
}
