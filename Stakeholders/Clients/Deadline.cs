using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Clients
{
    class Deadline
    {
        [Key]
        public int DeadlineID { get; set; }
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }        
    }
}
