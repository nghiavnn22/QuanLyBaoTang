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
    
    public partial class HienVat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HienVat()
        {
            this.HienVatXuatNhaps = new HashSet<HienVatXuatNhap>();
        }
    
        public string IDHienVat { get; set; }
        public string TenHV { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<System.DateTime> NgayThem { get; set; }
        public Nullable<System.DateTime> NgaySua { get; set; }
        public string IDDonViCungCap { get; set; }
        public string IDLoaiHienVat { get; set; }
        public string IDKhuVuc { get; set; }
        public string IDBaoCao { get; set; }
        public string DoUuTien { get; set; }
        public string SoLuong { get; set; }
        public string ThongTinKhac { get; set; }
    
        public virtual DonViCungCap DonViCungCap { get; set; }
        public virtual KhuVuc KhuVuc { get; set; }
        public virtual LoaiHienVat LoaiHienVat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HienVatXuatNhap> HienVatXuatNhaps { get; set; }
    }
}
