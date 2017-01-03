using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountable
{
    class Actor
    {
        [Key]
        public int ActorID { set; get; }
        public string Type { set; get; }
        //[Required(ErrorMessage = "Must enter a valid name.")]
        //[RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name may not contain special characters or numbers.")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Must enter a valid name.")]
        //[RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name may not contain special characters or numbers.")]
        public string LastName { get; set; }
        public string Photo { get; set; }
        //[Required(ErrorMessage = "Must enter a phone number.")]
        public string Mobile { get; set; }
        public string Job { get; set; }

    }
}
