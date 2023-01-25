using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class TimesFiftyController : ApiController
    {
        //POST: api/TimesFifty/5 ->250
        public int Post(int id)
        {

            return id * 50;
        }
    }
}
