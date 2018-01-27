using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies.Offices
{
    class OfficeMaterial : Material
    {
        public OfficeMaterial()
        {
            this.Type = Resources.office;
        }

        public int OfficeId { get; set; }
        //[ForeignKey("StakeholderID")]        
        public virtual Office Office { get; set; }
    }
}
