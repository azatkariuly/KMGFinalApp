using AutoMapper;
using Infrastructure.Data;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;
using Infrastructure.Data.Repo;
using Infrastructure.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FinalProjApi
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
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc();
            services.AddDbContext<MyContext>(opt =>
                opt.UseNpgsql(Configuration.GetConnectionString("MyWebConnection")));
            
            services.AddScoped<IRepo<User>, UserRepo>();
            services.AddScoped<IService<User>, UserService>();

            services.AddScoped<IRepo<Status>, StatusRepo>();
            services.AddScoped<IService<Status>, StatusService>();
            
            services.AddScoped<IRepo<Problem>, ProblemRepo>();
            services.AddScoped<IService<Problem>, ProblemService>();
            
            services.AddScoped<IRepo<History>, HistoryRepo>();
            services.AddScoped<IService<History>, HistoryService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapping());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();
            
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}