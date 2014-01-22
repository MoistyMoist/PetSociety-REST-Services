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
    public class ReportLostController : ApiController
    {
       [HttpGet]
        public LostModel createlost(string token,string INdateTimeSeen, string INaddress, string INDescription, double INx, double INy, string INfound, string INreward, int INpetID, int INuserID)
       {
           using (PetSocietyDBEntities db = new PetSocietyDBEntities())
           {
               int result = 0;
               List<string> errors = new List<string>();
               db.Configuration.LazyLoadingEnabled = false;
               db.Configuration.ProxyCreationEnabled = false;

               DateTime date = DateTime.Now;

               var query = db.LOSTs;
               List<LOST> OUTProducts = query.ToList();

               LOST newLostReport = new LOST();
               newLostReport.DateTimeSeen = INdateTimeSeen;
               newLostReport.Address = INaddress;
               newLostReport.Description = INDescription;
               newLostReport.X = INx;
               newLostReport.Y = INy;
               newLostReport.Found = INfound;
               newLostReport.Reward = INreward;
               newLostReport.UserID = INuserID;
               newLostReport.PetID = INpetID;
               newLostReport.DateTimeCreated = date;



               if (token.Equals("token"))
               {
                   query.Add(newLostReport);
                   try
                   {
                       result = db.SaveChanges();
                   }
                   catch (DbEntityValidationException dbEx)
                   {
                       result = 0;
                       foreach (var validationErrors in dbEx.EntityValidationErrors)
                       {
                           foreach (var validationError in validationErrors.ValidationErrors)
                           {
                               string error = "Property: " + validationError.PropertyName + "Error: " + validationError.ErrorMessage;
                               errors.Add(error);
                               System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                           }
                       }
                   }
                   if (result == 0)
                   {
                       LostModel model = new LostModel();
                       model.Status = 1;
                       model.Message = "Failed to add Lost Report";
                       model.ErrorList = errors;
                       model.Data = null;
                       return model;
                   }
                   else
                   {
                       LostModel model = new LostModel();
                       model.Status = 0;
                       model.Message = "Lost Report added successfullt";
                       model.ErrorList = errors;
                       model.Data = new List<LOST> { newLostReport };
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
