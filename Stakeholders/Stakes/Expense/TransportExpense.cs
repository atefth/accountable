using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using Accountable.Stakeholders.Companies.Factories;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Expense
{
    class TransportExpense : Expenditure
    {
        public decimal FuelExpense { get; set; }
        [Required]
        public decimal MaintenanceExpense { get; set; }
        [Required]
        public decimal LegalExpense { get; set; }
        [Required]
        public decimal DelivaryExpense { get; set; }

        public int WorkOrderExpenditureID { get; set; }
        //[ForeignKey("ExpenditureID")]
        public virtual WorkOrderExpenditure WorkOrderExpenditure { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }        
    }
}
