using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class RetrieveUserController : ApiController
    {
        // GET api/retrievealluser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrievealluser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrievealluser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrievealluser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrievealluser/5
        public void Delete(int id)
        {
        }
    }
}
