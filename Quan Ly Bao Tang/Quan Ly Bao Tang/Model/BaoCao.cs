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
    
    public partial class BaoCao
    {
        public string IDBaoCao { get; set; }
        public string TenBaoCao { get; set; }
        public Nullable<System.DateTime> NgayBaoCao { get; set; }
        public string NhanVienBaoCao { get; set; }
        public string MaXuatNhapHienVat { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
