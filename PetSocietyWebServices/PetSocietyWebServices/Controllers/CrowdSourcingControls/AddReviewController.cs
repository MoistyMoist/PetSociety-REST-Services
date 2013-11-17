using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class AddReviewController : ApiController
    {
        // GET api/addreview
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/addreview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/addreview
        public void Post([FromBody]string value)
        {
        }

        // PUT api/addreview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/addreview/5
        public void Delete(int id)
        {
        }
    }
}
