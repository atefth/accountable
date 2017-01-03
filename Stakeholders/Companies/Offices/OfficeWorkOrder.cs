using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Actors.Employees;

namespace Accountable.Stakeholders.Companies.Offices
{
    class OfficeWorkOrder : WorkOrder
    {
        public int OfficeID { get; set; }
        //[ForeignKey("StakeholderID")]
        public virtual Office Office { get; set; }

        public virtual ICollection<OfficeEmployee> OfficeEmployees { get; set; }
        public virtual ICollection<OfficeResource> OfficeResources { get; set; }            
    }
}
