//==============================================================================//
// Created By   : Lee Kai Quan
// Last Updated : 12/6/2013
// Tested       : YES
//==============================================================================//


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
    public class RetrieveEventController : ApiController
    {
       
        [HttpGet]
        public EventModel retrieveEventByDate(string INtoken, DateTime INstartDateTime, DateTime INendDateTime)
        {
            using(PetSocietyDBEntities db= new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.EVENTs
                            where (c.StartDateTime>=INstartDateTime && c.EndDateTime<=INendDateTime)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<EVENT> OUTevent = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTevent.Count() == 0)
                    {
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "NO events exists";
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTevent;
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

        [HttpGet]
        public EventModel retrieveAllEvent(string INtoken)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.EVENTs
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<EVENT> OUTevent = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTevent.Count() == 0)
                    {
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "NO events exists";
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTevent;
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

        [HttpGet]
        public EventModel retrieveEventByUser(string INtoken, int INuserID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.EVENTs
                            where(c.UserID==INuserID)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<EVENT> OUTevent = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTevent.Count() == 0)
                    {
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "NO events exists";
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTevent;
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

        [HttpGet]
        public EventModel retrieveCurrentEvent(string INtoken, DateTime INtodayDate)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.EVENTs
                            where (c.StartDateTime>=INtodayDate)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<EVENT> OUTevent = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTevent.Count() == 0)
                    {
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "NO events exists";
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTevent;
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

        [HttpGet]
        public EventModel retrieveEventByID(string INtoken, int INeventID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.EVENTs
                            where (c.EventID == INeventID)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<EVENT> OUTevent = query.ToList();
                if (INtoken.Equals("token"))
                {
                    if (OUTevent.Count() == 0)
                    {
                        EventModel model = new EventModel();
                        model.Status = 1;
                        model.Message = "NO events exists";
                        return model;
                    }
                    else
                    {
                        EventModel model = new EventModel();
                        model.Status = 0;
                        model.Message = "Retrieve successfull";
                        model.Data = OUTevent;
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
