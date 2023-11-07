namespace Module4_HW1
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateUser(user);
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            return await _userRepository.UpdateUser(id, user);
        }

        public async Task<User> UpdateUserPartial(int id, User user)
        {
            return await _userRepository.UpdateUserPartial(id, user);
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }
    }
}
