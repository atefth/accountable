using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Companies;
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Companies.Offices;
using System.ComponentModel.DataAnnotations;

namespace Accountable.Actors.Administrators
{
    class Administrator : Actor
    {
        public Administrator()
        {
            this.Type = Resources.administrator;
        }
        public int? AdministratorID { get; set; }
        //[Required(ErrorMessage = "Must enter a valid username.")]
        public string Username { get; set; }
        //[Required(ErrorMessage = "Must enter a password.")]
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}
