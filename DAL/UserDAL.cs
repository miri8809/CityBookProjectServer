using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL
    {
        public bool AddUser(User user,Child[] children)
        {
            try
            {
                using (UserContext ctx = new UserContext())
                {
                    foreach (var item in children)
                    {
                        ctx.Children.Add(item);
                    }
                    ctx.Users.Add(user);
                    ctx.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
