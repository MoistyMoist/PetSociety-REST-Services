using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Data.Entity.Validation;
using PetSocietyWebServices.Models;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    /// <summary>
    /// Summary description for LoginService
    /// </summary>
    [WebService(Namespace = "http://petsociety.cloudapp.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {

        [WebMethod]
        public UserModel login(string token, string INemail, string INpassword)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = true;
                //LOAD THE QUERY
                var query = from c in db.USERs
                            where (c.Email.Equals(INemail) && c.Password.Equals(INpassword))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<USER> OUTusers = query.ToList();
                if (token.Equals("token"))
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
