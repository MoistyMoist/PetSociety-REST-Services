﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class DislikeReviewController : ApiController
    {
        // GET api/dislikereview
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/dislikereview/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/dislikereview
        public void Post([FromBody]string value)
        {
        }

        // PUT api/dislikereview/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/dislikereview/5
        public void Delete(int id)
        {
        }
    }
}
