using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class Product
    {
        public Product()
        {
            Sizes = new List<Size>();
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int quantity { get; set; }

        public int WorkOrderID { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }

        public int ItemID { get; set; }
        public virtual Item Item { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Size> Sizes { get; set; }
    }
}
