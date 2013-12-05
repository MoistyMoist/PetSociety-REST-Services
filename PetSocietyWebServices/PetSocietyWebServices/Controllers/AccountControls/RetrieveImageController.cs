using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net.Mail;
using PetSocietyWebServices.Models;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class RetrieveImageController : ApiController
    {
        [HttpGet]
        public ImageModel retrieveImage(String token, int INimageID, int INuserID, int INpetID)
        {
            using (PetSocietyDBEntities db = new PetSocietyDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                //LOAD THE QUERY
                var query = from c in db.IMAGEs
                            where (c.GalleryID == INimageID || c.ImageID == INuserID)
                            select c;

                //CONVERT THE RESULT TO A LIST
                List<IMAGE> OUTImage = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTImage.Count() == 0)
                    {
                        ImageModel model = new ImageModel();
                        model.Status = 1;
                        model.Message = "No such image exists. please create one if needed or check again";
                        return model;
                    }
                    else
                    {
                        ImageModel model = new ImageModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTImage;
                        return model;
                    }
                }
                else
                {
                    ImageModel model = new ImageModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
               
            }
        }
    }
}
