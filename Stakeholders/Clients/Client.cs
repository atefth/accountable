using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using Accountable.Properties;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations;
using Accountable.Stakeholders.Stakes.Income.Work_Orders.Bills;
using Accountable.Stakeholders.Companies;

namespace Accountable.Stakeholders.Clients
{
    class Client : Stakeholder
    {
        public Client()
        {
            this.Type = Resources.client;
            WorkOrders = new List<WorkOrder>();
        }
        //[Required]
        public string RepresentativeName { get; set; }
        //[Required]
        public string CompanyName { get; set; }
        //[Required]
        public int Commission { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }        
    }
}
