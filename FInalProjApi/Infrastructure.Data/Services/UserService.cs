using System.Collections.Generic;
using Infrastructure.Data.Models;
using Infrastructure.Data.Repo;

namespace Infrastructure.Data.Services
{
    public class UserService : IService<User>
    {
        private readonly IRepo<User> _repo;

        public UserService(IRepo<User> repo)
        {
            _repo = repo;
        }

        public List<User> GetAll()
        {
            return _repo.getList();
        }

        public User Get(int id)
        {
            return _repo.get(id);
        }

        public void Add(User obj)
        {
            _repo.add(obj);
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public void Update(User user)
        {
            _repo.update(user);
        }
    }
}