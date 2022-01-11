using CarRental_UI.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Plugins.DataStore.SQL;
using Plugins.DataStore.SQL.Data;
using UseCases.DataStorePluginInterfaces;

namespace CarRental_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => 
                    builder.WithOrigins("https://localhost:5005", "http://localhost:5006").AllowAnyHeader().AllowAnyMethod());
            });

            services.AddControllers();

            services.Configure<RazorPagesOptions>(options =>
                options.RootDirectory = "/Pages");

            // Car Rental Database
            services.AddDbContext<CarRentalContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultDbConnection"));
            });

            // Swagger
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Car Rental API", Version = "v1" });
            });

            // Dependency Injection - Data Store
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IFleetVehicleRepository, FleetVehicleRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IVehicleModelRepository, VehicleModelRepository>();
            services.AddScoped<IVehicleBodyTypeRepository, VehicleBodyTypeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseCors("Open");

            // Swagger
            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
            app.UseSwagger(option => { option.RouteTemplate = swaggerOptions.JsonRoute; });
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(swaggerOptions.UIEndpoint,
                    swaggerOptions.Description);
            });

            app.UseEndpoints(endpoints =>
            {
                // Controllers
                endpoints.MapControllers();
            });
        }
    }
}
