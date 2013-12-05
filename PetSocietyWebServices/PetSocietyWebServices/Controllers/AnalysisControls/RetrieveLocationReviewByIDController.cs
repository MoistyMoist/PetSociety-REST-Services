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

namespace PetSocietyWebServices.Controllers.AnalysisControls
{
    public class RetrieveLocationReviewByIDController : ApiController
    {
        [HttpGet]
        public ReviewModel getlocationReviewsByLocationID(String token, int INlocationID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = true;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs
                            where (c.LocationID==INlocationID)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreviews = query.ToList();

          
                if (token.Equals("token"))
                {
                    if (OUTreviews.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "No reviews exists.";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTreviews;
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
