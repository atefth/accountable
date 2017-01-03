using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies
{
    class CompanyExpenditure : Expenditure
    {        
        public int? CompanyID { get; set; }
        //[ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

        //[Required]
        public decimal RentExpense { get; set; }
        //[Required]
        public decimal InfrastructureExpense { get; set; }
    }
}
