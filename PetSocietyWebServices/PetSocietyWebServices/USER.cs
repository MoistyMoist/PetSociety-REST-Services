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
    public partial class USER
    {
        public USER()
        {
            this.FEEDs = new HashSet<FEED>();
            this.PETs = new HashSet<PET>();
        }
        [DataMember(Order = 1)]
        public int UserID { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Email { get; set; }
        [DataMember(Order = 4)]
        public string Birthday { get; set; }
        [DataMember(Order = 5)]
        public string Password { get; set; }
        [DataMember(Order = 6)]
        public string Address { get; set; }
        [DataMember(Order = 7)]
        public string Biography { get; set; }
        [DataMember(Order = 8)]
        public string Privicy { get; set; }
        [DataMember(Order = 9)]
        public string Sex { get; set; }
        [DataMember(Order = 10)]
        public string Contact { get; set; }
        [DataMember(Order = 11)]
        public string Credibility { get; set; }
        [DataMember(Order = 12)]
        public string X { get; set; }
        [DataMember(Order = 13)]
        public string Y { get; set; }
        [DataMember(Order = 14)]
        public Nullable<int> ProfileImageID { get; set; }
        [DataMember(Order = 15)]
        public Nullable<int> PinID { get; set; }
    
        public virtual ICollection<FEED> FEEDs { get; set; }
        public virtual IMAGE IMAGE { get; set; }
        public virtual IMAGE IMAGE1 { get; set; }
        public virtual ICollection<PET> PETs { get; set; }
    }
}
