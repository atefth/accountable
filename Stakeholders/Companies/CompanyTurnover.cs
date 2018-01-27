using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies
{
    class CompanyTurnover : Turnover
    {
        public int? CompanyID { get; set; }
        //[ForeignKey("StakeholderID")]        
        public virtual Company Company { get; set; }
    }
}
