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
    public class RetrieveReviewController : ApiController
    {
        [HttpGet]
        public ReviewModel RetrieveAllReview(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs.Include("USER")
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreview = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTreview.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTreview;
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

        [HttpGet]
        public ReviewModel RetrieveReviewByID(string INtoken, int INreviewID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs.Include("USER")
                            where c.ReviewID==INreviewID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreview = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTreview.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTreview;
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
        
        [HttpGet]
        public ReviewModel RetrieveReviewByUserID(string INtoken, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs.Include("USER")
                            where c.UserID==INuserID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreview = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTreview.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTreview;
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

        [HttpGet]
        public ReviewModel RetrieveReviewByLocationID(string INtoken, int INlocationID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs.Include("USER")
                            where c.LocationID==INlocationID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreview = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTreview.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTreview;
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

        [HttpGet]
        public ReviewModel RetrieveReviewByStrayID(string INtoken, int INstrayID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.REVIEWs.Include("USER")
                            where c.StrayID==INstrayID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<REVIEW> OUTreview = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTreview.Count() == 0)
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        ReviewModel model = new ReviewModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTreview;
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
