using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class UpdateController : ApiController
    {
        // GET api/update
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/update/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/update
        public void Post([FromBody]string value)
        {
        }

        // PUT api/update/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/update/5
        public void Delete(int id)
        {
        }
    }
}
