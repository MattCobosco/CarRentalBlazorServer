using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;

namespace Plugins.DataStore.SQL.Data
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<AssignmentType> AssignmentTypes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FleetVehicle> FleetVehicles { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<VehicleBodyType> VehicleBodyTypes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Assignment
            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.AssignmentType)
                .WithMany(aty => aty.Assignments)
                .HasForeignKey(a => a.AssignmentTypeId);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Assignments)
                .HasForeignKey(a => a.EmployeeGuid);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Transfer)
                .WithOne(t => t.Assignment)
                .HasForeignKey<Transfer>(t => t.AssignmentGuid);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Reservation)
                .WithMany(res => res.Assignments)
                .HasForeignKey(a => a.ReservationGuid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.FleetVehicle)
                .WithMany(fv => fv.Assignments)
                .HasForeignKey(a => a.FleetVehicleLicensePlate)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.VehicleModel)
                .WithMany(vm => vm.Assignments)
                .HasForeignKey(a => a.VehicleModelId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Branch)
                .WithMany(br => br.Assignments)
                .HasForeignKey(a => a.BranchId);

            // Branch
            modelBuilder.Entity<Branch>()
                .HasMany(br => br.FleetVehicles)
                .WithOne(fv => fv.CurrentBranch)
                .HasForeignKey(fv => fv.CurrentBranchId);

            // Customer
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(f => f.Customer)
                .HasForeignKey(f => f.CustomerGuid);

            // Employee
            modelBuilder.Entity<Employee>()
                .HasOne(em => em.Branch)
                .WithMany(br => br.Employees)
                .HasForeignKey(em => em.BranchId);

            // Reservation
            modelBuilder.Entity<Reservation>()
                .HasOne(res => res.StartBranch)
                .WithMany(br => br.StartReservations)
                .HasForeignKey(res => res.StartBranchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(res => res.EndBranch)
                .WithMany(br => br.EndReservations)
                .HasForeignKey(res => res.EndBranchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Reservation>()
                .HasOne(res => res.FleetVehicle)
                .WithMany(fv => fv.Reservations)
                .HasForeignKey(res => res.FleetVehicleLicensePlate);

            modelBuilder.Entity<Reservation>()
                .HasOne(res => res.VehicleModel)
                .WithMany(vm => vm.Reservations)
                .HasForeignKey(res => res.VehicleModelId);

            // Transfer
            modelBuilder.Entity<Transfer>()
                .HasOne(tr => tr.FleetVehicle)
                .WithMany(fv => fv.Transfers)
                .HasForeignKey(tr => tr.FleetVehicleLicensePlate);

            modelBuilder.Entity<Transfer>()
                .HasOne(tr => tr.FromBranch)
                .WithMany(br => br.OutgoingTransfers)
                .HasForeignKey(tr => tr.FromBranchId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transfer>()
                .HasOne(tr => tr.ToBranch)
                .WithMany(br => br.IncomingTransfers)
                .HasForeignKey(tr => tr.ToBranchId)
                .OnDelete(DeleteBehavior.Restrict);

            // Vehicle Body Type
            modelBuilder.Entity<VehicleBodyType>()
                .HasMany(vbt => vbt.VehicleModels)
                .WithOne(vm => vm.VehicleBodyType)
                .HasForeignKey(vm => vm.BodyTypeId);

            // Vehicle Model
            modelBuilder.Entity<VehicleModel>()
                .HasMany(vm => vm.FleetVehicles)
                .WithOne(fv => fv.VehicleModel)
                .HasForeignKey(fv => fv.VehicleModelId);

            // Data seed
            modelBuilder.Entity<AssignmentType>().HasData(
                new AssignmentType
                {
                    AssignmentTypeId = 1,
                    Type = "Reservation Start"
                },
                new AssignmentType
                {
                    AssignmentTypeId = 2,
                    Type = "Reservation End"
                },
                new AssignmentType
                {
                    AssignmentTypeId = 3,
                    Type = "Maintenance"
                },
                new AssignmentType
                {
                    AssignmentTypeId = 4,
                    Type = "Transfer"
                });

            modelBuilder.Entity<Branch>().HasData(
                new Branch
                {
                    BranchId = 1,
                    Name = "Gdańsk",
                    Address = "Szklary 138 80-835 Gdańsk"
                },
                new Branch
                {
                    BranchId = 2,
                    Name = "Warszawa",
                    Address = "Rozłogi 1 01-323 Warszawa"
                },
                new Branch
                {
                    BranchId = 3,
                    Name = "Kraków - Airport",
                    Address = "Olszanicka 174 30-241 Kraków"
                },
                new Branch
                {
                    BranchId = 4,
                    Name = "Kraków - City",
                    Address = "Conrada 63 31-357 Kraków"
                });

            modelBuilder.Entity<FleetVehicle>().HasData(
               // Gdansk
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "GD19791",
                   Odometer = 345,
                   Vin = "7A8NPS1E0XBJD3395",
                   MaintenanceDate = DateTime.Today.AddYears(1),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today,
                   CurrentBranchId = 1,
                   VehicleModelId = 1
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "GD23372",
                   Odometer = 29200,
                   Vin = "8AWT9NYH431RU0111",
                   MaintenanceDate = DateTime.Today.AddMonths(1),
                   MaintenanceOdometer = 30000,
                   DateAdded = DateTime.Today.AddYears(-1),
                   CurrentBranchId = 1,
                   VehicleModelId = 2
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "GD38400",
                   Odometer = 5000,
                   Vin = "VF68LSKN8ZTBW4537",
                   MaintenanceDate = DateTime.Today.AddDays(14),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today.AddMonths(-3),
                   CurrentBranchId = 1,
                   VehicleModelId = 3
               },
               // Warszawa
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "WW81713",
                   Odometer = 345,
                   Vin = "99A5M70K4EB5H2412",
                   MaintenanceDate = DateTime.Today.AddYears(1),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today,
                   CurrentBranchId = 2,
                   VehicleModelId = 1
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "WW21759",
                   Odometer = 29200,
                   Vin = "YK1AA77X0TCNZ4856",
                   MaintenanceDate = DateTime.Today.AddMonths(1),
                   MaintenanceOdometer = 30000,
                   DateAdded = DateTime.Today.AddYears(-1),
                   CurrentBranchId = 2,
                   VehicleModelId = 2
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "WW51732",
                   Odometer = 5000,
                   Vin = "ZGARLKYE2NJM55700",
                   MaintenanceDate = DateTime.Today.AddDays(14),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today.AddMonths(-3),
                   CurrentBranchId = 2,
                   VehicleModelId = 3
               },
               // Kraków - airport
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR14805",
                   Odometer = 345,
                   Vin = "PR8T6WML9KN3V3570",
                   MaintenanceDate = DateTime.Today.AddYears(1),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today,
                   CurrentBranchId = 3,
                   VehicleModelId = 1
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR14819",
                   Odometer = 29200,
                   Vin = "U5YX3MFX0CA4Y2611",
                   MaintenanceDate = DateTime.Today.AddMonths(1),
                   MaintenanceOdometer = 30000,
                   DateAdded = DateTime.Today.AddYears(-1),
                   CurrentBranchId = 3,
                   VehicleModelId = 2
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR17430",
                   Odometer = 5000,
                   Vin = "SFDBSG9D24BNT5233",
                   MaintenanceDate = DateTime.Today.AddDays(14),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today.AddMonths(-3),
                   CurrentBranchId = 3,
                   VehicleModelId = 3
               },
               // Krakow - city
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR19676",
                   Odometer = 345,
                   Vin = "1NENUTEL5FABF3880",
                   MaintenanceDate = DateTime.Today.AddYears(1),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today,
                   CurrentBranchId = 4,
                   VehicleModelId = 1
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR27495",
                   Odometer = 29200,
                   Vin = "2HMM5P9Z8F9JW7622",
                   MaintenanceDate = DateTime.Today.AddMonths(1),
                   MaintenanceOdometer = 30000,
                   DateAdded = DateTime.Today.AddYears(-1),
                   CurrentBranchId = 4,
                   VehicleModelId = 2
               },
               new FleetVehicle
               {
                   FleetVehicleLicensePlate = "KR37442",
                   Odometer = 5000,
                   Vin = "5N13BMGT1NLC85021",
                   MaintenanceDate = DateTime.Today.AddDays(21),
                   MaintenanceOdometer = 15000,
                   DateAdded = DateTime.Today.AddMonths(-3),
                   CurrentBranchId = 4,
                   VehicleModelId = 3
               });

            modelBuilder.Entity<VehicleBodyType>().HasData(
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 1,
                    Name = "Convertible"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 2,
                    Name = "Cabriolet"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 3,
                    Name = "Hatchback"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 4,
                    Name = "Liftback"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 5,
                    Name = "Microvan"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 6,
                    Name = "Minivan"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 7,
                    Name = "Pickup"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 8,
                    Name = "Roadster"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 9,
                    Name = "Sedan"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 10,
                    Name = "Station Wagon"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 11,
                    Name = "SUV"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 12,
                    Name = "Targa"
                },
                new VehicleBodyType
                {
                    VehicleBodyTypeId = 13,
                    Name = "Van"
                });

            modelBuilder.Entity<VehicleModel>().HasData(
                new VehicleModel
                {
                    VehicleModelId = 1,
                    Make = "Toyota",
                    Model = "Aygo",
                    ModelYear = "2018",
                    BodyTypeId = 3,
                    Segment = "A",
                    EngineType = "petrol",
                    Horsepower = "72",
                    AutomaticGearbox = false,
                    Doors = 3,
                    Seats = 4,
                    BaseDailyPrice = 95
                },
                new VehicleModel
                {
                    VehicleModelId = 2,
                    Make = "Toyota",
                    Model = "Yaris",
                    ModelYear = "2020",
                    BodyTypeId = 3,
                    Segment = "B",
                    EngineType = "hybrid",
                    Horsepower = "116",
                    AutomaticGearbox = true,
                    Doors = 5,
                    Seats = 5,
                    BaseDailyPrice = 112
                },
                new VehicleModel
                {
                    VehicleModelId = 3,
                    Make = "Toyota",
                    Model = "Corolla",
                    ModelYear = "2018",
                    BodyTypeId = 9,
                    Segment = "C",
                    EngineType = "hybrid",
                    Horsepower = "184",
                    AutomaticGearbox = true,
                    Doors = 5,
                    Seats = 5,
                    BaseDailyPrice = 149
                });
        }
    }
}
