using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

namespace Person.Controllers
{
    public class PersonController : ApiController
    {
        public IEnumerable<string> GetAllPersons()
        {
            //File.ReadAllLines("persons.txt");
            return new[] { "Simao", "Ronald", "Jan", "Karel" };
        }
    }
}
