// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.DataStore.SQL.Data;

namespace Plugins.DataStore.SQL.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    [Migration("20220104135326_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CoreBusiness.FleetVehicle", b =>
                {
                    b.Property<string>("FleetVehicleLicensePlate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CurrentBranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaintenanceOdometer")
                        .HasColumnType("int");

                    b.Property<int>("ModelVehicleId")
                        .HasColumnType("int");

                    b.Property<int>("Odometer")
                        .HasColumnType("int");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FleetVehicleLicensePlate");

                    b.HasIndex("ModelVehicleId");

                    b.ToTable("FleetVehicles");

                    b.HasData(
                        new
                        {
                            FleetVehicleLicensePlate = "GD19791",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 1,
                            Odometer = 345,
                            Vin = "7A8NPS1E0XBJD3395"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "GD23372",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            ModelVehicleId = 2,
                            Odometer = 29200,
                            Vin = "8AWT9NYH431RU0111"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "GD38400",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 3,
                            Odometer = 5000,
                            Vin = "VF68LSKN8ZTBW4537"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW81713",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 1,
                            Odometer = 345,
                            Vin = "99A5M70K4EB5H2412"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW21759",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            ModelVehicleId = 2,
                            Odometer = 29200,
                            Vin = "YK1AA77X0TCNZ4856"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW51732",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 3,
                            Odometer = 5000,
                            Vin = "ZGARLKYE2NJM55700"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR14805",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 1,
                            Odometer = 345,
                            Vin = "PR8T6WML9KN3V3570"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR14819",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            ModelVehicleId = 2,
                            Odometer = 29200,
                            Vin = "U5YX3MFX0CA4Y2611"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR17430",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 3,
                            Odometer = 5000,
                            Vin = "SFDBSG9D24BNT5233"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR19676",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 1,
                            Odometer = 345,
                            Vin = "1NENUTEL5FABF3880"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR27495",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            ModelVehicleId = 2,
                            Odometer = 29200,
                            Vin = "2HMM5P9Z8F9JW7622"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR37442",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            ModelVehicleId = 3,
                            Odometer = 5000,
                            Vin = "5N13BMGT1NLC85021"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Reservation", b =>
                {
                    b.Property<Guid>("ReservationGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeName")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FleetVehicleLicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservationGuid");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CoreBusiness.Transfer", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FleetVehicleLicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransferId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("CoreBusiness.VehicleBodyType", b =>
                {
                    b.Property<int>("VehicleBodyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleBodyTypeId");

                    b.ToTable("VehicleBodyTypes");
                });

            modelBuilder.Entity("CoreBusiness.VehicleModel", b =>
                {
                    b.Property<int>("VehicleModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AutomaticGearbox")
                        .HasColumnType("bit");

                    b.Property<int>("BaseDailyPrice")
                        .HasColumnType("int");

                    b.Property<string>("BodyTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horsepower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleModelId");

                    b.ToTable("VehicleModels");

                    b.HasData(
                        new
                        {
                            VehicleModelId = 1,
                            AutomaticGearbox = false,
                            BaseDailyPrice = 95,
                            BodyTypeName = "hatchback",
                            Doors = 3,
                            EngineType = "petrol",
                            Horsepower = "72",
                            Make = "Toyota",
                            Model = "Aygo",
                            ModelYear = "2018",
                            Seats = 4,
                            Segment = "A"
                        },
                        new
                        {
                            VehicleModelId = 2,
                            AutomaticGearbox = true,
                            BaseDailyPrice = 112,
                            BodyTypeName = "hatchback",
                            Doors = 5,
                            EngineType = "hybrid",
                            Horsepower = "116",
                            Make = "Toyota",
                            Model = "Yaris",
                            ModelYear = "2020",
                            Seats = 5,
                            Segment = "B"
                        },
                        new
                        {
                            VehicleModelId = 3,
                            AutomaticGearbox = true,
                            BaseDailyPrice = 149,
                            BodyTypeName = "sedan",
                            Doors = 5,
                            EngineType = "hybrid",
                            Horsepower = "184",
                            Make = "Toyota",
                            Model = "Corolla",
                            ModelYear = "2018",
                            Seats = 5,
                            Segment = "C"
                        });
                });

            modelBuilder.Entity("CoreBusiness.FleetVehicle", b =>
                {
                    b.HasOne("CoreBusiness.VehicleModel", "VehicleModel")
                        .WithMany("FleetVehicles")
                        .HasForeignKey("ModelVehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("CoreBusiness.VehicleModel", b =>
                {
                    b.Navigation("FleetVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
