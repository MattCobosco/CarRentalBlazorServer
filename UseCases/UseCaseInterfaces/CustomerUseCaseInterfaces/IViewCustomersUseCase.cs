using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IViewCustomersUseCase
    {
        IEnumerable<Customer> Execute();
    }
}
