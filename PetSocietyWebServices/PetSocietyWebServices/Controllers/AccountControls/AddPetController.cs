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
        [HttpGet]
        public PetModel AddPet(String INname, String INbreed, String INtype, String INsex, String INage, String INbiography, String INUserID, String INimageID, String INpinID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                //LOAD THE QUERY
                var query = db.PETs;
                List<PET> OUTusers = query.ToList();



            }
            return new PetModel();
        }
    }
}
