using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransferRepository
    {
        IEnumerable<Transfer> GetTransfers();
        void AddTransfer(Transfer transfer);
        void EditTransfer(Transfer transfer);
        Transfer GetTransferById(int transferId);
        void DeleteTransfer(int transferId);
    }
}
