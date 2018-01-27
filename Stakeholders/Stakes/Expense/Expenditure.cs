using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Expense
{
    class Expenditure
    {
        [Key]
        public int ExpenditureID { get; set; }
        public string Type { get; set; }
        [Required]
        public string Purpose { get; set; }
        [Required]
        public decimal MiscExpense { get; set; }
        [Required]
        public decimal EntertainmentExpense { get; set; }
        public decimal TotalExpense { get; set; }

        public int ProductionID { get; set; }
        public virtual Production Production { get; set; }
    }
}
