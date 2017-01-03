using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountable.Stakeholders
{
    class Stakeholder
    {
        [Key]
        public int StakeholderID { get; set; }
        public string Type { get; set; }
        //[Required]
        public string Address { get; set; }
        public string Mobile { get; set; }
        //[Required]
        public string Phone { get; set; }
        public string Photo { get; set; }
        public double ProfitEfficiency { get; set; }
    }
}
