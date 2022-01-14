using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces.UserUseCaseInterfaces
{
    public interface IAddUserUseCase
    {
        string Execute(string userName, string email, string password, string claimValue);
    }
}
