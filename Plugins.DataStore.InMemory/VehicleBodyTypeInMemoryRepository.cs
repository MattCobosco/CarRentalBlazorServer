﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class VehicleBodyTypeInMemoryRepository : IVehicleBodyTypeRepository
    {
        private readonly List<VehicleBodyType> _vehicleBodyTypes;

        public VehicleBodyTypeInMemoryRepository()
        {
            // Add default body types
            _vehicleBodyTypes = new List<VehicleBodyType>
            {

                new() {VehicleBodyTypeId = 1, Name = "Sedan"},
                new() {VehicleBodyTypeId = 2, Name = "Hatchback"},
                new() {VehicleBodyTypeId = 3, Name = "SUV"},
                new() {VehicleBodyTypeId = 4, Name = "Coupe"},
                new() {VehicleBodyTypeId = 5, Name = "Convertible"},
                new() {VehicleBodyTypeId = 6, Name = "Other"}
            };
        }

        public IEnumerable<VehicleBodyType> GetVehicleBodyTypes()
        {
            return _vehicleBodyTypes;
        }

        public void AddVehicleBodyType(VehicleBodyType bodyType)
        {
            if (_vehicleBodyTypes.Any(x => x.Name.Equals(bodyType.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            if (_vehicleBodyTypes is {Count: > 0})
            {
                var maxId = _vehicleBodyTypes.Max(x => x.VehicleBodyTypeId);

                bodyType.VehicleBodyTypeId = maxId + 1;
            }
            else
            {
                bodyType.VehicleBodyTypeId = 1;
            }

            _vehicleBodyTypes.Add(bodyType);
        }

        public void EditVehicleBodyType(VehicleBodyType vehicleBodyType)
        {
            var vehicleBodyTypeToEdit = GetVehicleBodyTypeById(vehicleBodyType.VehicleBodyTypeId);

            if (vehicleBodyTypeToEdit != null)
            {
                vehicleBodyTypeToEdit.Name = vehicleBodyType.Name;
            }
        }

        public VehicleBodyType GetVehicleBodyTypeById(int vehicleBodyTypeId)
        {
            return _vehicleBodyTypes?.FirstOrDefault(x => x.VehicleBodyTypeId == vehicleBodyTypeId);
        }

        public void DeleteVehicleBodyType(int vehicleBodyTypeId)
        {
            _vehicleBodyTypes.Remove(GetVehicleBodyTypeById(vehicleBodyTypeId));
        }
    }
}
