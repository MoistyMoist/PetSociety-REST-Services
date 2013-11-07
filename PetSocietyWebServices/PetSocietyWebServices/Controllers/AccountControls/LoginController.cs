using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;
using PetSocietyWebServices.Models;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class LoginController : ApiController
    {
       
        // GET api/login/5
        public USER Get(string token, string INemail, string INpassword)
        {

            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                db.Configuration.LazyLoadingEnabled = false;
                USER OUTuser = new USER();

                //OUTuser = db.USERs;
                return OUTuser;
            }
        }
    }
}
