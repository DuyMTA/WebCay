namespace WenCay.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAIVIET")]
    public partial class BAIVIET
    {
        [Key]
        [StringLength(50)]
        public string MaBV { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        public int? MaAD { get; set; }

        [StringLength(50)]
        public string TieuDe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(50)]
        public string TenNguoiViet { get; set; }

        [StringLength(50)]
        public string LoiDan { get; set; }

        public virtual ADMIN ADMIN { get; set; }
    }
}
