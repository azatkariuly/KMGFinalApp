using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repo
{
    public class HistoryRepo : IRepo<History>
    {
        private readonly MyContext _db;

        public HistoryRepo(MyContext db)
        {
            _db = db;
        }
        
        public void add(History obj)
        {
            _db.Histories.Add(obj);
            _db.SaveChanges();
        }

        public History get(int id)
        {
            return _db.Histories.Find(id);
        }

        public void update(History obj)
        {
            _db.Histories.Update(obj);
            _db.SaveChanges();
        }

        public void delete(int id)
        {
            var history = get(id);
            _db.Histories.Remove(history);
            _db.SaveChanges();
        }

        public List<History> getList()
        {
            return _db.Histories.Include(x => x.User).Include(x => x.Problem).ThenInclude(x=> x.Status).ToList();
        }
    }
}