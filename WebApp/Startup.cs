using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Plugins.DataStore.InMemory;
using UseCases.BranchUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;
using UseCases.VehicleBodyTypeUseCases;
using WebApp.Data;

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
            services.AddSingleton<WeatherForecastService>();

            // Dependency Injection - In-Memory Data Store
            services.AddScoped<IBranchRepository, BranchInMemoryRepository>();
            services.AddScoped<IVehicleBodyTypeRepository, VehicleBodyTypeInMemoryRepository>();

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
