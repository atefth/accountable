using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Companies;
using Accountable.Stakeholders.Stakes.Expense;
using Accountable.Stakeholders.Stakes.Income;
using Accountable.Stakeholders.Clients;
using Accountable.Stakeholders.Stakes.Income.Work_Orders.Bills;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Employees;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class Work
    {
        [Key]
        public int WorkID { get; set; }
        
        public virtual Bill Bill { get; set; }

        public int? WorkOrderID {get; set;}
        public virtual WorkOrder WorkOrder {get; set;}

        public DateTime? Date { get; set; }
        public int? ProducedSheets { get; set; }
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }
        public TimeSpan? HoursSpent { get; set; }

        public virtual Resource Resource { get; set; }

        public virtual Delivery Delivery { get; set; }

        public virtual Item Item { get; set; }
        public virtual Product Product { get; set; }  
    }
}
