//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetSocietyWebServices
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract(IsReference = true)]
    public partial class LOST
    {

        [DataMember(Order = 1)]
        public int LostID { get; set; }
        [DataMember(Order = 2)]
        public string Time { get; set; }
        [DataMember(Order = 3)]
        public string Date { get; set; }
        [DataMember(Order = 4)]
        public string Address { get; set; }
        [DataMember(Order = 5)]
        public string Description { get; set; }
        [DataMember(Order = 6)]
        public string X { get; set; }
        [DataMember(Order = 7)]
        public string Y { get; set; }
        [DataMember(Order = 8)]
        public string Found { get; set; }
        [DataMember(Order = 9)]
        public string Reward { get; set; }
        [DataMember(Order = 10)]
        public Nullable<int> PetID { get; set; }
        [DataMember(Order = 11)]
        public int UserID { get; set; }

        [DataMember(Order = 12)]
        public virtual PET PET { get; set; }
        [DataMember(Order = 13)]
        public virtual USER USER { get; set; }
    }
}
