using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class WorkOrderTurnover : Turnover
    {
        public int WorkOrderID { get; set; }
        //[ForeignKey("WorkID")]        
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
