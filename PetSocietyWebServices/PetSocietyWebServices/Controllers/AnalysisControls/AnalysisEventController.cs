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
    public class AnalysisEventController : ApiController
    {
        [HttpGet]
        public LocationModel GetEvents(string token)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("Galleries.Images")
                            where (c.Type.Equals("event") || c.Type.Equals("EVENT"))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocations = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTlocations.Count() == 0)
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "Sorry. an error occured";
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "retrieve success";
                        model.Data = OUTlocations;
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
