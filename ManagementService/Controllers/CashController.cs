using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementService.Controllers
{
    public class CashController : ManagementApiController
    {
        private IQueue _queue = new DummyQueue();
        // GET api/cash
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/cash/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/cash
        public void Post([FromBody]int value)
        {
        }

        // PUT api/cash/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cash/5
        public void Delete(int id)
        {
        }
    }
}
