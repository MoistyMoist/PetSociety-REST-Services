using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetSocietyWebServices;
using System.Runtime.Serialization;

   
namespace PetSocietyWebServices.Models
{
    public class UserModel
    {


        public int Status { get; set; }
        public string Message { get; set; }
        public List<USER> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public UserModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}