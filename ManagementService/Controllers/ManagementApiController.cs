using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManagementService.Controllers
{
    public class ManagementApiController : ApiController
    {
        private IQueue _queue = new DummyQueue();

        [NonAction]
        public void queueMessage(object o)
        {
            _queue.Queue(o);
        }
    }
}
