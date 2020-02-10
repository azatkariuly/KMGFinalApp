using System.Collections.Generic;
using Infrastructure.Data.Models;
using Infrastructure.Data.Repo;

namespace Infrastructure.Data.Services
{
    public class HistoryService : IService<History>
    {
        private readonly IRepo<History> _repo;

        public HistoryService(IRepo<History> repo)
        {
            _repo = repo;
        }
        
        public List<History> GetAll()
        {
            return _repo.getList();
        }

        public History Get(int id)
        {
            return _repo.get(id);
        }

        public void Add(History obj)
        {
            _repo.add(obj);
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public void Update(History obj)
        {
            _repo.update(obj);
        }
    }
}