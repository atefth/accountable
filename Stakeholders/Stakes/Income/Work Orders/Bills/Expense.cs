using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders.Bills
{
    class Expense
    {
        [Key]
        public int ExpenseID { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }

        public int BillID { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
