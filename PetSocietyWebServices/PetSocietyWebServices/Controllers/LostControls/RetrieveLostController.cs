﻿using System;
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
    public class RetrieveLostController : ApiController
    {
        [HttpGet]
        public LostModel Retrieve(string token)
        {
            return null;
        }

        [HttpGet]
        public LostModel RetrieveByID (string token, string id)
        {
            return null;
        }

        
    }
}
