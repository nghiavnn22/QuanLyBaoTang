//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Bao_Tang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiHienVat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiHienVat()
        {
            this.HienVats = new HashSet<HienVat>();
        }
    
        public string IDLoaiHienVat { get; set; }
        public string TenLoaiHienVat { get; set; }
        public string DVTinh { get; set; }
        public Nullable<int> KichThuoc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HienVat> HienVats { get; set; }
    }
}
