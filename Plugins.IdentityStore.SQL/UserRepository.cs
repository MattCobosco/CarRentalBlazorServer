using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using UseCases.IdentityStoreUseCaseInterfaces;
using UseCases.UseCaseInterfaces.EmployeeUseCaseInterfaces;

namespace Plugins.IdentityStore.SQL
{
    public class UserRepository : IUserRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRepository(
            IHttpContextAccessor httpContextAccessor,
            UserManager<IdentityUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;

        }

        public string AddUser(string userName, string email, string password, string claimValue)
        {
            var user = new IdentityUser { UserName = userName, Email = email, EmailConfirmed = true };
            _userManager.CreateAsync(user, password);
            _userManager.AddClaimAsync(user, new Claim("Position", claimValue));
            return user.Id;
        }

        public string GetCurrentUserGuid()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
