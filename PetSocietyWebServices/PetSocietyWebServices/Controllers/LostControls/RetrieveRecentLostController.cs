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

namespace PetSocietyWebServices.Controllers.LostControls
{
    public class RetrieveRecentLostController : ApiController
    {
        [HttpGet]
        public LostModel RetrieveRecent(string token, int amount)
        {
            return null;
        }
    }
}
