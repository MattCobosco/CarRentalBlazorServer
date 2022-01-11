using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using UseCases.IdentityStoreUseCaseInterfaces;

namespace Plugins.IdentityStore.SQL
{
    public class UserRepository : IUserRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCurrentUserGuid()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

    }
}
