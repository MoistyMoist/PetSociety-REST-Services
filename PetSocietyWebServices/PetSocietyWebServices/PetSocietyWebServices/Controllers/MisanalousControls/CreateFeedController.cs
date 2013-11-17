using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.MisanalousControls
{
    public class CreateFeedController : ApiController
    {
        // GET api/createfeed
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/createfeed/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/createfeed
        public void Post([FromBody]string value)
        {
        }

        // PUT api/createfeed/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/createfeed/5
        public void Delete(int id)
        {
        }
    }
}
