using Dashboard.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementService.Controllers
{
    public class TransactionsController : ManagementApiController
    {
        // GET api/transactions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/transactions/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/transactions
        public void Post([FromBody]Transaction value)
        {
        }

        // PUT api/transactions/5
        public void Put(int id, [FromBody]Transaction transaction)
        {

        }

        // DELETE api/transactions/5
        public void Delete(int id)
        {
        }   
    }
}
