//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Robin
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSTEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSTEM()
        {
            this.ROMs = new HashSet<ROM>();
        }
    
        public long systemID { get; set; }
        public string systemName { get; set; }
        public string systemShortName { get; set; }
        public Nullable<long> systemHeaderSizeBytes { get; set; }
        public Nullable<long> systemHashless { get; set; }
        public Nullable<long> systemHeader { get; set; }
        public string systemSerial { get; set; }
        public string systemOEID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROM> ROMs { get; set; }
    }
}
