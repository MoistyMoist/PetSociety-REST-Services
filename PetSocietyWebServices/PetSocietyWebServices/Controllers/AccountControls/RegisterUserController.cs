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
    public class RegisterUserController : ApiController
    {
       [HttpGet]
       public UserModel RegisterUser(String token,String INname, String INemail, String INbirthday, String INpassword, String INaddress, String INbiography, String INprivicy, String INsex, String INcontact, String INx, String INy)
       {
           using (PetSocietyDBEntities db = new PetSocietyDBEntities())
           {
               int result = 0;
               List<string> errors = new List<string>();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;
               //LOAD THE QUERY
               var query = db.USERs;
               List<USER> OUTusers = query.ToList();

               //CREATING THE USER OBJECT
               USER newUser = new USER();
               newUser.Name = INname;
               newUser.Email = INemail;
               newUser.Birthday = INbirthday;
               newUser.Password = INpassword;
               newUser.Address = INaddress;
               newUser.Biography = INbiography;
               newUser.Privicy = INprivicy;
               newUser.Sex = INsex;
               newUser.Contact = INcontact;
               newUser.Credibility = "0";
               newUser.X = INx;
               newUser.Y = INy;

               if (token.Equals("token"))
               {
                   Boolean emailAlreadyExist=false;
                   for (int i = 0; i < query.ToList().Count;i++ )
                   {
                       if (query.ToList().ElementAt(i).Email.Equals(newUser.Email))
                       {
                           emailAlreadyExist = true;
                           break;
                       }
                   }
                   
                   if(emailAlreadyExist)
                   {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "Email Exists already.";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;    
                   }
                   else
                   {
                        query.Add(newUser);
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
                               model.Message = "Failed to add user.\nTry again later";
                               model.ErrorList = errors;
                               model.Data = null;
                               return model;
                           }
                           else
                           {
                               UserModel model = new UserModel();
                               model.Status = 0;
                               model.Message = "Registeration Successfull";
                               model.ErrorList = errors;
                               model.Data = new List<USER> { newUser };
                               return model;
                           }
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
