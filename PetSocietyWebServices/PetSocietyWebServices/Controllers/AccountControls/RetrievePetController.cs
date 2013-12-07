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


namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class RetrievePetController : ApiController
    {
        [HttpGet]
        public PetModel RetrieveAllPet(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
        
        [HttpGet]
        public PetModel RetrievePetByID(string INtoken, int INpetID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where c.PetID==INpetID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
        
        [HttpGet]
        public PetModel RetrievePetByUserID(string INtoken, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where c.UserID==INuserID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public PetModel RetrievePetByType(string INtoken, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where c.Type.Equals(INtype)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public PetModel RetrievePetByBreed(string INtoken, string INbreed)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where c.Breed.Equals(INbreed)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public PetModel RetrievePetByAge(string INtoken, string INage)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where c.Age.Equals(INage)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

        [HttpGet]
        public PetModel RetrievePetByType_N_Breed(string INtoken, string INtype, string INbreed)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.PETs.Include("USER")
                            where (c.Type.Equals(INtype)&& c.Breed.Equals(INbreed))
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<PET> OUTpet = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTpet.Count() == 0)
                    {
                        PetModel model = new PetModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        PetModel model = new PetModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTpet;
                        return model;
                    }
                }
                else
                {
                    PetModel model = new PetModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
    }
}
