using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Companies;
using Accountable.Stakeholders.Companies.Factories;
using Accountable.Stakeholders.Companies.Offices;
using Accountable.Stakeholders.Stakes.Income;

namespace Accountable.Actors.Administrators
{
    class RootAdmin : Administrator
    {
        public virtual ICollection<OfficeAdmin> OfficeAdmins { get; set; }
        public virtual ICollection<FactoryAdmin> FactoryAdmins { get; set; }
        public virtual ICollection<Production> Productions { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<Office> Offices { get; set; }
    }
}
