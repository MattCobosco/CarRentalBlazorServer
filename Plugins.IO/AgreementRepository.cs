using System.IO;
using UseCases.DataExportPluginInterfaces;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataExport
{
    public class AgreementRepository : IAgreementRepository
    {
        private readonly IBranchRepository _branchRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IFleetVehicleRepository _fleetVehicleRepository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IVehicleModelRepository _vehicleModelRepository;

        public AgreementRepository(
            IBranchRepository branchRepository,
            ICustomerRepository customerRepository,
            IEmployeeRepository employeeRepository,
            IReservationRepository reservationRepository,
            IFleetVehicleRepository fleetVehicleRepository,
            IVehicleModelRepository vehicleModelRepository)
        {
            _branchRepository = branchRepository;
            _customerRepository = customerRepository;
            _employeeRepository = employeeRepository;
            _fleetVehicleRepository = fleetVehicleRepository;
            _reservationRepository = reservationRepository;
            _vehicleModelRepository = vehicleModelRepository;
        }

        public MemoryStream CreatePdfAgreement(string reservationGuid)
        {
            return null;
        }
    }
}
