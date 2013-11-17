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
    public class TestController : ApiController
    {


        [HttpGet]
        public List<USER> GetTest()
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                db.Configuration.LazyLoadingEnabled = false;
                List<USER> errors = new List<USER>();

              errors =db.USERs.ToList();
              return errors;
            }
        }
       
    }
}