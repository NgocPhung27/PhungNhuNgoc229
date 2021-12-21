using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050229.Models
{
    [Table("SanPham")]
    public class PNNSanPham229
    {
        [Key]
        [Display(Name = "Mã Sản Phẩrm")]
        public int MaSanPham { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Tên Sản Phẩm ")]
        [StringLength(50)]
        public string TenSanPham { get; set; }

        [Display(Name = "Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }
        [ForeignKey("MaNhaCungCap")]
        public virtual NhaCungCap229 NhaCungCap229 { get; set; }
    }
}