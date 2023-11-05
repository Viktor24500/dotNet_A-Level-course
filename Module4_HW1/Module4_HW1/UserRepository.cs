namespace Module4_HW1
{
    public class UserRepository
    {
        private List<User> _users;

        public UserRepository(List<User> users)
        {
            _users = users;
        }

        public async Task<User> GetUserById(int id) 
        {
            return await Task.Run(() => _users.FirstOrDefault(user => user.Id == id) );
        }

        public async Task CreateUser(User user)
        {
            await Task.Run(() => _users.Add(user));
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            return await Task.Run(() =>
            {
                var findUser = _users.FirstOrDefault(u => u.Id == id);
                if (findUser != null)
                {
                    findUser.Name = user.Name;
                    findUser.Address = user.Address;
                }
                return findUser;
            });
        }

        public async Task<User> UpdateUserPartial(int id, User user)
        {
            return await Task.Run(() =>
            {
                var findUser = _users.FirstOrDefault(u => u.Id == id);
                if (findUser != null)
                {
                    if (!string.IsNullOrEmpty(user.Name))
                    {
                        findUser.Name = user.Name;
                    }
                    if (!string.IsNullOrEmpty(user.Address))
                    {
                        findUser.Address = user.Address;
                    }
                }
                return findUser;
            });
        }

        public async Task<bool> DeleteUser(int id)
        {
            return await Task.Run(() =>
            {
                var user = _users.FirstOrDefault(u => u.Id == id);
                if (user != null)
                {
                    _users.Remove(user);
                    return true;
                }
                return false;
            });
        }
    }
}
