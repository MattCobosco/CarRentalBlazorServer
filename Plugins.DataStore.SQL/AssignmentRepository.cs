using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces.FleetVehicleUseCaseInterfaces;
using UseCases.UseCaseInterfaces.ReservationUseCaseInterfaces;

namespace Plugins.DataStore.SQL
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IGetReservationByGuidUseCase _getReservationByGuidUseCase;
        private readonly IGetFleetVehicleByLicensePlateUseCase _getFleetVehicleByLicensePlateUseCase;

        public AssignmentRepository(
            CarRentalContext carRentalContext,
            IGetReservationByGuidUseCase getReservationByGuidUseCase,
            IGetFleetVehicleByLicensePlateUseCase getFleetVehicleByLicensePlateUseCase)
        {
            _carRentalContext = carRentalContext;
            _getReservationByGuidUseCase = getReservationByGuidUseCase;
            _getFleetVehicleByLicensePlateUseCase = getFleetVehicleByLicensePlateUseCase;
        }

        public async Task AddAssignmentFromReservationAsync(string reservationGuid)
        {
            var reservation = _getReservationByGuidUseCase.Execute(reservationGuid);

            var assignmentStart = new Assignment
            {
                AssignmentTypeId = 1,
                IsDone = false,
                DateTime = reservation.StartDateTime,
                EmployeeGuid = null,
                ReservationGuid = reservationGuid,
                FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate,
                VehicleModelId = reservation.VehicleModelId,
                BranchId = reservation.StartBranchId
            };

            var assignmentEnd = new Assignment
            {
                AssignmentTypeId = 2,
                IsDone = false,
                DateTime = reservation.EndDateTime,
                EmployeeGuid = null,
                ReservationGuid = reservationGuid,
                FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate,
                VehicleModelId = reservation.VehicleModelId,
                BranchId = reservation.EndBranchId
            };

            var transaction = await _carRentalContext.Database.BeginTransactionAsync();

            if (_carRentalContext.Assignments.Any(
                    x => x.AssignmentGuid == assignmentStart.AssignmentGuid ||
                         x.AssignmentGuid == assignmentEnd.AssignmentGuid))
            {
                await transaction.RollbackAsync();
                Console.WriteLine("Warning: Such Assignment already exists!");
                return;
            }

            try
            {
                await _carRentalContext.AddAsync(assignmentStart);
                await _carRentalContext.AddAsync(assignmentEnd);
                reservation.StartAssignmentGuid = assignmentStart.AssignmentGuid;
                reservation.EndAssignmentGuid = assignmentEnd.AssignmentGuid;
                await _carRentalContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine("Adding Assignment failed:");
                Console.WriteLine(ex.Message);
            }
        }

        public async Task AddEmployeeToTheAssignmentAsync(Assignment assignment, string employeeGuid)
        {
            var transaction = await _carRentalContext.Database.BeginTransactionAsync();

            try
            {
                assignment.EmployeeGuid = employeeGuid;
                await _carRentalContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine("Adding Employee to the Assignment failed:");
                Console.WriteLine(ex.Message);
            }

        }

        public async Task<IEnumerable<Assignment>> GetAssignmentsByAgentGuid(string agentGuid)
        {
            return await _carRentalContext.Assignments.Where(a => a.EmployeeGuid == agentGuid).OrderBy(a => a.DateTime).ToListAsync();
        }

        public async Task<Assignment> GetAssignmentByGuidAsync(string assignmentGuid)
        {
            return await _carRentalContext.Assignments.FindAsync(assignmentGuid);
        }

        public async Task SetAssignmentToDone(string assignmentGuid)
        {
            var transaction = await _carRentalContext.Database.BeginTransactionAsync();

            try
            {
                var assignment = await GetAssignmentByGuidAsync(assignmentGuid);
                assignment.IsDone = true;

                if (assignment.AssignmentTypeId == 2)
                {
                    var vehicle = _getFleetVehicleByLicensePlateUseCase.Execute(assignment.FleetVehicleLicensePlate);
                    vehicle.CurrentBranchId = assignment.BranchId;
                }

                await _carRentalContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine(ex.Message);
            }
        }

        public async Task UpdateAssignmentsOnReservationUpdateAsync(Reservation reservation)
        {
            var transaction = await _carRentalContext.Database.BeginTransactionAsync();

            try
            {
                var startAssignment = await GetAssignmentByGuidAsync(reservation.StartAssignmentGuid);
                var endAssignment = await GetAssignmentByGuidAsync(reservation.EndAssignmentGuid);

                startAssignment.DateTime = reservation.StartDateTime;
                startAssignment.VehicleModelId = reservation.VehicleModelId;
                startAssignment.FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate;
                startAssignment.BranchId = reservation.StartBranchId;

                endAssignment.DateTime = reservation.EndDateTime;
                endAssignment.VehicleModelId = reservation.VehicleModelId;
                endAssignment.FleetVehicleLicensePlate = reservation.FleetVehicleLicensePlate;
                endAssignment.BranchId = reservation.EndBranchId;

                await _carRentalContext.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine(ex.Message);
            }
        }

        public async Task<IEnumerable<Assignment>> ViewAssignmentsAsync()
        {
            return await _carRentalContext.Assignments.OrderBy(a => a.DateTime).ToListAsync();
        }
    }
}