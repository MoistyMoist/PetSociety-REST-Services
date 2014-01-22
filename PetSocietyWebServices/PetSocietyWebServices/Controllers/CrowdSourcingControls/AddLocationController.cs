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
    public class AddLocationController : ApiController
    {
        [HttpGet]
        public LocationModel CreateLocation(string token,double INX, double INy, string INdescription, string INtitle, string INaddress, string INtype, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                DateTime date = DateTime.Now;

                var query = db.LOCATIONs;
                List<LOCATION> OUTProducts = query.ToList();

                LOCATION newlocation = new LOCATION();
                newlocation.X = INX;
                newlocation.Y = INy;
                newlocation.Description = INdescription;
                newlocation.Title = INtitle;
                newlocation.Address = INaddress;
                newlocation.Type = INtype;
                newlocation.UserID = INuserID;
                newlocation.DateTimeCreated = date;


                if (token.Equals("token"))
                {
                    query.Add(newlocation);
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
                        model.Message = "New Location added successfullt";
                        model.ErrorList = errors;
                        model.Data = new List<LOCATION> { newlocation };
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
