using Module4_ModuleHW.Entity;

namespace Module4_ModuleHW.Interface
{
    public interface IRepositoryUser
    {
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User userId);

        Task<User> GetUserAsync(User userId);
    }
}
