using Microsoft.EntityFrameworkCore;
using QuanLiNhanKhau_CNPM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiNhanKhau_CNPM.DAL.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<ChungMinhThu> chung_minh_thu { get; set; }
        public DbSet<DinhChinh> dinh_chinh { get; set; }
        public DbSet<GiaDinh> gia_dinh { get; set; }
        public DbSet<HoKhau> ho_khau { get; set; }
        public DbSet<KhaiTu> khai_tu { get; set; }
        public DbSet<NhanKhau> nhan_khau { get; set; }
        public DbSet<TamTru> tam_tru { get; set; }
        public DbSet<TamVang> tam_vang { get; set; }
        public DbSet<ThanhVienCuaHo> thanh_vien_cua_ho { get; set; }
        public DbSet<TieuSu> tieu_su { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<ToKhaiYTe> to_khai_y_te { get; set; }
        public DbSet<ThongKeYTe> thong_ke_y_te { get; set; }
        
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-QQ4A2OU; initial catalog=Project1; persist security info=True; user id=sa; password=12;");
        }
        */
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }
}
