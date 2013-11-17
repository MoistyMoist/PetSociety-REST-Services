using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class AddLocationController : ApiController
    {
        // GET api/addlocation
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/addlocation/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/addlocation
        public void Post([FromBody]string value)
        {
        }

        // PUT api/addlocation/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/addlocation/5
        public void Delete(int id)
        {
        }
    }
}
