using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.LostControls
{
    public class ReportLostController : ApiController
    {
        // GET api/reportlost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/reportlost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/reportlost
        public void Post([FromBody]string value)
        {
        }

        // PUT api/reportlost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/reportlost/5
        public void Delete(int id)
        {
        }
    }
}
