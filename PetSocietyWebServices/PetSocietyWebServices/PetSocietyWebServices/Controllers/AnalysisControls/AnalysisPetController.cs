using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AnalysisControls
{
    public class AnalysisPetController : ApiController
    {
        // GET api/analysispet
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/analysispet/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/analysispet
        public void Post([FromBody]string value)
        {
        }

        // PUT api/analysispet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/analysispet/5
        public void Delete(int id)
        {
        }
    }
}
