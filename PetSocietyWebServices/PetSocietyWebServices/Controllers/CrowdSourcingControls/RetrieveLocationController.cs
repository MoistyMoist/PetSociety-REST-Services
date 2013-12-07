﻿using System;
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
    public class RetrieveLocationController : ApiController
    {
        [HttpGet]
        public LocationModel RetrieveLocationByID(string INtoken, int INlocationID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("USER")
                            where c.LocationID==INlocationID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocation = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlocation.Count() == 0)
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlocation;
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

        [HttpGet]
        public LocationModel RetrieveAllLocation(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("USER")
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocation = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlocation.Count() == 0)
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlocation;
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

        [HttpGet]
        public LocationModel RetrieveLocationByType(string INtoken, string INtype)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("USER")
                            where c.Type.Equals(INtype)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocation = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlocation.Count() == 0)
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlocation;
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

        [HttpGet]
        public LocationModel RetrieveLocationByUser(string INtoken, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("USER")
                            where c.UserID==INuserID
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocation = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTlocation.Count() == 0)
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        LocationModel model = new LocationModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTlocation;
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

        [HttpGet]
        public TypeModel RetrieveLocationTypes(string token)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.LOCATIONs.Include("USER")
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<LOCATION> OUTlocation = query.ToList();
 

                if (token.Equals("token"))
                {
                    if (OUTlocation.Count() == 0)
                    {
                        TypeModel model = new TypeModel();
                        model.Status = 1;
                        model.Message = "NO record exists";
                        return model;
                    }
                    else
                    {
                        List<string> list = new List<string>();
                        for (int i = 0; i < OUTlocation.Count(); i++)
                        {
                            if (!list.Contains(OUTlocation[i].Type))
                            {
                                list.Add(OUTlocation[i].Type);
                            }
                        }
                        TypeModel model = new TypeModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = list;
                        return model;
                    }
                }
                else
                {
                    TypeModel model = new TypeModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
    }
}
