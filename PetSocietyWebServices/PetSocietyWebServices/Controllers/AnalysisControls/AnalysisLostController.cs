using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AnalysisControls
{
    public class AnalysisLostController : ApiController
    {
        // GET api/analysislost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/analysislost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/analysislost
        public void Post([FromBody]string value)
        {
        }

        // PUT api/analysislost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/analysislost/5
        public void Delete(int id)
        {
        }
    }
}
