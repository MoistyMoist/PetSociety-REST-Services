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
    public class RetrieveStrayController : ApiController
    {
        [HttpGet]
        public StrayModel RetrieveAllStray(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByID(string INtoken, int INstrayID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where c.StrayID==INstrayID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByUserID(string INtoken, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where c.UserID==INuserID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetriveStrayByDateTimeSeen(string INtoken, DateTime INdateTimeSeen)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where c.DateTimeSeen>=INdateTimeSeen
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByBreed(string INtoken, string INbreed)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where c.Breed.Equals(INbreed)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByType(string INtoken, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where c.Type.Equals(INtype)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByDateTimeSeen_N_Type(string INtoken, string INtype, DateTime INdateTimeSeen)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where (c.Type.Equals(INtype)&& c.DateTimeSeen>=INdateTimeSeen)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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

        [HttpGet]
        public StrayModel RetrieveStrayByDateTimeSeen_N_Type_N_Breed(string INtoken, string INtype, string INbreed, DateTime INdateTimeSeen)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.STRAYs
                            where(c.DateTimeSeen>=INdateTimeSeen && c.Type.Equals(INtype)&& c.Breed.Equals(INbreed))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<STRAY> OUTstray = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTstray.Count() == 0)
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        StrayModel model = new StrayModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTstray;
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
