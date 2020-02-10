using System.Collections.Generic;
using Infrastructure.Data.Models;
using Infrastructure.Data.Repo;

namespace Infrastructure.Data.Services
{
    public class StatusService : IService<Status>
    {
        private readonly IRepo<Status> _repo;

        public StatusService(IRepo<Status> repo)
        {
            _repo = repo;
        }
        public List<Status> GetAll()
        {
            return _repo.getList();
        }

        public Status Get(int id)
        {
            return _repo.get(id);
        }

        public void Add(Status obj)
        {
            _repo.add(obj);
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public void Update(Status obj)
        {
            _repo.update(obj);
        }
    }
}