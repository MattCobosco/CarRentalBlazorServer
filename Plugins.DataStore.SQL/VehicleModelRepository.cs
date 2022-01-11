using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL.Data;
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

        public void AddVehicleModel(VehicleModel vehicleModel)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            if(_carRentalContext.VehicleModels.Any(
                    x => x.Model == vehicleModel.Model &&
                         x.AutomaticGearbox == vehicleModel.AutomaticGearbox &&
                         x.BodyTypeId == vehicleModel.BodyTypeId &&
                         x.Horsepower == vehicleModel.Horsepower))
            {
                transaction.Rollback();
                Console.WriteLine("Such Vehicle Model already exists!");
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

        public void DeleteVehicleModel(int vehicleModelId)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleModel = GetVehicleModelById(vehicleModelId);

                if(vehicleModel == null)
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

        public void EditVehicleModel(VehicleModel vehicleModel)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleModelToEdit = GetVehicleModelById(vehicleModel.VehicleModelId);

                vehicleModelToEdit.Make = vehicleModel.Make;
                vehicleModelToEdit.Model = vehicleModel.Model;
                vehicleModelToEdit.ModelYear = vehicleModel.ModelYear;
                vehicleModelToEdit.BodyTypeId = vehicleModel.BodyTypeId;
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
                Console.WriteLine("Editing Vehicle Model failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public VehicleModel GetVehicleModelById(int vehicleModelId)
        {
            var vehicleModel = _carRentalContext.VehicleModels.Find(vehicleModelId);

            if(vehicleModel != null)
            {
                return vehicleModel;
            }

            Console.WriteLine("Couldn't find the requested Vehicle Model!");
            return null;

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

        public async Task<IEnumerable<VehicleModel>> GetVehicleModelsAsync()
        {
            return await _carRentalContext.VehicleModels.ToListAsync();
        }
    }
}
