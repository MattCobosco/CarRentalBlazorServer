﻿using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IVehicleBodyTypeRepository
    {
        IEnumerable<VehicleBodyType> GetVehicleBodyTypes();
        void AddVehicleBodyType(VehicleBodyType vehicleBodyType);
        void EditVehicleBodyType(VehicleBodyType vehicleBodyType);
        VehicleBodyType GetVehicleBodyTypeById(int vehicleBodyTypeId);
        void DeleteVehicleBodyType(int vehicleBodyTypeId);
    }
}
