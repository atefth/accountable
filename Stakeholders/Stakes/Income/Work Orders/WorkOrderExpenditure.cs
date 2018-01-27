using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class WorkOrderExpenditure : Expenditure
    {
        public int WorkOrderID { get; set; }
        //[ForeignKey("WorkID")]
        public virtual WorkOrder WorkOrder { get; set; }  
      
        //[Required]
        public decimal WastageExpense { get; set; }

        public virtual TransportExpense TransportExpense { get; set; }        
    }
}
