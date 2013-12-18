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

namespace PetSocietyWebServices.Controllers.LostControls
{
    public class RetrieveLostController : ApiController
    {
        [HttpGet]
        public LostModel RetrieveAllLost(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER").Include("PET")
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByID (string INtoken, int INlostID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where(c.LostID==INlostID)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByFound(string INtoken, char INfound)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.Found.Equals(INfound))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }            
        }

        [HttpGet]
        public LostModel RetrieveLostByDate(string INtoken, DateTime INdateTimeCreated)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.DateTimeCreated>=INdateTimeCreated)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
        
        [HttpGet]
        public LostModel RetrieveLostByType(string INtoken, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.PET.Type.Equals(INtype))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByFound_N_Date(string INtoken, char INfound, DateTime INdateTimeCreated)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.Found.Equals(INfound)&& c.DateTimeCreated>=INdateTimeCreated)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByFound_N_Type(string INtoken, char INfound, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.Found.Equals(INfound)&&c.PET.Type.Equals(INtype))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByDate_N_Type(string INtoken, DateTime INdateTimeCreated, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.PET.Type.Equals(INtype)&& c.DateTimeCreated>=INdateTimeCreated)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public LostModel RetrieveLostByDate_N_Found_N_Type(string INtoken, DateTime INdateTimeCreated, char INfound, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOSTs.Include("USER")
                            where (c.DateTimeCreated>=INdateTimeCreated && c.Found.Equals(INfound) && c.PET.Type.Equals(INtype))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOST> OUTlost = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlost.Count() == 0)
                    {
                        LostModel model = new LostModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LostModel model = new LostModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlost;
                        return model;
                    }
                }
                else
                {
                    LostModel model = new LostModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
    }
}
