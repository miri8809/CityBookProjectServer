using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Converters
{
    public class UserConvert
    {
        public User ConvertUser(UserDTO user)
        {
            User u = new User
            {
                DateBorn = user.DateBorn,
                FirstName = user.FirstName,
                HMO = user.HMO,
                ID = user.ID,
                LastName = user.LastName,
                NumOfChildren = user.NumChildren,
                TZ = user.TZ,
                Male = user.Male,
                Female = user.Female

            };
            return u;
        }
        public Child[] ConvertChild(UserDTO user)
        {
            Child[] children = new Child[user.NumChildren];
            int i = 0;
            foreach (var item in user.Children)
            {
                children[i] = new Child
                {
                    DateBorn = item.DateBorn,
                    FirstName = item.FirstName,
                    ID = item.ID,
                    IDParent = user.ID,
                    LastName = item.LastName,
                    TZ = item.TZ,
                };
                i++;
            }
            return children;
        }
    }
}
