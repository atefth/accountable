using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Companies;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;

namespace Accountable.Stakeholders.Stakes.Expense
{
    class Resource
    {
        [Key]
        public int ResourceID { get; set; }
        public string Type { get; set; }
        //[Required]
        public string Name { get; set; }
        public bool Status { get; set; }
        //[Required]
        public int Value { get; set; }
        //[Required]
        public decimal Expense { get; set; }
        public double UpTime { get; set; }
        public double DownTime { get; set; }
        public double Efficiency { get; set; }
        public double ProfitEfficiency { get; set; }

        public int? CompanyID { get; set; }        
        public virtual Company Company { get; set; }

        public int WorkID { get; set; }
        public virtual Work Work { get; set; }
    }
}
