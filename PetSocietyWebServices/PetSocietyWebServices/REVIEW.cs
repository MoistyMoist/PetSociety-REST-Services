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
    public partial class REVIEW
    {
        [DataMember(Order = 1)]
        public int ReviewID { get; set; }
        [DataMember(Order = 2)]
        public string Description { get; set; }
        [DataMember(Order = 3)]
        public string Title { get; set; }
        [DataMember(Order = 4)]
        public string Likes { get; set; }
        [DataMember(Order = 5)]
        public string Dislikes { get; set; }
        [DataMember(Order = 6)]
        public string DateCreated { get; set; }
        [DataMember(Order = 7)]
        public string TimeCreated { get; set; }
        [DataMember(Order = 8)]
        public int LocationID { get; set; }
        [DataMember(Order = 9)]
        public int UserID { get; set; }
        [DataMember(Order = 10)]
        public Nullable<int> StrayID { get; set; }

        [DataMember(Order = 11)]
        public virtual LOCATION LOCATION { get; set; }
        [DataMember(Order = 12)]
        public virtual USER USER { get; set; }
        [DataMember(Order = 13)]
        public virtual STRAY STRAY { get; set; }
    }
}
