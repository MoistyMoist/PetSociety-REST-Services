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
       
        // GET api/login/
        public UserModel Get(string token, string INemail, string INpassword)
        {

            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                // create an Entity Framework query
                var query = from c in db.USERs.Include("Friend_List").Include("LOCATIONs")
                            where (c.Email.Equals(INemail) && c.Password.Equals(INpassword))
                            select c;

                // execute query and return a list of customer objects
                List<USER> OUTusers = query.ToList();
                if(token.Equals("token"))
                {
                    if (OUTusers.Count() == 0)
                    {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "Username or password is wrong";
                        return model;
                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 0;
                        model.Message = "Login successfull";
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

