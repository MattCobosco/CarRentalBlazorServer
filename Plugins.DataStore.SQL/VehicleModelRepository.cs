﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public VehicleModelRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public IEnumerable<VehicleModel> GetVehicleModels()
        {
            try
            {
                return _carRentalContext.VehicleModels.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Vehicle Models failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void AddVehicleModel(VehicleModel vehicleModel)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            if (_carRentalContext.VehicleModels.Any(
                    x => x.Model == vehicleModel.Model &&
                         x.AutomaticGearbox == vehicleModel.AutomaticGearbox &&
                         x.BodyTypeName == vehicleModel.BodyTypeName &&
                         x.Horsepower == vehicleModel.Horsepower))
            {
                Console.WriteLine("Such Vehicle Model already exists!");
                transaction.Rollback();
                return;
            }

            try
            {
                _carRentalContext.Add(vehicleModel);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Vehicle Model failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditVehicleModel(VehicleModel vehicleModel)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleModelToEdit = _carRentalContext.VehicleModels.Find(vehicleModel.VehicleModelId);

                vehicleModelToEdit.Make = vehicleModel.Make;
                vehicleModelToEdit.Model = vehicleModel.Model;
                vehicleModelToEdit.ModelYear = vehicleModel.ModelYear;
                vehicleModelToEdit.BodyTypeName = vehicleModel.BodyTypeName;
                vehicleModelToEdit.Segment = vehicleModel.Segment;
                vehicleModelToEdit.EngineType = vehicleModel.EngineType;
                vehicleModelToEdit.Horsepower = vehicleModel.Horsepower;
                vehicleModelToEdit.AutomaticGearbox = vehicleModel.AutomaticGearbox;
                vehicleModelToEdit.Doors = vehicleModel.Doors;
                vehicleModelToEdit.Seats = vehicleModel.Seats;
                vehicleModelToEdit.BaseDailyPrice = vehicleModel.BaseDailyPrice;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Branch failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public VehicleModel GetVehicleModelById(int vehicleModelId)
        {
            var vehicleModel = _carRentalContext.VehicleModels.Find(vehicleModelId);

            if (vehicleModel != null) return vehicleModel;

            Console.WriteLine("Couldn't find the requested Vehicle Model");
            return null;

        }

        public void DeleteVehicleModel(int vehicleModelId)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleModel = GetVehicleModelById(vehicleModelId);

                if (vehicleModel == null)
                {
                    return;
                }

                _carRentalContext.VehicleModels.Remove(vehicleModel);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Vehicle Model failed:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
