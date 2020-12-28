using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using QuanLiNhanKhau_CNPM.AutoMapper;
using QuanLiNhanKhau_CNPM.DAL.Database;
using QuanLiNhanKhau_CNPM.DAL.Repository.UnitOfWork;
using QuanLiNhanKhau_CNPM.Services.ChungMinhThuService;
using QuanLiNhanKhau_CNPM.Services.DinhChinhService;
using QuanLiNhanKhau_CNPM.Services.GiaDinhService;
using QuanLiNhanKhau_CNPM.Services.HoKhauService;
using QuanLiNhanKhau_CNPM.Services.KhaiTuService;
using QuanLiNhanKhau_CNPM.Services.NhanKhauService;
using QuanLiNhanKhau_CNPM.Services.TamTruService;
using QuanLiNhanKhau_CNPM.Services.TamVangService;
using QuanLiNhanKhau_CNPM.Services.ThanhVienCuaHoService;
using QuanLiNhanKhau_CNPM.Services.TieuSuService;
using QuanLiNhanKhau_CNPM.Services.TinhTrangCachLyService;
using QuanLiNhanKhau_CNPM.Services.ToKhaiYTeService;
using QuanLiNhanKhau_CNPM.Services.UserService;

namespace QuanLiNhanKhau_CNPM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AutoMapperConfiguration.Config();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();
            services.AddControllers();

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("project", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Project I",
                    Description = "SOICT",
                    Contact = new OpenApiContact()
                    {
                        Name = "Dang Phu Khang",
                        Email = "dangphukhang2742000@gmail.com"
                    }
                });
            });

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IChungMinhThuService, ChungMinhThuService>();
            services.AddScoped<IDinhChinhService, DinhChinhService>();
            services.AddScoped<IGiaDinhService, GiaDinhService>();
            services.AddScoped<IHoKhauService, HoKhauService>();
            services.AddScoped<IKhaiTuService, KhaiTuService>();
            services.AddScoped<INhanKhauService, NhanKhauService>();
            services.AddScoped<ITamTruService, TamTruService>();
            services.AddScoped<ITamVangService, TamVangService>();
            services.AddScoped<IThanhVienCuaHoService, ThanhVienCuaHoService>();
            services.AddScoped<ITieuSuService, TieuSuService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IToKhaiYTeService, ToKhaiYTeService>();
            services.AddScoped<ITinhTrangCachLyService, ThongKeYTeService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/project/swagger.json", "My API V1");
            });

            DbInitializer.Initialize(context);
        }
    }
}
