using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Actors.Employees.Attendance;
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Stakes.Income.Work_Orders;
using Accountable.Stakeholders.Stakes.Income;
using System.ComponentModel.DataAnnotations;
using Accountable.Actors.Administrators;
using Accountable.Stakeholders.Companies;

namespace Accountable.Actors.Employees
{
    class Employee : Actor
    {
        public Employee()
        {
            this.Type = Resources.employee;
            WorkOrders = new List<WorkOrder>();
            DailyAttendances = new List<DailyAttendance>();
        }
        
        public static float efficiency { get; set; }
        public float HourlySalary { get; set; }
        //[Required]
        public int MonthlySalary { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<WorkOrder> WorkOrders { get; set; }        
        public virtual ICollection<DailyAttendance> DailyAttendances { get; set; }


    }
}
