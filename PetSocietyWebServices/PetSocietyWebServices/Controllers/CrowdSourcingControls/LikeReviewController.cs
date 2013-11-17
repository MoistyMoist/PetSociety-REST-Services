using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class LikeReviewController : ApiController
    {
        // GET api/likereview
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/likereview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/likereview
        public void Post([FromBody]string value)
        {
        }

        // PUT api/likereview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/likereview/5
        public void Delete(int id)
        {
        }
    }
}
