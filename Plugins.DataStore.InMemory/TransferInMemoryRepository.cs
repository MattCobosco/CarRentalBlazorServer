using System;
using System.Collections.Generic;
using System.Linq;
using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class TransferInMemoryRepository : ITransferRepository
    {
        private readonly List<Transfer> _transfers;

        public TransferInMemoryRepository()
        {
            // Add default transfers
            _transfers = new List<Transfer>
            {
                new()
                {
                    TransferId = 1, Date = DateTime.Today.Date, FromBranch = "Gdańsk", ToBranch = "Kraków",
                    EmployeeId = 1, FleetVehicleLicensePlate = "GD23372"
                }
            };
        }

        public IEnumerable<Transfer> GetTransfers()
        {
            return _transfers;
        }
        
        public void AddTransfer(Transfer transfer)
        {
            if (_transfers.Any(x => x.FleetVehicleLicensePlate.Equals(transfer.FleetVehicleLicensePlate))
                && _transfers.Any(x=>x.Date.Equals(transfer.Date)))
            {
                return;
            }

            if (_transfers is { Count: > 0 })
            {
                var maxId = _transfers.Max(x => x.TransferId);

                transfer.TransferId = maxId + 1;
            }
            else
            {
                transfer.TransferId = 1;
            }

            _transfers.Add(transfer);
        }

        public void EditTransfer(Transfer transfer)
        {
            var transferToEdit = GetTransferById(transfer.TransferId);

            if (transferToEdit == null) return;

            transferToEdit.FromBranch = transfer.FromBranch;
            transferToEdit.ToBranch = transfer.ToBranch;
            transferToEdit.Date = transfer.Date;
            transferToEdit.EmployeeId = transfer.EmployeeId;
            transferToEdit.FleetVehicleLicensePlate = transferToEdit.FleetVehicleLicensePlate;

        }

        public Transfer GetTransferById(int transferId)
        {
            return _transfers.FirstOrDefault(x => x.TransferId == transferId);
        }

        public void DeleteTransfer(int transferId)
        {
            _transfers.Remove(GetTransferById(transferId));
        }
    }
}
