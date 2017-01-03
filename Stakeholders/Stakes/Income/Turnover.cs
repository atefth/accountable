﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountable.Stakeholders.Stakes.Income
{
    class Turnover
    {
        [Key]
        public int TurnoverID { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public int ProductionID { get; set; }

        public virtual Production Production { get; set; }
    }
}
