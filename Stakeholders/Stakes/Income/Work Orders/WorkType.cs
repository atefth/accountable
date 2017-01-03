using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class WorkType
    {
        public int WorkTypeID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Ups { get; set; }
        [Required]
        public double XInch { get; set; }
        [Required]
        public double YInch { get; set; }

        public int WorkOrderID { get; set; }
        //[ForeignKey("WorkID")]
        public virtual WorkOrder WorkOrder { get; set; }

        public WorkType(string type, double rate, int ups, double xInch, double yInch)
        {
            this.Type = type;
            this.Rate = rate;
            this.Ups = ups;
            this.XInch = xInch;
            this.YInch = yInch;
        }        
    }
}
