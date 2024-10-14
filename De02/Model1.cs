using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De02
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DBProductContext")
        {
        }

        public virtual DbSet<tbl_LoaiSP> tbl_LoaiSP { get; set; }
        public virtual DbSet<tbl_SanPham> tbl_SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_LoaiSP>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_LoaiSP>()
                .HasMany(e => e.tbl_SanPham)
                .WithRequired(e => e.tbl_LoaiSP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_SanPham>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
