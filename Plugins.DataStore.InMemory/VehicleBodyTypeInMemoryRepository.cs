using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class VehicleBodyTypeInMemoryRepository : IVehicleBodyTypeRepository
    {
        private List<VehicleBodyType> _vehicleBodyTypes;

        public VehicleBodyTypeInMemoryRepository()
        {
            // Add default bodytypes
            _vehicleBodyTypes = new List<VehicleBodyType>()
            {

                new() {VehicleBodyTypeId = 1, Name = "Sedan"},
                new() {VehicleBodyTypeId = 1, Name = "Hatchback"},
                new() {VehicleBodyTypeId = 1, Name = "SUV"},
                new() {VehicleBodyTypeId = 1, Name = "Coupe"},
                new() {VehicleBodyTypeId = 1, Name = "Convertible"},
                new() {VehicleBodyTypeId = 1, Name = "Other"}
            };
        }

        public IEnumerable<VehicleBodyType> GetVehicleBodyTypes()
        {
            return _vehicleBodyTypes;
        }

        public void AddVehicleBodyType(VehicleBodyType bodyType)
        {
            if (_vehicleBodyTypes.Any(x => x.Name.Equals(bodyType.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (_vehicleBodyTypes != null && _vehicleBodyTypes.Count > 0)
            {
                var maxId = _vehicleBodyTypes.Max(x => x.VehicleBodyTypeId);

                bodyType.VehicleBodyTypeId = maxId + 1;
            }
            else
            {
                bodyType.VehicleBodyTypeId = 1;
            }
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
