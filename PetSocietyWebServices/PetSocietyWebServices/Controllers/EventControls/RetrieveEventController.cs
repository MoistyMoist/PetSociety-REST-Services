using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class RetrieveEventController : ApiController
    {
        // GET api/retrieveevent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrieveevent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrieveevent
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrieveevent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrieveevent/5
        public void Delete(int id)
        {
        }
    }
}
