using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class VehicleBodyTypeRepository : IVehicleBodyTypeRepository
    {
        private readonly CarRentalContext _carRentalContext;

        public VehicleBodyTypeRepository(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }

        public IEnumerable<VehicleBodyType> GetVehicleBodyTypes()
        {
            try
            {
                return _carRentalContext.VehicleBodyTypes.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Getting Vehicle Body Types failed:");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void AddVehicleBodyType(VehicleBodyType vehicleBodyType)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            if (_carRentalContext.VehicleBodyTypes.Any(
                    x => x.Name == vehicleBodyType.Name))
            {
                Console.WriteLine("Such Vehicle Body Type already exists!");
                transaction.Rollback();
                return;
            }

            try
            {
                _carRentalContext.Add(vehicleBodyType);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Adding Vehicle Body Type failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public void EditVehicleBodyType(VehicleBodyType vehicleBodyType)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleBodyTypeToEdit = GetVehicleBodyTypeById(vehicleBodyType.VehicleBodyTypeId);

                vehicleBodyTypeToEdit.Name = vehicleBodyType.Name;

                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Editing Vehicle Body Type failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public VehicleBodyType GetVehicleBodyTypeById(int vehicleBodyTypeId)
        {
            var vehicleBodyType = _carRentalContext.VehicleBodyTypes.Find(vehicleBodyTypeId);

            if (vehicleBodyType != null)
            {
                return vehicleBodyType;
            }

            Console.WriteLine("Couldn't find the requested Vehicle Body Type!");
            return null;
        }

        public void DeleteVehicleBodyType(int vehicleBodyTypeId)
        {
            var transaction = _carRentalContext.Database.BeginTransaction();

            try
            {
                var vehicleBodyType = GetVehicleBodyTypeById(vehicleBodyTypeId);

                if (vehicleBodyType == null)
                {
                    return;
                }

                _carRentalContext.VehicleBodyTypes.Remove(vehicleBodyType);
                _carRentalContext.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("Deleting Vehicle Body Type failed:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}