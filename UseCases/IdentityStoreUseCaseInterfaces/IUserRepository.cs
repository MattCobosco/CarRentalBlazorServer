namespace UseCases.IdentityStoreUseCaseInterfaces
{
    public interface IUserRepository
    {
        string GetCurrentUserGuid();
        string AddUser(string userName, string email, string password, string claimValue);
    }
}
