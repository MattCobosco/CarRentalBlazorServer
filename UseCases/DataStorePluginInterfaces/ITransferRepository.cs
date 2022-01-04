using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;

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
