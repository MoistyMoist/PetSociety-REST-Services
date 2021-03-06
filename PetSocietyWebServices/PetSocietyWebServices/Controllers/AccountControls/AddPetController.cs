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

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class AddPetController : ApiController
    {
        [HttpGet]
        public PetModel AddPet(String INname, String INbreed, String INtype, String INsex, String INage, String INbiography, int INUserID)
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

                //CREATING THE USER OBJECT
                PET newUser = new PET();
                newUser.Name = INname;
                newUser.Breed = INbreed;
                newUser.Type = INtype;
                newUser.Sex = INsex;
                newUser.Biography = INbiography;
                newUser.Age = INage;
                newUser.UserID = INUserID;

                String token = "token";

                if (token.Equals("token"))
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
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "Failed to add user.\nTry again later";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Registeration Successfull";
                        model.ErrorList = errors;
                        model.Data = new List<PET> { newUser };
                        return model;
                    }
                }

                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }


        }
    }
}
