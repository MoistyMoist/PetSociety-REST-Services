﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class UpdateEventController : ApiController
    {
        // GET api/updateevent
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/updateevent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/updateevent
        public void Post([FromBody]string value)
        {
        }

        // PUT api/updateevent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updateevent/5
        public void Delete(int id)
        {
        }
    }
}