using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
                    EmployeeId = 1, FleetVehicleId = 1
                }
            };
        }

        public IEnumerable<Transfer> GetTransfers()
        {
            return _transfers;
        }
        
        public void AddTransfer(Transfer transfer)
        {
            if (_transfers.Any(x => x.FleetVehicleId.Equals(transfer.FleetVehicleId))
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
            transferToEdit.FleetVehicleId = transferToEdit.FleetVehicleId;

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
