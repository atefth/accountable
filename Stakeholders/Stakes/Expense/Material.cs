using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Companies;
using System.ComponentModel.DataAnnotations.Schema;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Expense
{
    class Material
    {
        [Key]
        public int MaterialId { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        public string Type { get; set; }
        //[Required]
        public string Purpose { get; set; }
        //[Required]
        public decimal Expense { get; set; }

        public int? CompanyID { get; set; }
        //[ForeignKey("StakeholderID")]
        public virtual Company Company { get; set; }
      
    }
}
