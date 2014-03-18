using Dashboard.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementService.Controllers
{
    public class FollowController : ManagementApiController
    {
        // GET api/follow
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/follow/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/follow
        public void Post([FromBody]string value)
        {
        }

        // PUT api/follow/5
        public void Put(int id, [FromBody]Company value)
        {
            
        }

        // DELETE api/follow/5
        public void Delete(int id)
        {
        }
    }
}
