using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using Accountable.Stakeholders.Stakes.Expense;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Clients;
using Accountable.Actors.Administrators;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income
{
    class Production
    {
        [Key]
        public int ProductionID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DayOfWeek Day { get; set; }
        public int TotalWorkOrders { get; set; }
        public double ProfitEfficiency { get; set; }

        public int RootAdminID { get; set; }
        //[ForeignKey("ActorID")]
        public virtual RootAdmin RootAdmin { get; set; }        
        
        public virtual ICollection<Work> Works { get; set; }
        public virtual ICollection<Expenditure> Expenditures { get; set; }
        public virtual ICollection<Turnover> Turnovers { get; set; }
    }
}
