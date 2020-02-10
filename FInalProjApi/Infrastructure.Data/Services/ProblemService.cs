using System.Collections.Generic;
using Infrastructure.Data.Models;
using Infrastructure.Data.Repo;

namespace Infrastructure.Data.Services
{
    public class ProblemService : IService<Problem>
    {
        private readonly IRepo<Problem> _repo;

        public ProblemService(IRepo<Problem> repo)
        {
            _repo = repo;
        }
        
        public List<Problem> GetAll()
        {
            return _repo.getList();
        }

        public Problem Get(int id)
        {
            return _repo.get(id);
        }

        public void Add(Problem obj)
        {
            _repo.add(obj);
        }

        public void Delete(int id)
        {
            _repo.delete(id);
        }

        public void Update(Problem obj)
        {
            _repo.update(obj);
        }
    }
}