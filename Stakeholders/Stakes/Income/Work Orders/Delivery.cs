using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Accountable.Stakeholders.Clients;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }
        //[Required]
        public DateTime Date { get; set; }
        //[Required]
        public string Address { get; set; }

        public int? WorkID { get; set; }
        public virtual Work Work { get; set; }

        public int? WorkOrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
