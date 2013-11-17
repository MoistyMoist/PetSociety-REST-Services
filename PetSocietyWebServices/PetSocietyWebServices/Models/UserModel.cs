﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetSocietyWebServices;
using System.Runtime.Serialization;

   
namespace PetSocietyWebServices.Models
{
    [DataContract(IsReference=true)]
    public class UserModel
    {

        [DataMember(Order = 1)]
        public int Status { get; set; }
        [DataMember(Order = 2)]
        public string Message { get; set; }
        [DataMember(Order = 3)]
        public List<USER> Data { get; set; }
        [DataMember(Order = 4)]
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