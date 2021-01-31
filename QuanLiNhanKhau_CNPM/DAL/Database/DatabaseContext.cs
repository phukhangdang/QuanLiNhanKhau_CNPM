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
        public DbSet<NhanKhau> nhan_khau { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<ToKhaiYTe> to_khai_y_te { get; set; }
        public DbSet<ThongKeYTe> thong_ke_y_te { get; set; }
        public DbSet<TiepXuc> tiep_xuc { get; set; }
        
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
