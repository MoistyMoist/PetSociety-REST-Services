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

namespace PetSocietyWebServices.Controllers.EventControls
{
    public class AddEventController : ApiController
    {
        [HttpGet]
        public EventModel AddEvent(string token, string INname, string INdescription, DateTime INstartDateTime, DateTime INendDateTime, double INx, double INy, int INstatus, int INprivacy, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                DateTime date = DateTime.Now;

                var query = db.EVENTs;
                List<EVENT> OUTProducts = query.ToList();

                EVENT newEvent = new EVENT();
                newEvent.Name = INname;
                newEvent.Description = INdescription;
                newEvent.StartDateTime = INstartDateTime;
                newEvent.EndDateTime = INendDateTime;
                newEvent.X = INx;
                newEvent.Y = INy;
                newEvent.Status = INstatus;
                newEvent.Privacy = INprivacy;
                newEvent.UserID = INuserID;
                newEvent.DateTimeCreated = date;

                if (token.Equals("token"))
                {
                    query.Add(newEvent);
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
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "Failed to add new event";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "New Event added successfullt";
                        model.ErrorList = errors;
                        model.Data = new List<EVENT> { newEvent };
                        return model;
                    }
                }
                else
                {
                    EventModel model = new EventModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }


            }
        }

    }
}
