using UseCases.IdentityStoreUseCaseInterfaces;
using UseCases.UseCaseInterfaces.UserUseCaseInterfaces;

namespace UseCases.UserUseCases
{
    public class AddUserUseCase : IAddUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public AddUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Execute(string userName, string email, string password, string claimValue)
        {
            return _userRepository.AddUser(userName, email, password, claimValue);
        }
    }
}
