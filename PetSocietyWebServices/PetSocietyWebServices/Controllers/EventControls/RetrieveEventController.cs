//==============================================================================//
// Created By   : Lee Kai Quan
// Last Updated : 12/6/2013
// Tested       : NO
// URL          : 
//==============================================================================//


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

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class RetrieveEventController : ApiController
    {
       
        [HttpGet]
        public LocationModel retrieveAllEvent(string INtoken, DateTime INstartDateTime, DateTime INendDateTime)
        {
            return null;
        }
    }
}
