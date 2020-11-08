namespace WenCay.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedBack")]
    public partial class FeedBack
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string IDKhachHang { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
