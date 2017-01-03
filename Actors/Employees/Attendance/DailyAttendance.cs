using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Actors.Employees.Attendance
{
    class DailyAttendance
    {
        public int DailyAttendanceID { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public decimal WorkingHour { get; set; }
        [Required]
        public bool IsPresent { get; set; }

        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; set; }        
    }
}
