using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;
using PetSocietyWebServices.Models;
namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class CheckEmailController : ApiController
    {
        [HttpGet]
        public USER checkEmail(String token, String email)
        {

            return new USER();
        }

      
    }
}
