using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class VehicleModelInMemoryRepository : IVehicleModelRepository
    {
        private readonly List<VehicleModel> _vehicleModels;

        public VehicleModelInMemoryRepository()
        {
            // Add default vehicle models
            _vehicleModels = new List<VehicleModel>
            {
                new()
                {
                    VehicleModelId = 1, Make = "Toyota", Model = "Aygo", ModelYear = "2018", BodyTypeName = "hatchback", Segment = "A",
                    EngineType = "petrol", Horsepower = "72", AutomaticGearbox = false, Doors = 3, Seats = 4,
                    BaseDailyPrice = 95
                },
                new()
                {
                    VehicleModelId = 2, Make = "Toyota", Model = "Yaris", ModelYear = "2020", BodyTypeName = "hatchback", Segment = "B",
                    EngineType = "hybrid", Horsepower = "116", AutomaticGearbox = true, Doors = 5, Seats = 5,
                    BaseDailyPrice = 112
                },
                new()
                {
                    VehicleModelId = 3, Make = "Toyota", Model = "Corolla", ModelYear = "2018", BodyTypeName = "sedan", Segment = "C",
                    EngineType = "hybrid", Horsepower = "184", AutomaticGearbox = true, Doors = 5, Seats = 5,
                    BaseDailyPrice = 149
                }
            };
        }

        public IEnumerable<VehicleModel> GetVehicleModels()
        {
            return _vehicleModels;
        }

        public void AddVehicleModel(VehicleModel vehicleModel)
        {
            if (_vehicleModels.Any(x => x.Model.Equals(vehicleModel.Model, StringComparison.OrdinalIgnoreCase))
            && _vehicleModels.Any(x => x.AutomaticGearbox.Equals(vehicleModel.AutomaticGearbox))
            && _vehicleModels.Any(x => x.BodyTypeName.Equals(vehicleModel.BodyTypeName))
            && _vehicleModels.Any(x => x.Horsepower.Equals(vehicleModel.Horsepower)))
            {
                return;
            }

            if (_vehicleModels is {Count: > 0})
            {
                var maxId = _vehicleModels.Max(x => x.VehicleModelId);

                vehicleModel.VehicleModelId = maxId + 1;
            }
            else
            {
                vehicleModel.VehicleModelId = 1;
            }
        }

        public void EditVehicleModel(VehicleModel vehicleModel)
        {
            var vehicleModelToEdit = GetVehicleModelById(vehicleModel.VehicleModelId);
            if (vehicleModelToEdit != null)
            {
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
            }
        }

        public VehicleModel GetVehicleModelById(int vehicleModel)
        {
            return _vehicleModels?.FirstOrDefault(x => x.VehicleModelId == vehicleModel);
        }

        public void DeleteVehicleModel(int vehicleModelId)
        {
            _vehicleModels.Remove(GetVehicleModelById(vehicleModelId));
        }
    }
}
