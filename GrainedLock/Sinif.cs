//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrainedLock
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinif
    {
        public Sinif()
        {
            this.Ders = new HashSet<Ders>();
        }
    
        public int SinifId { get; set; }
        public string SinifAdi { get; set; }
    
        public virtual ICollection<Ders> Ders { get; set; }
    }
}
