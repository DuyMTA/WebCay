namespace WenCay.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            FeedBacks = new HashSet<FeedBack>();
            GIOHANGs = new HashSet<GIOHANG>();
            HOADON_CHITIET = new HashSet<HOADON_CHITIET>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        public int? ID { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public int? GiaGoc { get; set; }

        public int? Gia { get; set; }

        public int? SoLuongCon { get; set; }

        public int? MaTheLoai { get; set; }

        [StringLength(50)]
        public string ThongTin { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        [StringLength(50)]
        public string DanhGia { get; set; }

        [StringLength(100)]
        public string Anh { get; set; }

        [StringLength(100)]
        public string Anh1 { get; set; }

        [StringLength(100)]
        public string Anh2 { get; set; }

        [StringLength(100)]
        public string Anh3 { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        [StringLength(20)]
        public string LienQuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON_CHITIET> HOADON_CHITIET { get; set; }

        public virtual THELOAI THELOAI { get; set; }
    }
}
