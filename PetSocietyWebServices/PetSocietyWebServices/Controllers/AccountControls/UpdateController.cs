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
    public class UpdateController : ApiController
    {
        [HttpGet]
        public UserModel UpdateUser(String token,int INuserID, String INname, String INemail, String INbirthday, String INpassword, String INaddress, String INbiography, String INprivicy, String INsex, String INcontact, String INx, String INy)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.USERs
                            where (c.Email.Equals(INemail) && c.UserID==INuserID)
                            select c;
                List<USER> OUTusers = query.ToList();

                if (token.Equals("token"))
                {

                    
                    //CHECK IF THE USER RECORD EXIST
                    if(OUTusers.Count>0)
                    {

                        //Updating THE USER OBJECT
                        USER user = query.ToList().ElementAt(0);
                        user.Name = INname;
                        user.Birthday = INbirthday;
                        user.Password = INpassword;
                        user.Address = INaddress;
                        user.Biography = INbiography;
                        user.Privicy = INprivicy;
                        user.Sex = INsex;
                        user.Contact = INcontact;
                        user.Credibility = "0";
                        user.X = INx;
                        user.Y = INy;

                        //query.ToList()=OUTusers;

                        try
                        {
                            result = db.SaveChanges();
                        }
                        catch (DbEntityValidationException dbEx)
                        {
                            result = 0;
                               foreach (var validationErrors in dbEx.EntityValidationErrors)
                               {
                                   foreach (var validationError in validationErrors.ValidationErrors)
                                   {
                                       string error = "Property: " + validationError.PropertyName + "Error: " + validationError.ErrorMessage;
                                       errors.Add(error);
                                       System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                                   }
                               }
                           }
                           //IF SOME ERROR HAPPENDS
                           if (result == 0)
                           {
                               UserModel model = new UserModel();
                               model.Status = 1;
                               model.Message = "Failed to update user.\nTry again later";
                               model.ErrorList = errors;
                               model.Data = null;
                               return model;
                           }
                           else
                           {
                               UserModel model = new UserModel();
                               model.Status = 0;
                               model.Message = "Update Successfull";
                               model.ErrorList = errors;
                               model.Data = new List<USER> { OUTusers.ElementAt(0) };
                               return model;
                           }

                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "User record does ot exist";
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
