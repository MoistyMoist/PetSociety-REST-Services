﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSocietyWebServices.Models
{
    public class PetModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<PET> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public PetModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}