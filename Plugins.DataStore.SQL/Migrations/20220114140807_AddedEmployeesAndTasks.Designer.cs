﻿// <auto-generated />
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
    [Migration("20220114140807_AddedEmployeesAndTasks")]
    partial class AddedEmployeesAndTasks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreBusiness.Assignment", b =>
                {
                    b.Property<string>("AssignmentGuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AssignmentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeGuid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AssignmentGuid");

                    b.HasIndex("AssignmentTypeId");

                    b.HasIndex("EmployeeGuid");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("CoreBusiness.AssignmentType", b =>
                {
                    b.Property<int>("AssignmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssignmentTypeId");

                    b.ToTable("AssignmentTypes");

                    b.HasData(
                        new
                        {
                            AssignmentTypeId = 1,
                            Type = "ReservationStart"
                        },
                        new
                        {
                            AssignmentTypeId = 2,
                            Type = "ReservationEnd"
                        },
                        new
                        {
                            AssignmentTypeId = 3,
                            Type = "Maintenance"
                        },
                        new
                        {
                            AssignmentTypeId = 4,
                            Type = "Transfer"
                        });
                });

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

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            Address = "Szklary 138 80-835 Gdańsk",
                            Name = "Gdańsk"
                        },
                        new
                        {
                            BranchId = 2,
                            Address = "Rozłogi 1 01-323 Warszawa",
                            Name = "Warszawa"
                        },
                        new
                        {
                            BranchId = 3,
                            Address = "Olszanicka 174 30-241 Kraków",
                            Name = "Kraków - Airport"
                        },
                        new
                        {
                            BranchId = 4,
                            Address = "Conrada 63 31-357 Kraków",
                            Name = "Kraków - City"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Customer", b =>
                {
                    b.Property<string>("CustomerGuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrivingLicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalDocumentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerGuid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CoreBusiness.Employee", b =>
                {
                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BranchId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BranchId1")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Guid");

                    b.HasIndex("BranchId1");

                    b.ToTable("Employee");
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

                    b.Property<int>("Odometer")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FleetVehicleLicensePlate");

                    b.HasIndex("CurrentBranchId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("FleetVehicles");

                    b.HasData(
                        new
                        {
                            FleetVehicleLicensePlate = "GD19791",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 345,
                            VehicleModelId = 1,
                            Vin = "7A8NPS1E0XBJD3395"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "GD23372",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            Odometer = 29200,
                            VehicleModelId = 2,
                            Vin = "8AWT9NYH431RU0111"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "GD38400",
                            CurrentBranchId = 1,
                            DateAdded = new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 5000,
                            VehicleModelId = 3,
                            Vin = "VF68LSKN8ZTBW4537"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW81713",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 345,
                            VehicleModelId = 1,
                            Vin = "99A5M70K4EB5H2412"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW21759",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            Odometer = 29200,
                            VehicleModelId = 2,
                            Vin = "YK1AA77X0TCNZ4856"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "WW51732",
                            CurrentBranchId = 2,
                            DateAdded = new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 5000,
                            VehicleModelId = 3,
                            Vin = "ZGARLKYE2NJM55700"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR14805",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 345,
                            VehicleModelId = 1,
                            Vin = "PR8T6WML9KN3V3570"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR14819",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            Odometer = 29200,
                            VehicleModelId = 2,
                            Vin = "U5YX3MFX0CA4Y2611"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR17430",
                            CurrentBranchId = 3,
                            DateAdded = new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 5000,
                            VehicleModelId = 3,
                            Vin = "SFDBSG9D24BNT5233"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR19676",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 345,
                            VehicleModelId = 1,
                            Vin = "1NENUTEL5FABF3880"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR27495",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 30000,
                            Odometer = 29200,
                            VehicleModelId = 2,
                            Vin = "2HMM5P9Z8F9JW7622"
                        },
                        new
                        {
                            FleetVehicleLicensePlate = "KR37442",
                            CurrentBranchId = 4,
                            DateAdded = new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            MaintenanceOdometer = 15000,
                            Odometer = 5000,
                            VehicleModelId = 3,
                            Vin = "5N13BMGT1NLC85021"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Reservation", b =>
                {
                    b.Property<string>("ReservationGuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerGuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EndAssignmentGuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EndBranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FleetVehicleLicensePlate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("StartAssignmentGuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("StartBranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.HasKey("ReservationGuid");

                    b.HasIndex("CustomerGuid");

                    b.HasIndex("EndAssignmentGuid")
                        .IsUnique()
                        .HasFilter("[EndAssignmentGuid] IS NOT NULL");

                    b.HasIndex("EndBranchId");

                    b.HasIndex("FleetVehicleLicensePlate");

                    b.HasIndex("StartAssignmentGuid")
                        .IsUnique()
                        .HasFilter("[StartAssignmentGuid] IS NOT NULL");

                    b.HasIndex("StartBranchId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CoreBusiness.Transfer", b =>
                {
                    b.Property<int>("TransferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignmentGuid")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("AssignmentGuid")
                        .IsUnique()
                        .HasFilter("[AssignmentGuid] IS NOT NULL");

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

                    b.HasData(
                        new
                        {
                            VehicleBodyTypeId = 1,
                            Name = "Convertible"
                        },
                        new
                        {
                            VehicleBodyTypeId = 2,
                            Name = "Cabriolet"
                        },
                        new
                        {
                            VehicleBodyTypeId = 3,
                            Name = "Hatchback"
                        },
                        new
                        {
                            VehicleBodyTypeId = 4,
                            Name = "Liftback"
                        },
                        new
                        {
                            VehicleBodyTypeId = 5,
                            Name = "Microvan"
                        },
                        new
                        {
                            VehicleBodyTypeId = 6,
                            Name = "Minivan"
                        },
                        new
                        {
                            VehicleBodyTypeId = 7,
                            Name = "Pickup"
                        },
                        new
                        {
                            VehicleBodyTypeId = 8,
                            Name = "Roadster"
                        },
                        new
                        {
                            VehicleBodyTypeId = 9,
                            Name = "Sedan"
                        },
                        new
                        {
                            VehicleBodyTypeId = 10,
                            Name = "Station Wagon"
                        },
                        new
                        {
                            VehicleBodyTypeId = 11,
                            Name = "SUV"
                        },
                        new
                        {
                            VehicleBodyTypeId = 12,
                            Name = "Targa"
                        },
                        new
                        {
                            VehicleBodyTypeId = 13,
                            Name = "Van"
                        });
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

                    b.Property<int>("BodyTypeId")
                        .HasColumnType("int");

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

                    b.HasIndex("BodyTypeId");

                    b.ToTable("VehicleModels");

                    b.HasData(
                        new
                        {
                            VehicleModelId = 1,
                            AutomaticGearbox = false,
                            BaseDailyPrice = 95,
                            BodyTypeId = 3,
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
                            BodyTypeId = 3,
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
                            BodyTypeId = 9,
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

            modelBuilder.Entity("CoreBusiness.Assignment", b =>
                {
                    b.HasOne("CoreBusiness.AssignmentType", "AssignmentType")
                        .WithMany("Assignments")
                        .HasForeignKey("AssignmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreBusiness.Employee", "Employee")
                        .WithMany("Assignments")
                        .HasForeignKey("EmployeeGuid");

                    b.Navigation("AssignmentType");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CoreBusiness.Employee", b =>
                {
                    b.HasOne("CoreBusiness.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchId1");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("CoreBusiness.FleetVehicle", b =>
                {
                    b.HasOne("CoreBusiness.Branch", "CurrentBranch")
                        .WithMany("FleetVehicles")
                        .HasForeignKey("CurrentBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreBusiness.VehicleModel", "VehicleModel")
                        .WithMany("FleetVehicles")
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentBranch");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("CoreBusiness.Reservation", b =>
                {
                    b.HasOne("CoreBusiness.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreBusiness.Assignment", "EndAssignment")
                        .WithOne("EndReservation")
                        .HasForeignKey("CoreBusiness.Reservation", "EndAssignmentGuid");

                    b.HasOne("CoreBusiness.Branch", "EndBranch")
                        .WithMany("EndReservations")
                        .HasForeignKey("EndBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CoreBusiness.FleetVehicle", "FleetVehicle")
                        .WithMany("Reservations")
                        .HasForeignKey("FleetVehicleLicensePlate");

                    b.HasOne("CoreBusiness.Assignment", "StartAssignment")
                        .WithOne("StartReservation")
                        .HasForeignKey("CoreBusiness.Reservation", "StartAssignmentGuid");

                    b.HasOne("CoreBusiness.Branch", "StartBranch")
                        .WithMany("StartReservations")
                        .HasForeignKey("StartBranchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CoreBusiness.VehicleModel", "VehicleModel")
                        .WithMany("Reservations")
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("EndAssignment");

                    b.Navigation("EndBranch");

                    b.Navigation("FleetVehicle");

                    b.Navigation("StartAssignment");

                    b.Navigation("StartBranch");

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("CoreBusiness.Transfer", b =>
                {
                    b.HasOne("CoreBusiness.Assignment", "Assignment")
                        .WithOne("Transfer")
                        .HasForeignKey("CoreBusiness.Transfer", "AssignmentGuid");

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("CoreBusiness.VehicleModel", b =>
                {
                    b.HasOne("CoreBusiness.VehicleBodyType", "VehicleBodyType")
                        .WithMany("VehicleModels")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleBodyType");
                });

            modelBuilder.Entity("CoreBusiness.Assignment", b =>
                {
                    b.Navigation("EndReservation");

                    b.Navigation("StartReservation");

                    b.Navigation("Transfer");
                });

            modelBuilder.Entity("CoreBusiness.AssignmentType", b =>
                {
                    b.Navigation("Assignments");
                });

            modelBuilder.Entity("CoreBusiness.Branch", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("EndReservations");

                    b.Navigation("FleetVehicles");

                    b.Navigation("StartReservations");
                });

            modelBuilder.Entity("CoreBusiness.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CoreBusiness.Employee", b =>
                {
                    b.Navigation("Assignments");
                });

            modelBuilder.Entity("CoreBusiness.FleetVehicle", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("CoreBusiness.VehicleBodyType", b =>
                {
                    b.Navigation("VehicleModels");
                });

            modelBuilder.Entity("CoreBusiness.VehicleModel", b =>
                {
                    b.Navigation("FleetVehicles");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
