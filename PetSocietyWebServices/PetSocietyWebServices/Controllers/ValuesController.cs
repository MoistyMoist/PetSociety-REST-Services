using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;

namespace PetSocietyWebServices.Controllers
{
    public class ValuesController : ApiController
    {



        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet]
        public List<USER> GetTest()
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                db.Configuration.ProxyCreationEnabled = false;

                List<USER> errors = new List<USER>();

              errors =db.USERs.ToList();
              return errors;
            }
        }
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}