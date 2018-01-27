using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies.Offices
{
    class OfficeTurnover : Turnover
    {
        public int OfficeID { get; set; }
        //[ForeignKey("StakeholderID")]        
        public virtual Office Office { get; set; }

        public virtual ICollection<OfficeWorkOrder> OfficeWorkOrders { get; set; }
    }
}
