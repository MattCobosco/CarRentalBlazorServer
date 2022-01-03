using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.VehicleModelUseCaseInterfaces
{
    public interface IGetVehicleModelByLicensePlateUseCase
    {
        VehicleModel Execute(string licensePlate);
    }
}
