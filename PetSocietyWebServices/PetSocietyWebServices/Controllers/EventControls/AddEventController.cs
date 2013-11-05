using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class AddEventController : ApiController
    {
        // GET api/addevent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/addevent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/addevent
        public void Post([FromBody]string value)
        {
        }

        // PUT api/addevent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/addevent/5
        public void Delete(int id)
        {
        }
    }
}
