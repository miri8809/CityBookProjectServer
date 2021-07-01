using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL
{
    public class UserBL
    {
        public SaveUserResponse AddUser(UserDTO user)
        {
            if (!IsValid(user))
                return new SaveUserResponse() { IsSuccessful = false };
            return new SaveUserResponse() { IsSuccessful = new UserDAL().AddUser(new Converters.UserConvert().ConvertUser(user), new Converters.UserConvert().ConvertChild(user)) };
        }


        public bool IsValid(UserDTO user)
        {
            return user.DateBorn != null &&
               !string.IsNullOrEmpty(user.FirstName) &&
               !string.IsNullOrEmpty(user.LastName) &&
               !string.IsNullOrEmpty(user.TZ) &&
               !string.IsNullOrEmpty(user.HMO);
        }
    }
}
