using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IViewCustomersUseCase
    {
        IEnumerable<Customer> Execute();
    }
}
