using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AddUsersController : ApiController
    {
        // GET: api/AddUsers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddUsers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddUsers
        [HttpPost]
        [Route("api/AddUsers/Post")]
        public void Post([FromBody]UserDTO user)
        {
            new BL.UserBL().AddUser(user);
        }

        // PUT: api/AddUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AddUsers/5
        public void Delete(int id)
        {
        }
    }
}
