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
    public partial class EVENT
    {
        public EVENT()
        {
            this.ATTENDEEs = new HashSet<ATTENDEE>();
            this.PINs = new HashSet<PIN>();
        }

        [DataMember(Order = 1)]
        public int EventID { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
        [DataMember(Order = 4)]
        public string Date { get; set; }
        [DataMember(Order = 5)]
        public string Time { get; set; }
        [DataMember(Order = 6)]
        public string Duration { get; set; }
        [DataMember(Order = 7)]
        public string CreatedDate { get; set; }
        [DataMember(Order = 8)]
        public string X { get; set; }
        [DataMember(Order = 9)]
        public string Y { get; set; }
        [DataMember(Order = 10)]
        public string Status { get; set; }
        [DataMember(Order = 11)]
        public string Privacy { get; set; }
        [DataMember(Order = 12)]
        public Nullable<int> PinID { get; set; }
        [DataMember(Order = 13)]
        public int UserID { get; set; }

        [DataMember(Order = 14)]
        public virtual ICollection<ATTENDEE> ATTENDEEs { get; set; }
        [DataMember(Order = 15)]
        public virtual USER USER { get; set; }
        [DataMember(Order = 16)]
        public virtual ICollection<PIN> PINs { get; set; }
    }
}
