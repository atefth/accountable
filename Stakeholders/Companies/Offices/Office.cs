using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Actors.Administrators;
using Accountable.Actors.Employees;
using Accountable.Stakeholders.Stakes.Expense;
using Accountable.Stakeholders.Stakes.Income;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Stakeholders.Companies.Offices
{
    class Office : Stakeholder
    {
        public Office()
        {
            this.Type = Resources.office;
            OfficeEmployees = new List<OfficeEmployee>();
            OfficeMaterials = new List<OfficeMaterial>();
            OfficeResources = new List<OfficeResource>();
            OfficeWorkOrders = new List<OfficeWorkOrder>();
            OfficeExpenditures = new List<OfficeExpenditure>();
            OfficeTurnovers = new List<OfficeTurnover>();
        }
        //[Required]
        public string Name { get; set; }
        public int? TotalEmployees { get; set; }
        public int? TotalWorkOrders { get; set; }
        public int? TotalResources { get; set; }

        public int RootAdminID { get; set; }
        //[ForeignKey("RootAdminID")]
        public virtual RootAdmin RootAdmin { get; set; }
         
        public int CompanyID { get; set; }
        //[ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

        public virtual ICollection<OfficeEmployee> OfficeEmployees { get; set; }
        public virtual ICollection<OfficeMaterial> OfficeMaterials { get; set; }
        public virtual ICollection<OfficeResource> OfficeResources { get; set; }
        public virtual ICollection<OfficeWorkOrder> OfficeWorkOrders { get; set; }
        public virtual ICollection<OfficeExpenditure> OfficeExpenditures { get; set; }
        public virtual ICollection<OfficeTurnover> OfficeTurnovers { get; set; }
    }
}
