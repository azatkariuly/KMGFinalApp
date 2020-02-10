using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repo
{
    public class ProblemRepo : IRepo<Problem>
    {
        private readonly MyContext _db;

        public ProblemRepo(MyContext db)
        {
            _db = db;
        }
        
        public void add(Problem obj)
        {
            _db.Problems.Add(obj);
            _db.SaveChanges();
        }

        public Problem get(int id)
        {
            return _db.Problems.Find(id);
        }

        public void update(Problem obj)
        {
            _db.Problems.Update(obj);
            _db.SaveChanges();
        }

        public void delete(int id)
        {
            var problem = get(id);
            _db.Problems.Remove(problem);
            _db.SaveChanges();
        }

        public List<Problem> getList()
        {
            return _db.Problems.Include(x => x.User).Include(x => x.Status).ToList();
        }
    }
}