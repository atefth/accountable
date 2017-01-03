using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes;
using Accountable.Stakeholders.Clients;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Employees;
using System.ComponentModel.DataAnnotations;
using Accountable.Stakeholders.Companies;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class WorkOrder
    {
        public WorkOrder()
        {
            Products = new List<Product>();
            Works = new List<Work>();
        }
        [Key]
        public int WorkOrderID { get; set; }
        public string type { get; set; }
        public TimeSpan? Duration { get; set; }
        //[Required]
        public DateTime? StartTime { get; set; }
        //[Required]
        public DateTime? EndTime { get; set; }
        //[Required]
        public decimal? RatePerSheet { get; set; }
        //[Required]
        public int? TotalSheets { get; set; }
        //[Required]
        public int? OrderedSheets { get; set; }
        //[Required]
        public int? BalancedSheets { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }

        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Work> Works { get; set; }

        public virtual Deadline Deadline { get; set; }
        public virtual WorkOrderTurnover WorkOrderTurnover { get; set; }
        public virtual WorkOrderExpenditure WorkOrderExpenditure { get; set; }
    }
}
