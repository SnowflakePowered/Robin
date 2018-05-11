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
    
    public partial class LBPlatform
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LBPlatform()
        {
            this.LBGames = new HashSet<LBGame>();
        }
    
        public long ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Developer { get; set; }
        public string Manufacturer { get; set; }
        public string Cpu { get; set; }
        public string Memory { get; set; }
        public string Graphics { get; set; }
        public string Sound { get; set; }
        public string Display { get; set; }
        public string Media { get; set; }
        public string Controllers { get; set; }
        public System.DateTime CacheDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LBGame> LBGames { get; set; }
    }
}
