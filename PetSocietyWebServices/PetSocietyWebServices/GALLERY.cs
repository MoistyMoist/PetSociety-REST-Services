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

    [DataContract(IsReference = true)]
    public partial class GALLERY
    {
        public GALLERY()
        {
            this.EVENTs = new List<EVENT>();
            this.IMAGEs = new List<IMAGE>();
            this.LOCATIONs = new List<LOCATION>();
            this.PETs = new List<PET>();
        }

        [DataMember(Order = 1)]
        public int GalleryID { get; set; }
        [DataMember(Order = 2)]
        public Nullable<int> userID { get; set; }
        [DataMember(Order = 3)]
        public Nullable<int> PetID { get; set; }
        [DataMember(Order = 4)]
        public Nullable<int> LocationID { get; set; }
        [DataMember(Order = 5)]
        public Nullable<int> EventID { get; set; }


        [DataMember(Order = 6)]
        public virtual List<EVENT> EVENTs { get; set; }
        [DataMember(Order = 7)]
        public virtual EVENT EVENT { get; set; }
        [DataMember(Order = 8)]
        public virtual LOCATION LOCATION { get; set; }
        [DataMember(Order = 9)]
        public virtual PET PET { get; set; }
        [DataMember(Order = 10)]
        public virtual USER USER { get; set; }
        [DataMember(Order = 11)]
        public virtual List<IMAGE> IMAGEs { get; set; }
        [DataMember(Order = 12)]
        public virtual List<LOCATION> LOCATIONs { get; set; }
        [DataMember(Order = 13)]
        public virtual List<PET> PETs { get; set; }
    }

}
