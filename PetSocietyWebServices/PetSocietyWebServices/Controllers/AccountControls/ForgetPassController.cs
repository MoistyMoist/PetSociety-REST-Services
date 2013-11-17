using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Data.Entity.Validation;
using PetSocietyWebServices.Models;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class ForgetPassController : ApiController
    {
        [HttpGet]
        public String ForgetPassword (String token, int INuserID, String INemail)
        {
            return "veration was send to your email to rest your password";
        }
    }
}
