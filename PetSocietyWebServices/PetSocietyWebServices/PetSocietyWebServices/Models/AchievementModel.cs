﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSocietyWebServices.Models
{
    public class AchievementModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<ACHIEVEMENT> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public AchievementModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}