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
        [HttpGet]
        public UserModel Get(string token, string INemail, string INpassword)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.USERs.Include("Friend_List").Include("Pets").Include("Friend_Request").Include("Pins").Include("Galleries.Images")
                            where (c.Email.Equals(INemail) && c.Password.Equals(INpassword))
                            select c;

                //CONVERT THE RESULT TO A LIST
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

