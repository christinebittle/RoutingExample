using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class TimesHundredController : ApiController
    {
        //GET: api/TimesHundred/90 -> 9000
        public int Get(int id)
        {
            return id * 100;

        }

        


    }
}
