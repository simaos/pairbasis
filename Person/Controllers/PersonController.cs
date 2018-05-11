using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Person.Controllers
{
    public class PersonController : ApiController
    {
        public IEnumerable<string> GetAllPersons()
        {
            return new[] { "Simao", "Ronald", "Jan", "Karel" };
        }
    }
}
