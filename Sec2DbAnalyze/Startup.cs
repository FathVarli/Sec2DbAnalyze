using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Sec2DbAnalyze.AppSettings;
using Sec2DbAnalyze.Helper.Mapper;
using Sec2DbAnalyze.Helper.Mapper.Mapster;
using Sec2DbAnalyze.Persistence.Context;
using Sec2DbAnalyze.Persistence.Repository.Abstract.App;
using Sec2DbAnalyze.Persistence.Repository.Base;
using Sec2DbAnalyze.Persistence.Repository.Concrete.App;
using Sec2DbAnalyze.Persistence.UnitOfWork;
using Sec2DbAnalyze.ServiceLayer.Log;
using Sec2DbAnalyze.ServiceLayer.Mock;
using Sec2DbAnalyze.ServiceLayer.Test;


namespace Sec2DbAnalyze
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sec2DbAnalyze", Version = "v1" });
            });
            
            #region AppSettings Configuration

            services.Configure<AppSetting>(Configuration);
            var appSettings = Configuration.GetSection(nameof(AppSetting)).Get<AppSetting>();
            services.AddSingleton(appSettings);

            #endregion
            
            services.AddDbContext<ProjectDbContext>(ServiceLifetime.Scoped);
            services.AddDbContext<PartitionDbContext>();
            services.AddScoped(typeof(IGenericRepository<,,>), typeof(GenericRepository<,,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMapperAdapter, MapsterAdapter>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IIdentityRepository, IdentityRepository>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<IUserProfileRepository, UserProfileRepository>();
            services.AddScoped<IUserSectionRepository, UserSectionRepository>();
            services.AddScoped<IIdentitySectionRepository, IdentitySectionRepository>();
            services.AddScoped<IUserPartitionRepository, UserPartitionRepository>();
            services.AddScoped<IIdentityPartitionRepository, IdentityPartitionRepository>();

            services.AddScoped<ILogService, LogService>();
            services.AddScoped<IMockService, MockService>();
            services.AddScoped<ITestService, TestService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sec2DbAnalyze v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}