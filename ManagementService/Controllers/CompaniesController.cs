using Dashboard.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementService.Controllers
{
    public class CompaniesController : ManagementApiController
    {
        // GET api/companies
        public List<Company> Get()
        {
            var list = new List<Company>();
            list.Add(new Company() { Name = "Apple Inc", Symbol = "AAPL" });
            list.Add(new Company() { Name = "Google", Symbol = "GOOG" });
            list.Add(new Company() { Name = "Microsoft", Symbol = "MSFT" });

            return list;
        }

        // GET api/companies/5
        public Company Get(string id)
        {
            switch(id)
            {
                case "AAPL":
                    return new Company() { Name = "Apple Inc", Symbol = "AAPL" };
                case "GOOG":
                    return new Company() { Name = "Google", Symbol = "GOOG" };
                case "MSFT":
                    return new Company() { Name = "Microsoft", Symbol = "MSFT" };
                default:
                    return new Company();
            }
        }

        // POST api/companies
        public void Post([FromBody]Company company)
        {
            queueMessage(company);
        }

        // PUT api/companies/5
        public void Put(int id, [FromBody]Company company)
        {
        }

        // DELETE api/companies/5
        public void Delete(int id)
        {
        }
    }
}
