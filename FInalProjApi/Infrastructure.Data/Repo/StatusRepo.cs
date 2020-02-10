using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data.Models;

namespace Infrastructure.Data.Repo
{
    public class StatusRepo : IRepo<Status>
    {
        private readonly MyContext _db;

        public StatusRepo(MyContext db)
        {
            _db = db;
        }

        public void add(Status obj)
        {
            _db.Statuses.Add(obj);
            _db.SaveChanges();
        }

        public Status get(int id)
        {
            return _db.Statuses.Find(id);
        }

        public void update(Status obj)
        {
            _db.Statuses.Update(obj);
            _db.SaveChanges();
        }

        public void delete(int id)
        {
            var status = get(id);
            _db.Statuses.Remove(status);
            _db.SaveChanges();
        }

        public List<Status> getList()
        {
            return _db.Statuses.ToList();
        }
    }
}