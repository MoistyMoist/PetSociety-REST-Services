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
    public partial class EVENT
    {
        public EVENT()
        {
            this.ATTENDEEs = new HashSet<ATTENDEE>();
            this.GALLERies = new HashSet<GALLERY>();
        }

        [DataMember(Order = 1)]
        public int EventID { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
        [DataMember(Order = 4)]
        public System.DateTime StartDateTime { get; set; }
        [DataMember(Order = 5)]
        public System.DateTime EndDateTime { get; set; }
        [DataMember(Order = 6)]
        public System.DateTime DateTimeCreated { get; set; }
        [DataMember(Order = 7)]
        public double X { get; set; }
        [DataMember(Order = 8)]
        public double Y { get; set; }
        [DataMember(Order = 9)]
        public Nullable<int> Status { get; set; }
        [DataMember(Order = 10)]
        public Nullable<int> Privacy { get; set; }
        [DataMember(Order = 11)]
        public Nullable<int> GalleryID { get; set; }
        [DataMember(Order = 12)]
        public int UserID { get; set; }


        [DataMember(Order = 13)]
        public virtual ICollection<ATTENDEE> ATTENDEEs { get; set; }
        [DataMember(Order = 14)]
        public virtual GALLERY GALLERY { get; set; }
        [DataMember(Order = 15)]
        public virtual USER USER { get; set; }
        [DataMember(Order = 16)]    
        public virtual ICollection<GALLERY> GALLERies { get; set; }
    }

}
