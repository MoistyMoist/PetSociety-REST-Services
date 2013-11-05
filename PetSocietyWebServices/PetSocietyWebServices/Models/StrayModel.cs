using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSocietyWebServices.Models
{
    public class StrayModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<STRAY> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public StrayModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}