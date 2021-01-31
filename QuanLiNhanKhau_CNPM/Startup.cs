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
using QuanLiNhanKhau_CNPM.Services.LoginService;
using QuanLiNhanKhau_CNPM.Services.NhanKhauService;
using QuanLiNhanKhau_CNPM.Services.ThongKeService;
using QuanLiNhanKhau_CNPM.Services.TiepXucService;
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
                    Title = "Quản lí y tế",
                    Description = "Nhóm 06",
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
            services.AddScoped<INhanKhauService, NhanKhauService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IToKhaiYTeService, ToKhaiYTeService>();
            services.AddScoped<IThongKeYTeService, ThongKeYTeService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ITiepXucService, TiepXucService>();
            services.AddScoped<IThongKeService, ThongKeService>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllOrigins",
                    builder =>
                    {
                        builder.AllowAnyHeader()
                               .AllowAnyOrigin()
                               .AllowAnyMethod();
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DatabaseContext context)
        {
            app.UseCors("AllOrigins");

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
