using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050229.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public DbSet<NhaCungCap229> NhaCungCaps{ get; set; }
        public DbSet<PNNSanPham229> PNNSanPham229s { get; set; }
        public DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<LTQL_1721050229.Models.PNNSanPham229> PNNSanPham229 { get; set; }
    }
}
