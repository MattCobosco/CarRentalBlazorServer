using UseCases.DataStorePluginInterfaces;
using UseCases.IdentityStoreUseCaseInterfaces;
using UseCases.UseCaseInterfaces.UserUseCaseInterfaces;

namespace UseCases.UserUseCases
{
    public class GetCurrentUserGuidUseCase : IGetCurrentUserGuidUseCase
    {
        private readonly IUserRepository _userRepository;

        public GetCurrentUserGuidUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string Execute()
        {
            return _userRepository.GetCurrentUserGuid();
        }
    }
}
