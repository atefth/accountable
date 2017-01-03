using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Companies.Factories
{
    class FactoryExpenditure : Expenditure
    {
        public int FactoryID { get; set; }
        //[ForeignKey("StakeholderID")]
        public virtual Factory Factory { get; set; }
        
        //[Required]
        public decimal RentExpense { get; set; }
        //[Required]
        public decimal InfrastructureExpense { get; set; }
    }
}
