//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teknik_Servis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLFATURABILGI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLFATURABILGI()
        {
            this.TBLFATURADETAY = new HashSet<TBLFATURADETAY>();
        }
    
        public int id { get; set; }
        public string seri { get; set; }
        public string sirano { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public string saat { get; set; }
        public string vergidairesi { get; set; }
        public Nullable<int> cari { get; set; }
        public Nullable<short> personel { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFATURADETAY> TBLFATURADETAY { get; set; }
    }
}