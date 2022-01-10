using CoreBusiness;

namespace UseCases.UseCaseInterfaces.CustomerUseCaseInterfaces
{
    public interface IGetCustomerByGuidUseCase
    {
        Customer Execute(string customerGuid);
    }
}
