using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050229.Models
{
    [Table("NhaCungCap")]
    public class NhaCungCap229
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
         public int MaNhaCungCap { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "Tên Nhà Cung Cấp ")]
        [StringLength(50)]
        public string TenNhaCungCap { get; set; }
        }
}