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
    using System.ComponentModel;
    using System.Collections.ObjectModel;
    
    public partial class LBRelease : INotifyPropertyChanged
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LBRelease()
        {
    		LBImages = new List<LBImage>();
    		Releases = new List<Release>();
        }
    
        private long _iD;
    	public long ID 
    	{ 
    		get { return _iD; } 
    		set { _iD = value; OnPropertyChanged("ID"); } 
    	}
    
        private long _lBGame_ID;
    	public long LBGame_ID 
    	{ 
    		get { return _lBGame_ID; } 
    		set { _lBGame_ID = value; OnPropertyChanged("LBGame_ID"); } 
    	}
    
        private long _region_ID;
    	public long Region_ID 
    	{ 
    		get { return _region_ID; } 
    		set { _region_ID = value; OnPropertyChanged("Region_ID"); } 
    	}
    
        private long _lBPlatform_ID;
    	public long LBPlatform_ID 
    	{ 
    		get { return _lBPlatform_ID; } 
    		set { _lBPlatform_ID = value; OnPropertyChanged("LBPlatform_ID"); } 
    	}
    
        private string _title;
    	public string Title 
    	{ 
    		get { return _title; } 
    		set { _title = value; OnPropertyChanged("Title"); } 
    	}
    
    
        public virtual LBGame LBGame { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<LBImage> LBImages { get; set; }
        public virtual LBPlatform LBPlatform { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Release> Releases { get; set; }
     
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    	
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                WhenPropertyChanged(e);
                PropertyChanged(this, e);
            }
        }
    
        partial void WhenPropertyChanged(PropertyChangedEventArgs e);
        
    }
}
