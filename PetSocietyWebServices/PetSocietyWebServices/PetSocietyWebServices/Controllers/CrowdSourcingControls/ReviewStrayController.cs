using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class ReviewStrayController : ApiController
    {
        // GET api/reviewstray
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/reviewstray/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/reviewstray
        public void Post([FromBody]string value)
        {
        }

        // PUT api/reviewstray/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/reviewstray/5
        public void Delete(int id)
        {
        }
    }
}
