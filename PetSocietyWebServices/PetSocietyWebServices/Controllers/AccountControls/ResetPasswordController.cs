using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSocietyWebServices.Controllers.AccountControls
{
    public class ResetPasswordController : ApiController
    {
        [HttpGet]
        public String ResetPassword(String UserID, String INemail, String INpassword)

        {
            //add a new table to store variaction code to a user
            return "password updated";
        }
    }
}
