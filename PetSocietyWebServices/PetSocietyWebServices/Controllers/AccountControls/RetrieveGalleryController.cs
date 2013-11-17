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
    public class RetrieveGalleryController : ApiController
    {
        [HttpGet]
        public GalleryModel retrieveGallery(String token,int INgalleryID, int INuserID, int INpetID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.GALLERies.Include("Images")
                            where (c.GalleryID==INgalleryID || c.UserID==INuserID || c.PetID==INpetID)
                            select c;

                 //CONVERT THE RESULT TO A LIST
                List<GALLERY> OUTgallery = query.ToList();
                if(token.Equals("token"))
                {
                    if (OUTgallery.Count() == 0)
                    {
                        GalleryModel model = new GalleryModel();
                        model.Status = 1;
                        model.Message = "No such gallery exists. please create one if needed or check again";
                        return model;
                    }
                    else
                    {
                        GalleryModel model = new GalleryModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTgallery;
                        return model;
                    } 
                }
                else
                {
                    GalleryModel model = new GalleryModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;   
                }
               
            }

        }
    }
}
