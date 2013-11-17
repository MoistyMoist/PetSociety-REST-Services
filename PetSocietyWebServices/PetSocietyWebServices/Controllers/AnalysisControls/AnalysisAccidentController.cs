using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AnalysisControls
{
    public class AnalysisAccidentController : ApiController
    {
        // GET api/analysisaccident
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/analysisaccident/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/analysisaccident
        public void Post([FromBody]string value)
        {
        }

        // PUT api/analysisaccident/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/analysisaccident/5
        public void Delete(int id)
        {
        }
    }
}
