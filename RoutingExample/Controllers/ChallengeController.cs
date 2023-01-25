using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class ChallengeController : ApiController
    {
        /// <summary>
        /// Calculates the volumne of a prism given length, width, and height
        /// </summary>
        /// <param name="x">The width of the prism in cm</param>
        /// <param name="y">The length of the prism in cm</param>
        /// <param name="z">The height of the prism in cm</param>
        /// <returns>
        /// The total volumne is {result}cm^3
        /// </returns>
        //GET: api/challenge/calculate/x/y/z -> "The total volumne is {result}cm^3"
        [HttpGet]
        [Route("api/challenge/calculate/{x}/{y}/{z}")]
        public string calculate(int x, int y, int z)
        {
            int volume = x * y * z;
            string message = "The total volumne is "+volume+"cm^3";
            return message;
        }
    }
}
