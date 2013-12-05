﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSocietyWebServices.Models
{
    public class AttendeeModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public List<ATTENDEE> Data { get; set; }
        public List<string> ErrorList { get; set; }


        public AttendeeModel()
        {
            this.Status = 0;
            this.Message = "";
            this.Data = null;
            this.ErrorList = null;
        }
    }
}