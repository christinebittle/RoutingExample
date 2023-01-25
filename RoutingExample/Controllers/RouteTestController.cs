using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class RouteTestController : ApiController
    {

        //get: api/RouteTest/Math/x/y -> x*y
        [HttpGet]
        [Route("api/RouteTest/Math/{operand1}/{operand2}")]
        public int Math(int operand1, int operand2)
        {
            return operand1*operand2;
        }

        //get: api/RouteTest/Greeting2 -> "howdy"
        [HttpGet]
        public string Greeting2()
        {

            return "howdy";
        }

        //post: api/RouteTest/Greeting3 ->"Heya"
        [HttpPost]
        public string Greeting3()
        {
            return "Heya";
        }

        //post: api/RouteTest/Greeting4 -> "Hola"
        [HttpPost]
        public string Greeting4()
        {
            return "Hola";
        }

    }
}
