using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.MisanalousControls
{
    public class RetrieveFeedsController : ApiController
    {
        // GET api/retrievefeeds
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrievefeeds/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrievefeeds
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrievefeeds/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrievefeeds/5
        public void Delete(int id)
        {
        }
    }
}
