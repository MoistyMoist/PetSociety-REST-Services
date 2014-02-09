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
    public class UpdateLocationController : ApiController
    {
        [HttpGet]
        public LocationModel UpateLocation(string token,int INlocationID, String INimageURL)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = true;
                db.Configuration.ProxyCreationEnabled = true;

                //LOAD THE QUERY
                var query = db.IMAGEs;

                //CONVERT THE RESULT TO A LIST
                
                IMAGE i = new IMAGE();
                i.ImageURL = INimageURL;
                i.Type = INlocationID.ToString();
               

               


                if (token.Equals("token"))
                {
                    query.Add(i);

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
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "Failed to add new location";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "New Location updated successfullt";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                }
                else
                {
                    LocationModel model = new LocationModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }

            }
        }
    }
}
