using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Actors.Administrators;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Companies.Factories
{
    class Factory : Stakeholder
    {
        public Factory()
        {
            this.Type = Resources.factory;
            FactoryEmployees = new List<FactoryEmployee>();
            FactoryMaterials = new List<FactoryMaterial>();
            FactoryResources = new List<FactoryResource>();
            FactoryWorkOrders = new List<FactoryWorkOrder>();
            FactoryExpenditures = new List<FactoryExpenditure>();
            FactoryTurnovers = new List<FactoryTurnover>();
        }
        //[Required]
        public string Name { get; set; }
        public int? TotalEmployees { get; set; }
        public int? TotalWorkOrders { get; set; }
        public int? TotalResources { get; set; }        

        public int? RootAdminID { get; set; }
        //[ForeignKey("RootAdminID")]
        public virtual RootAdmin RootAdmin { get; set; }

        public int? FactoryAdminID { get; set; }
        //[ForeignKey("FactoryAdminID")]
        public virtual FactoryAdmin FactoryAdmin { get; set; }

        public int CompanyID { get; set; }
        //[ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }        
                        
        public virtual ICollection<FactoryEmployee> FactoryEmployees { get; set; }
        public virtual ICollection<FactoryMaterial> FactoryMaterials { get; set; }
        public virtual ICollection<FactoryResource> FactoryResources { get; set; }
        public virtual ICollection<FactoryWorkOrder> FactoryWorkOrders { get; set; }
        public virtual ICollection<FactoryExpenditure> FactoryExpenditures { get; set; }
        public virtual ICollection<FactoryTurnover> FactoryTurnovers { get; set; }
    }
}
