using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLKho.Models.Domain;

namespace QLKho.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Kho> kho { get; set; }
        public DbSet<NhaCC> ncc { get; set; }
        public DbSet<NhomSanPham> nhom_san_pham { get; set; }
        public DbSet<SanPham> san_pham { get; set; }
        public DbSet<NhapKho> nhap_kho { get; set; }
        public DbSet<NhapKhoCT> nhap_kho_ct { get; set; }
        /*
         public DbSet<XuatKho> xuat_kho { get; set; }
         public DbSet<XuatKhoCT> xuat_kho_ct { get; set; }*/

    }
}
