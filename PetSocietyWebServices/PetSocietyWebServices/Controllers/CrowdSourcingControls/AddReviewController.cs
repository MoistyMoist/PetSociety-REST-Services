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
    public class AddReviewController : ApiController
    {
        [HttpGet]
        public ReviewModel CreateReview(string Intoken, int INlocationID, int INstrayID, string INdescription, string INtitle, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {

                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                DateTime date = DateTime.Now;

                var query = db.REVIEWs;
                List<REVIEW> OUTReview = query.ToList();

                REVIEW newReview = new REVIEW();
                newReview.Description = INdescription;
                newReview.Dislikes = "0";
                newReview.Likes = "0";
                newReview.Title = INtitle;
                newReview.DateTimeCreated = date;
                newReview.UserID = INuserID;
                if (INstrayID != null || !INstrayID.Equals(""))
                    newReview.StrayID = INstrayID;
                if(INlocationID!=null||!INlocationID.Equals(""))
                    newReview.LocationID = INlocationID;


                if (Intoken.Equals("token"))
                {
                    query.Add(newReview);
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
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "Failed to add new review";
                        model.ErrorList = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "New review added successfullt";
                        model.ErrorList = errors;
                        model.Data = new List<REVIEW> { newReview };
                        return model;
                    }
                }
                else
                {
                    ReviewModel model = new ReviewModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }

            }
        }
    }
}
