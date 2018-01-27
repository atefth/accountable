using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountable.Properties;
using Accountable.Stakeholders.Stakes.Expense;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accountable.Stakeholders.Companies.Factories
{
    class FactoryMaterial : Material
    {
        public FactoryMaterial()
        {
            this.Type = Resources.factory;
        }

        public int FactoryId { get; set; }
        public virtual Factory Factory { get; set; }        
        
    }
}
