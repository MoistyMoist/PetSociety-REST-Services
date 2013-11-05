using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSocietyWebServices.Models
{
    public class ReviewModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<REVIEW> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public ReviewModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}