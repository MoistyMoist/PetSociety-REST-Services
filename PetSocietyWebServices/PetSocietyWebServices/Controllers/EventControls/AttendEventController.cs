using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class AttendEventController : ApiController
    {
        // GET api/attendevent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/attendevent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/attendevent
        public void Post([FromBody]string value)
        {
        }

        // PUT api/attendevent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/attendevent/5
        public void Delete(int id)
        {
        }
    }
}
