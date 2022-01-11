using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Plugins.DataStore.SQL;
using Plugins.IdentityStore.SQL;
using UseCases.BranchUseCases;
using UseCases.CustomerUseCases;
using UseCases.DataStorePluginInterfaces;
using UseCases.FleetVehicleUseCases;
using UseCases.IdentityStoreUseCaseInterfaces;
using UseCases.ReservationUseCases;
using UseCases.UseCaseInterfaces.BranchUseCaseInterfaces;
using UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;
using UseCases.UseCaseInterfaces.UserUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleBodyTypeUseCaseInterfaces;
using UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces;
using UseCases.UserUseCases;
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

            services.AddHttpContextAccessor();

            // Identity
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", p => p.RequireClaim("Position", "Admin"));
                options.AddPolicy("LogisticianOnly", p => p.RequireClaim("Position", "Logistician"));
                options.AddPolicy("AgentOnly", p => p.RequireClaim("Position", "Agent"));
                options.AddPolicy("CustomerOnly", p => p.RequireClaim("Position", "Customer"));
                options.AddPolicy("AdminLogisticianOnly", p => p.RequireClaim("Position", "Admin", "Logistician"));
                options.AddPolicy("EmployeeOnly", p => p.RequireClaim("Position", "Admin", "Logistician", "Agent"));
            });

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

            // Dependency injection - Identity Store
            services.AddScoped<IUserRepository, UserRepository>();

            // Dependency Injection - Use Cases and Repositories
            // Branches
            services.AddTransient<IAddBranchUseCase, AddBranchUseCase>();
            services.AddTransient<IDeleteBranchUseCase, DeleteBranchUseCase>();
            services.AddTransient<IEditBranchUseCase, EditBranchUseCase>();
            services.AddTransient<IGetBranchByIdUseCase, GetBranchByIdUseCase>();
            services.AddTransient<IViewBranchesUseCase, ViewBranchesUseCase>();
            // Customers
            services.AddTransient<IAddCustomerUseCase, AddCustomerUseCase>();
            services.AddTransient<IDeleteCustomerUseCase, DeleteCustomerUseCase>();
            services.AddTransient<IEditCustomerUseCase, EditCustomerUseCase>();
            services.AddTransient<IGetCustomerByGuidUseCase, GetCustomerByGuidUseCase>();
            services.AddTransient<IViewCustomersUseCase, ViewCustomersUseCase>();
            // Fleet Vehicles
            services.AddTransient<IAddFleetVehicleUseCase, AddFleetVehicleUseCase>();
            services.AddTransient<IDeleteFleetVehicleUseCase, DeleteFleetVehicleUseCase>();
            services.AddTransient<IEditFleetVehicleUseCase, EditFleetVehicleUseCase>();
            services.AddTransient<IGetFleetVehicleByLicensePlateUseCase, GetFleetVehicleByLicensePlate>();
            services.AddTransient<IGetFleetVehiclesMaintenanceDateUseCase, GetFleetVehiclesMaintenanceDateUseCase>();
            services.AddTransient<IGetFleetVehiclesMaintenanceOdometerUseCase, GetFleetVehiclesMaintenanceOdometerUseCase>();
            services.AddTransient<IViewFleetVehiclesUseCase, ViewFleetVehiclesUseCase>();
            //Reservations
            services.AddTransient<IAddReservationUseCase, AddReservationUseCase>();
            services.AddTransient<IDeleteReservationUseCase, DeleteReservationUseCase>();
            services.AddTransient<IEditReservationUseCase, EditReservationUseCase>();
            services.AddTransient<IGetReservationByGuidUseCase, GetReservationByGuidUseCase>();
            services.AddTransient<IGetReservationPriceUseCase, GetReservationPriceUseCase>();
            services.AddTransient<IViewReservationsUseCase, ViewReservationsUseCase>();
            // Vehicle Body Types
            services.AddTransient<IAddVehicleBodyTypeUseCase, AddVehicleBodyTypeUseCase>();
            services.AddTransient<IDeleteVehicleBodyTypeUseCase, DeleteVehicleBodyTypeUseCase>();
            services.AddTransient<IEditVehicleBodyTypeUseCase, EditVehicleBodyTypeUseCase>();
            services.AddTransient<IGetVehicleBodyTypeByIdUseCase, GetVehicleBodyTypeByIdUseCase>();
            services.AddTransient<IViewVehicleBodyTypesUseCase, ViewVehicleBodyTypesUseCase>();
            // Vehicle Models
            services.AddTransient<IAddVehicleModelUseCase, AddVehicleModelUseCase>();
            services.AddTransient<IDeleteVehicleModelUseCase, DeleteVehicleModelUseCase>();
            services.AddTransient<IEditVehicleModelUseCase, EditVehicleModelUseCase>();
            services.AddTransient<IGetVehicleModelByIdUseCase, GetVehicleModelByIdUseCase>();
            services.AddTransient<IGetVehicleModelByLicensePlateUseCase, GetVehicleModelByLicensePlateUseCase>();
            services.AddTransient<IViewVehicleModelsUseCase, ViewVehicleModelsUseCase>();
            //Users
            services.AddTransient<IGetCurrentUserGuidUseCase, GetCurrentUserGuidUseCase>();
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

            // Identity
            app.UseAuthentication();
            app.UseAuthorization();

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

                // Controllers
                endpoints.MapControllers();

                // Identity
                endpoints.MapRazorPages();
            });
        }
    }
}
