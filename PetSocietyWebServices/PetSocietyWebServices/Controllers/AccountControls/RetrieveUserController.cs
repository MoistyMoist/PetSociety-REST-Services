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
    public class RetrieveUserController : ApiController
    {
        [HttpGet]
        public UserModel RetrieveUsers(String token)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.USERs
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<USER> OUTusers = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTusers.Count() == 0)
                    {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "No Users";
                        return model;
                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 0;
                        model.Message = "successfull";
                        model.Data = OUTusers;
                        return model;
                    }
                }
                else
                {
                    UserModel model = new UserModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }

            }
        }
    }
}
