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

namespace PetSocietyWebServices.Controllers.CrowdSourcingControls
{
    public class ReportStrayController : ApiController
    {
        [HttpGet]
        public StrayModel reportStray(string token, double INx, double INy,string INbiography, string INtitle, string INtype, string INbreed, string INimageURL, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                DateTime date = DateTime.Now;

                var query = db.STRAYs;
                List<STRAY> OUTProducts = query.ToList();

                STRAY newStray = new STRAY();
                newStray.X = INx;
                newStray.Y = INy;
                newStray.Biography = INbiography;
                newStray.Title = INtitle;
                newStray.Breed = INbreed;
                newStray.Type = INtype;
                newStray.UserID = INuserID;
                newStray.DateTimeSeen = date;


                if (token.Equals("token"))
                {
                    query.Add(newStray);
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
                    if (result == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "Failed to add new location";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "New Location added successfullt";
                        model.ErrorList = errors;
                        model.Data = new List<STRAY> { newStray };
                        return model;
                    }
                }
                else
                {
                    StrayModel model = new StrayModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }

            }
        }
    }
}
