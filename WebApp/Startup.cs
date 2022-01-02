using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Plugins.DataStore.InMemory;
using UseCases.BranchUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelsUseCaseInterfaces;
using UseCases.VehicleBodyTypeUseCases;
using UseCases.VehicleModelUseCases;
using WebApp.Swagger;

namespace WebApp
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
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddControllers();

            // Swagger
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Car Rental API", Version = "v1" });
            });

            // Dependency Injection - In-Memory Data Store
            services.AddScoped<IBranchRepository, BranchInMemoryRepository>();
            services.AddScoped<IVehicleBodyTypeRepository, VehicleBodyTypeInMemoryRepository>();
            services.AddScoped<IVehicleModelRepository, VehicleModelInMemoryRepository>();

            // Dependency Injection - Use Cases and Repositories
            // Branches
            services.AddTransient<IViewBranchesUseCase, ViewBranchesUseCase>();
            services.AddTransient<IAddBranchUseCase, AddBranchUseCase>();
            services.AddTransient<IEditBranchUseCase, EditBranchUseCase>();
            services.AddTransient<IGetBranchByIdUseCase, GetBranchByIdUseCase>();
            services.AddTransient<IDeleteBranchUseCase, DeleteBranchUseCase>();
            // Vehicle Body Types
            services.AddTransient<IViewVehicleBodyTypesUseCase, ViewVehicleBodyTypesUseCase>();
            services.AddTransient<IAddVehicleBodyTypeUseCase, AddVehicleBodyTypeUseCase>();
            services.AddTransient<IEditVehicleBodyTypeUseCase, EditVehicleBodyTypeUseCase>();
            services.AddTransient<IGetVehicleBodyTypeByIdUseCase, GetVehicleBodyTypeByIdUseCase>();
            services.AddTransient<IDeleteVehicleBodyTypeUseCase, DeleteVehicleBodyTypeUseCase>();
            // Vehicle Models
            services.AddTransient<IViewVehicleModelsUseCase, ViewVehicleModelsUseCase>();
            services.AddTransient<IAddVehicleModelUseCase, AddVehicleModelUseCase>();
            services.AddTransient<IEditVehicleModelUseCase, EditVehicleModelUseCase>();
            services.AddTransient<IGetVehicleModelByIdUseCase, GetVehicleModelByIdUseCase>();
            services.AddTransient<IDeleteVehicleModelUseCase, DeleteVehicleModelUseCase>();
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

            app.UseRouting();

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
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
