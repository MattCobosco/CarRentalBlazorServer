using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using Plugins.DataStore.SQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IReservationRepository _reservationRepository;

        public AssignmentRepository(
            CarRentalContext carRentalContext,
            IReservationRepository reservationRepository)
        {
            _carRentalContext = carRentalContext;
            _reservationRepository = reservationRepository;
        }

        public async Task AddAssignmentFromReservationAsync(string reservationGuid)
        {
            var reservation = _reservationRepository.GetReservationByGuid(reservationGuid);

            var assignmentStart = new Assignment
            {
                AssignmentTypeId = 1,
                IsDone = false,
                DateTime = reservation.StartDateTime,
                EmployeeGuid = null,
                ReservationGuid = reservationGuid
            };

            var assignmentEnd = new Assignment
            {
                AssignmentTypeId = 2,
                IsDone = false,
                DateTime = reservation.EndDateTime,
                EmployeeGuid = null,
                ReservationGuid = reservationGuid
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

        public async Task<IEnumerable<Assignment>> GetAssignmentsAsync()
        {
            return await _carRentalContext.Assignments.ToListAsync();
        }
    }
}