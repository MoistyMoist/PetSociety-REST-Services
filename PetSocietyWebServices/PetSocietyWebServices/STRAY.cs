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
    
    public partial class STRAY
    {
        public STRAY()
        {
            this.REVIEWs = new HashSet<REVIEW>();
        }
    
        public int StrayID { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string TimeSeen { get; set; }
        public string DateSeen { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public Nullable<int> ImageID { get; set; }
        public Nullable<int> PinID { get; set; }
        public Nullable<int> ReviewID { get; set; }
        public int UserID { get; set; }
    
        public virtual ICollection<REVIEW> REVIEWs { get; set; }
        public virtual USER USER { get; set; }
    }
}
