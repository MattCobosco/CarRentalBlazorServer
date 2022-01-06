using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransferRepository
    {
        void AddTransfer(Transfer transfer);
        void DeleteTransfer(int transferId);
        void EditTransfer(Transfer transfer);
        Transfer GetTransferById(int transferId);
        IEnumerable<Transfer> GetTransfers();
    }
}
