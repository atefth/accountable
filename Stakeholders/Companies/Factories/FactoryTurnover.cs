using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies.Factories
{
    class FactoryTurnover : Turnover
    {
        public int FactoryID { get; set; }
        //[ForeignKey("StakeholderID")]        
        public virtual Factory Factory { get; set; }

        public virtual ICollection<FactoryWorkOrder> FactoryWorkOrders { get; set; }
    }
}
