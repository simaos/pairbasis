using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using System.Web;

namespace Person.Controllers
{
    public class PersonController : ApiController
    {
        public IEnumerable<string> GetAllPersons()
        {
            var path = HttpContext.Current.Request.MapPath("~\\persons.txt");
            var names = new List<string>();
            foreach (var line in File.ReadAllLines(path))
            {
                var fields = line.Split(',');
                var name = fields[0];
                var country = fields[1];
                if (country == "NL")
                    names.Add(name);                    
            }
            return names;
        }
    }
}
