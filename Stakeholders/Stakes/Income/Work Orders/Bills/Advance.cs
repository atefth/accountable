using Accountable.Stakeholders.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders.Bills
{
    class Advance
    {
        [Key]
        public int AdvanceID { get; set; }
        //[Required]
        public decimal Amount { get; set; }
        //[Required]
        public DateTime? PaymentDate { get; set; }

        public int BillID { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
