using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Expense;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders.Bills
{
    class Bill
    {
        [Key]
        public int BillID { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool Payed { get; set; }

        public int WorkID { get; set; }
        public virtual Work Work { get; set; }

        public virtual Advance Advance { get; set; }
        public virtual Due Due { get; set; }
        public virtual Expense Expense { get; set; }        
    }
}
