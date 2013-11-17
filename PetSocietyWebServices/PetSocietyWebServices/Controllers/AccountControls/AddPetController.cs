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
    public class AddPetController : ApiController
    {
        public PetModel AddPet(String INname, String INbreed, String INtype, String INsex, String INage, String INbiography, String INUserID, String INimageID, String INpinID)
        {
            //create a new gallery
            return new PetModel();
        }
    }
}
