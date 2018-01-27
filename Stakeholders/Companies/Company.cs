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
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Companies.Offices;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Accountable.Stakeholders.Clients;

namespace Accountable.Stakeholders.Companies
{
    class Company : Stakeholder
    {
        public Company()
        {
            this.Type = Properties.Resources.company;
            Factories = new List<Factory>();
            Offices = new List<Office>();
            Clients = new List<Client>();
            Employees = new List<Employee>();
            Materials = new List<Material>();
            Resources = new List<Resource>();
            WorkOrders = new List<WorkOrder>();
            CompanyExpenditures = new List<CompanyExpenditure>();
            CompanyTurnovers = new List<CompanyTurnover>();
        }
        //[Required]
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Country { get; set; }
        public int? TotalEmployees { get; set; }
        public int? TotalWorkOrders { get; set; }
        public int? TotalResources { get; set; }        

        public int RootAdminID { get; set; }
        public virtual RootAdmin RootAdmin { get; set; }

        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<CompanyExpenditure> CompanyExpenditures { get; set; }
        public virtual ICollection<CompanyTurnover> CompanyTurnovers { get; set; }
    }
}
