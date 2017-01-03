using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Stakes.Income.Work_Orders
{
    class Item
    {
        //public Item()
        //{
        //    Products = new List<Product>();
        //}
        public int ItemID { get; set; }
        //[Required]
        public string Name { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
