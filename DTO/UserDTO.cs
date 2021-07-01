using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class UserDTO
    {
        public int ID { get; set; }
        public string TZ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumChildren { get; set; }
        public string HMO { get; set; }
        public DateTime DateBorn { get; set; }
        public bool Male { get; set; }
        public bool Female { get; set; }
        public ICollection<ChildDTO> Children { get; set; }

    }
}
