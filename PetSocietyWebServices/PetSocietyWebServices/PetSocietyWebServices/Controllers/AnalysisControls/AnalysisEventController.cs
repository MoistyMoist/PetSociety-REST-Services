using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AnalysisControls
{
    public class AnalysisEventController : ApiController
    {
        // GET api/analysisevent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/analysisevent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/analysisevent
        public void Post([FromBody]string value)
        {
        }

        // PUT api/analysisevent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/analysisevent/5
        public void Delete(int id)
        {
        }
    }
}
