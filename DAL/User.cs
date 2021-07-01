using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string TZ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumOfChildren { get; set; }
        public string HMO { get; set; }
        public System.DateTime DateBorn { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}
